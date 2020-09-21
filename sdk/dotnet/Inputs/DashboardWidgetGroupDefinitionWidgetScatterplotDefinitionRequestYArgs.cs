// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYArgs : Pulumi.ResourceArgs
    {
        [Input("aggregator")]
        public Input<string>? Aggregator { get; set; }

        [Input("apmQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYApmQueryArgs>? ApmQuery { get; set; }

        [Input("logQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYLogQueryArgs>? LogQuery { get; set; }

        [Input("processQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYProcessQueryArgs>? ProcessQuery { get; set; }

        [Input("q")]
        public Input<string>? Q { get; set; }

        [Input("rumQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYRumQueryArgs>? RumQuery { get; set; }

        [Input("securityQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYSecurityQueryArgs>? SecurityQuery { get; set; }

        public DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYArgs()
        {
        }
    }
}
