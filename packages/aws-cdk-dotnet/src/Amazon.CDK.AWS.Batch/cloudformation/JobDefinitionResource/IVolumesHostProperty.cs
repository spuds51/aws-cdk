using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.Batch.cloudformation.JobDefinitionResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-volumeshost.html </remarks>
    [JsiiInterface(typeof(IVolumesHostProperty), "@aws-cdk/aws-batch.cloudformation.JobDefinitionResource.VolumesHostProperty")]
    public interface IVolumesHostProperty
    {
        /// <summary>``JobDefinitionResource.VolumesHostProperty.SourcePath``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-volumeshost.html#cfn-batch-jobdefinition-volumeshost-sourcepath </remarks>
        [JsiiProperty("sourcePath", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object SourcePath
        {
            get;
            set;
        }
    }
}