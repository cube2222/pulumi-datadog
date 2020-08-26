// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetHeatmapDefinitionRequestArgs : Pulumi.ResourceArgs
    {
        [Input("apmQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetHeatmapDefinitionRequestApmQueryArgs>? ApmQuery { get; set; }

        [Input("logQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetHeatmapDefinitionRequestLogQueryArgs>? LogQuery { get; set; }

        [Input("processQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetHeatmapDefinitionRequestProcessQueryArgs>? ProcessQuery { get; set; }

        [Input("q")]
        public Input<string>? Q { get; set; }

        /// <summary>
        /// Style of the widget graph. One nested block is allowed with the following structure:
        /// </summary>
        [Input("style")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetHeatmapDefinitionRequestStyleArgs>? Style { get; set; }

        public DashboardWidgetGroupDefinitionWidgetHeatmapDefinitionRequestArgs()
        {
        }
    }
}
