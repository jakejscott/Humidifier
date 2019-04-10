namespace Humidifier.AppMesh
{
    using System.Collections.Generic;
    using VirtualServiceTypes;

    public class VirtualService : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string Uid =  "Uid" ;
            public static string MeshName =  "MeshName" ;
            public static string VirtualServiceName =  "VirtualServiceName" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::AppMesh::VirtualService";
            }
        }

        /// <summary>
        /// MeshName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualservice.html#cfn-appmesh-virtualservice-meshname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MeshName
        {
            get;
            set;
        }

        /// <summary>
        /// VirtualServiceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualservice.html#cfn-appmesh-virtualservice-virtualservicename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VirtualServiceName
        {
            get;
            set;
        }

        /// <summary>
        /// Spec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualservice.html#cfn-appmesh-virtualservice-spec
        /// Required: True
        /// UpdateType: Mutable
        /// Type: VirtualServiceSpec
        /// </summary>
        public VirtualServiceSpec Spec
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualservice.html#cfn-appmesh-virtualservice-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagRef
        /// </summary>
        public List<TagRef> Tags
        {
            get;
            set;
        }
    }

    namespace VirtualServiceTypes
    {
        public class VirtualServiceSpec
        {
            /// <summary>
            /// Provider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualservice-virtualservicespec.html#cfn-appmesh-virtualservice-virtualservicespec-provider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualServiceProvider
            /// </summary>
            public VirtualServiceProvider Provider
            {
                get;
                set;
            }
        }

        public class VirtualRouterServiceProvider
        {
            /// <summary>
            /// VirtualRouterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualservice-virtualrouterserviceprovider.html#cfn-appmesh-virtualservice-virtualrouterserviceprovider-virtualroutername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VirtualRouterName
            {
                get;
                set;
            }
        }

        public class TagRef
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualservice-tagref.html#cfn-appmesh-virtualservice-tagref-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value
            {
                get;
                set;
            }

            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualservice-tagref.html#cfn-appmesh-virtualservice-tagref-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key
            {
                get;
                set;
            }
        }

        public class VirtualNodeServiceProvider
        {
            /// <summary>
            /// VirtualNodeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualservice-virtualnodeserviceprovider.html#cfn-appmesh-virtualservice-virtualnodeserviceprovider-virtualnodename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VirtualNodeName
            {
                get;
                set;
            }
        }

        public class VirtualServiceProvider
        {
            /// <summary>
            /// VirtualNode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualservice-virtualserviceprovider.html#cfn-appmesh-virtualservice-virtualserviceprovider-virtualnode
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualNodeServiceProvider
            /// </summary>
            public VirtualNodeServiceProvider VirtualNode
            {
                get;
                set;
            }

            /// <summary>
            /// VirtualRouter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualservice-virtualserviceprovider.html#cfn-appmesh-virtualservice-virtualserviceprovider-virtualrouter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualRouterServiceProvider
            /// </summary>
            public VirtualRouterServiceProvider VirtualRouter
            {
                get;
                set;
            }
        }
    }
}