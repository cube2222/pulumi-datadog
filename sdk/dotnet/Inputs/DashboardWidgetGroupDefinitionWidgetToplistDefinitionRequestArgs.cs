// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestArgs : Pulumi.ResourceArgs
    {
        [Input("apmQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestApmQueryArgs>? ApmQuery { get; set; }

        [Input("conditionalFormats")]
        private InputList<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestConditionalFormatArgs>? _conditionalFormats;
        public InputList<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestConditionalFormatArgs> ConditionalFormats
        {
            get => _conditionalFormats ?? (_conditionalFormats = new InputList<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestConditionalFormatArgs>());
            set => _conditionalFormats = value;
        }

        [Input("logQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestLogQueryArgs>? LogQuery { get; set; }

        [Input("processQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestProcessQueryArgs>? ProcessQuery { get; set; }

        [Input("q")]
        public Input<string>? Q { get; set; }

        [Input("rumQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestRumQueryArgs>? RumQuery { get; set; }

        [Input("securityQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestSecurityQueryArgs>? SecurityQuery { get; set; }

        [Input("style")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestStyleArgs>? Style { get; set; }

        public DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestArgs()
        {
        }
    }
}
