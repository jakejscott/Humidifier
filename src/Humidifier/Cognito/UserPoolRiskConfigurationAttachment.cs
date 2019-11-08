namespace Humidifier.Cognito
{
    using System.Collections.Generic;
    using UserPoolRiskConfigurationAttachmentTypes;

    public class UserPoolRiskConfigurationAttachment : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Cognito::UserPoolRiskConfigurationAttachment";
            }
        }

        /// <summary>
        /// CompromisedCredentialsRiskConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolriskconfigurationattachment.html#cfn-cognito-userpoolriskconfigurationattachment-compromisedcredentialsriskconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CompromisedCredentialsRiskConfigurationType
        /// </summary>
        public CompromisedCredentialsRiskConfigurationType CompromisedCredentialsRiskConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// UserPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolriskconfigurationattachment.html#cfn-cognito-userpoolriskconfigurationattachment-userpoolid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic UserPoolId
        {
            get;
            set;
        }

        /// <summary>
        /// ClientId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolriskconfigurationattachment.html#cfn-cognito-userpoolriskconfigurationattachment-clientid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClientId
        {
            get;
            set;
        }

        /// <summary>
        /// AccountTakeoverRiskConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolriskconfigurationattachment.html#cfn-cognito-userpoolriskconfigurationattachment-accounttakeoverriskconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AccountTakeoverRiskConfigurationType
        /// </summary>
        public AccountTakeoverRiskConfigurationType AccountTakeoverRiskConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// RiskExceptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolriskconfigurationattachment.html#cfn-cognito-userpoolriskconfigurationattachment-riskexceptionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RiskExceptionConfigurationType
        /// </summary>
        public RiskExceptionConfigurationType RiskExceptionConfiguration
        {
            get;
            set;
        }
    }

    namespace UserPoolRiskConfigurationAttachmentTypes
    {
        public class AccountTakeoverActionsType
        {
            /// <summary>
            /// HighAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-accounttakeoveractionstype.html#cfn-cognito-userpoolriskconfigurationattachment-accounttakeoveractionstype-highaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AccountTakeoverActionType
            /// </summary>
            public AccountTakeoverActionType HighAction
            {
                get;
                set;
            }

            /// <summary>
            /// LowAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-accounttakeoveractionstype.html#cfn-cognito-userpoolriskconfigurationattachment-accounttakeoveractionstype-lowaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AccountTakeoverActionType
            /// </summary>
            public AccountTakeoverActionType LowAction
            {
                get;
                set;
            }

            /// <summary>
            /// MediumAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-accounttakeoveractionstype.html#cfn-cognito-userpoolriskconfigurationattachment-accounttakeoveractionstype-mediumaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AccountTakeoverActionType
            /// </summary>
            public AccountTakeoverActionType MediumAction
            {
                get;
                set;
            }
        }

        public class RiskExceptionConfigurationType
        {
            /// <summary>
            /// BlockedIPRangeList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-riskexceptionconfigurationtype.html#cfn-cognito-userpoolriskconfigurationattachment-riskexceptionconfigurationtype-blockediprangelist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic BlockedIPRangeList
            {
                get;
                set;
            }

            /// <summary>
            /// SkippedIPRangeList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-riskexceptionconfigurationtype.html#cfn-cognito-userpoolriskconfigurationattachment-riskexceptionconfigurationtype-skippediprangelist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SkippedIPRangeList
            {
                get;
                set;
            }
        }

        public class NotifyEmailType
        {
            /// <summary>
            /// TextBody
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-notifyemailtype.html#cfn-cognito-userpoolriskconfigurationattachment-notifyemailtype-textbody
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TextBody
            {
                get;
                set;
            }

            /// <summary>
            /// HtmlBody
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-notifyemailtype.html#cfn-cognito-userpoolriskconfigurationattachment-notifyemailtype-htmlbody
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HtmlBody
            {
                get;
                set;
            }

            /// <summary>
            /// Subject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-notifyemailtype.html#cfn-cognito-userpoolriskconfigurationattachment-notifyemailtype-subject
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Subject
            {
                get;
                set;
            }
        }

        public class AccountTakeoverActionType
        {
            /// <summary>
            /// Notify
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-accounttakeoveractiontype.html#cfn-cognito-userpoolriskconfigurationattachment-accounttakeoveractiontype-notify
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Notify
            {
                get;
                set;
            }

            /// <summary>
            /// EventAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-accounttakeoveractiontype.html#cfn-cognito-userpoolriskconfigurationattachment-accounttakeoveractiontype-eventaction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EventAction
            {
                get;
                set;
            }
        }

        public class CompromisedCredentialsRiskConfigurationType
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-compromisedcredentialsriskconfigurationtype.html#cfn-cognito-userpoolriskconfigurationattachment-compromisedcredentialsriskconfigurationtype-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CompromisedCredentialsActionsType
            /// </summary>
            public CompromisedCredentialsActionsType Actions
            {
                get;
                set;
            }

            /// <summary>
            /// EventFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-compromisedcredentialsriskconfigurationtype.html#cfn-cognito-userpoolriskconfigurationattachment-compromisedcredentialsriskconfigurationtype-eventfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic EventFilter
            {
                get;
                set;
            }
        }

        public class CompromisedCredentialsActionsType
        {
            /// <summary>
            /// EventAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-compromisedcredentialsactionstype.html#cfn-cognito-userpoolriskconfigurationattachment-compromisedcredentialsactionstype-eventaction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EventAction
            {
                get;
                set;
            }
        }

        public class NotifyConfigurationType
        {
            /// <summary>
            /// BlockEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype.html#cfn-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype-blockemail
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotifyEmailType
            /// </summary>
            public NotifyEmailType BlockEmail
            {
                get;
                set;
            }

            /// <summary>
            /// ReplyTo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype.html#cfn-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype-replyto
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReplyTo
            {
                get;
                set;
            }

            /// <summary>
            /// SourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype.html#cfn-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype-sourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceArn
            {
                get;
                set;
            }

            /// <summary>
            /// NoActionEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype.html#cfn-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype-noactionemail
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotifyEmailType
            /// </summary>
            public NotifyEmailType NoActionEmail
            {
                get;
                set;
            }

            /// <summary>
            /// From
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype.html#cfn-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype-from
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic From
            {
                get;
                set;
            }

            /// <summary>
            /// MfaEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype.html#cfn-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype-mfaemail
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotifyEmailType
            /// </summary>
            public NotifyEmailType MfaEmail
            {
                get;
                set;
            }
        }

        public class AccountTakeoverRiskConfigurationType
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-accounttakeoverriskconfigurationtype.html#cfn-cognito-userpoolriskconfigurationattachment-accounttakeoverriskconfigurationtype-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AccountTakeoverActionsType
            /// </summary>
            public AccountTakeoverActionsType Actions
            {
                get;
                set;
            }

            /// <summary>
            /// NotifyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-accounttakeoverriskconfigurationtype.html#cfn-cognito-userpoolriskconfigurationattachment-accounttakeoverriskconfigurationtype-notifyconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotifyConfigurationType
            /// </summary>
            public NotifyConfigurationType NotifyConfiguration
            {
                get;
                set;
            }
        }
    }
}