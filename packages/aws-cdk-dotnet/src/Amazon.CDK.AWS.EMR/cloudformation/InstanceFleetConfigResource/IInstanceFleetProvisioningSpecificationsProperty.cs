using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.EMR.cloudformation.InstanceFleetConfigResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancefleetprovisioningspecifications.html </remarks>
    [JsiiInterface(typeof(IInstanceFleetProvisioningSpecificationsProperty), "@aws-cdk/aws-emr.cloudformation.InstanceFleetConfigResource.InstanceFleetProvisioningSpecificationsProperty")]
    public interface IInstanceFleetProvisioningSpecificationsProperty
    {
        /// <summary>``InstanceFleetConfigResource.InstanceFleetProvisioningSpecificationsProperty.SpotSpecification``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancefleetprovisioningspecifications.html#cfn-elasticmapreduce-instancefleetconfig-instancefleetprovisioningspecifications-spotspecification </remarks>
        [JsiiProperty("spotSpecification", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-emr.cloudformation.InstanceFleetConfigResource.SpotProvisioningSpecificationProperty\"}]}}")]
        object SpotSpecification
        {
            get;
            set;
        }
    }
}