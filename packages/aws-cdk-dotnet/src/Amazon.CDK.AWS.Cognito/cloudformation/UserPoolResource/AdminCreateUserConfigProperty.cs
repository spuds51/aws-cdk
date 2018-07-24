using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.Cognito.cloudformation.UserPoolResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-admincreateuserconfig.html </remarks>
    public class AdminCreateUserConfigProperty : DeputyBase, IAdminCreateUserConfigProperty
    {
        /// <summary>``UserPoolResource.AdminCreateUserConfigProperty.AllowAdminCreateUserOnly``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-admincreateuserconfig.html#cfn-cognito-userpool-admincreateuserconfig-allowadmincreateuseronly </remarks>
        [JsiiProperty("allowAdminCreateUserOnly", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object AllowAdminCreateUserOnly
        {
            get;
            set;
        }

        /// <summary>``UserPoolResource.AdminCreateUserConfigProperty.InviteMessageTemplate``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-admincreateuserconfig.html#cfn-cognito-userpool-admincreateuserconfig-invitemessagetemplate </remarks>
        [JsiiProperty("inviteMessageTemplate", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-cognito.cloudformation.UserPoolResource.InviteMessageTemplateProperty\"}]},\"optional\":true}", true)]
        public object InviteMessageTemplate
        {
            get;
            set;
        }

        /// <summary>``UserPoolResource.AdminCreateUserConfigProperty.UnusedAccountValidityDays``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-admincreateuserconfig.html#cfn-cognito-userpool-admincreateuserconfig-unusedaccountvaliditydays </remarks>
        [JsiiProperty("unusedAccountValidityDays", "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object UnusedAccountValidityDays
        {
            get;
            set;
        }
    }
}