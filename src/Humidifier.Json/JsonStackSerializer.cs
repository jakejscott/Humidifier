using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Humidifier.Json
{
    public class JsonStackSerializer : IStackSerializer
    {
        private static readonly JsonSerializerSettings settings;

        static JsonStackSerializer()
        {
            settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
            };

            settings.ContractResolver = new JsonStackSerializerContractResolver();

            settings.Converters.Add(new ConditionConverter());

            // Intrinsic functions
            settings.Converters.Add(new FnJoinConverter());
            settings.Converters.Add(new FnRefConverter());
            settings.Converters.Add(new FnGetAttConverter());
            settings.Converters.Add(new FnSubConverter());
            settings.Converters.Add(new FnImportValueConverter());
            settings.Converters.Add(new FnSplitConverter());
            settings.Converters.Add(new FnSelectConverter());
            settings.Converters.Add(new FnGetAZsConverter());
            settings.Converters.Add(new FnFindInMapConverter());
            settings.Converters.Add(new FnBase64Converter());
            settings.Converters.Add(new FnCidrConvertor());

            // Conditional functions
            settings.Converters.Add(new FnAndConverter());
            settings.Converters.Add(new FnIfConverter());
            settings.Converters.Add(new FnEqualsConverter());
            settings.Converters.Add(new FnNotConverter());
            settings.Converters.Add(new FnOrConverter());
        }

        public string Serialize(Stack stack)
        {
            var stackJson = new StackJson
            {
                AWSTemplateFormatVersion = stack.AWSTemplateFormatVersion,
                Transform = stack.Transform,
                Description = stack.Description
            };

            if (stack.Parameters != null && stack.Parameters.Any())
            {
                stackJson.Parameters = stack.Parameters;
            }

            if (stack.Mappings != null && stack.Mappings.Any())
            {
                stackJson.Mappings = stack.Mappings;
            }

            if (stack.Outputs != null && stack.Outputs.Any())
            {
                stackJson.Outputs = stack.Outputs;
            }

            if (stack.Conditions != null && stack.Conditions.Any())
            {
                stackJson.Conditions = stack.Conditions;
            }

            if (stack.Resources != null && stack.Resources.Any())
            {
                stackJson.Resources = new Dictionary<string, ResourceJson>();

                foreach (KeyValuePair<string, Resource> kvp in stack.Resources)
                {
                    var resource = kvp.Value;

                    var typeInfo = kvp.Value.GetType();
                    Debug.Assert(typeInfo.Namespace != null);

                    var condition = stack.GetCondition(kvp.Key);
                    var dependsOn = stack.GetDependsOn(kvp.Key);

                    var creationPolicy = stack.GetCreationPolicy(kvp.Key);
                    var updatePolicy = stack.GetUpdatePolicy(kvp.Key);
                    var deletionPolicy = stack.GetDeletionPolicy(kvp.Key);
                    var metadata = stack.GetMetadata(kvp.Key);

                    var resourceJson = new ResourceJson
                    {
                        Type = resource.AWSTypeName,
                        Condition = condition,
                        Properties = resource,
                        DependsOn = dependsOn,
                        CreationPolicy = creationPolicy,
                        UpdatePolicy = updatePolicy,
                        DeletionPolicy = deletionPolicy,
                        Metadata = metadata
                    };

                    stackJson.Resources.Add(kvp.Key, resourceJson);
                }
            }

            var result = JsonConvert.SerializeObject(stackJson, settings);
            return result;
        }

        private class JsonStackSerializerContractResolver : DefaultContractResolver
        {
            protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
            {
                IList<JsonProperty> properties = base.CreateProperties(type, memberSerialization);

                foreach (var jsonProperty in properties)
                {
                    // Removes trailing underscore from property names
                    if (jsonProperty.PropertyName.EndsWith("_"))
                    {
                        jsonProperty.PropertyName = jsonProperty.PropertyName.TrimEnd('_');
                    }
                }

                return properties;
            }

            protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
            {
                var property = base.CreateProperty(member, memberSerialization);

                // Omits AWSTypeName property
                if (property.PropertyName == @"AWSTypeName")
                    property.ShouldSerialize = instance => { return false; };

                return property;
            }
        }

        private class StackJson
        {
            public string AWSTemplateFormatVersion { get; set; }
            public string Description { get; set; }
            public string Transform { get; set; }
            public Dictionary<string, Parameter> Parameters { get; set; }
            public Dictionary<string, ResourceJson> Resources { get; set; }
            public Dictionary<string, Output> Outputs { get; set; }
            public Dictionary<string, Mapping> Mappings { get; set; }
            public Dictionary<string, Condition> Conditions { get; set; }
        }

        private class ResourceJson
        {
            public string Type { get; set; }
            public string Condition { get; set; }
            public Resource Properties { get; set; }
            public List<string> DependsOn { get; set; }
            public CreationPolicy CreationPolicy { get; set; }
            public UpdatePolicy UpdatePolicy { get; set; }
            [JsonConverter(typeof(StringEnumConverter))]
            public DeletionPolicy? DeletionPolicy { get; set; }
            public dynamic Metadata { get; set; }
        }
    }
}