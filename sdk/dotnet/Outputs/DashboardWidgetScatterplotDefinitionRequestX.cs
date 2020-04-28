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
    public sealed class DashboardWidgetScatterplotDefinitionRequestX
    {
        public readonly string? Aggregator;
        public readonly Outputs.DashboardWidgetScatterplotDefinitionRequestXApmQuery? ApmQuery;
        public readonly Outputs.DashboardWidgetScatterplotDefinitionRequestXLogQuery? LogQuery;
        public readonly Outputs.DashboardWidgetScatterplotDefinitionRequestXProcessQuery? ProcessQuery;
        public readonly string? Q;

        [OutputConstructor]
        private DashboardWidgetScatterplotDefinitionRequestX(
            string? aggregator,

            Outputs.DashboardWidgetScatterplotDefinitionRequestXApmQuery? apmQuery,

            Outputs.DashboardWidgetScatterplotDefinitionRequestXLogQuery? logQuery,

            Outputs.DashboardWidgetScatterplotDefinitionRequestXProcessQuery? processQuery,

            string? q)
        {
            Aggregator = aggregator;
            ApmQuery = apmQuery;
            LogQuery = logQuery;
            ProcessQuery = processQuery;
            Q = q;
        }
    }
}