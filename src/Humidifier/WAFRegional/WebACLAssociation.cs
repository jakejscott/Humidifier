namespace Humidifier.WAFRegional
{
    using System.Collections.Generic;
    using WebACLAssociationPropertyTypes;

    public class WebACLAssociation : IResource
    {
        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-webaclassociation.html#cfn-wafregional-webaclassociation-resourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResourceArn
        {
            get;
            set;
        }

        /// <summary>
        /// WebACLId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-webaclassociation.html#cfn-wafregional-webaclassociation-webaclid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic WebACLId
        {
            get;
            set;
        }
    }

    namespace WebACLAssociationPropertyTypes
    {
    }
}