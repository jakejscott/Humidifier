namespace Humidifier.ASK
{
    using System.Collections.Generic;
    using SkillTypes;

    public class Skill : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"Alexa::ASK::Skill";
            }
        }

        /// <summary>
        /// AuthenticationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ask-skill.html#cfn-ask-skill-authenticationconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AuthenticationConfiguration
        /// </summary>
        public AuthenticationConfiguration AuthenticationConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// VendorId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ask-skill.html#cfn-ask-skill-vendorid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VendorId
        {
            get;
            set;
        }

        /// <summary>
        /// SkillPackage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ask-skill.html#cfn-ask-skill-skillpackage
        /// Required: True
        /// UpdateType: Mutable
        /// Type: SkillPackage
        /// </summary>
        public SkillPackage SkillPackage
        {
            get;
            set;
        }
    }

    namespace SkillTypes
    {
        public class SkillPackage
        {
            /// <summary>
            /// S3BucketRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-skillpackage.html#cfn-ask-skill-skillpackage-s3bucketrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BucketRole
            {
                get;
                set;
            }

            /// <summary>
            /// S3ObjectVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-skillpackage.html#cfn-ask-skill-skillpackage-s3objectversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3ObjectVersion
            {
                get;
                set;
            }

            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-skillpackage.html#cfn-ask-skill-skillpackage-s3bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Bucket
            {
                get;
                set;
            }

            /// <summary>
            /// S3Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-skillpackage.html#cfn-ask-skill-skillpackage-s3key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Key
            {
                get;
                set;
            }

            /// <summary>
            /// Overrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-skillpackage.html#cfn-ask-skill-skillpackage-overrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Overrides
            /// </summary>
            public Overrides Overrides
            {
                get;
                set;
            }
        }

        public class Overrides
        {
            /// <summary>
            /// Manifest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-overrides.html#cfn-ask-skill-overrides-manifest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Manifest
            {
                get;
                set;
            }
        }

        public class AuthenticationConfiguration
        {
            /// <summary>
            /// RefreshToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-authenticationconfiguration.html#cfn-ask-skill-authenticationconfiguration-refreshtoken
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RefreshToken
            {
                get;
                set;
            }

            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-authenticationconfiguration.html#cfn-ask-skill-authenticationconfiguration-clientsecret
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecret
            {
                get;
                set;
            }

            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-authenticationconfiguration.html#cfn-ask-skill-authenticationconfiguration-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId
            {
                get;
                set;
            }
        }
    }
}