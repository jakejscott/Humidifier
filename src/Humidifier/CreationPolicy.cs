namespace Humidifier
{
    public class CreationPolicy
    {
        public AutoScalingCreationPolicy AutoScalingCreationPolicy { get; set; }
        public ResourceSignal ResourceSignal { get; set; }
    }

    public class AutoScalingCreationPolicy
    {
        /// <summary>
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MinSuccessfulInstancesPercent { get; set; }
    }

    public class ResourceSignal
    {
        /// <summary>
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Count { get; set; }

        /// <summary>
        /// PrimitiveType: String
        /// </summary>
        public dynamic Timeout { get; set; }
    }
}