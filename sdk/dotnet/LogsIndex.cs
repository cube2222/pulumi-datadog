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
    /// ## Important Notes
    /// 
    /// The order of indexes is maintained in the separated resource datadog_logs_index_order. 
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/logs_index.html.markdown.
    /// </summary>
    public partial class LogsIndex : Pulumi.CustomResource
    {
        /// <summary>
        /// List of exclusion filters.
        /// </summary>
        [Output("exclusionFilters")]
        public Output<ImmutableArray<Outputs.LogsIndexExclusionFilters>> ExclusionFilters { get; private set; } = null!;

        [Output("filters")]
        public Output<ImmutableArray<Outputs.LogsIndexFilters>> Filters { get; private set; } = null!;

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
            : base("datadog:index/logsIndex:LogsIndex", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
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
        private InputList<Inputs.LogsIndexExclusionFiltersArgs>? _exclusionFilters;

        /// <summary>
        /// List of exclusion filters.
        /// </summary>
        public InputList<Inputs.LogsIndexExclusionFiltersArgs> ExclusionFilters
        {
            get => _exclusionFilters ?? (_exclusionFilters = new InputList<Inputs.LogsIndexExclusionFiltersArgs>());
            set => _exclusionFilters = value;
        }

        [Input("filters", required: true)]
        private InputList<Inputs.LogsIndexFiltersArgs>? _filters;
        public InputList<Inputs.LogsIndexFiltersArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.LogsIndexFiltersArgs>());
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
        private InputList<Inputs.LogsIndexExclusionFiltersGetArgs>? _exclusionFilters;

        /// <summary>
        /// List of exclusion filters.
        /// </summary>
        public InputList<Inputs.LogsIndexExclusionFiltersGetArgs> ExclusionFilters
        {
            get => _exclusionFilters ?? (_exclusionFilters = new InputList<Inputs.LogsIndexExclusionFiltersGetArgs>());
            set => _exclusionFilters = value;
        }

        [Input("filters")]
        private InputList<Inputs.LogsIndexFiltersGetArgs>? _filters;
        public InputList<Inputs.LogsIndexFiltersGetArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.LogsIndexFiltersGetArgs>());
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

    namespace Inputs
    {

    public sealed class LogsIndexExclusionFiltersArgs : Pulumi.ResourceArgs
    {
        [Input("filters")]
        private InputList<LogsIndexExclusionFiltersFiltersArgs>? _filters;
        public InputList<LogsIndexExclusionFiltersFiltersArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<LogsIndexExclusionFiltersFiltersArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// A boolean stating if the exclusion is active or not.
        /// </summary>
        [Input("isEnabled")]
        public Input<bool>? IsEnabled { get; set; }

        /// <summary>
        /// The name of the exclusion filter.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public LogsIndexExclusionFiltersArgs()
        {
        }
    }

    public sealed class LogsIndexExclusionFiltersFiltersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Only logs matching the filter criteria and the query of the parent index will be considered for this exclusion filter.
        /// </summary>
        [Input("query")]
        public Input<string>? Query { get; set; }

        /// <summary>
        /// The fraction of logs excluded by the exclusion filter, when active.
        /// </summary>
        [Input("sampleRate")]
        public Input<double>? SampleRate { get; set; }

        public LogsIndexExclusionFiltersFiltersArgs()
        {
        }
    }

    public sealed class LogsIndexExclusionFiltersFiltersGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Only logs matching the filter criteria and the query of the parent index will be considered for this exclusion filter.
        /// </summary>
        [Input("query")]
        public Input<string>? Query { get; set; }

        /// <summary>
        /// The fraction of logs excluded by the exclusion filter, when active.
        /// </summary>
        [Input("sampleRate")]
        public Input<double>? SampleRate { get; set; }

        public LogsIndexExclusionFiltersFiltersGetArgs()
        {
        }
    }

    public sealed class LogsIndexExclusionFiltersGetArgs : Pulumi.ResourceArgs
    {
        [Input("filters")]
        private InputList<LogsIndexExclusionFiltersFiltersGetArgs>? _filters;
        public InputList<LogsIndexExclusionFiltersFiltersGetArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<LogsIndexExclusionFiltersFiltersGetArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// A boolean stating if the exclusion is active or not.
        /// </summary>
        [Input("isEnabled")]
        public Input<bool>? IsEnabled { get; set; }

        /// <summary>
        /// The name of the exclusion filter.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public LogsIndexExclusionFiltersGetArgs()
        {
        }
    }

    public sealed class LogsIndexFiltersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Only logs matching the filter criteria and the query of the parent index will be considered for this exclusion filter.
        /// </summary>
        [Input("query", required: true)]
        public Input<string> Query { get; set; } = null!;

        public LogsIndexFiltersArgs()
        {
        }
    }

    public sealed class LogsIndexFiltersGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Only logs matching the filter criteria and the query of the parent index will be considered for this exclusion filter.
        /// </summary>
        [Input("query", required: true)]
        public Input<string> Query { get; set; } = null!;

        public LogsIndexFiltersGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class LogsIndexExclusionFilters
    {
        public readonly ImmutableArray<LogsIndexExclusionFiltersFilters> Filters;
        /// <summary>
        /// A boolean stating if the exclusion is active or not.
        /// </summary>
        public readonly bool? IsEnabled;
        /// <summary>
        /// The name of the exclusion filter.
        /// </summary>
        public readonly string? Name;

        [OutputConstructor]
        private LogsIndexExclusionFilters(
            ImmutableArray<LogsIndexExclusionFiltersFilters> filters,
            bool? isEnabled,
            string? name)
        {
            Filters = filters;
            IsEnabled = isEnabled;
            Name = name;
        }
    }

    [OutputType]
    public sealed class LogsIndexExclusionFiltersFilters
    {
        /// <summary>
        /// Only logs matching the filter criteria and the query of the parent index will be considered for this exclusion filter.
        /// </summary>
        public readonly string? Query;
        /// <summary>
        /// The fraction of logs excluded by the exclusion filter, when active.
        /// </summary>
        public readonly double? SampleRate;

        [OutputConstructor]
        private LogsIndexExclusionFiltersFilters(
            string? query,
            double? sampleRate)
        {
            Query = query;
            SampleRate = sampleRate;
        }
    }

    [OutputType]
    public sealed class LogsIndexFilters
    {
        /// <summary>
        /// Only logs matching the filter criteria and the query of the parent index will be considered for this exclusion filter.
        /// </summary>
        public readonly string Query;

        [OutputConstructor]
        private LogsIndexFilters(string query)
        {
            Query = query;
        }
    }
    }
}
