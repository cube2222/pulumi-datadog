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
    public sealed class DashboardWidgetTimeseriesDefinitionRequest
    {
        public readonly Outputs.DashboardWidgetTimeseriesDefinitionRequestApmQuery? ApmQuery;
        public readonly string? DisplayType;
        public readonly Outputs.DashboardWidgetTimeseriesDefinitionRequestLogQuery? LogQuery;
        public readonly ImmutableArray<Outputs.DashboardWidgetTimeseriesDefinitionRequestMetadata> Metadatas;
        public readonly Outputs.DashboardWidgetTimeseriesDefinitionRequestProcessQuery? ProcessQuery;
        public readonly string? Q;
        public readonly Outputs.DashboardWidgetTimeseriesDefinitionRequestStyle? Style;

        [OutputConstructor]
        private DashboardWidgetTimeseriesDefinitionRequest(
            Outputs.DashboardWidgetTimeseriesDefinitionRequestApmQuery? apmQuery,

            string? displayType,

            Outputs.DashboardWidgetTimeseriesDefinitionRequestLogQuery? logQuery,

            ImmutableArray<Outputs.DashboardWidgetTimeseriesDefinitionRequestMetadata> metadatas,

            Outputs.DashboardWidgetTimeseriesDefinitionRequestProcessQuery? processQuery,

            string? q,

            Outputs.DashboardWidgetTimeseriesDefinitionRequestStyle? style)
        {
            ApmQuery = apmQuery;
            DisplayType = displayType;
            LogQuery = logQuery;
            Metadatas = metadatas;
            ProcessQuery = processQuery;
            Q = q;
            Style = style;
        }
    }
}
