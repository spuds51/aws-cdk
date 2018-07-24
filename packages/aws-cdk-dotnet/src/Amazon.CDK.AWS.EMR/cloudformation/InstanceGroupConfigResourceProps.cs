using Amazon.CDK;
using Amazon.CDK.AWS.EMR.cloudformation.InstanceGroupConfigResource;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.EMR.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html </remarks>
    public class InstanceGroupConfigResourceProps : DeputyBase, IInstanceGroupConfigResourceProps
    {
        /// <summary>``AWS::EMR::InstanceGroupConfig.InstanceCount``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfiginstancecount- </remarks>
        [JsiiProperty("instanceCount", "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object InstanceCount
        {
            get;
            set;
        }

        /// <summary>``AWS::EMR::InstanceGroupConfig.InstanceRole``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-instancerole </remarks>
        [JsiiProperty("instanceRole", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object InstanceRole
        {
            get;
            set;
        }

        /// <summary>``AWS::EMR::InstanceGroupConfig.InstanceType``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-instancetype </remarks>
        [JsiiProperty("instanceType", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object InstanceType
        {
            get;
            set;
        }

        /// <summary>``AWS::EMR::InstanceGroupConfig.JobFlowId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-jobflowid </remarks>
        [JsiiProperty("jobFlowId", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object JobFlowId
        {
            get;
            set;
        }

        /// <summary>``AWS::EMR::InstanceGroupConfig.AutoScalingPolicy``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-elasticmapreduce-instancegroupconfig-autoscalingpolicy </remarks>
        [JsiiProperty("autoScalingPolicy", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-emr.cloudformation.InstanceGroupConfigResource.AutoScalingPolicyProperty\"}]},\"optional\":true}", true)]
        public object AutoScalingPolicy
        {
            get;
            set;
        }

        /// <summary>``AWS::EMR::InstanceGroupConfig.BidPrice``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-bidprice </remarks>
        [JsiiProperty("bidPrice", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object BidPrice
        {
            get;
            set;
        }

        /// <summary>``AWS::EMR::InstanceGroupConfig.Configurations``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-configurations </remarks>
        [JsiiProperty("configurations", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-emr.cloudformation.InstanceGroupConfigResource.ConfigurationProperty\"}]}}}}]},\"optional\":true}", true)]
        public object Configurations
        {
            get;
            set;
        }

        /// <summary>``AWS::EMR::InstanceGroupConfig.EbsConfiguration``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-ebsconfiguration </remarks>
        [JsiiProperty("ebsConfiguration", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-emr.cloudformation.InstanceGroupConfigResource.EbsConfigurationProperty\"}]},\"optional\":true}", true)]
        public object EbsConfiguration
        {
            get;
            set;
        }

        /// <summary>``AWS::EMR::InstanceGroupConfig.Market``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-market </remarks>
        [JsiiProperty("market", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object Market
        {
            get;
            set;
        }

        /// <summary>``AWS::EMR::InstanceGroupConfig.Name``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-name </remarks>
        [JsiiProperty("instanceGroupConfigName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object InstanceGroupConfigName
        {
            get;
            set;
        }
    }
}