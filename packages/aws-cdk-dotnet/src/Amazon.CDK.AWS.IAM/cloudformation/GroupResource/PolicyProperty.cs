using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;
using Newtonsoft.Json.Linq;

namespace Amazon.CDK.AWS.IAM.cloudformation.GroupResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-policy.html </remarks>
    public class PolicyProperty : DeputyBase, Amazon.CDK.AWS.IAM.cloudformation.GroupResource.IPolicyProperty
    {
        /// <summary>``GroupResource.PolicyProperty.PolicyDocument``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-policy.html#cfn-iam-policies-policydocument </remarks>
        [JsiiProperty("policyDocument", "{\"union\":{\"types\":[{\"primitive\":\"json\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object PolicyDocument
        {
            get;
            set;
        }

        /// <summary>``GroupResource.PolicyProperty.PolicyName``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-policy.html#cfn-iam-policies-policyname </remarks>
        [JsiiProperty("policyName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object PolicyName
        {
            get;
            set;
        }
    }
}