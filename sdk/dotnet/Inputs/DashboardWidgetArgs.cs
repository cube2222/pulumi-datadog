// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetArgs : Pulumi.ResourceArgs
    {
        [Input("alertGraphDefinition")]
        public Input<Inputs.DashboardWidgetAlertGraphDefinitionArgs>? AlertGraphDefinition { get; set; }

        [Input("alertValueDefinition")]
        public Input<Inputs.DashboardWidgetAlertValueDefinitionArgs>? AlertValueDefinition { get; set; }

        [Input("changeDefinition")]
        public Input<Inputs.DashboardWidgetChangeDefinitionArgs>? ChangeDefinition { get; set; }

        [Input("checkStatusDefinition")]
        public Input<Inputs.DashboardWidgetCheckStatusDefinitionArgs>? CheckStatusDefinition { get; set; }

        [Input("distributionDefinition")]
        public Input<Inputs.DashboardWidgetDistributionDefinitionArgs>? DistributionDefinition { get; set; }

        [Input("eventStreamDefinition")]
        public Input<Inputs.DashboardWidgetEventStreamDefinitionArgs>? EventStreamDefinition { get; set; }

        [Input("eventTimelineDefinition")]
        public Input<Inputs.DashboardWidgetEventTimelineDefinitionArgs>? EventTimelineDefinition { get; set; }

        [Input("freeTextDefinition")]
        public Input<Inputs.DashboardWidgetFreeTextDefinitionArgs>? FreeTextDefinition { get; set; }

        [Input("groupDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionArgs>? GroupDefinition { get; set; }

        [Input("heatmapDefinition")]
        public Input<Inputs.DashboardWidgetHeatmapDefinitionArgs>? HeatmapDefinition { get; set; }

        [Input("hostmapDefinition")]
        public Input<Inputs.DashboardWidgetHostmapDefinitionArgs>? HostmapDefinition { get; set; }

        [Input("iframeDefinition")]
        public Input<Inputs.DashboardWidgetIframeDefinitionArgs>? IframeDefinition { get; set; }

        [Input("imageDefinition")]
        public Input<Inputs.DashboardWidgetImageDefinitionArgs>? ImageDefinition { get; set; }

        /// <summary>
        /// . The structure of this block is described below
        /// - A widget should have exactly one of the following nested blocks describing the widget definition:
        /// - `alert_graph_definition`: The definition for a Alert Graph widget. Exactly one nested block is allowed with the following structure:
        /// - `alert_id`: (Required) The ID of the monitor used by the widget.
        /// - `viz_type`: (Required) Type of visualization to use when displaying the widget. Either "timeseries" or "toplist".
        /// - `title`: (Optional) The title of the widget.
        /// - `title_size`: (Optional) The size of the widget's title. Default is 16.
        /// - `title_align`: (Optional) The alignment of the widget's title. One of "left", "center", or "right"
        /// - `time`: (Optional) Nested block describing the timeframe to use when displaying the widget. The structure of this block is described below.
        /// - `alert_value_definition`: The definition for an Alert Value widget. Exactly one nested block is allowed with the following structure:
        /// - `alert_id`: (Required) The ID of the monitor used by the widget.
        /// - `precision`: (Optional) The precision to use when displaying the value. Use "*" for maximum precision.
        /// - `unit`: (Optional) The unit for the value displayed in the widget.
        /// - `text_align`: (Optional) The alignment of the text in the widget.
        /// - `title`: (Optional) The title of the widget.
        /// - `title_size`: (Optional) The size of the widget's title. Default is 16.
        /// - `title_align`: (Optional) The alignment of the widget's title. One of "left", "center", or "right"
        /// - `change_definition`: The definition for a Change widget. Exactly one nested block is allowed with the following structure:
        /// - `request`: (Required) Nested block describing the request to use when displaying the widget. Multiple request blocks are allowed with the following structure:
        /// - `q`: (Required) The metric query to use in the widget.
        /// - `change_type`: (Optional) Whether to show absolute or relative change. One of "absolute", "relative".
        /// </summary>
        [Input("layout")]
        public Input<Inputs.DashboardWidgetLayoutArgs>? Layout { get; set; }

        [Input("logStreamDefinition")]
        public Input<Inputs.DashboardWidgetLogStreamDefinitionArgs>? LogStreamDefinition { get; set; }

        [Input("manageStatusDefinition")]
        public Input<Inputs.DashboardWidgetManageStatusDefinitionArgs>? ManageStatusDefinition { get; set; }

        [Input("noteDefinition")]
        public Input<Inputs.DashboardWidgetNoteDefinitionArgs>? NoteDefinition { get; set; }

        [Input("queryTableDefinition")]
        public Input<Inputs.DashboardWidgetQueryTableDefinitionArgs>? QueryTableDefinition { get; set; }

        [Input("queryValueDefinition")]
        public Input<Inputs.DashboardWidgetQueryValueDefinitionArgs>? QueryValueDefinition { get; set; }

        [Input("scatterplotDefinition")]
        public Input<Inputs.DashboardWidgetScatterplotDefinitionArgs>? ScatterplotDefinition { get; set; }

        [Input("serviceLevelObjectiveDefinition")]
        public Input<Inputs.DashboardWidgetServiceLevelObjectiveDefinitionArgs>? ServiceLevelObjectiveDefinition { get; set; }

        [Input("servicemapDefinition")]
        public Input<Inputs.DashboardWidgetServicemapDefinitionArgs>? ServicemapDefinition { get; set; }

        [Input("timeseriesDefinition")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionArgs>? TimeseriesDefinition { get; set; }

        [Input("toplistDefinition")]
        public Input<Inputs.DashboardWidgetToplistDefinitionArgs>? ToplistDefinition { get; set; }

        [Input("traceServiceDefinition")]
        public Input<Inputs.DashboardWidgetTraceServiceDefinitionArgs>? TraceServiceDefinition { get; set; }

        public DashboardWidgetArgs()
        {
        }
    }
}
