using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.WAFRegional.cloudformation.XssMatchSetResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-fieldtomatch.html </remarks>
    [JsiiInterface(typeof(IFieldToMatchProperty), "@aws-cdk/aws-wafregional.cloudformation.XssMatchSetResource.FieldToMatchProperty")]
    public interface IFieldToMatchProperty
    {
        /// <summary>``XssMatchSetResource.FieldToMatchProperty.Data``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-fieldtomatch.html#cfn-wafregional-xssmatchset-fieldtomatch-data </remarks>
        [JsiiProperty("data", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object Data
        {
            get;
            set;
        }

        /// <summary>``XssMatchSetResource.FieldToMatchProperty.Type``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-fieldtomatch.html#cfn-wafregional-xssmatchset-fieldtomatch-type </remarks>
        [JsiiProperty("type", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object Type
        {
            get;
            set;
        }
    }
}