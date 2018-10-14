using System.Collections.Generic;
using System.Linq;

namespace Humidifier
{
    public class Stack
    {
        private Dictionary<string, string> ResourceConditions { get; } = new Dictionary<string, string>();
        private Dictionary<string, DeletionPolicy> ResourceDeletionPolicies { get; } = new Dictionary<string, DeletionPolicy>();
        private Dictionary<string, CreationPolicy> ResourceCreationPolicies { get; } = new Dictionary<string, CreationPolicy>();
        private Dictionary<string, UpdatePolicy> ResourceUpdatePolicies { get; } = new Dictionary<string, UpdatePolicy>();
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
        public Dictionary<string, dynamic> ResourceMetadata { get; } = new Dictionary<string, dynamic>();
        public Dictionary<string, dynamic> TemplateMetadata { get; } = new Dictionary<string, dynamic>();

        public void Add(string name, Parameter parameter) => Parameters.Add(name, parameter);
        public void Add(string name, Condition condition) => Conditions.Add(name, condition);
        public void Add(string name, Output output) => Outputs.Add(name, output);
        public void Add(string name, Mapping mapping) => Mappings.Add(name, mapping);

        public void Add(string name, Resource resource, string condition = null, CreationPolicy creationPolicy = null, UpdatePolicy updatePolicy = null, DeletionPolicy? deletionPolicy = null, dynamic metadata = null, string[] dependsOn = null)
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

            if (creationPolicy != null)
            {
                AddCreationPolicy(name, creationPolicy);
            }

            if (updatePolicy != null)
            {
                AddUpdatePolicy(name, updatePolicy);
            }

            if (deletionPolicy != null)
            {
                AddDeletionPolicy(name, deletionPolicy.Value);
            }

            if (metadata != null)
            {
                AddResourceMetadata(name, metadata);
            }
        }

        public void AddCondition(string resource, string condition)
        {
            if (ResourceConditions.ContainsKey(resource))
            {
                ResourceConditions[resource] = condition;
            }
            else
            {
                ResourceConditions.Add(resource, condition);
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

        public void AddCreationPolicy(string resource, CreationPolicy creationPolicy)
        {
            if (ResourceCreationPolicies.ContainsKey(resource))
            {
                ResourceCreationPolicies[resource] = creationPolicy;
            }
            else
            {
                ResourceCreationPolicies.Add(resource, creationPolicy);
            }
        }

        public void AddUpdatePolicy(string resource, UpdatePolicy updatePolicy)
        {
            if (ResourceCreationPolicies.ContainsKey(resource))
            {
                ResourceUpdatePolicies[resource] = updatePolicy;
            }
            else
            {
                ResourceUpdatePolicies.Add(resource, updatePolicy);
            }
        }

        public void AddDeletionPolicy(string resource, DeletionPolicy policy)
        {
            if (ResourceDeletionPolicies.ContainsKey(resource))
            {
                ResourceDeletionPolicies[resource] = policy;
            }
            else
            {
                ResourceDeletionPolicies.Add(resource, policy);
            }
        }

        public void AddResourceMetadata(string resource, dynamic metadata)
        {
            if (ResourceMetadata.ContainsKey(resource))
            {
                ResourceMetadata[resource] = metadata;
            }
            else
            {
                ResourceMetadata.Add(resource, metadata);
            }
        }

        public void AddTemplateMetadata(string resource, dynamic metadata)
        {
            if (TemplateMetadata.ContainsKey(resource))
            {
                TemplateMetadata[resource] = metadata;
            }
            else
            {
                TemplateMetadata.Add(resource, metadata);
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

        public CreationPolicy GetCreationPolicy(string resource)
        {
            if (ResourceCreationPolicies.ContainsKey(resource))
            {
                return ResourceCreationPolicies[resource];
            }

            return null;
        }

        public UpdatePolicy GetUpdatePolicy(string resource)
        {
            if (ResourceUpdatePolicies.ContainsKey(resource))
            {
                return ResourceUpdatePolicies[resource];
            }

            return null;
        }

        public DeletionPolicy? GetDeletionPolicy(string resource)
        {
            if (ResourceDeletionPolicies.ContainsKey(resource))
            {
                return ResourceDeletionPolicies[resource];
            }

            return null;
        }

        public dynamic GetMetadata(string resource)
        {
            if (ResourceMetadata.ContainsKey(resource))
            {
                return ResourceMetadata[resource];
            }

            return null;
        }
    }
}
