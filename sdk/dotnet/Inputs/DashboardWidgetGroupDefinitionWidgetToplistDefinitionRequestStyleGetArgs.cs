// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestStyleGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Color palette to apply to the widget. The available options are available here: https://docs.datadoghq.com/graphing/widgets/timeseries/#appearance.
        /// - `title`: (Optional) The title of the widget.
        /// - `title_size`: (Optional) The size of the widget's title. Default is 16.
        /// - `title_align`: (Optional) The alignment of the widget's title. One of "left", "center", or "right".
        /// - `show_legend`: (Optional) Whether or not to show the legend on this widget.
        /// - `legend_size`: (Optional) The size of the legend displayed in the widget.
        /// - `time`: (Optional) Nested block describing the timeframe to use when displaying the widget. The structure of this block is described below.
        /// - `event_stream_definition`: The definition for a Event Stream widget. Exactly one nested block is allowed with the following structure:
        /// - `query`: (Required) The query to use in the widget.
        /// - `yaxis`: (Optional) Nested block describing the Y-Axis Controls. The structure of this block is described below
        /// - `show_legend`: (Optional) Whether or not to show the legend on this widget.
        /// - `legend_size`: (Optional) The size of the legend displayed in the widget.
        /// - `event`: (Optional) The definition of the event to overlay on the graph. Includes the following structure:
        /// - `q`: (Required) The event query to use in the widget.
        /// - `tags_execution`: (Optional) The execution method for multi-value filters.
        /// - `title`: (Optional) The title of the widget.
        /// - `title_size`: (Optional) The size of the widget's title. Default is 16.
        /// - `title_align`: (Optional) The alignment of the widget's title. One of "left", "center", or "right".
        /// - `time`: (Optional) Nested block describing the timeframe to use when displaying the widget. The structure of this block is described below.
        /// - `hostmap_definition`: The definition for a Hostmap widget. Exactly one nested block is allowed with the following structure:
        /// - `request`: (Required) Nested block describing the request to use when displaying the widget. Multiple request blocks are allowed with the following structure:
        /// - `fill`: (Optional) The query used to fill the map. Exactly one nested block is allowed with the following structure:
        /// - `q`: (Required) The metric query to use in the widget.
        /// - `size`: (Optional) The query used to size the map. Exactly one nested block is allowed with the following structure:
        /// - `q`: (Required) The metric query to use in the widget.
        /// </summary>
        [Input("palette")]
        public Input<string>? Palette { get; set; }

        public DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestStyleGetArgs()
        {
        }
    }
}
