namespace Humidifier.Redshift
{
    using System.Collections.Generic;
    using ClusterParameterGroupPropertyTypes;

    public class ClusterParameterGroup : Humidifier.Resource
    {
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clusterparametergroup.html#cfn-redshift-clusterparametergroup-description
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description
        {
            get;
            set;
        }

        /// <summary>
        /// ParameterGroupFamily
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clusterparametergroup.html#cfn-redshift-clusterparametergroup-parametergroupfamily
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ParameterGroupFamily
        {
            get;
            set;
        }

        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clusterparametergroup.html#cfn-redshift-clusterparametergroup-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Parameter
        /// </summary>
        public List<Parameter> Parameters
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clusterparametergroup.html#cfn-redshift-clusterparametergroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags
        {
            get;
            set;
        }
    }

    namespace ClusterParameterGroupPropertyTypes
    {
        public class Parameter
        {
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-property-redshift-clusterparametergroup-parameter.html#cfn-redshift-clusterparametergroup-parameter-parametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName
            {
                get;
                set;
            }

            /// <summary>
            /// ParameterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-property-redshift-clusterparametergroup-parameter.html#cfn-redshift-clusterparametergroup-parameter-parametervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterValue
            {
                get;
                set;
            }
        }
    }
}