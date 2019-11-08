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
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags
        {
            get;
            set;
        }
    }

    namespace RouteTypes
    {
        public class GrpcRetryPolicy
        {
            /// <summary>
            /// MaxRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-maxretries
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxRetries
            {
                get;
                set;
            }

            /// <summary>
            /// PerRetryTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-perretrytimeout
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Duration PerRetryTimeout
            {
                get;
                set;
            }

            /// <summary>
            /// GrpcRetryEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-grpcretryevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic GrpcRetryEvents
            {
                get;
                set;
            }

            /// <summary>
            /// HttpRetryEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-httpretryevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic HttpRetryEvents
            {
                get;
                set;
            }

            /// <summary>
            /// TcpRetryEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-tcpretryevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TcpRetryEvents
            {
                get;
                set;
            }
        }

        public class Duration
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-duration.html#cfn-appmesh-route-duration-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Value
            {
                get;
                set;
            }

            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-duration.html#cfn-appmesh-route-duration-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit
            {
                get;
                set;
            }
        }

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

        public class GrpcRouteMetadataMatchMethod
        {
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadatamatchmethod.html#cfn-appmesh-route-grpcroutemetadatamatchmethod-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Suffix
            {
                get;
                set;
            }

            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadatamatchmethod.html#cfn-appmesh-route-grpcroutemetadatamatchmethod-regex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Regex
            {
                get;
                set;
            }

            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadatamatchmethod.html#cfn-appmesh-route-grpcroutemetadatamatchmethod-exact
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Exact
            {
                get;
                set;
            }

            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadatamatchmethod.html#cfn-appmesh-route-grpcroutemetadatamatchmethod-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix
            {
                get;
                set;
            }

            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadatamatchmethod.html#cfn-appmesh-route-grpcroutemetadatamatchmethod-range
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchRange
            /// </summary>
            public MatchRange Range
            {
                get;
                set;
            }
        }

        public class HttpRetryPolicy
        {
            /// <summary>
            /// MaxRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httpretrypolicy.html#cfn-appmesh-route-httpretrypolicy-maxretries
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxRetries
            {
                get;
                set;
            }

            /// <summary>
            /// PerRetryTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httpretrypolicy.html#cfn-appmesh-route-httpretrypolicy-perretrytimeout
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Duration PerRetryTimeout
            {
                get;
                set;
            }

            /// <summary>
            /// HttpRetryEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httpretrypolicy.html#cfn-appmesh-route-httpretrypolicy-httpretryevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic HttpRetryEvents
            {
                get;
                set;
            }

            /// <summary>
            /// TcpRetryEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httpretrypolicy.html#cfn-appmesh-route-httpretrypolicy-tcpretryevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TcpRetryEvents
            {
                get;
                set;
            }
        }

        public class HeaderMatchMethod
        {
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-headermatchmethod.html#cfn-appmesh-route-headermatchmethod-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Suffix
            {
                get;
                set;
            }

            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-headermatchmethod.html#cfn-appmesh-route-headermatchmethod-regex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Regex
            {
                get;
                set;
            }

            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-headermatchmethod.html#cfn-appmesh-route-headermatchmethod-exact
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Exact
            {
                get;
                set;
            }

            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-headermatchmethod.html#cfn-appmesh-route-headermatchmethod-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix
            {
                get;
                set;
            }

            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-headermatchmethod.html#cfn-appmesh-route-headermatchmethod-range
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchRange
            /// </summary>
            public MatchRange Range
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
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-routespec.html#cfn-appmesh-route-routespec-priority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Priority
            {
                get;
                set;
            }

            /// <summary>
            /// Http2Route
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-routespec.html#cfn-appmesh-route-routespec-http2route
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpRoute
            /// </summary>
            public HttpRoute Http2Route
            {
                get;
                set;
            }

            /// <summary>
            /// GrpcRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-routespec.html#cfn-appmesh-route-routespec-grpcroute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrpcRoute
            /// </summary>
            public GrpcRoute GrpcRoute
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

        public class GrpcRoute
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroute.html#cfn-appmesh-route-grpcroute-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GrpcRouteAction
            /// </summary>
            public GrpcRouteAction Action
            {
                get;
                set;
            }

            /// <summary>
            /// RetryPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroute.html#cfn-appmesh-route-grpcroute-retrypolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrpcRetryPolicy
            /// </summary>
            public GrpcRetryPolicy RetryPolicy
            {
                get;
                set;
            }

            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroute.html#cfn-appmesh-route-grpcroute-match
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GrpcRouteMatch
            /// </summary>
            public GrpcRouteMatch Match
            {
                get;
                set;
            }
        }

        public class HttpRouteHeader
        {
            /// <summary>
            /// Invert
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httprouteheader.html#cfn-appmesh-route-httprouteheader-invert
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Invert
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httprouteheader.html#cfn-appmesh-route-httprouteheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }

            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httprouteheader.html#cfn-appmesh-route-httprouteheader-match
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeaderMatchMethod
            /// </summary>
            public HeaderMatchMethod Match
            {
                get;
                set;
            }
        }

        public class GrpcRouteMetadata
        {
            /// <summary>
            /// Invert
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadata.html#cfn-appmesh-route-grpcroutemetadata-invert
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Invert
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadata.html#cfn-appmesh-route-grpcroutemetadata-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }

            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadata.html#cfn-appmesh-route-grpcroutemetadata-match
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrpcRouteMetadataMatchMethod
            /// </summary>
            public GrpcRouteMetadataMatchMethod Match
            {
                get;
                set;
            }
        }

        public class HttpRouteMatch
        {
            /// <summary>
            /// Scheme
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-scheme
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scheme
            {
                get;
                set;
            }

            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HttpRouteHeader
            /// </summary>
            public List<HttpRouteHeader> Headers
            {
                get;
                set;
            }

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

            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-method
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Method
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

        public class GrpcRouteAction
        {
            /// <summary>
            /// WeightedTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcrouteaction.html#cfn-appmesh-route-grpcrouteaction-weightedtargets
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

        public class GrpcRouteMatch
        {
            /// <summary>
            /// ServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutematch.html#cfn-appmesh-route-grpcroutematch-servicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceName
            {
                get;
                set;
            }

            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutematch.html#cfn-appmesh-route-grpcroutematch-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GrpcRouteMetadata
            /// </summary>
            public List<GrpcRouteMetadata> Metadata
            {
                get;
                set;
            }

            /// <summary>
            /// MethodName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutematch.html#cfn-appmesh-route-grpcroutematch-methodname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MethodName
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
            /// RetryPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproute.html#cfn-appmesh-route-httproute-retrypolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpRetryPolicy
            /// </summary>
            public HttpRetryPolicy RetryPolicy
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

        public class MatchRange
        {
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-matchrange.html#cfn-appmesh-route-matchrange-start
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Start
            {
                get;
                set;
            }

            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-matchrange.html#cfn-appmesh-route-matchrange-end
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic End
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