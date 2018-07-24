using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace Amazon.CDK.AWS.APIGateway.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationpart.html </remarks>
    [JsiiClass(typeof(DocumentationPartResource_), "@aws-cdk/aws-apigateway.cloudformation.DocumentationPartResource", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"@aws-cdk/cdk.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"properties\",\"type\":{\"fqn\":\"@aws-cdk/aws-apigateway.cloudformation.DocumentationPartResourceProps\"}}]")]
    public class DocumentationPartResource_ : Amazon.CDK.Resource
    {
        public DocumentationPartResource_(Construct parent, string name, IDocumentationPartResourceProps properties): base(new DeputyProps(new object[]{parent, name, properties}))
        {
        }

        protected DocumentationPartResource_(ByRefValue reference): base(reference)
        {
        }

        protected DocumentationPartResource_(DeputyProps props): base(props)
        {
        }

        /// <summary>The CloudFormation resource type name for this resource class.</summary>
        [JsiiProperty("resourceTypeName", "{\"primitive\":\"string\"}")]
        public static string ResourceTypeName
        {
            get;
        }

        = GetStaticProperty<string>(typeof(DocumentationPartResource_));
        [JsiiMethod("renderProperties", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}}}", "[]")]
        protected override IDictionary<string, object> RenderProperties()
        {
            return InvokeInstanceMethod<IDictionary<string, object>>(new object[]{});
        }
    }
}