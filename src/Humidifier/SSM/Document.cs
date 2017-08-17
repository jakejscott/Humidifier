namespace Humidifier.SSM
{
    using System.Collections.Generic;
    using DocumentPropertyTypes;

    public class Document : Humidifier.Resource
    {
        /// <summary>
        /// Content
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-document.html#cfn-ssm-document-content
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Content
        {
            get;
            set;
        }

        /// <summary>
        /// DocumentType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-document.html#cfn-ssm-document-documenttype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DocumentType
        {
            get;
            set;
        }
    }

    namespace DocumentPropertyTypes
    {
    }
}