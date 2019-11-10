namespace Humidifier.WAFRegional
{
    using System.Collections.Generic;

    public class RegexPatternSet : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::WAFRegional::RegexPatternSet";
            }
        }

        /// <summary>
        /// RegexPatternStrings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-regexpatternset.html#cfn-wafregional-regexpatternset-regexpatternstrings
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic RegexPatternStrings
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-regexpatternset.html#cfn-wafregional-regexpatternset-name
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name
        {
            get;
            set;
        }
    }
}