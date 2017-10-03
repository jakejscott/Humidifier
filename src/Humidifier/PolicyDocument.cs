using System.Collections.Generic;

namespace Humidifier
{
    public class PolicyDocument
    {
        public string Version { get; set; }
        public string Id { get; set; }
        public List<Statement> Statement { get; set; }
    }

    public class Statement
    {
        public string Sid { get; set; }
        public string Effect { get; set; }
        public dynamic Principal { get; set; }
        public dynamic NotPrincipal { get; set; }
        public dynamic Action { get; set; }
        public dynamic NotAction { get; set; }
        public dynamic Resource { get; set; }
        public dynamic NotResource { get; set; }

        public Dictionary<string, Dictionary<string, dynamic>> Condition { get; set; }
    }
}