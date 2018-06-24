using System.Collections.Generic;
using Humidifier.ApiGateway.StageTypes;

namespace Humidifier.Serverless
{
    public class Api : Resource
    {
        public override string AWSTypeName => "AWS::Serverless::Api";

        /// <summary>
        /// A name for the API Gateway RestApi resource.
        /// 
        /// Type: String
        /// </summary>
        public dynamic Name { get; set; }

        /// <summary>
        /// The name of the stage, which API Gateway uses as the first path segment in the invoke Uniform Resource Identifier (URI).
        /// Required
        /// Type: String
        /// </summary>
        public dynamic StageName { get; set; }

        /// <summary>
        /// S3 URI or location to the Swagger document describing the API. Either one of DefinitionUri or DefinitionBody must be specified.
        /// Type: String | S3LocationObject
        /// </summary>
        public dynamic DefinitionUri { get; set; }

        /// <summary>
        /// Swagger specification that describes your API. Either one of DefinitionUri or DefinitionBody must be specified.
        /// Type: JSON or YAML
        /// </summary>
        public dynamic DefinitionBody { get; set; }

        /// <summary>
        /// Indicates whether cache clustering is enabled for the stage.
        /// Type: bool
        /// </summary>
        public dynamic CacheClusterEnabled { get; set; }

        /// <summary>
        /// The stage's cache cluster size.
        /// Type: string
        /// </summary>
        public dynamic CacheClusterSize { get; set; }

        /// <summary>
        /// A map (string to string map) that defines the stage variables, where the variable name is the key and the variable value is the value. Variable names are limited to alphanumeric characters. Values must match the following regular expression: [A-Za-z0-9._~:/?#&amp;=,-]+.
        /// </summary>
        public Dictionary<string, dynamic> Variables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public MethodSetting MethodSetting { get; set; }

        /// <summary>
        /// Specify the type of endpoint for API endpoint. Value is either REGIONAL or EDGE.
        /// Type: String
        /// </summary>
        public dynamic EndpointConfiguration { get; set; }

        /// <summary>
        /// List of MIME types that your API could return. Use this to enable binary support for APIs. Use ~1 instead of / in the mime types
        /// For example:
        /// image~1gif
        /// image~1png
        /// </summary>
        public List<string> BinaryMediaTypes { get; set; }

        /// <summary>
        /// Enable CORS for all your APIs. Specify the domain to allow as a string or specify a dictionary with additional Cors Configuration. NOTE: Cors requires SAM to modify your Swagger definition. Hence it works only inline swagger defined with DefinitionBody.
        /// https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#cors-configuration
        /// Cors:
        /// AllowMethods: Optional. String containing the HTTP methods to allow. 
        /// # For example, "'GET,POST,DELETE'". If you omit this property, then SAM will automatically allow all the methods configured for each API. 
        /// # Checkout [HTTP Spec](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Allow-Methods) more details on the value.
        /// 
        /// AllowHeaders: Optional. String of headers to allow. 
        /// # For example, "'X-Forwarded-For'". Checkout [HTTP Spec](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Allow-Headers) for more details on the value
        /// 
        /// AllowOrigin: Required. String of origin to allow. 
        /// # For example, "'www.example.com'". Checkout [HTTP Spec](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Allow-Origin) for more details on this value.
        /// 
        /// MaxAge: Optional. String containing the number of seconds to cache CORS Preflight request. 
        /// # For example, "'600'" will cache request for 600 seconds. Checkout [HTTP Spec](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Max-Age) for more details on this value
        /// </summary>
        public dynamic Cors { get; set; }
    }

    namespace ApiTypes
    {
        public class S3LocationObject
        {
            public dynamic Bucket { get; set; }
            public dynamic Key { get; set; }
            public dynamic Version { get; set; }
        }
    }
}