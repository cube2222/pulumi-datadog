// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Outputs
{

    [OutputType]
    public sealed class DashboardWidgetAlertValueDefinition
    {
        public readonly string AlertId;
        /// <summary>
        /// The precision to use when displaying the tile.
        /// </summary>
        public readonly int? Precision;
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
        public readonly string? TextAlign;
        /// <summary>
        /// Title of the dashboard.
        /// </summary>
        public readonly string? Title;
        public readonly string? TitleAlign;
        public readonly string? TitleSize;
        public readonly string? Unit;

        [OutputConstructor]
        private DashboardWidgetAlertValueDefinition(
            string alertId,

            int? precision,

            string? textAlign,

            string? title,

            string? titleAlign,

            string? titleSize,

            string? unit)
        {
            AlertId = alertId;
            Precision = precision;
            TextAlign = textAlign;
            Title = title;
            TitleAlign = titleAlign;
            TitleSize = titleSize;
            Unit = unit;
        }
    }
}
