using System.Collections.Generic;

namespace Humidifier
{
    public class Stack
    {
        private Dictionary<string, Parameter> parameters = new Dictionary<string, Parameter>();
        private Dictionary<string, Mapping> mappings = new Dictionary<string, Mapping>();
        private Dictionary<string, IResource> resources = new Dictionary<string, IResource>();
        private Dictionary<string, Output> outputs = new Dictionary<string, Output>();

        public Stack(string awsTemplateFormatVersion = "2010-09-09")
        {
            AWSTemplateFormatVersion = awsTemplateFormatVersion;
        }

        public string AWSTemplateFormatVersion { get; set; } 
        public string Transform { get; set; }
        public string Description { get; set; }

        public Dictionary<string, Parameter> Parameters => parameters;
        public Dictionary<string, Mapping> Mappings => mappings;
        public Dictionary<string, IResource> Resources => resources;
        public Dictionary<string, Output> Outputs => outputs;

        public void Add(string name, Parameter parameter) => parameters.Add(name, parameter);
        public void Add(string name, IResource resource) => resources.Add(name, resource);
        public void Add(string name, Output output) => outputs.Add(name, output);
        public void Add(string name, Mapping mapping) => mappings.Add(name, mapping);
    }
}
