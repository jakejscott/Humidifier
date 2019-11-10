namespace Humidifier.MSK
{
    using System.Collections.Generic;
    using ClusterTypes;

    public class Cluster : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::MSK::Cluster";
            }
        }

        /// <summary>
        /// BrokerNodeGroupInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-brokernodegroupinfo
        /// Required: True
        /// UpdateType: Immutable
        /// Type: BrokerNodeGroupInfo
        /// </summary>
        public BrokerNodeGroupInfo BrokerNodeGroupInfo
        {
            get;
            set;
        }

        /// <summary>
        /// EnhancedMonitoring
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-enhancedmonitoring
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EnhancedMonitoring
        {
            get;
            set;
        }

        /// <summary>
        /// KafkaVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-kafkaversion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KafkaVersion
        {
            get;
            set;
        }

        /// <summary>
        /// NumberOfBrokerNodes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-numberofbrokernodes
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic NumberOfBrokerNodes
        {
            get;
            set;
        }

        /// <summary>
        /// EncryptionInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-encryptioninfo
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionInfo
        /// </summary>
        public EncryptionInfo EncryptionInfo
        {
            get;
            set;
        }

        /// <summary>
        /// ClusterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-clustername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClusterName
        {
            get;
            set;
        }

        /// <summary>
        /// ClientAuthentication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-clientauthentication
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ClientAuthentication
        /// </summary>
        public ClientAuthentication ClientAuthentication
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-tags
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Tags
        {
            get;
            set;
        }

        /// <summary>
        /// ConfigurationInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html#cfn-msk-cluster-configurationinfo
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ConfigurationInfo
        /// </summary>
        public ConfigurationInfo ConfigurationInfo
        {
            get;
            set;
        }
    }

    namespace ClusterTypes
    {
        public class EncryptionInfo
        {
            /// <summary>
            /// EncryptionAtRest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-encryptioninfo.html#cfn-msk-cluster-encryptioninfo-encryptionatrest
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EncryptionAtRest
            /// </summary>
            public EncryptionAtRest EncryptionAtRest
            {
                get;
                set;
            }

            /// <summary>
            /// EncryptionInTransit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-encryptioninfo.html#cfn-msk-cluster-encryptioninfo-encryptionintransit
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EncryptionInTransit
            /// </summary>
            public EncryptionInTransit EncryptionInTransit
            {
                get;
                set;
            }
        }

        public class ConfigurationInfo
        {
            /// <summary>
            /// Revision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-configurationinfo.html#cfn-msk-cluster-configurationinfo-revision
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Revision
            {
                get;
                set;
            }

            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-configurationinfo.html#cfn-msk-cluster-configurationinfo-arn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn
            {
                get;
                set;
            }
        }

        public class BrokerNodeGroupInfo
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-brokernodegroupinfo.html#cfn-msk-cluster-brokernodegroupinfo-securitygroups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroups
            {
                get;
                set;
            }

            /// <summary>
            /// ClientSubnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-brokernodegroupinfo.html#cfn-msk-cluster-brokernodegroupinfo-clientsubnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ClientSubnets
            {
                get;
                set;
            }

            /// <summary>
            /// StorageInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-brokernodegroupinfo.html#cfn-msk-cluster-brokernodegroupinfo-storageinfo
            /// Required: False
            /// UpdateType: Immutable
            /// Type: StorageInfo
            /// </summary>
            public StorageInfo StorageInfo
            {
                get;
                set;
            }

            /// <summary>
            /// BrokerAZDistribution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-brokernodegroupinfo.html#cfn-msk-cluster-brokernodegroupinfo-brokerazdistribution
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BrokerAZDistribution
            {
                get;
                set;
            }

            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-brokernodegroupinfo.html#cfn-msk-cluster-brokernodegroupinfo-instancetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType
            {
                get;
                set;
            }
        }

        public class StorageInfo
        {
            /// <summary>
            /// EBSStorageInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-storageinfo.html#cfn-msk-cluster-storageinfo-ebsstorageinfo
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EBSStorageInfo
            /// </summary>
            public EBSStorageInfo EBSStorageInfo
            {
                get;
                set;
            }
        }

        public class EncryptionAtRest
        {
            /// <summary>
            /// DataVolumeKMSKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-encryptionatrest.html#cfn-msk-cluster-encryptionatrest-datavolumekmskeyid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataVolumeKMSKeyId
            {
                get;
                set;
            }
        }

        public class EBSStorageInfo
        {
            /// <summary>
            /// VolumeSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-ebsstorageinfo.html#cfn-msk-cluster-ebsstorageinfo-volumesize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumeSize
            {
                get;
                set;
            }
        }

        public class EncryptionInTransit
        {
            /// <summary>
            /// ClientBroker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-encryptionintransit.html#cfn-msk-cluster-encryptionintransit-clientbroker
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientBroker
            {
                get;
                set;
            }

            /// <summary>
            /// InCluster
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-encryptionintransit.html#cfn-msk-cluster-encryptionintransit-incluster
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic InCluster
            {
                get;
                set;
            }
        }

        public class ClientAuthentication
        {
            /// <summary>
            /// Tls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-clientauthentication.html#cfn-msk-cluster-clientauthentication-tls
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Tls
            /// </summary>
            public Tls Tls
            {
                get;
                set;
            }
        }

        public class Tls
        {
            /// <summary>
            /// CertificateAuthorityArnList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-tls.html#cfn-msk-cluster-tls-certificateauthorityarnlist
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CertificateAuthorityArnList
            {
                get;
                set;
            }
        }
    }
}