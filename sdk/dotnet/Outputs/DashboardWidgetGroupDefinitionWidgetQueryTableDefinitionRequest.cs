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
    public sealed class DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequest
    {
        public readonly string? Aggregator;
        public readonly string? Alias;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQuery? ApmQuery;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmStatsQuery? ApmStatsQuery;
        public readonly ImmutableArray<string> CellDisplayModes;
        public readonly ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestConditionalFormat> ConditionalFormats;
        public readonly int? Limit;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestLogQuery? LogQuery;
        public readonly string? Order;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestProcessQuery? ProcessQuery;
        public readonly string? Q;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestRumQuery? RumQuery;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestSecurityQuery? SecurityQuery;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequest(
            string? aggregator,

            string? alias,

            Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQuery? apmQuery,

            Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmStatsQuery? apmStatsQuery,

            ImmutableArray<string> cellDisplayModes,

            ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestConditionalFormat> conditionalFormats,

            int? limit,

            Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestLogQuery? logQuery,

            string? order,

            Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestProcessQuery? processQuery,

            string? q,

            Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestRumQuery? rumQuery,

            Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestSecurityQuery? securityQuery)
        {
            Aggregator = aggregator;
            Alias = alias;
            ApmQuery = apmQuery;
            ApmStatsQuery = apmStatsQuery;
            CellDisplayModes = cellDisplayModes;
            ConditionalFormats = conditionalFormats;
            Limit = limit;
            LogQuery = logQuery;
            Order = order;
            ProcessQuery = processQuery;
            Q = q;
            RumQuery = rumQuery;
            SecurityQuery = securityQuery;
        }
    }
}
