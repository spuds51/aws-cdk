using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.IAM
{
    [JsiiInterface(typeof(IGroupProps), "@aws-cdk/aws-iam.GroupProps")]
    public interface IGroupProps
    {
        /// <summary>
        /// A name for the IAM group. For valid values, see the GroupName parameter
        /// for the CreateGroup action in the IAM API Reference. If you don't specify
        /// a name, AWS CloudFormation generates a unique physical ID and uses that
        /// ID for the group name.
        /// 
        /// If you specify a name, you must specify the CAPABILITY_NAMED_IAM value to
        /// acknowledge your template's capabilities. For more information, see
        /// Acknowledging IAM Resources in AWS CloudFormation Templates.
        /// </summary>
        /// <remarks>default: Generated by CloudFormation (recommended)</remarks>
        [JsiiProperty("groupName", "{\"primitive\":\"string\",\"optional\":true}")]
        string GroupName
        {
            get;
            set;
        }

        /// <summary>A list of ARNs for managed policies associated with group.</summary>
        /// <remarks>default: No managed policies.</remarks>
        [JsiiProperty("managedPolicyArns", "{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"primitive\":\"any\"}},\"optional\":true}")]
        object[] ManagedPolicyArns
        {
            get;
            set;
        }

        /// <summary>
        /// The path to the group. For more information about paths, see [IAM
        /// Identifiers](http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?Using_Identifiers.html)
        /// in the IAM User Guide.
        /// </summary>
        [JsiiProperty("path", "{\"primitive\":\"string\",\"optional\":true}")]
        string Path
        {
            get;
            set;
        }
    }
}