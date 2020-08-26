// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetAlertValueDefinitionGetArgs : Pulumi.ResourceArgs
    {
        [Input("alertId", required: true)]
        public Input<string> AlertId { get; set; } = null!;

        /// <summary>
        /// The precision to use when displaying the tile.
        /// </summary>
        [Input("precision")]
        public Input<int>? Precision { get; set; }

        /// <summary>
        /// The alignment of the text in the widget.
        /// - `heatmap_definition`: The definition for a Heatmap widget. Exactly one nested block is allowed with the following structure:
        /// - `request`: (Required) Nested block describing the request to use when displaying the widget. Multiple request blocks are allowed with the following structure:
        /// - `q`: (Required) The metric query to use in the widget.
        /// - `title`: (Optional) The title of the widget.
        /// - `title_size`: (Optional) The size of the widget's title. Default is 16.
        /// - `title_align`: (Optional) The alignment of the widget's title. One of "left", "center", or "right".
        /// - `time`: (Optional) Nested block describing the timeframe to use when displaying the widget. The structure of this block is described below.
        /// - `query_table_definition`: The definition for a Query Table widget. Exactly one nested block is allowed with the following structure:
        /// - `request`: (Required) Nested block describing the request to use when displaying the widget. Multiple request blocks are allowed with the following structure (exactly only one of `q`, `apm_query`, `log_query` or `process_query` is required within the request block):
        /// - `q`: (Optional) The metric query to use in the widget
        /// - `apm_query`: (Optional) The APM query to use in the widget. The structure of this block is described below.
        /// - `log_query`: (Optional) The log query to use in the widget. The structure of this block is described below.
        /// - `process_query`: (Optional) The process query to use in the widget. The structure of this block is described below.
        /// </summary>
        [Input("textAlign")]
        public Input<string>? TextAlign { get; set; }

        /// <summary>
        /// Title of the dashboard.
        /// </summary>
        [Input("title")]
        public Input<string>? Title { get; set; }

        [Input("titleAlign")]
        public Input<string>? TitleAlign { get; set; }

        [Input("titleSize")]
        public Input<string>? TitleSize { get; set; }

        [Input("unit")]
        public Input<string>? Unit { get; set; }

        public DashboardWidgetAlertValueDefinitionGetArgs()
        {
        }
    }
}
