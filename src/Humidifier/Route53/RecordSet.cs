namespace Humidifier.Route53
{
    using System.Collections.Generic;
    using RecordSetPropertyTypes;

    public class RecordSet : Humidifier.Resource
    {
        /// <summary>
        /// AliasTarget
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-aliastarget
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AliasTarget
        /// </summary>
        public AliasTarget AliasTarget
        {
            get;
            set;
        }

        /// <summary>
        /// Comment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-comment
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Comment
        {
            get;
            set;
        }

        /// <summary>
        /// Failover
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-failover
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Failover
        {
            get;
            set;
        }

        /// <summary>
        /// GeoLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-geolocation
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GeoLocation
        /// </summary>
        public GeoLocation GeoLocation
        {
            get;
            set;
        }

        /// <summary>
        /// HealthCheckId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-healthcheckid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HealthCheckId
        {
            get;
            set;
        }

        /// <summary>
        /// HostedZoneId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-hostedzoneid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HostedZoneId
        {
            get;
            set;
        }

        /// <summary>
        /// HostedZoneName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-hostedzonename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HostedZoneName
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-name
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name
        {
            get;
            set;
        }

        /// <summary>
        /// Region
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-region
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Region
        {
            get;
            set;
        }

        /// <summary>
        /// ResourceRecords
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-resourcerecords
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public List<dynamic> ResourceRecords
        {
            get;
            set;
        }

        /// <summary>
        /// SetIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-setidentifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SetIdentifier
        {
            get;
            set;
        }

        /// <summary>
        /// TTL
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-ttl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TTL
        {
            get;
            set;
        }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-type
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Type
        {
            get;
            set;
        }

        /// <summary>
        /// Weight
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-weight
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? Weight
        {
            get;
            set;
        }
    }

    namespace RecordSetPropertyTypes
    {
        public class GeoLocation
        {
            /// <summary>
            /// ContinentCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html#cfn-route53-recordset-geolocation-continentcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContinentCode
            {
                get;
                set;
            }

            /// <summary>
            /// CountryCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html#cfn-route53-recordset-geolocation-countrycode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CountryCode
            {
                get;
                set;
            }

            /// <summary>
            /// SubdivisionCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html#cfn-route53-recordset-geolocation-subdivisioncode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubdivisionCode
            {
                get;
                set;
            }
        }

        public class AliasTarget
        {
            /// <summary>
            /// DNSName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-aliastarget.html#cfn-route53-aliastarget-dnshostname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DNSName
            {
                get;
                set;
            }

            /// <summary>
            /// EvaluateTargetHealth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-aliastarget.html#cfn-route53-aliastarget-evaluatetargethealth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? EvaluateTargetHealth
            {
                get;
                set;
            }

            /// <summary>
            /// HostedZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-aliastarget.html#cfn-route53-aliastarget-hostedzoneid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostedZoneId
            {
                get;
                set;
            }
        }
    }
}