namespace Humidifier.SDB
{
    using System.Collections.Generic;
    using DomainPropertyTypes;

    public class Domain : IResource
    {
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-simpledb.html#cfn-sdb-domain-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description
        {
            get;
            set;
        }
    }

    namespace DomainPropertyTypes
    {
    }
}