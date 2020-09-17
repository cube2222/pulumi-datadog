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
    public sealed class DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSize
    {
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeApmQuery? ApmQuery;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeLogQuery? LogQuery;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeProcessQuery? ProcessQuery;
        public readonly string? Q;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeRumQuery? RumQuery;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeSecurityQuery? SecurityQuery;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSize(
            Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeApmQuery? apmQuery,

            Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeLogQuery? logQuery,

            Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeProcessQuery? processQuery,

            string? q,

            Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeRumQuery? rumQuery,

            Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeSecurityQuery? securityQuery)
        {
            ApmQuery = apmQuery;
            LogQuery = logQuery;
            ProcessQuery = processQuery;
            Q = q;
            RumQuery = rumQuery;
            SecurityQuery = securityQuery;
        }
    }
}
