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
    public sealed class DashboardWidgetHostmapDefinitionRequestFill
    {
        public readonly Outputs.DashboardWidgetHostmapDefinitionRequestFillApmQuery? ApmQuery;
        public readonly Outputs.DashboardWidgetHostmapDefinitionRequestFillLogQuery? LogQuery;
        public readonly Outputs.DashboardWidgetHostmapDefinitionRequestFillProcessQuery? ProcessQuery;
        public readonly string? Q;

        [OutputConstructor]
        private DashboardWidgetHostmapDefinitionRequestFill(
            Outputs.DashboardWidgetHostmapDefinitionRequestFillApmQuery? apmQuery,

            Outputs.DashboardWidgetHostmapDefinitionRequestFillLogQuery? logQuery,

            Outputs.DashboardWidgetHostmapDefinitionRequestFillProcessQuery? processQuery,

            string? q)
        {
            ApmQuery = apmQuery;
            LogQuery = logQuery;
            ProcessQuery = processQuery;
            Q = q;
        }
    }
}
