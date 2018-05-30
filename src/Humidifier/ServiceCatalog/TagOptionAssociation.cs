namespace Humidifier.ServiceCatalog
{
    using System.Collections.Generic;

    public class TagOptionAssociation : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::ServiceCatalog::TagOptionAssociation";
            }
        }

        /// <summary>
        /// TagOptionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-tagoptionassociation.html#cfn-servicecatalog-tagoptionassociation-tagoptionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TagOptionId
        {
            get;
            set;
        }

        /// <summary>
        /// ResourceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-tagoptionassociation.html#cfn-servicecatalog-tagoptionassociation-resourceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResourceId
        {
            get;
            set;
        }
    }
}