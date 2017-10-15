using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
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
        static string url = "https://d1uauaxba7bl26.cloudfront.net/latest/gzip/CloudFormationResourceSpecification.json";

        public static void Main(string[] args)
        {
            Console.WriteLine("Cleaning files");

            var basePath = Environment.GetEnvironmentVariable("BUILD_PATH");
            var humidifierPath = Path.Combine(basePath, "src", "Humidifier");
            var codegenPath = Path.Combine(basePath, "src", "Humidifier.CodeGen");

            foreach (var directory in Directory.GetDirectories(humidifierPath))
            {
                if (directory.EndsWith("bin") || directory.EndsWith("obj")) continue;
                Directory.Delete(directory, true);
            }

            Console.WriteLine("Downloading spec from " + url);
            var client = new HttpClient();
            var json = client.GetStringAsync(url).GetAwaiter().GetResult();
            File.WriteAllText(Path.Combine(codegenPath, "Specification.json"), json);

            Console.WriteLine("Parsing spec");
            Specification specification = ParseSpecification(json);
            Console.WriteLine("ResourceSpecificationVersion: " + specification.ResourceSpecificationVersion);

            foreach (ResourceType resourceType in specification.ResourceTypes)
            {
                var parts = resourceType.Name.Split(new[] { "::" }, StringSplitOptions.RemoveEmptyEntries);

                var group = parts[1];
                var resourceClassName = parts[2];
                var path = Path.Combine(humidifierPath, group);

                Directory.CreateDirectory(path);

                var propsNamespace = resourceClassName + "PropertyTypes";

                var namespaceDecl = NamespaceDeclaration(ParseName("Humidifier." + group))
                    .AddUsings(
                        UsingDirective(ParseName("System.Collections.Generic"))
                    );

                List<PropertyType> propertyTypes = specification.PropertyTypes.Where(x => x.Name.StartsWith(resourceType.Name + ".")).ToList();

                if (propertyTypes.Any())
                {
                    namespaceDecl = namespaceDecl.AddUsings(
                        UsingDirective(ParseName(propsNamespace))
                    );
                }

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

                if (propertyTypes.Any())
                {
                    namespaceDecl = namespaceDecl.AddMembers(propertyTypesNamespace);
                }

                var code = namespaceDecl.NormalizeWhitespace().ToFullString();
                var filePath = $"{path}/{resourceClassName}.cs";
                File.WriteAllText(filePath, code);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Done");
            Console.ResetColor();
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
                // NOTE: We can't actually use strong typing because of the cloudformation intrinsics functions :(
                // I thought about doing something like DynamicInt, DynamicString etc so that you still get a bit of an indication of what the type should be.
                // At least the xmldoc comments show the correct types in intellisense.
                return "dynamic";
#if false
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
#endif
            }
            else
            {
                Debug.Assert(property.PrimitiveType == null);

                switch (property.Type)
                {
                    // TODO: Might have use "List<dynamic>" dynamic[] or dynamic.
                    case "List":
                        if (property.PrimitiveItemType != null)
                        {
                            switch (property.PrimitiveItemType)
                            {
                                case "String":
                                    typeName = "dynamic";
                                    break;
                                case "Long":
                                    typeName = $"List<long>";
                                    break;
                                case "Double":
                                    typeName = $"List<double>";
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
                            // Console.WriteLine("List:: " + property.ItemType);
                            typeName = $"List<{property.ItemType}>";
                        }

                        break;

                    // TODO: Might have to use "Dictionary<string, dynamic>"
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
                            // Console.WriteLine("Map:: " + property.ItemType);
                            typeName = $"Dictionary<string, {property.ItemType}>";
                        }

                        break;

                    default:
                        // Console.WriteLine("Struct:: " + property.Type);
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
                var docs = propType.Value.SelectToken("Documentation");
                if (docs == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("MISSING DOCS!! " + propType.Name);
                    Console.ResetColor();
                    continue;
                }

                var propertyType = new PropertyType
                {
                    Name = propType.Name,
                    Documentation = docs?.ToString()
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