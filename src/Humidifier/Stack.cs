using System.Collections.Generic;
using System.Linq;

namespace Humidifier
{
    public class Stack
    {
        private Dictionary<string, string> ResourceConditions { get; } = new Dictionary<string, string>();
        private Dictionary<string, HashSet<string>> ResourceDependsOn { get; } = new Dictionary<string, HashSet<string>>();

        public Stack(string awsTemplateFormatVersion = "2010-09-09")
        {
            AWSTemplateFormatVersion = awsTemplateFormatVersion;
        }

        public string AWSTemplateFormatVersion { get; set; }
        public string Transform { get; set; }
        public string Description { get; set; }

        public Dictionary<string, Parameter> Parameters { get; } = new Dictionary<string, Parameter>();
        public Dictionary<string, Condition> Conditions { get; } = new Dictionary<string, Condition>();
        public Dictionary<string, Mapping> Mappings { get; } = new Dictionary<string, Mapping>();
        public Dictionary<string, Resource> Resources { get; } = new Dictionary<string, Resource>();
        public Dictionary<string, Output> Outputs { get; } = new Dictionary<string, Output>();

        public void Add(string name, Parameter parameter) => Parameters.Add(name, parameter);
        public void Add(string name, Condition condition) => Conditions.Add(name, condition);
        public void Add(string name, Output output) => Outputs.Add(name, output);
        public void Add(string name, Mapping mapping) => Mappings.Add(name, mapping);

        public void Add(string name, Resource resource, string condition = null, string[] dependsOn = null)
        {
            Resources.Add(name, resource);

            if (!string.IsNullOrWhiteSpace(condition))
            {
                AddCondition(name, condition);
            }

            if (dependsOn != null && dependsOn.Length > 0)
            {
                AddDependsOn(name, dependsOn);
            }
        }

        public void AddCondition(string name, string condition)
        {
            if (ResourceConditions.ContainsKey(name))
            {
                ResourceConditions[name] = condition;
            }
            else
            {
                ResourceConditions.Add(name, condition);
            }
        }

        public void AddDependsOn(string resource, params string[] dependsOn)
        {
            if (ResourceDependsOn.ContainsKey(resource))
            {
                foreach (var item in dependsOn)
                {
                    ResourceDependsOn[resource].Add(item);
                }
            }
            else
            {
                ResourceDependsOn.Add(resource, new HashSet<string>(dependsOn));
            }
        }

        public string GetCondition(string resource)
        {
            if (ResourceConditions.ContainsKey(resource))
            {
                return ResourceConditions[resource];
            }

            return null;
        }


        public List<string> GetDependsOn(string resource)
        {
            if (ResourceDependsOn.ContainsKey(resource))
            {
                return ResourceDependsOn[resource].ToList();
            }

            return null;
        }
    }
}
