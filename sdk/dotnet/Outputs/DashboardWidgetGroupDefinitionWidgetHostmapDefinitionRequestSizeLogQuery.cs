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
    public sealed class DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeLogQuery
    {
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeLogQueryCompute? Compute;
        public readonly ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeLogQueryGroupBy> GroupBies;
        public readonly string Index;
        public readonly ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeLogQueryMultiCompute> MultiComputes;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeLogQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeLogQuery(
            Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeLogQueryCompute? compute,

            ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeLogQueryGroupBy> groupBies,

            string index,

            ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeLogQueryMultiCompute> multiComputes,

            Outputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeLogQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            MultiComputes = multiComputes;
            Search = search;
        }
    }
}
