// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetQueryTableDefinitionRequestGetArgs : Pulumi.ResourceArgs
    {
        [Input("aggregator")]
        public Input<string>? Aggregator { get; set; }

        [Input("alias")]
        public Input<string>? Alias { get; set; }

        [Input("apmQuery")]
        public Input<Inputs.DashboardWidgetQueryTableDefinitionRequestApmQueryGetArgs>? ApmQuery { get; set; }

        [Input("apmStatsQuery")]
        public Input<Inputs.DashboardWidgetQueryTableDefinitionRequestApmStatsQueryGetArgs>? ApmStatsQuery { get; set; }

        [Input("cellDisplayModes")]
        private InputList<string>? _cellDisplayModes;
        public InputList<string> CellDisplayModes
        {
            get => _cellDisplayModes ?? (_cellDisplayModes = new InputList<string>());
            set => _cellDisplayModes = value;
        }

        [Input("conditionalFormats")]
        private InputList<Inputs.DashboardWidgetQueryTableDefinitionRequestConditionalFormatGetArgs>? _conditionalFormats;
        public InputList<Inputs.DashboardWidgetQueryTableDefinitionRequestConditionalFormatGetArgs> ConditionalFormats
        {
            get => _conditionalFormats ?? (_conditionalFormats = new InputList<Inputs.DashboardWidgetQueryTableDefinitionRequestConditionalFormatGetArgs>());
            set => _conditionalFormats = value;
        }

        [Input("limit")]
        public Input<int>? Limit { get; set; }

        [Input("logQuery")]
        public Input<Inputs.DashboardWidgetQueryTableDefinitionRequestLogQueryGetArgs>? LogQuery { get; set; }

        [Input("order")]
        public Input<string>? Order { get; set; }

        [Input("processQuery")]
        public Input<Inputs.DashboardWidgetQueryTableDefinitionRequestProcessQueryGetArgs>? ProcessQuery { get; set; }

        [Input("q")]
        public Input<string>? Q { get; set; }

        [Input("rumQuery")]
        public Input<Inputs.DashboardWidgetQueryTableDefinitionRequestRumQueryGetArgs>? RumQuery { get; set; }

        [Input("securityQuery")]
        public Input<Inputs.DashboardWidgetQueryTableDefinitionRequestSecurityQueryGetArgs>? SecurityQuery { get; set; }

        public DashboardWidgetQueryTableDefinitionRequestGetArgs()
        {
        }
    }
}
