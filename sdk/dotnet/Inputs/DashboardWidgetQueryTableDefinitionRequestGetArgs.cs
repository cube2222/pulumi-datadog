// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetQueryTableDefinitionRequestGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The aggregator to use for time aggregation. One of `avg`, `min`, `max`, `sum`, `last`.
        /// - `y`: (Optional) The query used for the Y-Axis. Exactly one nested block is allowed with the following structure:
        /// - `q`: (Required) The metric query to use in the widget.
        /// - `xaxis`: (Optional) Nested block describing the X-Axis Controls. The structure of this block is described below
        /// - `yaxis`: (Optional) Nested block describing the Y-Axis Controls. The structure of this block is described below
        /// </summary>
        [Input("aggregator")]
        public Input<string>? Aggregator { get; set; }

        /// <summary>
        /// The alias for the column name. Default is the metric name.
        /// </summary>
        [Input("alias")]
        public Input<string>? Alias { get; set; }

        [Input("apmQuery")]
        public Input<Inputs.DashboardWidgetQueryTableDefinitionRequestApmQueryGetArgs>? ApmQuery { get; set; }

        [Input("conditionalFormats")]
        private InputList<Inputs.DashboardWidgetQueryTableDefinitionRequestConditionalFormatGetArgs>? _conditionalFormats;

        /// <summary>
        /// Conditional formats allow you to set the color of your widget content or background, depending on a rule applied to your data. Multiple request blocks are allowed. The structure of this block is described below.
        /// - `title`: (Optional) The title of the widget.
        /// - `title_size`: (Optional) The size of the widget's title. Default is 16.
        /// - `title_align`: (Optional) The alignment of the widget's title. One of "left", "center", or "right".
        /// - `time`: (Optional) Nested block describing the timeframe to use when displaying the widget. The structure of this block is described below.
        /// - `trace_service_definition`: The definition for a Trace Service widget. Exactly one nested block is allowed with the following structure:
        /// - `env`: (Required) APM environment.
        /// - `service`: (Required) APM service.
        /// - `span_name`: (Required) APM span name.
        /// - `show_hits`: (Optional) APM span name.
        /// - `show_hits`: (Optional) Whether to show the hits metrics or not.
        /// - `show_errors`: (Optional) Whether to show the error metrics or not.
        /// - `show_latency`: (Optional) Whether to show the latency metrics or not.
        /// - `show_breakdown`: (Optional) Whether to show the latency breakdown or not.
        /// - `show_distribution`: (Optional) Whether to show the latency distribution or not.
        /// - `show_resource_list`: (Optional) Whether to show the resource list or not.
        /// - `size_format`: (Optional) Size of the widget. Available values are: `small`, `medium`, or `large`.
        /// - `display_format`: (Optional) Number of columns to display. Available values are: `one_column`, `two_column`, or `three_column`.
        /// - `title`: (Optional) The title of the widget.
        /// - `title_size`: (Optional) The size of the widget's title. Default is 16.
        /// - `title_align`: (Optional) The alignment of the widget's title. One of "left", "center", or "right".
        /// - `time`: (Optional) Nested block describing the timeframe to use when displaying the widget. The structure of this block is described below.
        /// </summary>
        public InputList<Inputs.DashboardWidgetQueryTableDefinitionRequestConditionalFormatGetArgs> ConditionalFormats
        {
            get => _conditionalFormats ?? (_conditionalFormats = new InputList<Inputs.DashboardWidgetQueryTableDefinitionRequestConditionalFormatGetArgs>());
            set => _conditionalFormats = value;
        }

        /// <summary>
        /// The number of lines to show in the table.
        /// </summary>
        [Input("limit")]
        public Input<int>? Limit { get; set; }

        [Input("logQuery")]
        public Input<Inputs.DashboardWidgetQueryTableDefinitionRequestLogQueryGetArgs>? LogQuery { get; set; }

        /// <summary>
        /// The sort order for the rows. One of `desc` or `asc`.
        /// - `title`: (Optional) The title of the widget.
        /// - `title_size`: (Optional) The size of the widget's title. Default is 16.
        /// - `title_align`: (Optional) The alignment of the widget's title. One of "left", "center", or "right".
        /// - `time`: (Optional) Nested block describing the timeframe to use when displaying the widget. The structure of this block is described below.
        /// - `scatterplot_definition`: The definition for a Scatterplot widget. Exactly one nested block is allowed with the following structure:
        /// - `request`: (Required) Nested block describing the request to use when displaying the widget. Exactly one request block is allowed with the following structure:
        /// - `x`: (Optional) The query used for the X-Axis. Exactly one nested block is allowed with the following structure:
        /// - `q`: (Required) The metric query to use in the widget.
        /// </summary>
        [Input("order")]
        public Input<string>? Order { get; set; }

        [Input("processQuery")]
        public Input<Inputs.DashboardWidgetQueryTableDefinitionRequestProcessQueryGetArgs>? ProcessQuery { get; set; }

        [Input("q")]
        public Input<string>? Q { get; set; }

        public DashboardWidgetQueryTableDefinitionRequestGetArgs()
        {
        }
    }
}
