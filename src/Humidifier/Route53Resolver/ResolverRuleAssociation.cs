namespace Humidifier.Route53Resolver
{
    using System.Collections.Generic;

    public class ResolverRuleAssociation : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string VPCId =  "VPCId" ;
            public static string ResolverRuleId =  "ResolverRuleId" ;
            public static string ResolverRuleAssociationId =  "ResolverRuleAssociationId" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Route53Resolver::ResolverRuleAssociation";
            }
        }

        /// <summary>
        /// VPCId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverruleassociation.html#cfn-route53resolver-resolverruleassociation-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VPCId
        {
            get;
            set;
        }

        /// <summary>
        /// ResolverRuleId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverruleassociation.html#cfn-route53resolver-resolverruleassociation-resolverruleid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResolverRuleId
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverruleassociation.html#cfn-route53resolver-resolverruleassociation-name
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name
        {
            get;
            set;
        }
    }
}