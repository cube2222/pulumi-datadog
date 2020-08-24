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
    public sealed class DashboardWidgetGroupDefinitionWidget
    {
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetAlertGraphDefinition? AlertGraphDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetAlertValueDefinition? AlertValueDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetChangeDefinition? ChangeDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetCheckStatusDefinition? CheckStatusDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetDistributionDefinition? DistributionDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetEventStreamDefinition? EventStreamDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetEventTimelineDefinition? EventTimelineDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetFreeTextDefinition? FreeTextDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetHeatmapDefinition? HeatmapDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinition? HostmapDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetIframeDefinition? IframeDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetImageDefinition? ImageDefinition;
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
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetLayout? Layout;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetLogStreamDefinition? LogStreamDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetManageStatusDefinition? ManageStatusDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetNoteDefinition? NoteDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinition? QueryTableDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetQueryValueDefinition? QueryValueDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinition? ScatterplotDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetServiceLevelObjectiveDefinition? ServiceLevelObjectiveDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetServicemapDefinition? ServicemapDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinition? TimeseriesDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetToplistDefinition? ToplistDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetTraceServiceDefinition? TraceServiceDefinition;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidget(
            Outputs.DashboardWidgetGroupDefinitionWidgetAlertGraphDefinition? alertGraphDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetAlertValueDefinition? alertValueDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetChangeDefinition? changeDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetCheckStatusDefinition? checkStatusDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetDistributionDefinition? distributionDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetEventStreamDefinition? eventStreamDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetEventTimelineDefinition? eventTimelineDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetFreeTextDefinition? freeTextDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetHeatmapDefinition? heatmapDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinition? hostmapDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetIframeDefinition? iframeDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetImageDefinition? imageDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetLayout? layout,

            Outputs.DashboardWidgetGroupDefinitionWidgetLogStreamDefinition? logStreamDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetManageStatusDefinition? manageStatusDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetNoteDefinition? noteDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinition? queryTableDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetQueryValueDefinition? queryValueDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinition? scatterplotDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetServiceLevelObjectiveDefinition? serviceLevelObjectiveDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetServicemapDefinition? servicemapDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinition? timeseriesDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetToplistDefinition? toplistDefinition,

            Outputs.DashboardWidgetGroupDefinitionWidgetTraceServiceDefinition? traceServiceDefinition)
        {
            AlertGraphDefinition = alertGraphDefinition;
            AlertValueDefinition = alertValueDefinition;
            ChangeDefinition = changeDefinition;
            CheckStatusDefinition = checkStatusDefinition;
            DistributionDefinition = distributionDefinition;
            EventStreamDefinition = eventStreamDefinition;
            EventTimelineDefinition = eventTimelineDefinition;
            FreeTextDefinition = freeTextDefinition;
            HeatmapDefinition = heatmapDefinition;
            HostmapDefinition = hostmapDefinition;
            IframeDefinition = iframeDefinition;
            ImageDefinition = imageDefinition;
            Layout = layout;
            LogStreamDefinition = logStreamDefinition;
            ManageStatusDefinition = manageStatusDefinition;
            NoteDefinition = noteDefinition;
            QueryTableDefinition = queryTableDefinition;
            QueryValueDefinition = queryValueDefinition;
            ScatterplotDefinition = scatterplotDefinition;
            ServiceLevelObjectiveDefinition = serviceLevelObjectiveDefinition;
            ServicemapDefinition = servicemapDefinition;
            TimeseriesDefinition = timeseriesDefinition;
            ToplistDefinition = toplistDefinition;
            TraceServiceDefinition = traceServiceDefinition;
        }
    }
}
