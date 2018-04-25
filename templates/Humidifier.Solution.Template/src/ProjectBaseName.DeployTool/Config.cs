using System.Collections.Generic;
using Amazon.CloudFormation.Model;

namespace ProjectBaseName.DeployTool
{
    public class Config
    {
        public string Env { get; set; }
        public string Region { get; set; }
        public string Profile { get; set; }
        public string Stack { get; set; }
        public string Team { get; set; }
        public string Email { get; set; }
        public string BuildPath { get; set; }
        public string BuildConfig { get; set; }
        public List<Tag> Tags { get; set; }
        
    }
}