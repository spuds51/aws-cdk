using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.S3.cloudformation.BucketResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html </remarks>
    public class InventoryConfigurationProperty : DeputyBase, IInventoryConfigurationProperty
    {
        /// <summary>``BucketResource.InventoryConfigurationProperty.Destination``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-destination </remarks>
        [JsiiProperty("destination", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-s3.cloudformation.BucketResource.DestinationProperty\"}]}}", true)]
        public object Destination
        {
            get;
            set;
        }

        /// <summary>``BucketResource.InventoryConfigurationProperty.Enabled``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-enabled </remarks>
        [JsiiProperty("enabled", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object Enabled
        {
            get;
            set;
        }

        /// <summary>``BucketResource.InventoryConfigurationProperty.Id``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-id </remarks>
        [JsiiProperty("id", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object Id
        {
            get;
            set;
        }

        /// <summary>``BucketResource.InventoryConfigurationProperty.IncludedObjectVersions``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-includedobjectversions </remarks>
        [JsiiProperty("includedObjectVersions", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object IncludedObjectVersions
        {
            get;
            set;
        }

        /// <summary>``BucketResource.InventoryConfigurationProperty.OptionalFields``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-optionalfields </remarks>
        [JsiiProperty("optionalFields", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}}}]},\"optional\":true}", true)]
        public object OptionalFields
        {
            get;
            set;
        }

        /// <summary>``BucketResource.InventoryConfigurationProperty.Prefix``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-prefix </remarks>
        [JsiiProperty("prefix", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object Prefix
        {
            get;
            set;
        }

        /// <summary>``BucketResource.InventoryConfigurationProperty.ScheduleFrequency``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-schedulefrequency </remarks>
        [JsiiProperty("scheduleFrequency", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object ScheduleFrequency
        {
            get;
            set;
        }
    }
}