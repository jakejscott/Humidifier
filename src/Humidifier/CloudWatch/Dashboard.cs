namespace Humidifier.CloudWatch
{
    using System.Collections.Generic;
    using DashboardPropertyTypes;

    public class Dashboard : IResource
    {
        /// <summary>
        /// DashboardName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-dashboard.html#cfn-cloudwatch-dashboard-dashboardname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DashboardName
        {
            get;
            set;
        }

        /// <summary>
        /// DashboardBody
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-dashboard.html#cfn-cloudwatch-dashboard-dashboardbody
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DashboardBody
        {
            get;
            set;
        }
    }

    namespace DashboardPropertyTypes
    {
    }
}