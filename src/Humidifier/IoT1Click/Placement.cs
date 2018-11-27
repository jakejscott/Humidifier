namespace Humidifier.IoT1Click
{
    using System.Collections.Generic;

    public class Placement : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string PlacementName =  "PlacementName" ;
            public static string ProjectName =  "ProjectName" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::IoT1Click::Placement";
            }
        }

        /// <summary>
        /// PlacementName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot1click-placement.html#cfn-iot1click-placement-placementname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PlacementName
        {
            get;
            set;
        }

        /// <summary>
        /// ProjectName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot1click-placement.html#cfn-iot1click-placement-projectname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProjectName
        {
            get;
            set;
        }

        /// <summary>
        /// AssociatedDevices
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot1click-placement.html#cfn-iot1click-placement-associateddevices
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic AssociatedDevices
        {
            get;
            set;
        }

        /// <summary>
        /// Attributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot1click-placement.html#cfn-iot1click-placement-attributes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Attributes_
        {
            get;
            set;
        }
    }
}