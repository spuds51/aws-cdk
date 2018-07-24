using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.EMR.cloudformation.ClusterResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingtrigger.html </remarks>
    [JsiiInterface(typeof(IScalingTriggerProperty), "@aws-cdk/aws-emr.cloudformation.ClusterResource.ScalingTriggerProperty")]
    public interface IScalingTriggerProperty
    {
        /// <summary>``ClusterResource.ScalingTriggerProperty.CloudWatchAlarmDefinition``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingtrigger.html#cfn-elasticmapreduce-cluster-scalingtrigger-cloudwatchalarmdefinition </remarks>
        [JsiiProperty("cloudWatchAlarmDefinition", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-emr.cloudformation.ClusterResource.CloudWatchAlarmDefinitionProperty\"}]}}")]
        object CloudWatchAlarmDefinition
        {
            get;
            set;
        }
    }
}