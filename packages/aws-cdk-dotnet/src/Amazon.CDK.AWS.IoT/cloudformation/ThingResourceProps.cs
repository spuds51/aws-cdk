using Amazon.CDK;
using Amazon.CDK.AWS.IoT.cloudformation.ThingResource;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.IoT.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thing.html </remarks>
    public class ThingResourceProps : DeputyBase, IThingResourceProps
    {
        /// <summary>``AWS::IoT::Thing.AttributePayload``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thing.html#cfn-iot-thing-attributepayload </remarks>
        [JsiiProperty("attributePayload", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-iot.cloudformation.ThingResource.AttributePayloadProperty\"}]},\"optional\":true}", true)]
        public object AttributePayload
        {
            get;
            set;
        }

        /// <summary>``AWS::IoT::Thing.ThingName``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thing.html#cfn-iot-thing-thingname </remarks>
        [JsiiProperty("thingName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object ThingName
        {
            get;
            set;
        }
    }
}