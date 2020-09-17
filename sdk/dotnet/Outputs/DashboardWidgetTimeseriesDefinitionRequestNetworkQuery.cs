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
    public sealed class DashboardWidgetTimeseriesDefinitionRequestNetworkQuery
    {
        public readonly Outputs.DashboardWidgetTimeseriesDefinitionRequestNetworkQueryCompute? Compute;
        public readonly ImmutableArray<Outputs.DashboardWidgetTimeseriesDefinitionRequestNetworkQueryGroupBy> GroupBies;
        public readonly string Index;
        public readonly ImmutableArray<Outputs.DashboardWidgetTimeseriesDefinitionRequestNetworkQueryMultiCompute> MultiComputes;
        public readonly Outputs.DashboardWidgetTimeseriesDefinitionRequestNetworkQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetTimeseriesDefinitionRequestNetworkQuery(
            Outputs.DashboardWidgetTimeseriesDefinitionRequestNetworkQueryCompute? compute,

            ImmutableArray<Outputs.DashboardWidgetTimeseriesDefinitionRequestNetworkQueryGroupBy> groupBies,

            string index,

            ImmutableArray<Outputs.DashboardWidgetTimeseriesDefinitionRequestNetworkQueryMultiCompute> multiComputes,

            Outputs.DashboardWidgetTimeseriesDefinitionRequestNetworkQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            MultiComputes = multiComputes;
            Search = search;
        }
    }
}
