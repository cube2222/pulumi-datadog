// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetHeatmapDefinitionRequestArgs : Pulumi.ResourceArgs
    {
        [Input("apmQuery")]
        public Input<Inputs.DashboardWidgetHeatmapDefinitionRequestApmQueryArgs>? ApmQuery { get; set; }

        [Input("logQuery")]
        public Input<Inputs.DashboardWidgetHeatmapDefinitionRequestLogQueryArgs>? LogQuery { get; set; }

        [Input("processQuery")]
        public Input<Inputs.DashboardWidgetHeatmapDefinitionRequestProcessQueryArgs>? ProcessQuery { get; set; }

        [Input("q")]
        public Input<string>? Q { get; set; }

        [Input("rumQuery")]
        public Input<Inputs.DashboardWidgetHeatmapDefinitionRequestRumQueryArgs>? RumQuery { get; set; }

        [Input("securityQuery")]
        public Input<Inputs.DashboardWidgetHeatmapDefinitionRequestSecurityQueryArgs>? SecurityQuery { get; set; }

        [Input("style")]
        public Input<Inputs.DashboardWidgetHeatmapDefinitionRequestStyleArgs>? Style { get; set; }

        public DashboardWidgetHeatmapDefinitionRequestArgs()
        {
        }
    }
}
