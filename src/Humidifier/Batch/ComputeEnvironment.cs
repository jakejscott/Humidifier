namespace Humidifier.Batch
{
    using System.Collections.Generic;
    using ComputeEnvironmentTypes;

    public class ComputeEnvironment : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Batch::ComputeEnvironment";
            }
        }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Type
        {
            get;
            set;
        }

        /// <summary>
        /// ServiceRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-servicerole
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ServiceRole
        {
            get;
            set;
        }

        /// <summary>
        /// ComputeEnvironmentName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-computeenvironmentname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ComputeEnvironmentName
        {
            get;
            set;
        }

        /// <summary>
        /// ComputeResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-computeresources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ComputeResources
        /// </summary>
        public ComputeResources ComputeResources
        {
            get;
            set;
        }

        /// <summary>
        /// State
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-state
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic State
        {
            get;
            set;
        }
    }

    namespace ComputeEnvironmentTypes
    {
        public class LaunchTemplateSpecification
        {
            /// <summary>
            /// LaunchTemplateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-launchtemplatespecification.html#cfn-batch-computeenvironment-launchtemplatespecification-launchtemplatename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LaunchTemplateName
            {
                get;
                set;
            }

            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-launchtemplatespecification.html#cfn-batch-computeenvironment-launchtemplatespecification-version
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Version
            {
                get;
                set;
            }

            /// <summary>
            /// LaunchTemplateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-launchtemplatespecification.html#cfn-batch-computeenvironment-launchtemplatespecification-launchtemplateid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LaunchTemplateId
            {
                get;
                set;
            }
        }

        public class ComputeResources
        {
            /// <summary>
            /// SpotIamFleetRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-spotiamfleetrole
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SpotIamFleetRole
            {
                get;
                set;
            }

            /// <summary>
            /// MaxvCpus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-maxvcpus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxvCpus
            {
                get;
                set;
            }

            /// <summary>
            /// BidPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-bidpercentage
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BidPercentage
            {
                get;
                set;
            }

            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds
            {
                get;
                set;
            }

            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets
            {
                get;
                set;
            }

            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type
            {
                get;
                set;
            }

            /// <summary>
            /// MinvCpus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-minvcpus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinvCpus
            {
                get;
                set;
            }

            /// <summary>
            /// LaunchTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-launchtemplate
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LaunchTemplateSpecification
            /// </summary>
            public LaunchTemplateSpecification LaunchTemplate
            {
                get;
                set;
            }

            /// <summary>
            /// ImageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-imageid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageId
            {
                get;
                set;
            }

            /// <summary>
            /// InstanceRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-instancerole
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceRole
            {
                get;
                set;
            }

            /// <summary>
            /// InstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-instancetypes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InstanceTypes
            {
                get;
                set;
            }

            /// <summary>
            /// Ec2KeyPair
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-ec2keypair
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ec2KeyPair
            {
                get;
                set;
            }

            /// <summary>
            /// PlacementGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-placementgroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PlacementGroup
            {
                get;
                set;
            }

            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-tags
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
            /// DesiredvCpus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-desiredvcpus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DesiredvCpus
            {
                get;
                set;
            }
        }
    }
}