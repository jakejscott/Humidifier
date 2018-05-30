namespace Humidifier.ServiceCatalog
{
    using System.Collections.Generic;

    public class PortfolioShare : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::ServiceCatalog::PortfolioShare";
            }
        }

        /// <summary>
        /// AccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolioshare.html#cfn-servicecatalog-portfolioshare-accountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AccountId
        {
            get;
            set;
        }

        /// <summary>
        /// AcceptLanguage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolioshare.html#cfn-servicecatalog-portfolioshare-acceptlanguage
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AcceptLanguage
        {
            get;
            set;
        }

        /// <summary>
        /// PortfolioId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolioshare.html#cfn-servicecatalog-portfolioshare-portfolioid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PortfolioId
        {
            get;
            set;
        }
    }
}