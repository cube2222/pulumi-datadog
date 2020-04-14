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
    public sealed class DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFill
    {
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillApmQuery? ApmQuery;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillLogQuery? LogQuery;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillProcessQuery? ProcessQuery;
        public readonly string? Q;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFill(
            Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillApmQuery? apmQuery,

            Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillLogQuery? logQuery,

            Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillProcessQuery? processQuery,

            string? q)
        {
            ApmQuery = apmQuery;
            LogQuery = logQuery;
            ProcessQuery = processQuery;
            Q = q;
        }
    }
}
