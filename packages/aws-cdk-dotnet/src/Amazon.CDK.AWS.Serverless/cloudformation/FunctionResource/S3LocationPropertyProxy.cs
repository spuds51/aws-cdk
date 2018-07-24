using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.Serverless.cloudformation.FunctionResource
{
    /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#s3-location-object </remarks>
    [JsiiInterfaceProxy(typeof(IS3LocationProperty), "@aws-cdk/aws-serverless.cloudformation.FunctionResource.S3LocationProperty")]
    internal class S3LocationPropertyProxy : DeputyBase, Amazon.CDK.AWS.Serverless.cloudformation.FunctionResource.IS3LocationProperty
    {
        private S3LocationPropertyProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>``FunctionResource.S3LocationProperty.Bucket``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
        [JsiiProperty("bucket", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        public virtual object Bucket
        {
            get => GetInstanceProperty<object>();
            set => SetInstanceProperty(value);
        }

        /// <summary>``FunctionResource.S3LocationProperty.Key``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
        [JsiiProperty("key", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        public virtual object Key
        {
            get => GetInstanceProperty<object>();
            set => SetInstanceProperty(value);
        }

        /// <summary>``FunctionResource.S3LocationProperty.Version``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
        [JsiiProperty("version", "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        public virtual object Version
        {
            get => GetInstanceProperty<object>();
            set => SetInstanceProperty(value);
        }
    }
}