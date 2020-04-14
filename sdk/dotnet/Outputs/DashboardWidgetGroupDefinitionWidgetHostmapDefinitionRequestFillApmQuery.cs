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
    public sealed class DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillApmQuery
    {
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillApmQueryCompute Compute;
        public readonly ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillApmQueryGroupBy> GroupBies;
        public readonly string Index;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillApmQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillApmQuery(
            Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillApmQueryCompute compute,

            ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillApmQueryGroupBy> groupBies,

            string index,

            Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillApmQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            Search = search;
        }
    }
}
