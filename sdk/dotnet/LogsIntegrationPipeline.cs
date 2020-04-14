// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog
{
    /// <summary>
    /// Provides a Datadog [Logs Pipeline API](https://docs.datadoghq.com/api/?lang=python#logs-pipelines) resource to manage
    /// the [integrations](https://docs.datadoghq.com/logs/log_collection/?tab=tcpussite).
    /// 
    /// Integration pipelines are the pipelines that are automatically installed for your organization when sending the logs with 
    /// specific sources. You don't need to maintain or update these types of pipelines. Keeping them as resources, however, 
    /// allows you to manage the order of your pipelines by referencing them in your 
    /// datadog..LogsPipelineOrder resource. If you don't need the
    /// `pipeline_order` feature, this resource declaration can be omitted.
    /// </summary>
    public partial class LogsIntegrationPipeline : Pulumi.CustomResource
    {
        /// <summary>
        /// Boolean value to enable your pipeline.
        /// </summary>
        [Output("isEnabled")]
        public Output<bool?> IsEnabled { get; private set; } = null!;


        /// <summary>
        /// Create a LogsIntegrationPipeline resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LogsIntegrationPipeline(string name, LogsIntegrationPipelineArgs? args = null, CustomResourceOptions? options = null)
            : base("datadog:index/logsIntegrationPipeline:LogsIntegrationPipeline", name, args ?? new LogsIntegrationPipelineArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LogsIntegrationPipeline(string name, Input<string> id, LogsIntegrationPipelineState? state = null, CustomResourceOptions? options = null)
            : base("datadog:index/logsIntegrationPipeline:LogsIntegrationPipeline", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing LogsIntegrationPipeline resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LogsIntegrationPipeline Get(string name, Input<string> id, LogsIntegrationPipelineState? state = null, CustomResourceOptions? options = null)
        {
            return new LogsIntegrationPipeline(name, id, state, options);
        }
    }

    public sealed class LogsIntegrationPipelineArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Boolean value to enable your pipeline.
        /// </summary>
        [Input("isEnabled")]
        public Input<bool>? IsEnabled { get; set; }

        public LogsIntegrationPipelineArgs()
        {
        }
    }

    public sealed class LogsIntegrationPipelineState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Boolean value to enable your pipeline.
        /// </summary>
        [Input("isEnabled")]
        public Input<bool>? IsEnabled { get; set; }

        public LogsIntegrationPipelineState()
        {
        }
    }
}
