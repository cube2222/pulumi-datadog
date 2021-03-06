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
    public sealed class DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYLogQuery
    {
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYLogQueryCompute? Compute;
        public readonly ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYLogQueryGroupBy> GroupBies;
        public readonly string Index;
        public readonly ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYLogQueryMultiCompute> MultiComputes;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYLogQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYLogQuery(
            Outputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYLogQueryCompute? compute,

            ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYLogQueryGroupBy> groupBies,

            string index,

            ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYLogQueryMultiCompute> multiComputes,

            Outputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYLogQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            MultiComputes = multiComputes;
            Search = search;
        }
    }
}
