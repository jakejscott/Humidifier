using System.Collections.Generic;

namespace Humidifier
{
    public class Stack
    {
        public Stack(string awsTemplateFormatVersion = "2010-09-09")
        {
            AWSTemplateFormatVersion = awsTemplateFormatVersion;
        }

        public string AWSTemplateFormatVersion { get; set; } 
        public string Transform { get; set; }
        public string Description { get; set; }

        public Dictionary<string, string> ResourceConditions { get; } = new Dictionary<string, string>();

        public Dictionary<string, Parameter> Parameters { get; } = new Dictionary<string, Parameter>();
        public Dictionary<string, Condition> Conditions { get; } = new Dictionary<string, Condition>();
        public Dictionary<string, Mapping> Mappings { get; } = new Dictionary<string, Mapping>();
        public Dictionary<string, Resource> Resources { get; } = new Dictionary<string, Resource>();
        public Dictionary<string, Output> Outputs { get; } = new Dictionary<string, Output>();

        public void Add(string name, Parameter parameter) => Parameters.Add(name, parameter);
        public void Add(string name, Condition condition) => Conditions.Add(name, condition);
        public void Add(string name, Output output) => Outputs.Add(name, output);
        public void Add(string name, Mapping mapping) => Mappings.Add(name, mapping);
        public void Add(string name, Resource resource, string condition = null)
        {
            Resources.Add(name, resource);
            if (!string.IsNullOrWhiteSpace(condition))
            {
                ResourceConditions.Add(name, condition);
            }
        }
    }
}
