namespace Humidifier.CodeDeploy
{
    using System.Collections.Generic;
    using DeploymentConfigPropertyTypes;

    public class DeploymentConfig : Humidifier.Resource
    {
        /// <summary>
        /// DeploymentConfigName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentconfig.html#cfn-codedeploy-deploymentconfig-deploymentconfigname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DeploymentConfigName
        {
            get;
            set;
        }

        /// <summary>
        /// MinimumHealthyHosts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentconfig.html#cfn-codedeploy-deploymentconfig-minimumhealthyhosts
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MinimumHealthyHosts
        /// </summary>
        public MinimumHealthyHosts MinimumHealthyHosts
        {
            get;
            set;
        }
    }

    namespace DeploymentConfigPropertyTypes
    {
        public class MinimumHealthyHosts
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-minimumhealthyhosts.html#cfn-codedeploy-deploymentconfig-minimumhealthyhosts-type
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
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-minimumhealthyhosts.html#cfn-codedeploy-deploymentconfig-minimumhealthyhosts-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public int Value
            {
                get;
                set;
            }
        }
    }
}