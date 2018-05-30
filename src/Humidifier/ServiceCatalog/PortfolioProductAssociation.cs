namespace Humidifier.ServiceCatalog
{
    using System.Collections.Generic;

    public class PortfolioProductAssociation : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::ServiceCatalog::PortfolioProductAssociation";
            }
        }

        /// <summary>
        /// SourcePortfolioId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolioproductassociation.html#cfn-servicecatalog-portfolioproductassociation-sourceportfolioid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SourcePortfolioId
        {
            get;
            set;
        }

        /// <summary>
        /// AcceptLanguage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolioproductassociation.html#cfn-servicecatalog-portfolioproductassociation-acceptlanguage
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolioproductassociation.html#cfn-servicecatalog-portfolioproductassociation-portfolioid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PortfolioId
        {
            get;
            set;
        }

        /// <summary>
        /// ProductId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolioproductassociation.html#cfn-servicecatalog-portfolioproductassociation-productid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProductId
        {
            get;
            set;
        }
    }
}