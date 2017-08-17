namespace Humidifier.Cognito
{
    using System.Collections.Generic;
    using UserPoolPropertyTypes;

    public class UserPool : Humidifier.Resource
    {
        /// <summary>
        /// UserPoolTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-userpooltags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic UserPoolTags
        {
            get;
            set;
        }

        /// <summary>
        /// Policies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-policies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Policies
        /// </summary>
        public Policies Policies
        {
            get;
            set;
        }

        /// <summary>
        /// MfaConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-mfaconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MfaConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// Schema
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-schema
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: SchemaAttribute
        /// </summary>
        public List<SchemaAttribute> Schema
        {
            get;
            set;
        }

        /// <summary>
        /// AdminCreateUserConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-admincreateuserconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AdminCreateUserConfig
        /// </summary>
        public AdminCreateUserConfig AdminCreateUserConfig
        {
            get;
            set;
        }

        /// <summary>
        /// SmsAuthenticationMessage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-smsauthenticationmessage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SmsAuthenticationMessage
        {
            get;
            set;
        }

        /// <summary>
        /// UserPoolName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-userpoolname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic UserPoolName
        {
            get;
            set;
        }

        /// <summary>
        /// SmsVerificationMessage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-smsverificationmessage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SmsVerificationMessage
        {
            get;
            set;
        }

        /// <summary>
        /// EmailConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-emailconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EmailConfiguration
        /// </summary>
        public EmailConfiguration EmailConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// SmsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-smsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SmsConfiguration
        /// </summary>
        public SmsConfiguration SmsConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// AliasAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-aliasattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public List<dynamic> AliasAttributes
        {
            get;
            set;
        }

        /// <summary>
        /// EmailVerificationSubject
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-emailverificationsubject
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EmailVerificationSubject
        {
            get;
            set;
        }

        /// <summary>
        /// LambdaConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-lambdaconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LambdaConfig
        /// </summary>
        public LambdaConfig LambdaConfig
        {
            get;
            set;
        }

        /// <summary>
        /// AutoVerifiedAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-autoverifiedattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public List<dynamic> AutoVerifiedAttributes
        {
            get;
            set;
        }

        /// <summary>
        /// DeviceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-deviceconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeviceConfiguration
        /// </summary>
        public DeviceConfiguration DeviceConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// EmailVerificationMessage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpool.html#cfn-cognito-userpool-emailverificationmessage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EmailVerificationMessage
        {
            get;
            set;
        }
    }

    namespace UserPoolPropertyTypes
    {
        public class Policies
        {
            /// <summary>
            /// PasswordPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-policies.html#cfn-cognito-userpool-policies-passwordpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PasswordPolicy
            /// </summary>
            public PasswordPolicy PasswordPolicy
            {
                get;
                set;
            }
        }

        public class EmailConfiguration
        {
            /// <summary>
            /// ReplyToEmailAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-emailconfiguration.html#cfn-cognito-userpool-emailconfiguration-replytoemailaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReplyToEmailAddress
            {
                get;
                set;
            }

            /// <summary>
            /// SourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-emailconfiguration.html#cfn-cognito-userpool-emailconfiguration-sourcearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceArn
            {
                get;
                set;
            }
        }

        public class LambdaConfig
        {
            /// <summary>
            /// CreateAuthChallenge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-createauthchallenge
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAuthChallenge
            {
                get;
                set;
            }

            /// <summary>
            /// PreAuthentication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-preauthentication
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PreAuthentication
            {
                get;
                set;
            }

            /// <summary>
            /// DefineAuthChallenge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-defineauthchallenge
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefineAuthChallenge
            {
                get;
                set;
            }

            /// <summary>
            /// PreSignUp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-presignup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PreSignUp
            {
                get;
                set;
            }

            /// <summary>
            /// PostAuthentication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-postauthentication
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PostAuthentication
            {
                get;
                set;
            }

            /// <summary>
            /// PostConfirmation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-postconfirmation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PostConfirmation
            {
                get;
                set;
            }

            /// <summary>
            /// CustomMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-custommessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomMessage
            {
                get;
                set;
            }

            /// <summary>
            /// VerifyAuthChallengeResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-verifyauthchallengeresponse
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VerifyAuthChallengeResponse
            {
                get;
                set;
            }
        }

        public class PasswordPolicy
        {
            /// <summary>
            /// RequireNumbers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html#cfn-cognito-userpool-passwordpolicy-requirenumbers
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? RequireNumbers
            {
                get;
                set;
            }

            /// <summary>
            /// MinimumLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html#cfn-cognito-userpool-passwordpolicy-minimumlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public int ? MinimumLength
            {
                get;
                set;
            }

            /// <summary>
            /// RequireUppercase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html#cfn-cognito-userpool-passwordpolicy-requireuppercase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? RequireUppercase
            {
                get;
                set;
            }

            /// <summary>
            /// RequireLowercase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html#cfn-cognito-userpool-passwordpolicy-requirelowercase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? RequireLowercase
            {
                get;
                set;
            }

            /// <summary>
            /// RequireSymbols
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html#cfn-cognito-userpool-passwordpolicy-requiresymbols
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? RequireSymbols
            {
                get;
                set;
            }
        }

        public class AdminCreateUserConfig
        {
            /// <summary>
            /// InviteMessageTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-admincreateuserconfig.html#cfn-cognito-userpool-admincreateuserconfig-invitemessagetemplate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InviteMessageTemplate
            /// </summary>
            public InviteMessageTemplate InviteMessageTemplate
            {
                get;
                set;
            }

            /// <summary>
            /// UnusedAccountValidityDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-admincreateuserconfig.html#cfn-cognito-userpool-admincreateuserconfig-unusedaccountvaliditydays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public double ? UnusedAccountValidityDays
            {
                get;
                set;
            }

            /// <summary>
            /// AllowAdminCreateUserOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-admincreateuserconfig.html#cfn-cognito-userpool-admincreateuserconfig-allowadmincreateuseronly
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? AllowAdminCreateUserOnly
            {
                get;
                set;
            }
        }

        public class SchemaAttribute
        {
            /// <summary>
            /// DeveloperOnlyAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-schemaattribute.html#cfn-cognito-userpool-schemaattribute-developeronlyattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? DeveloperOnlyAttribute
            {
                get;
                set;
            }

            /// <summary>
            /// Mutable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-schemaattribute.html#cfn-cognito-userpool-schemaattribute-mutable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? Mutable
            {
                get;
                set;
            }

            /// <summary>
            /// AttributeDataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-schemaattribute.html#cfn-cognito-userpool-schemaattribute-attributedatatype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeDataType
            {
                get;
                set;
            }

            /// <summary>
            /// StringAttributeConstraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-schemaattribute.html#cfn-cognito-userpool-schemaattribute-stringattributeconstraints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringAttributeConstraints
            /// </summary>
            public StringAttributeConstraints StringAttributeConstraints
            {
                get;
                set;
            }

            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-schemaattribute.html#cfn-cognito-userpool-schemaattribute-required
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? Required
            {
                get;
                set;
            }

            /// <summary>
            /// NumberAttributeConstraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-schemaattribute.html#cfn-cognito-userpool-schemaattribute-numberattributeconstraints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberAttributeConstraints
            /// </summary>
            public NumberAttributeConstraints NumberAttributeConstraints
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-schemaattribute.html#cfn-cognito-userpool-schemaattribute-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }
        }

        public class NumberAttributeConstraints
        {
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-numberattributeconstraints.html#cfn-cognito-userpool-numberattributeconstraints-minvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MinValue
            {
                get;
                set;
            }

            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-numberattributeconstraints.html#cfn-cognito-userpool-numberattributeconstraints-maxvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaxValue
            {
                get;
                set;
            }
        }

        public class SmsConfiguration
        {
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-smsconfiguration.html#cfn-cognito-userpool-smsconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExternalId
            {
                get;
                set;
            }

            /// <summary>
            /// SnsCallerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-smsconfiguration.html#cfn-cognito-userpool-smsconfiguration-snscallerarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SnsCallerArn
            {
                get;
                set;
            }
        }

        public class DeviceConfiguration
        {
            /// <summary>
            /// DeviceOnlyRememberedOnUserPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-deviceconfiguration.html#cfn-cognito-userpool-deviceconfiguration-deviceonlyrememberedonuserprompt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? DeviceOnlyRememberedOnUserPrompt
            {
                get;
                set;
            }

            /// <summary>
            /// ChallengeRequiredOnNewDevice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-deviceconfiguration.html#cfn-cognito-userpool-deviceconfiguration-challengerequiredonnewdevice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? ChallengeRequiredOnNewDevice
            {
                get;
                set;
            }
        }

        public class InviteMessageTemplate
        {
            /// <summary>
            /// EmailMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-invitemessagetemplate.html#cfn-cognito-userpool-invitemessagetemplate-emailmessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EmailMessage
            {
                get;
                set;
            }

            /// <summary>
            /// SMSMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-invitemessagetemplate.html#cfn-cognito-userpool-invitemessagetemplate-smsmessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SMSMessage
            {
                get;
                set;
            }

            /// <summary>
            /// EmailSubject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-invitemessagetemplate.html#cfn-cognito-userpool-invitemessagetemplate-emailsubject
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EmailSubject
            {
                get;
                set;
            }
        }

        public class StringAttributeConstraints
        {
            /// <summary>
            /// MinLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-stringattributeconstraints.html#cfn-cognito-userpool-stringattributeconstraints-minlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MinLength
            {
                get;
                set;
            }

            /// <summary>
            /// MaxLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-stringattributeconstraints.html#cfn-cognito-userpool-stringattributeconstraints-maxlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaxLength
            {
                get;
                set;
            }
        }
    }
}