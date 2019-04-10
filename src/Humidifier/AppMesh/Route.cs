namespace Humidifier.AppMesh
{
    using System.Collections.Generic;
    using RouteTypes;

    public class Route : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string Uid =  "Uid" ;
            public static string MeshName =  "MeshName" ;
            public static string VirtualRouterName =  "VirtualRouterName" ;
            public static string RouteName =  "RouteName" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::AppMesh::Route";
            }
        }

        /// <summary>
        /// MeshName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-route.html#cfn-appmesh-route-meshname
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
        /// VirtualRouterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-route.html#cfn-appmesh-route-virtualroutername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VirtualRouterName
        {
            get;
            set;
        }

        /// <summary>
        /// RouteName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-route.html#cfn-appmesh-route-routename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RouteName
        {
            get;
            set;
        }

        /// <summary>
        /// Spec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-route.html#cfn-appmesh-route-spec
        /// Required: True
        /// UpdateType: Mutable
        /// Type: RouteSpec
        /// </summary>
        public RouteSpec Spec
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-route.html#cfn-appmesh-route-tags
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

    namespace RouteTypes
    {
        public class WeightedTarget
        {
            /// <summary>
            /// VirtualNode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-weightedtarget.html#cfn-appmesh-route-weightedtarget-virtualnode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VirtualNode
            {
                get;
                set;
            }

            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-weightedtarget.html#cfn-appmesh-route-weightedtarget-weight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Weight
            {
                get;
                set;
            }
        }

        public class TcpRoute
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tcproute.html#cfn-appmesh-route-tcproute-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TcpRouteAction
            /// </summary>
            public TcpRouteAction Action
            {
                get;
                set;
            }
        }

        public class RouteSpec
        {
            /// <summary>
            /// HttpRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-routespec.html#cfn-appmesh-route-routespec-httproute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpRoute
            /// </summary>
            public HttpRoute HttpRoute
            {
                get;
                set;
            }

            /// <summary>
            /// TcpRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-routespec.html#cfn-appmesh-route-routespec-tcproute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TcpRoute
            /// </summary>
            public TcpRoute TcpRoute
            {
                get;
                set;
            }
        }

        public class HttpRouteMatch
        {
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-prefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix
            {
                get;
                set;
            }
        }

        public class HttpRouteAction
        {
            /// <summary>
            /// WeightedTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httprouteaction.html#cfn-appmesh-route-httprouteaction-weightedtargets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WeightedTarget
            /// </summary>
            public List<WeightedTarget> WeightedTargets
            {
                get;
                set;
            }
        }

        public class HttpRoute
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproute.html#cfn-appmesh-route-httproute-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HttpRouteAction
            /// </summary>
            public HttpRouteAction Action
            {
                get;
                set;
            }

            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproute.html#cfn-appmesh-route-httproute-match
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HttpRouteMatch
            /// </summary>
            public HttpRouteMatch Match
            {
                get;
                set;
            }
        }

        public class TagRef
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tagref.html#cfn-appmesh-route-tagref-value
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tagref.html#cfn-appmesh-route-tagref-key
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

        public class TcpRouteAction
        {
            /// <summary>
            /// WeightedTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tcprouteaction.html#cfn-appmesh-route-tcprouteaction-weightedtargets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WeightedTarget
            /// </summary>
            public List<WeightedTarget> WeightedTargets
            {
                get;
                set;
            }
        }
    }
}