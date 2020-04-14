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
        public readonly Outputs.DashboardWidgetTimeseriesDefinitionRequestApmQueryCompute Compute;
        public readonly ImmutableArray<Outputs.DashboardWidgetTimeseriesDefinitionRequestApmQueryGroupBy> GroupBies;
        public readonly string Index;
        public readonly Outputs.DashboardWidgetTimeseriesDefinitionRequestApmQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetTimeseriesDefinitionRequestApmQuery(
            Outputs.DashboardWidgetTimeseriesDefinitionRequestApmQueryCompute compute,

            ImmutableArray<Outputs.DashboardWidgetTimeseriesDefinitionRequestApmQueryGroupBy> groupBies,

            string index,

            Outputs.DashboardWidgetTimeseriesDefinitionRequestApmQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            Search = search;
        }
    }
}
