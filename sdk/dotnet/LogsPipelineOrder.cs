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
    /// Provides a Datadog [Logs Pipeline API](https://docs.datadoghq.com/api/v1/logs-pipelines/) resource, which is used to manage Datadog log pipelines order.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Datadog = Pulumi.Datadog;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var samplePipelineOrder = new Datadog.LogsPipelineOrder("samplePipelineOrder", new Datadog.LogsPipelineOrderArgs
    ///         {
    ///             Name = "sample_pipeline_order",
    ///             Pipelines = 
    ///             {
    ///                 datadog_logs_custom_pipeline.Sample_pipeline.Id,
    ///                 datadog_logs_integration_pipeline.Python.Id,
    ///             },
    ///         }, new CustomResourceOptions
    ///         {
    ///             DependsOn = 
    ///             {
    ///                 "datadog_logs_custom_pipeline.sample_pipeline",
    ///                 "datadog_logs_integration_pipeline.python",
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class LogsPipelineOrder : Pulumi.CustomResource
    {
        /// <summary>
        /// The name attribute in the resource `datadog.LogsPipelineOrder` needs to be unique. It's recommended to use the same value as the resource `NAME`.
        /// No related field is available in  [Logs Pipeline API](https://docs.datadoghq.com/api/v1/logs-pipelines/#get-pipeline-orderr).
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The pipeline IDs list. The order of pipeline IDs in this attribute defines the overall pipeline order for logs.
        /// </summary>
        [Output("pipelines")]
        public Output<ImmutableArray<string>> Pipelines { get; private set; } = null!;


        /// <summary>
        /// Create a LogsPipelineOrder resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LogsPipelineOrder(string name, LogsPipelineOrderArgs args, CustomResourceOptions? options = null)
            : base("datadog:index/logsPipelineOrder:LogsPipelineOrder", name, args ?? new LogsPipelineOrderArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LogsPipelineOrder(string name, Input<string> id, LogsPipelineOrderState? state = null, CustomResourceOptions? options = null)
            : base("datadog:index/logsPipelineOrder:LogsPipelineOrder", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing LogsPipelineOrder resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LogsPipelineOrder Get(string name, Input<string> id, LogsPipelineOrderState? state = null, CustomResourceOptions? options = null)
        {
            return new LogsPipelineOrder(name, id, state, options);
        }
    }

    public sealed class LogsPipelineOrderArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name attribute in the resource `datadog.LogsPipelineOrder` needs to be unique. It's recommended to use the same value as the resource `NAME`.
        /// No related field is available in  [Logs Pipeline API](https://docs.datadoghq.com/api/v1/logs-pipelines/#get-pipeline-orderr).
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("pipelines", required: true)]
        private InputList<string>? _pipelines;

        /// <summary>
        /// The pipeline IDs list. The order of pipeline IDs in this attribute defines the overall pipeline order for logs.
        /// </summary>
        public InputList<string> Pipelines
        {
            get => _pipelines ?? (_pipelines = new InputList<string>());
            set => _pipelines = value;
        }

        public LogsPipelineOrderArgs()
        {
        }
    }

    public sealed class LogsPipelineOrderState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name attribute in the resource `datadog.LogsPipelineOrder` needs to be unique. It's recommended to use the same value as the resource `NAME`.
        /// No related field is available in  [Logs Pipeline API](https://docs.datadoghq.com/api/v1/logs-pipelines/#get-pipeline-orderr).
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("pipelines")]
        private InputList<string>? _pipelines;

        /// <summary>
        /// The pipeline IDs list. The order of pipeline IDs in this attribute defines the overall pipeline order for logs.
        /// </summary>
        public InputList<string> Pipelines
        {
            get => _pipelines ?? (_pipelines = new InputList<string>());
            set => _pipelines = value;
        }

        public LogsPipelineOrderState()
        {
        }
    }
}
