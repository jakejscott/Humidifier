using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Humidifier.CodeGen
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var json = File.ReadAllText("../../CloudFormationResourceSpecification.json");
            Specification specification = ParseSpecification(json);

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.Indented,
            };

            var result = JsonConvert.SerializeObject(specification, settings);
            File.WriteAllText("../../Spec.json", result);
            File.WriteAllText("../../PropertyTypes.json", JsonConvert.SerializeObject(specification.PropertyTypes, settings));
            File.WriteAllText("../../ResourceTypes.json", JsonConvert.SerializeObject(specification.ResourceTypes, settings));

            // Clean out any files from last run of the code generator
            var directories = Directory.GetDirectories("../Humidifier/");
            foreach (var directory in directories)
            {
                if (directory.StartsWith("../Humidifier/bin")) continue;
                if (directory.StartsWith("../Humidifier/obj")) continue;
                Directory.Delete(directory, true);
            }

            foreach (ResourceType resourceType in specification.ResourceTypes)
            {
                var parts = resourceType.Name.Split(new[] { "::" }, StringSplitOptions.RemoveEmptyEntries);

                var group = parts[1];
                var resourceClassName = parts[2];
                var path = $"../Humidifier/{group}";

                Directory.CreateDirectory(path);

                var propsNamespace = resourceClassName + "PropertyTypes";

                var namespaceDecl = NamespaceDeclaration(ParseName("Humidifier." + group))
                    .AddUsings(
                        UsingDirective(ParseName("System.Collections.Generic")),
                        UsingDirective(ParseName(propsNamespace))
                    );

                var resourceClassDecl = ClassDeclaration(resourceClassName)
                    .AddModifiers(Token(SyntaxKind.PublicKeyword))
                    .AddBaseListTypes(SimpleBaseType(ParseTypeName("Humidifier.Resource")));

                if (resourceType.Attributes != null)
                {
                    var attributesClassDecl = ClassDeclaration("Attributes")
                        .AddModifiers(Token(SyntaxKind.PublicKeyword))
                        .AddModifiers(Token(SyntaxKind.StaticKeyword));

                    foreach (Attribute attribute in resourceType.Attributes)
                    {
                        if (attribute.Name.Contains(".") && attribute.Name != resourceClassName)
                        {
                            continue;
                        }

                        string[] tokens = attribute.Name.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                        string attributeName = tokens.Length == 2 ? tokens[1] : tokens[0];

                        var propertyDecl = PropertyDeclaration(ParseTypeName("string"), attributeName)
                            .WithTrailingTrivia(
                                Trivia(SkippedTokensTrivia().WithTokens(TokenList(Token(SyntaxKind.EqualsToken)))),
                                Trivia(SkippedTokensTrivia().WithTokens(TokenList(Literal(attributeName))))
                            )
                            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                            .AddModifiers(Token(SyntaxKind.PublicKeyword))
                            .AddModifiers(Token(SyntaxKind.StaticKeyword));

                        attributesClassDecl = attributesClassDecl.AddMembers(propertyDecl);
                    }

                    resourceClassDecl = resourceClassDecl.AddMembers(attributesClassDecl);
                }

                foreach (var property in resourceType.Properties)
                {
                    var typeName = GetTypeName(property);

                    var propertyName = property.Name;
                    if (property.Name == resourceClassName)
                    {
                        propertyName += "_";
                    }

                    var commentDecl = ParseLeadingTrivia(GetComment(property));

                    var propertyDecl = PropertyDeclaration(ParseTypeName(typeName), propertyName)
                            .AddModifiers(Token(SyntaxKind.PublicKeyword))
                            .AddAccessorListAccessors(
                                AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                                AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                            )
                            .WithLeadingTrivia(TriviaList(commentDecl))
                        ;

                    resourceClassDecl = resourceClassDecl.AddMembers(propertyDecl);
                }

                List<PropertyType> propertyTypes = specification.PropertyTypes.Where(x => x.Name.StartsWith(resourceType.Name + ".")).ToList();

                var propertyTypesNamespace = NamespaceDeclaration(ParseName(propsNamespace));

                foreach (PropertyType propertyType in propertyTypes)
                {
                    var split = propertyType.Name.Split(new[] { "::" }, StringSplitOptions.RemoveEmptyEntries);
                    var propertyTypeClassName = split[2].Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries)[1];

                    var propertyTypeClassDecl = ClassDeclaration(propertyTypeClassName)
                        .AddModifiers(Token(SyntaxKind.PublicKeyword));

                    foreach (var property in propertyType.Properties)
                    {
                        var typeName = GetTypeName(property);

                        var propertyName = property.Name;
                        if (property.Name == propertyTypeClassName)
                        {
                            propertyName += "_";
                        }

                        var commentDecl = ParseLeadingTrivia(GetComment(property));

                        PropertyDeclarationSyntax propertyDecl = PropertyDeclaration(ParseTypeName(typeName), propertyName)
                                .AddModifiers(Token(SyntaxKind.PublicKeyword))
                                .AddAccessorListAccessors(
                                    AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                                    AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                                )
                                .WithLeadingTrivia(TriviaList(commentDecl))
                            ;

                        propertyTypeClassDecl = propertyTypeClassDecl.AddMembers(propertyDecl);
                    }

                    propertyTypesNamespace = propertyTypesNamespace.AddMembers(propertyTypeClassDecl);
                }

                namespaceDecl = namespaceDecl.AddMembers(resourceClassDecl);
                namespaceDecl = namespaceDecl.AddMembers(propertyTypesNamespace);

                var code = namespaceDecl.NormalizeWhitespace().ToFullString();
                var filePath = $"{path}/{resourceClassName}.cs";
                File.WriteAllText(filePath, code);
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private static string GetComment(Property property)
        {
            var sb = new StringBuilder();

            sb.AppendLine("/// <summary>");
            sb.AppendLine($"/// {property.Name}");
            sb.AppendLine($"/// {property.Documentation}");
            sb.AppendLine($"/// Required: {property.Required}");
            sb.AppendLine($"/// UpdateType: {property.UpdateType}");

            if (!string.IsNullOrWhiteSpace(property.Type))
            {
                sb.AppendLine($"/// Type: {property.Type}");
            }

            if (!string.IsNullOrWhiteSpace(property.ItemType))
            {
                sb.AppendLine($"/// ItemType: {property.ItemType}");
            }

            if (!string.IsNullOrWhiteSpace(property.PrimitiveItemType))
            {
                sb.AppendLine($"/// PrimitiveItemType: {property.PrimitiveItemType}");
            }

            if (!string.IsNullOrWhiteSpace(property.PrimitiveType))
            {
                sb.AppendLine($"/// PrimitiveType: {property.PrimitiveType}");
            }

            sb.AppendLine("/// </summary>");

            return sb.ToString();
        }


        private static string GetTypeName(Property property)
        {
            string typeName;

            if (!string.IsNullOrWhiteSpace(property.PrimitiveType))
            {
                switch (property.PrimitiveType)
                {
                    case "String":
                        typeName = "dynamic";
                        break;
                    case "Long":
                    case "Double":
                        typeName = property.PrimitiveType.ToLower();
                        if (!property.Required) typeName += "?";
                        break;
                    case "Boolean":
                        typeName = "bool";
                        if (!property.Required) typeName += "?";
                        break;
                    case "Integer":
                        typeName = "int";
                        if (!property.Required) typeName += "?";
                        break;
                    case "Timestamp":
                        typeName = "System.DateTime";
                        break;
                    case "Json":
                        typeName = "dynamic";
                        break;
                    default:
                        throw new InvalidOperationException($"Unknown PrimitiveType: {property.PrimitiveType}");
                }
            }
            else
            {
                Debug.Assert(property.PrimitiveType == null);

                switch (property.Type)
                {
                    case "List":
                        if (property.PrimitiveItemType != null)
                        {
                            switch (property.PrimitiveItemType)
                            {
                                case "String":
                                    typeName = $"List<dynamic>";
                                    break;
                                case "Long":
                                case "Double":
                                    typeName = $"List<{property.PrimitiveItemType.ToLower()}>";
                                    break;
                                case "Boolean":
                                    typeName = "List<bool>";
                                    break;
                                case "Integer":
                                    typeName = "List<int>";
                                    break;
                                case "Timestamp":
                                    typeName = "List<DateTime>";
                                    break;
                                case "Json":
                                    typeName = "List<dynamic>";
                                    break;
                                default:
                                    throw new InvalidOperationException($"Unknown PrimitiveItemType: {property.PrimitiveItemType}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("List:: " + property.ItemType);
                            typeName = $"List<{property.ItemType}>";
                        }

                        break;

                    case "Map":
                        if (property.PrimitiveItemType != null)
                        {
                            switch (property.PrimitiveItemType)
                            {
                                case "String":
                                    typeName = $"Dictionary<string, dynamic>";
                                    break;
                                case "Boolean":
                                    typeName = "Dictionary<string, bool>";
                                    break;
                                default:
                                    throw new InvalidOperationException($"Unknown PrimitiveItemType: {property.PrimitiveItemType}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Map:: " + property.ItemType);
                            typeName = $"Dictionary<string, {property.ItemType}>";
                        }

                        break;

                    default:
                        Console.WriteLine("Struct:: " + property.Type);
                        typeName = property.Type;
                        break;
                }
            }

            return typeName;
        }

        private static Specification ParseSpecification(string json)
        {
            var parsed = JsonConvert.DeserializeObject<JObject>(json);

            var specification = new Specification
            {
                ResourceSpecificationVersion = parsed.SelectToken("ResourceSpecificationVersion").Value<string>()
            };

            if (string.IsNullOrWhiteSpace(specification.ResourceSpecificationVersion))
            {
                throw new InvalidOperationException("Error: ResourceSpecificationVersion");
            }

            foreach (var propType in parsed.SelectToken("PropertyTypes").Children<JProperty>())
            {
                var propertyType = new PropertyType
                {
                    Name = propType.Name,
                    Documentation = propType.Value.SelectToken("Documentation").Value<string>()
                };

                var properties = propType.Value.SelectToken("Properties");
                if (properties != null)
                {
                    if (propertyType.Properties == null) propertyType.Properties = new List<Property>();

                    foreach (var prop in properties.Children<JProperty>())
                    {
                        Property property = ParseProperty(prop);
                        propertyType.Properties.Add(property);
                    }
                }
                else
                {
                    // NOTE: Special case to handle "AWS::Cognito::IdentityPoolRoleAttachment.RulesConfigurationType" which doesn't have properties, but IS A property.
                    if (propertyType.Properties == null) propertyType.Properties = new List<Property>();

                    var split = propertyType.Name.Split(new[] { "::" }, StringSplitOptions.RemoveEmptyEntries);
                    var name = split[2].Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries)[1];

                    var property = new Property
                    {
                        Name = name,
                        Documentation = propType.Value.SelectToken("Documentation").Value<string>(),
                        Required = propType.Value.SelectToken("Required").Value<bool>(),
                        UpdateType = propType.Value.SelectToken("UpdateType").Value<string>(),
                        Type = propType.Value.SelectToken("Type")?.Value<string>(),
                        ItemType = propType.Value.SelectToken("ItemType")?.Value<string>(),
                    };

                    propertyType.Properties.Add(property);
                }

                specification.PropertyTypes.Add(propertyType);
            }

            foreach (var resType in parsed.SelectToken("ResourceTypes").Children<JProperty>())
            {
                var resourceType = new ResourceType
                {
                    Name = resType.Name,
                    Documentation = resType.Value.SelectToken("Documentation").Value<string>()
                };

                var properties = resType.Value.SelectToken("Properties");
                resourceType.Properties = new List<Property>();

                foreach (var prop in properties.Children<JProperty>())
                {
                    Property property = ParseProperty(prop);
                    resourceType.Properties.Add(property);
                }

                var attributes = resType.Value.SelectToken("Attributes");
                if (attributes != null)
                {
                    resourceType.Attributes = new List<Attribute>();

                    foreach (var attr in attributes.Children<JProperty>())
                    {
                        Attribute attribute = ParseAttribute(attr);
                        resourceType.Attributes.Add(attribute);
                    }
                }

                specification.ResourceTypes.Add(resourceType);
            }

            return specification;
        }

        private static Attribute ParseAttribute(JProperty attr)
        {
            var attribute = new Attribute
            {
                Name = attr.Name,
                ItemType = attr.Value.SelectToken("ItemType")?.Value<string>(),
                PrimitiveItemType = attr.Value.SelectToken("PrimitiveItemType")?.Value<string>(),
                PrimitiveType = attr.Value.SelectToken("PrimitiveType")?.Value<string>(),
                Type = attr.Value.SelectToken("Type")?.Value<string>()
            };

            return attribute;
        }

        private static Property ParseProperty(JProperty prop)
        {
            var property = new Property
            {
                Name = prop.Name,
                Documentation = prop.Value.SelectToken("Documentation").Value<string>(),
                Required = prop.Value.SelectToken("Required").Value<bool>(),
                UpdateType = prop.Value.SelectToken("UpdateType").Value<string>(),
                PrimitiveType = prop.Value.SelectToken("PrimitiveType")?.Value<string>(),
                PrimitiveItemType = prop.Value.SelectToken("PrimitiveItemType")?.Value<string>(),
                Type = prop.Value.SelectToken("Type")?.Value<string>(),
                ItemType = prop.Value.SelectToken("ItemType")?.Value<string>(),
                DuplicatesAllowed = prop.Value.SelectToken("DuplicatesAllowed")?.Value<bool>()
            };

            if (property.PrimitiveType == null)
            {
                Debug.Assert(property.Type != null);
            }
            else
            {
                Debug.Assert(property.Type == null);
            }

            if (property.PrimitiveItemType != null)
            {
                Debug.Assert(property.Type != null);
                Debug.Assert(property.Type == "List" || property.Type == "Map");
            }

            return property;
        }
    }
}