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
    public sealed class DashboardWidgetHeatmapDefinitionRequest
    {
        public readonly Outputs.DashboardWidgetHeatmapDefinitionRequestApmQuery? ApmQuery;
        public readonly Outputs.DashboardWidgetHeatmapDefinitionRequestLogQuery? LogQuery;
        public readonly Outputs.DashboardWidgetHeatmapDefinitionRequestProcessQuery? ProcessQuery;
        public readonly string? Q;
        public readonly Outputs.DashboardWidgetHeatmapDefinitionRequestStyle? Style;

        [OutputConstructor]
        private DashboardWidgetHeatmapDefinitionRequest(
            Outputs.DashboardWidgetHeatmapDefinitionRequestApmQuery? apmQuery,

            Outputs.DashboardWidgetHeatmapDefinitionRequestLogQuery? logQuery,

            Outputs.DashboardWidgetHeatmapDefinitionRequestProcessQuery? processQuery,

            string? q,

            Outputs.DashboardWidgetHeatmapDefinitionRequestStyle? style)
        {
            ApmQuery = apmQuery;
            LogQuery = logQuery;
            ProcessQuery = processQuery;
            Q = q;
            Style = style;
        }
    }
}
