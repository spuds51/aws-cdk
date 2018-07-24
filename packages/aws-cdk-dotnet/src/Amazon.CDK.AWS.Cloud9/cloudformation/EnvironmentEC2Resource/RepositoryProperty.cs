using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.Cloud9.cloudformation.EnvironmentEC2Resource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloud9-environmentec2-repository.html </remarks>
    public class RepositoryProperty : DeputyBase, IRepositoryProperty
    {
        /// <summary>``EnvironmentEC2Resource.RepositoryProperty.PathComponent``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloud9-environmentec2-repository.html#cfn-cloud9-environmentec2-repository-pathcomponent </remarks>
        [JsiiProperty("pathComponent", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object PathComponent
        {
            get;
            set;
        }

        /// <summary>``EnvironmentEC2Resource.RepositoryProperty.RepositoryUrl``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloud9-environmentec2-repository.html#cfn-cloud9-environmentec2-repository-repositoryurl </remarks>
        [JsiiProperty("repositoryUrl", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object RepositoryUrl
        {
            get;
            set;
        }
    }
}