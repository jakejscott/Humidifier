namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using NotebookInstanceLifecycleConfigTypes;

    public class NotebookInstanceLifecycleConfig : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string NotebookInstanceLifecycleConfigName =  "NotebookInstanceLifecycleConfigName" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SageMaker::NotebookInstanceLifecycleConfig";
            }
        }

        /// <summary>
        /// OnStart
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstancelifecycleconfig.html#cfn-sagemaker-notebookinstancelifecycleconfig-onstart
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: NotebookInstanceLifecycleHook
        /// </summary>
        public List<NotebookInstanceLifecycleHook> OnStart
        {
            get;
            set;
        }

        /// <summary>
        /// NotebookInstanceLifecycleConfigName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstancelifecycleconfig.html#cfn-sagemaker-notebookinstancelifecycleconfig-notebookinstancelifecycleconfigname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NotebookInstanceLifecycleConfigName
        {
            get;
            set;
        }

        /// <summary>
        /// OnCreate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstancelifecycleconfig.html#cfn-sagemaker-notebookinstancelifecycleconfig-oncreate
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: NotebookInstanceLifecycleHook
        /// </summary>
        public List<NotebookInstanceLifecycleHook> OnCreate
        {
            get;
            set;
        }
    }

    namespace NotebookInstanceLifecycleConfigTypes
    {
        public class NotebookInstanceLifecycleHook
        {
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-notebookinstancelifecycleconfig-notebookinstancelifecyclehook.html#cfn-sagemaker-notebookinstancelifecycleconfig-notebookinstancelifecyclehook-content
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Content
            {
                get;
                set;
            }
        }
    }
}