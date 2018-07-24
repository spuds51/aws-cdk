using Amazon.CDK;
using Amazon.CDK.AWS.APIGateway.cloudformation.DomainNameResource;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.APIGateway.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html </remarks>
    [JsiiInterface(typeof(IDomainNameResourceProps), "@aws-cdk/aws-apigateway.cloudformation.DomainNameResourceProps")]
    public interface IDomainNameResourceProps
    {
        /// <summary>``AWS::ApiGateway::DomainName.DomainName``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-domainname </remarks>
        [JsiiProperty("domainName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object DomainName
        {
            get;
            set;
        }

        /// <summary>``AWS::ApiGateway::DomainName.CertificateArn``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-certificatearn </remarks>
        [JsiiProperty("certificateArn", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object CertificateArn
        {
            get;
            set;
        }

        /// <summary>``AWS::ApiGateway::DomainName.EndpointConfiguration``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-endpointconfiguration </remarks>
        [JsiiProperty("endpointConfiguration", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-apigateway.cloudformation.DomainNameResource.EndpointConfigurationProperty\"}]},\"optional\":true}")]
        object EndpointConfiguration
        {
            get;
            set;
        }

        /// <summary>``AWS::ApiGateway::DomainName.RegionalCertificateArn``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-regionalcertificatearn </remarks>
        [JsiiProperty("regionalCertificateArn", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object RegionalCertificateArn
        {
            get;
            set;
        }
    }
}