using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.KinesisAnalytics.cloudformation.ApplicationReferenceDataSourceResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-jsonmappingparameters.html </remarks>
    [JsiiInterface(typeof(IJSONMappingParametersProperty), "@aws-cdk/aws-kinesisanalytics.cloudformation.ApplicationReferenceDataSourceResource.JSONMappingParametersProperty")]
    public interface IJSONMappingParametersProperty
    {
        /// <summary>``ApplicationReferenceDataSourceResource.JSONMappingParametersProperty.RecordRowPath``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-jsonmappingparameters.html#cfn-kinesisanalytics-applicationreferencedatasource-jsonmappingparameters-recordrowpath </remarks>
        [JsiiProperty("recordRowPath", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object RecordRowPath
        {
            get;
            set;
        }
    }
}