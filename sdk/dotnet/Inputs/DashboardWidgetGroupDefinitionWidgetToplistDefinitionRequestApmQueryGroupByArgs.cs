// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestApmQueryGroupByArgs : Pulumi.ResourceArgs
    {
        [Input("facet")]
        public Input<string>? Facet { get; set; }

        /// <summary>
        /// The number of lines to show in the table.
        /// </summary>
        [Input("limit")]
        public Input<int>? Limit { get; set; }

        /// <summary>
        /// The facet and order to sort the data based upon. Example: `"{"column": "time", "order": "desc"}"`.
        /// - `title`: (Optional) The title of the widget.
        /// - `title_size`: (Optional) The size of the widget's title. Default is 16.
        /// - `title_align`: (Optional) The alignment of the widget's title. One of "left", "center", or "right".
        /// - `time`: (Optional) Nested block describing the timeframe to use when displaying the widget. The structure of this block is described below.
        /// - `manage_status_definition`: The definition for a Manage Status, aka Monitor Summary, widget. Exactly one nested block is allowed with the following structure:
        /// - `query`: (Required) The query to use in the widget.
        /// </summary>
        [Input("sort")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestApmQueryGroupBySortArgs>? Sort { get; set; }

        public DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestApmQueryGroupByArgs()
        {
        }
    }
}
