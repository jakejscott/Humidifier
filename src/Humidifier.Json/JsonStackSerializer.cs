using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Humidifier.Json
{
    public class JsonStackSerializer : IStackSerializer
    {
        private static JsonSerializerSettings settings;

        static JsonStackSerializer()
        {
            settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,

                ContractResolver = new FixPropertyNameWithUnderscoreContractResolver(),
            };

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
        }

        public string Serialize(Stack stack)
        {
            StackJson stackJson = Convert(stack);
            var result = JsonConvert.SerializeObject(stackJson, settings);
            return result;
        }

        private static StackJson Convert(Stack stack)
        {
            var stackJson = new StackJson
            {
                AWSTemplateFormatVersion = stack.AWSTemplateFormatVersion,
                Transform = stack.Transform,
                Parameters = stack.Parameters,
                Mappings = stack.Mappings,
                Outputs = stack.Outputs
            };

            if (stack.Resources != null && stack.Resources.Any())
            {
                stackJson.Resources = new Dictionary<string, ResourceJson>();

                foreach (var kvp in stack.Resources)
                {
                    var typeInfo = kvp.Value.GetType();
                    var awsTypeName = typeInfo.Namespace.Replace("Humidifier.", "AWS::") + "::" + typeInfo.Name;

                    var resourceJson = new ResourceJson
                    {
                        Type = awsTypeName,
                        Properties = kvp.Value
                    };

                    stackJson.Resources.Add(kvp.Key, resourceJson);
                }
            }

            return stackJson;
        }

        private class StackJson
        {
            public string AWSTemplateFormatVersion { get; set; }
            public string Transform { get; set; }

            public Dictionary<string, Parameter> Parameters { get; set; }
            public Dictionary<string, ResourceJson> Resources { get; set; }
            public Dictionary<string, Output> Outputs { get; set; }
            public Dictionary<string, Mapping> Mappings { get; set; }
        }

        private class ResourceJson
        {
            public string Type { get; set; }
            public Resource Properties { get; set; }
        }

        private class FixPropertyNameWithUnderscoreContractResolver : DefaultContractResolver
        {
            protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
            {
                IList<JsonProperty> properties = base.CreateProperties(type, memberSerialization);

                foreach (var jsonProperty in properties)
                {
                    if (jsonProperty.PropertyName.EndsWith("_"))
                    {
                        jsonProperty.PropertyName = jsonProperty.PropertyName.TrimEnd('_');
                    }
                }

                return properties;
            }
        }
    }
}