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
    public sealed class DashboardWidgetGroupDefinitionWidgetHeatmapDefinitionRequestLogQueryGroupBySort
    {
        public readonly string Aggregation;
        public readonly string? Facet;
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
        public readonly string Order;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetHeatmapDefinitionRequestLogQueryGroupBySort(
            string aggregation,

            string? facet,

            string order)
        {
            Aggregation = aggregation;
            Facet = facet;
            Order = order;
        }
    }
}
