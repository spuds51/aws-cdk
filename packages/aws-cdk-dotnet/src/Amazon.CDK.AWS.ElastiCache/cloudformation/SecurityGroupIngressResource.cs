using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace Amazon.CDK.AWS.ElastiCache.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group-ingress.html </remarks>
    [JsiiClass(typeof(SecurityGroupIngressResource), "@aws-cdk/aws-elasticache.cloudformation.SecurityGroupIngressResource", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"@aws-cdk/cdk.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"properties\",\"type\":{\"fqn\":\"@aws-cdk/aws-elasticache.cloudformation.SecurityGroupIngressResourceProps\"}}]")]
    public class SecurityGroupIngressResource : Resource
    {
        public SecurityGroupIngressResource(Construct parent, string name, ISecurityGroupIngressResourceProps properties): base(new DeputyProps(new object[]{parent, name, properties}))
        {
        }

        protected SecurityGroupIngressResource(ByRefValue reference): base(reference)
        {
        }

        protected SecurityGroupIngressResource(DeputyProps props): base(props)
        {
        }

        /// <summary>The CloudFormation resource type name for this resource class.</summary>
        [JsiiProperty("resourceTypeName", "{\"primitive\":\"string\"}")]
        public static string ResourceTypeName
        {
            get;
        }

        = GetStaticProperty<string>(typeof(SecurityGroupIngressResource));
        [JsiiMethod("renderProperties", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}}}", "[]")]
        protected override IDictionary<string, object> RenderProperties()
        {
            return InvokeInstanceMethod<IDictionary<string, object>>(new object[]{});
        }
    }
}