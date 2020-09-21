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
    public sealed class DashboardWidgetTimeseriesDefinitionRequestApmQuery
    {
        public readonly Outputs.DashboardWidgetTimeseriesDefinitionRequestApmQueryCompute? Compute;
        public readonly ImmutableArray<Outputs.DashboardWidgetTimeseriesDefinitionRequestApmQueryGroupBy> GroupBies;
        public readonly string Index;
        public readonly ImmutableArray<Outputs.DashboardWidgetTimeseriesDefinitionRequestApmQueryMultiCompute> MultiComputes;
        public readonly Outputs.DashboardWidgetTimeseriesDefinitionRequestApmQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetTimeseriesDefinitionRequestApmQuery(
            Outputs.DashboardWidgetTimeseriesDefinitionRequestApmQueryCompute? compute,

            ImmutableArray<Outputs.DashboardWidgetTimeseriesDefinitionRequestApmQueryGroupBy> groupBies,

            string index,

            ImmutableArray<Outputs.DashboardWidgetTimeseriesDefinitionRequestApmQueryMultiCompute> multiComputes,

            Outputs.DashboardWidgetTimeseriesDefinitionRequestApmQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            MultiComputes = multiComputes;
            Search = search;
        }
    }
}
