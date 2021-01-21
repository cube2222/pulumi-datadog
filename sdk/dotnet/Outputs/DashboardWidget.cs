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
    public sealed class DashboardWidget
    {
        public readonly Outputs.DashboardWidgetAlertGraphDefinition? AlertGraphDefinition;
        public readonly Outputs.DashboardWidgetAlertValueDefinition? AlertValueDefinition;
        public readonly Outputs.DashboardWidgetChangeDefinition? ChangeDefinition;
        public readonly Outputs.DashboardWidgetCheckStatusDefinition? CheckStatusDefinition;
        public readonly Outputs.DashboardWidgetDistributionDefinition? DistributionDefinition;
        public readonly Outputs.DashboardWidgetEventStreamDefinition? EventStreamDefinition;
        public readonly Outputs.DashboardWidgetEventTimelineDefinition? EventTimelineDefinition;
        public readonly Outputs.DashboardWidgetFreeTextDefinition? FreeTextDefinition;
        public readonly Outputs.DashboardWidgetGroupDefinition? GroupDefinition;
        public readonly Outputs.DashboardWidgetHeatmapDefinition? HeatmapDefinition;
        public readonly Outputs.DashboardWidgetHostmapDefinition? HostmapDefinition;
        public readonly int? Id;
        public readonly Outputs.DashboardWidgetIframeDefinition? IframeDefinition;
        public readonly Outputs.DashboardWidgetImageDefinition? ImageDefinition;
        public readonly Outputs.DashboardWidgetLayout? Layout;
        public readonly Outputs.DashboardWidgetLogStreamDefinition? LogStreamDefinition;
        public readonly Outputs.DashboardWidgetManageStatusDefinition? ManageStatusDefinition;
        public readonly Outputs.DashboardWidgetNoteDefinition? NoteDefinition;
        public readonly Outputs.DashboardWidgetQueryTableDefinition? QueryTableDefinition;
        public readonly Outputs.DashboardWidgetQueryValueDefinition? QueryValueDefinition;
        public readonly Outputs.DashboardWidgetScatterplotDefinition? ScatterplotDefinition;
        public readonly Outputs.DashboardWidgetServiceLevelObjectiveDefinition? ServiceLevelObjectiveDefinition;
        public readonly Outputs.DashboardWidgetServicemapDefinition? ServicemapDefinition;
        public readonly Outputs.DashboardWidgetTimeseriesDefinition? TimeseriesDefinition;
        public readonly Outputs.DashboardWidgetToplistDefinition? ToplistDefinition;
        public readonly Outputs.DashboardWidgetTraceServiceDefinition? TraceServiceDefinition;

        [OutputConstructor]
        private DashboardWidget(
            Outputs.DashboardWidgetAlertGraphDefinition? alertGraphDefinition,

            Outputs.DashboardWidgetAlertValueDefinition? alertValueDefinition,

            Outputs.DashboardWidgetChangeDefinition? changeDefinition,

            Outputs.DashboardWidgetCheckStatusDefinition? checkStatusDefinition,

            Outputs.DashboardWidgetDistributionDefinition? distributionDefinition,

            Outputs.DashboardWidgetEventStreamDefinition? eventStreamDefinition,

            Outputs.DashboardWidgetEventTimelineDefinition? eventTimelineDefinition,

            Outputs.DashboardWidgetFreeTextDefinition? freeTextDefinition,

            Outputs.DashboardWidgetGroupDefinition? groupDefinition,

            Outputs.DashboardWidgetHeatmapDefinition? heatmapDefinition,

            Outputs.DashboardWidgetHostmapDefinition? hostmapDefinition,

            int? id,

            Outputs.DashboardWidgetIframeDefinition? iframeDefinition,

            Outputs.DashboardWidgetImageDefinition? imageDefinition,

            Outputs.DashboardWidgetLayout? layout,

            Outputs.DashboardWidgetLogStreamDefinition? logStreamDefinition,

            Outputs.DashboardWidgetManageStatusDefinition? manageStatusDefinition,

            Outputs.DashboardWidgetNoteDefinition? noteDefinition,

            Outputs.DashboardWidgetQueryTableDefinition? queryTableDefinition,

            Outputs.DashboardWidgetQueryValueDefinition? queryValueDefinition,

            Outputs.DashboardWidgetScatterplotDefinition? scatterplotDefinition,

            Outputs.DashboardWidgetServiceLevelObjectiveDefinition? serviceLevelObjectiveDefinition,

            Outputs.DashboardWidgetServicemapDefinition? servicemapDefinition,

            Outputs.DashboardWidgetTimeseriesDefinition? timeseriesDefinition,

            Outputs.DashboardWidgetToplistDefinition? toplistDefinition,

            Outputs.DashboardWidgetTraceServiceDefinition? traceServiceDefinition)
        {
            AlertGraphDefinition = alertGraphDefinition;
            AlertValueDefinition = alertValueDefinition;
            ChangeDefinition = changeDefinition;
            CheckStatusDefinition = checkStatusDefinition;
            DistributionDefinition = distributionDefinition;
            EventStreamDefinition = eventStreamDefinition;
            EventTimelineDefinition = eventTimelineDefinition;
            FreeTextDefinition = freeTextDefinition;
            GroupDefinition = groupDefinition;
            HeatmapDefinition = heatmapDefinition;
            HostmapDefinition = hostmapDefinition;
            Id = id;
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
