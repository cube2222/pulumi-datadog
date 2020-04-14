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
    /// Provides a Datadog [Logs Index API](https://docs.datadoghq.com/api/?lang=python#logs-indexes) resource. This can be used to create and manage Datadog logs indexes.
    /// 
    /// 
    /// ## Important Notes
    /// 
    /// The order of indexes is maintained in the separated resource datadog_logs_index_order. 
    /// </summary>
    public partial class LogsIndex : Pulumi.CustomResource
    {
        /// <summary>
        /// List of exclusion filters.
        /// </summary>
        [Output("exclusionFilters")]
        public Output<ImmutableArray<Outputs.LogsIndexExclusionFilter>> ExclusionFilters { get; private set; } = null!;

        [Output("filters")]
        public Output<ImmutableArray<Outputs.LogsIndexFilter>> Filters { get; private set; } = null!;

        /// <summary>
        /// The name of the exclusion filter.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;


        /// <summary>
        /// Create a LogsIndex resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LogsIndex(string name, LogsIndexArgs args, CustomResourceOptions? options = null)
            : base("datadog:index/logsIndex:LogsIndex", name, args ?? new LogsIndexArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LogsIndex(string name, Input<string> id, LogsIndexState? state = null, CustomResourceOptions? options = null)
            : base("datadog:index/logsIndex:LogsIndex", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing LogsIndex resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LogsIndex Get(string name, Input<string> id, LogsIndexState? state = null, CustomResourceOptions? options = null)
        {
            return new LogsIndex(name, id, state, options);
        }
    }

    public sealed class LogsIndexArgs : Pulumi.ResourceArgs
    {
        [Input("exclusionFilters")]
        private InputList<Inputs.LogsIndexExclusionFilterArgs>? _exclusionFilters;

        /// <summary>
        /// List of exclusion filters.
        /// </summary>
        public InputList<Inputs.LogsIndexExclusionFilterArgs> ExclusionFilters
        {
            get => _exclusionFilters ?? (_exclusionFilters = new InputList<Inputs.LogsIndexExclusionFilterArgs>());
            set => _exclusionFilters = value;
        }

        [Input("filters", required: true)]
        private InputList<Inputs.LogsIndexFilterArgs>? _filters;
        public InputList<Inputs.LogsIndexFilterArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.LogsIndexFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// The name of the exclusion filter.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public LogsIndexArgs()
        {
        }
    }

    public sealed class LogsIndexState : Pulumi.ResourceArgs
    {
        [Input("exclusionFilters")]
        private InputList<Inputs.LogsIndexExclusionFilterGetArgs>? _exclusionFilters;

        /// <summary>
        /// List of exclusion filters.
        /// </summary>
        public InputList<Inputs.LogsIndexExclusionFilterGetArgs> ExclusionFilters
        {
            get => _exclusionFilters ?? (_exclusionFilters = new InputList<Inputs.LogsIndexExclusionFilterGetArgs>());
            set => _exclusionFilters = value;
        }

        [Input("filters")]
        private InputList<Inputs.LogsIndexFilterGetArgs>? _filters;
        public InputList<Inputs.LogsIndexFilterGetArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.LogsIndexFilterGetArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// The name of the exclusion filter.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public LogsIndexState()
        {
        }
    }
}
