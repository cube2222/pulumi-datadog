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
    public sealed class DashboardWidgetScatterplotDefinitionRequestYApmQuery
    {
        public readonly Outputs.DashboardWidgetScatterplotDefinitionRequestYApmQueryCompute? Compute;
        public readonly ImmutableArray<Outputs.DashboardWidgetScatterplotDefinitionRequestYApmQueryGroupBy> GroupBies;
        public readonly string Index;
        public readonly ImmutableArray<Outputs.DashboardWidgetScatterplotDefinitionRequestYApmQueryMultiCompute> MultiComputes;
        public readonly Outputs.DashboardWidgetScatterplotDefinitionRequestYApmQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetScatterplotDefinitionRequestYApmQuery(
            Outputs.DashboardWidgetScatterplotDefinitionRequestYApmQueryCompute? compute,

            ImmutableArray<Outputs.DashboardWidgetScatterplotDefinitionRequestYApmQueryGroupBy> groupBies,

            string index,

            ImmutableArray<Outputs.DashboardWidgetScatterplotDefinitionRequestYApmQueryMultiCompute> multiComputes,

            Outputs.DashboardWidgetScatterplotDefinitionRequestYApmQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            MultiComputes = multiComputes;
            Search = search;
        }
    }
}
