namespace Humidifier.ECS
{
    using System.Collections.Generic;
    using ClusterPropertyTypes;

    public class Cluster : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        /// <summary>
        /// ClusterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-cluster.html#cfn-ecs-cluster-clustername
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClusterName
        {
            get;
            set;
        }
    }

    namespace ClusterPropertyTypes
    {
    }
}