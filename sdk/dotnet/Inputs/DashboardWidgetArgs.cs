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

        [Input("id")]
        public Input<int>? Id { get; set; }

        [Input("iframeDefinition")]
        public Input<Inputs.DashboardWidgetIframeDefinitionArgs>? IframeDefinition { get; set; }

        [Input("imageDefinition")]
        public Input<Inputs.DashboardWidgetImageDefinitionArgs>? ImageDefinition { get; set; }

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
