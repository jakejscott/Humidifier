using System.Collections.Generic;

namespace Humidifier
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/parameters-section-structure.html
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// The data type for the parameter.
        /// <remarks>Required: Yes</remarks>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// A string of up to 4000 characters that describes the parameter.
        /// <remarks>Required: No</remarks>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A regular expression that represents the patterns you want to allow for String types. 
        /// <remarks>Required: No</remarks>
        /// </summary>
        public string AllowedPattern { get; set; }

        /// <summary>
        /// An array containing the list of values allowed for the parameter.
        /// <remarks>Required: No</remarks>
        /// </summary>
        public List<string> AllowedValues { get; set; }

        /// <summary>
        /// A string that explains the constraint when the constraint is violated. 
        /// <remarks>Required: No</remarks>
        /// </summary>
        public string ConstraintDescription { get; set; }

        /// <summary>
        /// A value of the appropriate type for the template to use if no value is specified when a stack is created. 
        /// If you define constraints for the parameter, you must specify a value that adheres to those constraints.
        /// <remarks>Required: No</remarks>
        /// </summary>
        public string Default { get; set; }

        /// <summary>
        /// An integer value that determines the smallest number of characters you want to allow for String types.
        /// <remarks>Required: No</remarks>
        /// </summary>
        public int? MinLength { get; set; }

        /// <summary>
        /// An integer value that determines the largest number of characters you want to allow for String types.
        /// <remarks>Required: No</remarks>
        /// </summary>
        public int? MaxLength { get; set; }

        /// <summary>
        /// A numeric value that determines the smallest numeric value you want to allow for Number types.
        /// <remarks>Required: No</remarks>
        /// </summary>
        public int? MinValue { get; set; }

        /// <summary>
        /// A numeric value that determines the largest numeric value you want to allow for Number types.
        /// <remarks>Required: No</remarks>
        /// </summary>
        public int? MaxValue { get; set; }

        /// <summary>
        /// Whether to mask the parameter value whenever anyone makes a call that describes the stack. If you set the value to true, the parameter value is masked with asterisks (*****).
        /// <remarks>Required: No</remarks>
        /// </summary>
        public bool? NoEcho { get; set; }
    }
}