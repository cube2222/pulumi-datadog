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
    public sealed class DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYApmQuery
    {
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYApmQueryCompute? Compute;
        public readonly ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYApmQueryGroupBy> GroupBies;
        public readonly string Index;
        public readonly ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYApmQueryMultiCompute> MultiComputes;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYApmQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYApmQuery(
            Outputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYApmQueryCompute? compute,

            ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYApmQueryGroupBy> groupBies,

            string index,

            ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYApmQueryMultiCompute> multiComputes,

            Outputs.DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionRequestYApmQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            MultiComputes = multiComputes;
            Search = search;
        }
    }
}
