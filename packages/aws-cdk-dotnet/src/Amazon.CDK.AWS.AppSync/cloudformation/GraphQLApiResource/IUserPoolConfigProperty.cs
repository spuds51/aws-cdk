using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.AppSync.cloudformation.GraphQLApiResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-userpoolconfig.html </remarks>
    [JsiiInterface(typeof(IUserPoolConfigProperty), "@aws-cdk/aws-appsync.cloudformation.GraphQLApiResource.UserPoolConfigProperty")]
    public interface IUserPoolConfigProperty
    {
        /// <summary>``GraphQLApiResource.UserPoolConfigProperty.AppIdClientRegex``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-userpoolconfig.html#cfn-appsync-graphqlapi-userpoolconfig-appidclientregex </remarks>
        [JsiiProperty("appIdClientRegex", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object AppIdClientRegex
        {
            get;
            set;
        }

        /// <summary>``GraphQLApiResource.UserPoolConfigProperty.AwsRegion``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-userpoolconfig.html#cfn-appsync-graphqlapi-userpoolconfig-awsregion </remarks>
        [JsiiProperty("awsRegion", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object AwsRegion
        {
            get;
            set;
        }

        /// <summary>``GraphQLApiResource.UserPoolConfigProperty.DefaultAction``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-userpoolconfig.html#cfn-appsync-graphqlapi-userpoolconfig-defaultaction </remarks>
        [JsiiProperty("defaultAction", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object DefaultAction
        {
            get;
            set;
        }

        /// <summary>``GraphQLApiResource.UserPoolConfigProperty.UserPoolId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-userpoolconfig.html#cfn-appsync-graphqlapi-userpoolconfig-userpoolid </remarks>
        [JsiiProperty("userPoolId", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object UserPoolId
        {
            get;
            set;
        }
    }
}