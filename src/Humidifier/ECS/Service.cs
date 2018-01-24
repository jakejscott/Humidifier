namespace Humidifier.ECS
{
    using System.Collections.Generic;
    using ServiceTypes;

    public class Service : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string Name =  "Name" ;
        }

        /// <summary>
        /// Cluster
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-cluster
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Cluster
        {
            get;
            set;
        }

        /// <summary>
        /// DeploymentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-deploymentconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeploymentConfiguration
        /// </summary>
        public DeploymentConfiguration DeploymentConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// DesiredCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-desiredcount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic DesiredCount
        {
            get;
            set;
        }

        /// <summary>
        /// HealthCheckGracePeriodSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-healthcheckgraceperiodseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic HealthCheckGracePeriodSeconds
        {
            get;
            set;
        }

        /// <summary>
        /// LaunchType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-launchtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LaunchType
        {
            get;
            set;
        }

        /// <summary>
        /// LoadBalancers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-loadbalancers
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: LoadBalancer
        /// </summary>
        public List<LoadBalancer> LoadBalancers
        {
            get;
            set;
        }

        /// <summary>
        /// NetworkConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-networkconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NetworkConfiguration
        /// </summary>
        public NetworkConfiguration NetworkConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// PlacementConstraints
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-placementconstraints
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: PlacementConstraint
        /// </summary>
        public List<PlacementConstraint> PlacementConstraints
        {
            get;
            set;
        }

        /// <summary>
        /// PlacementStrategies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-placementstrategies
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: PlacementStrategy
        /// </summary>
        public List<PlacementStrategy> PlacementStrategies
        {
            get;
            set;
        }

        /// <summary>
        /// PlatformVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-platformversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PlatformVersion
        {
            get;
            set;
        }

        /// <summary>
        /// Role
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-role
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Role
        {
            get;
            set;
        }

        /// <summary>
        /// ServiceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-servicename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ServiceName
        {
            get;
            set;
        }

        /// <summary>
        /// TaskDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-taskdefinition
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TaskDefinition
        {
            get;
            set;
        }
    }

    namespace ServiceTypes
    {
        public class LoadBalancer
        {
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-loadbalancers.html#cfn-ecs-service-loadbalancers-containername
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerName
            {
                get;
                set;
            }

            /// <summary>
            /// ContainerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-loadbalancers.html#cfn-ecs-service-loadbalancers-containerport
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ContainerPort
            {
                get;
                set;
            }

            /// <summary>
            /// LoadBalancerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-loadbalancers.html#cfn-ecs-service-loadbalancers-loadbalancername
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LoadBalancerName
            {
                get;
                set;
            }

            /// <summary>
            /// TargetGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-loadbalancers.html#cfn-ecs-service-loadbalancers-targetgrouparn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetGroupArn
            {
                get;
                set;
            }
        }

        public class PlacementStrategy
        {
            /// <summary>
            /// Field
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-placementstrategy.html#cfn-ecs-service-placementstrategy-field
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Field
            {
                get;
                set;
            }

            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-placementstrategy.html#cfn-ecs-service-placementstrategy-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type
            {
                get;
                set;
            }
        }

        public class DeploymentConfiguration
        {
            /// <summary>
            /// MaximumPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentconfiguration.html#cfn-ecs-service-deploymentconfiguration-maximumpercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumPercent
            {
                get;
                set;
            }

            /// <summary>
            /// MinimumHealthyPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentconfiguration.html#cfn-ecs-service-deploymentconfiguration-minimumhealthypercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinimumHealthyPercent
            {
                get;
                set;
            }
        }

        public class PlacementConstraint
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-placementconstraint.html#cfn-ecs-service-placementconstraint-expression
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression
            {
                get;
                set;
            }

            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-placementconstraint.html#cfn-ecs-service-placementconstraint-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type
            {
                get;
                set;
            }
        }

        public class AwsVpcConfiguration
        {
            /// <summary>
            /// AssignPublicIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-awsvpcconfiguration.html#cfn-ecs-service-awsvpcconfiguration-assignpublicip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AssignPublicIp
            {
                get;
                set;
            }

            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-awsvpcconfiguration.html#cfn-ecs-service-awsvpcconfiguration-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroups
            {
                get;
                set;
            }

            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-awsvpcconfiguration.html#cfn-ecs-service-awsvpcconfiguration-subnets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets
            {
                get;
                set;
            }
        }

        public class NetworkConfiguration
        {
            /// <summary>
            /// AwsvpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-networkconfiguration.html#cfn-ecs-service-networkconfiguration-awsvpcconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AwsVpcConfiguration
            /// </summary>
            public AwsVpcConfiguration AwsvpcConfiguration
            {
                get;
                set;
            }
        }
    }
}