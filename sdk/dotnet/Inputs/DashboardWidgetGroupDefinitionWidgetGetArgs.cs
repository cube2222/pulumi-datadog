// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetGetArgs : Pulumi.ResourceArgs
    {
        [Input("alertGraphDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetAlertGraphDefinitionGetArgs>? AlertGraphDefinition { get; set; }

        [Input("alertValueDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetAlertValueDefinitionGetArgs>? AlertValueDefinition { get; set; }

        [Input("changeDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetChangeDefinitionGetArgs>? ChangeDefinition { get; set; }

        [Input("checkStatusDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetCheckStatusDefinitionGetArgs>? CheckStatusDefinition { get; set; }

        [Input("distributionDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetDistributionDefinitionGetArgs>? DistributionDefinition { get; set; }

        [Input("eventStreamDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetEventStreamDefinitionGetArgs>? EventStreamDefinition { get; set; }

        [Input("eventTimelineDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetEventTimelineDefinitionGetArgs>? EventTimelineDefinition { get; set; }

        [Input("freeTextDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetFreeTextDefinitionGetArgs>? FreeTextDefinition { get; set; }

        [Input("heatmapDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetHeatmapDefinitionGetArgs>? HeatmapDefinition { get; set; }

        [Input("hostmapDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionGetArgs>? HostmapDefinition { get; set; }

        [Input("id")]
        public Input<int>? Id { get; set; }

        [Input("iframeDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetIframeDefinitionGetArgs>? IframeDefinition { get; set; }

        [Input("imageDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetImageDefinitionGetArgs>? ImageDefinition { get; set; }

        [Input("layout")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetLayoutGetArgs>? Layout { get; set; }

        [Input("logStreamDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetLogStreamDefinitionGetArgs>? LogStreamDefinition { get; set; }

        [Input("manageStatusDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetManageStatusDefinitionGetArgs>? ManageStatusDefinition { get; set; }

        [Input("noteDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetNoteDefinitionGetArgs>? NoteDefinition { get; set; }

        [Input("queryTableDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionGetArgs>? QueryTableDefinition { get; set; }

        [Input("queryValueDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetQueryValueDefinitionGetArgs>? QueryValueDefinition { get; set; }

        [Input("scatterplotDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionGetArgs>? ScatterplotDefinition { get; set; }

        [Input("serviceLevelObjectiveDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetServiceLevelObjectiveDefinitionGetArgs>? ServiceLevelObjectiveDefinition { get; set; }

        [Input("servicemapDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetServicemapDefinitionGetArgs>? ServicemapDefinition { get; set; }

        [Input("timeseriesDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionGetArgs>? TimeseriesDefinition { get; set; }

        [Input("toplistDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionGetArgs>? ToplistDefinition { get; set; }

        [Input("traceServiceDefinition")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetTraceServiceDefinitionGetArgs>? TraceServiceDefinition { get; set; }

        public DashboardWidgetGroupDefinitionWidgetGetArgs()
        {
        }
    }
}
