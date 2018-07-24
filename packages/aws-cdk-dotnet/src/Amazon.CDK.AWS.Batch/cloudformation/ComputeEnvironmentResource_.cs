using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace Amazon.CDK.AWS.Batch.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html </remarks>
    [JsiiClass(typeof(ComputeEnvironmentResource_), "@aws-cdk/aws-batch.cloudformation.ComputeEnvironmentResource", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"@aws-cdk/cdk.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"properties\",\"type\":{\"fqn\":\"@aws-cdk/aws-batch.cloudformation.ComputeEnvironmentResourceProps\"}}]")]
    public class ComputeEnvironmentResource_ : Resource
    {
        public ComputeEnvironmentResource_(Construct parent, string name, IComputeEnvironmentResourceProps properties): base(new DeputyProps(new object[]{parent, name, properties}))
        {
        }

        protected ComputeEnvironmentResource_(ByRefValue reference): base(reference)
        {
        }

        protected ComputeEnvironmentResource_(DeputyProps props): base(props)
        {
        }

        /// <summary>The CloudFormation resource type name for this resource class.</summary>
        [JsiiProperty("resourceTypeName", "{\"primitive\":\"string\"}")]
        public static string ResourceTypeName
        {
            get;
        }

        = GetStaticProperty<string>(typeof(ComputeEnvironmentResource_));
        [JsiiMethod("renderProperties", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}}}", "[]")]
        protected override IDictionary<string, object> RenderProperties()
        {
            return InvokeInstanceMethod<IDictionary<string, object>>(new object[]{});
        }
    }
}