using System;
using System.Collections.Generic;

namespace Humidifier
{
    public static class Fn
    {
        public static FnBase64 Base64(dynamic valueToEncode) => new FnBase64(valueToEncode);
        public static FnJoin Join(string seperator, params dynamic[] parameters) => new FnJoin(seperator, parameters);
        public static FnRef Ref(string reference) => new FnRef(reference);
        public static FnGetAtt GetAtt(string logicalNameOfResource, string attributeName) => new FnGetAtt(logicalNameOfResource, attributeName);
        public static FnSub Sub(string input, Dictionary<string, dynamic> variables = null) => new FnSub(input, variables);
        public static FnImportValue ImportValue(dynamic sharedValueToImport) => new FnImportValue(sharedValueToImport);
        public static FnSplit Split(string delimiter, dynamic sourceString) => new FnSplit(delimiter, sourceString);
        public static FnSelect Select(string index, dynamic listOfObjects) => new FnSelect(index, listOfObjects);
        public static FnGetAZs GetAZs(dynamic region) => new FnGetAZs(region);
        public static FnFindInMap FindInMap(string mapName, dynamic topLevelKey, dynamic secondLevelKey) => new FnFindInMap(mapName, topLevelKey, secondLevelKey);

        public static FnAnd And(params dynamic[] conditions) => new FnAnd(conditions);
        public static FnIf If(string conditionName, dynamic valueIfTrue, dynamic valueIfFalse) => new FnIf(conditionName, valueIfTrue, valueIfFalse);
        public new static FnEquals Equals(dynamic value1, dynamic value2) => new FnEquals(value1, value2);
        public static FnNot Not(dynamic condition) => new FnNot(condition);
        public static FnOr Or(params dynamic[] conditions) => new FnOr(conditions);
        public static FnCidr Cidr(dynamic ipBlock, dynamic count, dynamic sizeMask) => new FnCidr(ipBlock, count, sizeMask);
    }

    /// <summary>
    /// The intrinsic function Fn::Cidr returns the specified Cidr address block.
    /// 
    /// Example: 
    /// 
    /// { "Fn:Cidr": [ipBlock, count, sizeMask] }
    /// 
    /// ipBlock: The user-specified default Cidr address block.
    /// count: The number of subnets' Cidr block wanted. Count can be 1 to 256.
    /// sizeMask: Optional. The digit covered in the subnet.
    /// 
    /// 
    /// </summary>
    public class FnCidr
    {
        public dynamic IpBlock { get; set; }
        public dynamic Count { get; set; }
        public dynamic SizeMask { get; set; }

        public FnCidr(dynamic ipBlock, dynamic count, dynamic sizeMask)
        {
            IpBlock = ipBlock;
            Count = count;
            SizeMask = sizeMask;
        }
    }

    /// <summary>
    /// Returns true if any one of the specified conditions evaluate to true, or returns false if all of the conditions evaluates to false. Fn::Or acts as an OR operator. The minimum number of conditions that you can include is 2, and the maximum is 10.
    /// 
    /// Example: 
    /// 
    /// { "Fn::And": [{condition}, {...}] }
    /// 
    /// </summary>
    public class FnAnd
    {
        public List<dynamic> Conditions { get; }

        public FnAnd(params dynamic[] conditions)
        {
            if (conditions == null) throw new ArgumentNullException(nameof(conditions));
            if (conditions.Length < 2 || conditions.Length > 10)
            {
                throw new ArgumentException("The minimum number of conditions that you can include is 2, and the maximum is 10.");
            }

            Conditions = new List<dynamic>(conditions);
        }
    }

    /// <summary>
    /// Returns true if any one of the specified conditions evaluate to true, or returns false if all of the conditions evaluates to false. Fn::Or acts as an OR operator. The minimum number of conditions that you can include is 2, and the maximum is 10.
    /// 
    /// Example: 
    /// 
    /// { "Fn::Or": [{condition}, {...}] }
    /// 
    /// </summary>
    public class FnOr
    {
        public List<dynamic> Conditions { get; }

        public FnOr(params dynamic[] conditions)
        {
            if (conditions == null) throw new ArgumentNullException(nameof(conditions));
            if (conditions.Length < 2 || conditions.Length > 10)
            {
                throw new ArgumentException("The minimum number of conditions that you can include is 2, and the maximum is 10.");
            }

            Conditions = new List<dynamic>(conditions);
        }
    }

    /// <summary>
    /// Returns true for a condition that evaluates to false or returns false for a condition that evaluates to true. Fn::Not acts as a NOT operator.
    /// 
    /// A condition such as Fn::Equals that evaluates to true or false.
    /// 
    /// Example:
    /// 
    /// { "Fn::Not": [{condition}] }
    /// 
    /// </summary>
    public class FnNot
    {
        public dynamic Condition { get; }

        public FnNot(dynamic condition)
        {
            if (condition == null) throw new ArgumentNullException(nameof(condition));
            Condition = condition;
        }
    }

    /// <summary>
    /// Compares if two values are equal. Returns true if the two values are equal or false if they aren't.
    /// 
    /// Example: 
    /// 
    /// { "Fn::Equals" : ["value_1", "value_2"] }
    /// 
    /// </summary>
    public class FnEquals
    {
        public dynamic Value1 { get; }
        public dynamic Value2 { get; }

        public FnEquals(dynamic value1, dynamic value2)
        {
            if (value1 == null) throw new ArgumentNullException(nameof(value1));
            if (value2 == null) throw new ArgumentNullException(nameof(value2));

            Value1 = value1;
            Value2 = value2;
        }
    }

    /// <summary>
    /// Returns one value if the specified condition evaluates to true and another value if the specified condition evaluates to false. 
    /// Currently, AWS CloudFormation supports the Fn::If intrinsic function in the metadata attribute, update policy attribute, and property 
    /// values in the Resources section and Outputs sections of a template. 
    /// 
    /// You can use the AWS::NoValue pseudo parameter as a return value to remove the corresponding property.
    /// 
    /// Example:
    /// 
    /// "Fn::If": [condition_name, value_if_true, value_if_false]
    /// 
    /// "Fn::If" : [
    ///    "UseDBSnapshot",
    ///      {"Ref" : "DBSnapshotName"},
    //       {"Ref" : "AWS::NoValue"}
    //  ]
    /// </summary>
    public class FnIf
    {
        public string ConditionName { get; }
        public dynamic ValueIfTrue { get; }
        public dynamic ValueIfFalse { get; }

        public FnIf(string conditionName, dynamic valueIfTrue, dynamic valueIfFalse)
        {
            ConditionName = conditionName ?? throw new ArgumentNullException(nameof(conditionName));

            if (valueIfTrue == null) throw new ArgumentNullException(nameof(valueIfTrue));
            if (valueIfFalse == null) throw new ArgumentNullException(nameof(valueIfFalse));

            ValueIfTrue = valueIfTrue;
            ValueIfFalse = valueIfFalse;
        }
    }

    /// <summary>
    /// The intrinsic function Fn::Base64 returns the Base64 representation of the input string. This function is typically used to pass 
    /// encoded data to Amazon EC2 instances by way of the UserData property.
    /// 
    /// Example:
    /// 
    /// { "Fn::Base64" : "AWS CloudFormation" }
    /// 
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-base64.html
    ///  </summary>
    public class FnBase64
    {
        public dynamic ValueToEncode { get; }
        public FnBase64(dynamic valueToEncode) => ValueToEncode = valueToEncode ?? throw new ArgumentNullException(nameof(valueToEncode));
    }

    /// <summary>
    /// The intrinsic function Fn::FindInMap returns the value corresponding to keys in a two-level map that is declared in the Mappings section.
    /// 
    /// Example:
    /// 
    /// { "Fn::FindInMap" : [ "RegionMap", { "Ref" : "AWS::Region" }, "32"]}
    /// 
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-findinmap.html#w2ab2c21c28c22c11
    /// </summary>
    public class FnFindInMap
    {
        public string MapName { get; }
        public dynamic TopLevelKey { get; }
        public dynamic SecondLevelKey { get; }

        public FnFindInMap(string mapName, dynamic topLevelKey, dynamic secondLevelKey)
        {
            MapName = mapName ?? throw new ArgumentNullException(nameof(mapName));

            if (topLevelKey == null) throw new ArgumentNullException(nameof(topLevelKey));
            if (secondLevelKey == null) throw new ArgumentNullException(nameof(secondLevelKey));

            TopLevelKey = topLevelKey;
            SecondLevelKey = secondLevelKey;
        }
    }

    /// <summary>
    /// The intrinsic function Fn::GetAZs returns an array that lists Availability Zones for a specified region. 
    /// Because customers have access to different Availability Zones, the intrinsic function Fn::GetAZs enables template authors to write templates that adapt to 
    /// the calling user's access. That way you don't have to hard-code a full list of Availability Zones for a specified region.
    /// 
    /// Example:
    /// 
    /// { "Fn::GetAZs" : "" }
    /// { "Fn::GetAZs" : { "Ref" : "AWS::Region" } }
    /// { "Fn::GetAZs" : "us-east-2" }
    /// 
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-getavailabilityzones.html
    /// </summary>
    public class FnGetAZs
    {
        public dynamic Region { get; }

        public FnGetAZs(dynamic region)
        {
            Region = region ?? throw new ArgumentNullException(nameof(region));
        }
    }

    /// <summary>
    /// The intrinsic function Fn::Select returns a single object from a list of objects by index.
    /// 
    /// Example: The following example returns: "grapes".
    /// 
    /// { "Fn::Select" : [ "1", [ "apples", "grapes", "oranges", "mangoes" ] ] }
    /// 
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-select.html
    /// </summary>
    public class FnSelect
    {
        public string Index { get; }
        public dynamic ListOfObjects { get; }

        public FnSelect(string index, dynamic listOfObjects)
        {
            Index = index ?? throw new ArgumentNullException(nameof(index));
            ListOfObjects = listOfObjects ?? throw new ArgumentNullException(nameof(listOfObjects));
        }
    }

    /// <summary>
    /// To split a string into a list of string values so that you can select an element from the resulting string list, use the Fn::Split intrinsic function. 
    /// Specify the location of splits with a delimiter, such as , (a comma). After you split a string, use the Fn::Select function to pick a specific element.
    /// 
    /// Example: The following example splits a string at each vertical bar (|). The function returns ["a", "b", "c"].
    /// 
    /// { "Fn::Split" : [ "|" , "a|b|c" ] }
    /// 
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-split.html  
    /// </summary>
    public class FnSplit
    {
        public string Delimiter { get; }
        public dynamic SourceString { get; }

        public FnSplit(string delimiter, dynamic sourceString)
        {
            Delimiter = delimiter ?? throw new ArgumentNullException(nameof(delimiter));
            SourceString = sourceString ?? throw new ArgumentNullException(nameof(sourceString));
        }
    }

    /// <summary>
    /// The Fn::GetAtt intrinsic function returns the value of an attribute from a resource in the template.
    /// 
    /// Example: This example snippet returns a string containing the DNS name of the load balancer with the logical name myELB.
    /// 
    /// { "Fn::GetAtt" : [ "myELB" , "DNSName" ] }
    /// 
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-getatt.html
    /// </summary>
    public class FnGetAtt
    {
        public string LogicalNameOfResource { get; }
        public string AttributeName { get; }

        public FnGetAtt(string logicalNameOfResource, string attributeName)
        {
            LogicalNameOfResource = logicalNameOfResource ?? throw new ArgumentNullException(nameof(logicalNameOfResource));
            AttributeName = attributeName ?? throw new ArgumentNullException(nameof(attributeName));
        }
    }

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-ref.html
    ///  </summary>
    public class FnRef
    {
        public string Reference { get; }
        public FnRef(string reference) => Reference = reference ?? throw new ArgumentNullException(nameof(Reference));
    }

    /// <summary>
    /// 
    /// TODO: Example
    /// 
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-join.html
    /// </summary>
    public class FnJoin
    {
        public string Seperator { get; }
        public dynamic[] Parameters { get; }

        public FnJoin(string seperator, dynamic[] parameters)
        {
            Seperator = seperator ?? throw new ArgumentNullException(nameof(seperator));
            Parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
        }
    }

    /// <summary>
    /// The intrinsic function Fn::Sub substitutes variables in an input string with values that you specify. 
    /// In your templates, you can use this function to construct commands or outputs that include values that aren't 
    /// available until you create or update a stack.
    /// 
    /// TODO: Example
    /// 
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-sub.html
    /// </summary>
    public class FnSub
    {
        public string String { get; }
        public Dictionary<string, dynamic> Variables { get; }

        public FnSub(string input, Dictionary<string, dynamic> variables = null)
        {
            String = input ?? throw new ArgumentNullException(nameof(input));
            Variables = variables;
        }
    }

    /// <summary>
    /// TODO: Example
    /// </summary>
    public class FnImportValue
    {
        public dynamic SharedValueToImport { get; }

        public FnImportValue(dynamic sharedValueToImport)
        {
            SharedValueToImport = sharedValueToImport ?? throw new ArgumentNullException(nameof(sharedValueToImport));
        }
    }
}
