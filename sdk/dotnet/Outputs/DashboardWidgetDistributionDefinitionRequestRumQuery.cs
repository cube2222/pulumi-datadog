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
    public sealed class DashboardWidgetDistributionDefinitionRequestRumQuery
    {
        public readonly Outputs.DashboardWidgetDistributionDefinitionRequestRumQueryCompute? Compute;
        public readonly ImmutableArray<Outputs.DashboardWidgetDistributionDefinitionRequestRumQueryGroupBy> GroupBies;
        public readonly string Index;
        public readonly ImmutableArray<Outputs.DashboardWidgetDistributionDefinitionRequestRumQueryMultiCompute> MultiComputes;
        public readonly Outputs.DashboardWidgetDistributionDefinitionRequestRumQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetDistributionDefinitionRequestRumQuery(
            Outputs.DashboardWidgetDistributionDefinitionRequestRumQueryCompute? compute,

            ImmutableArray<Outputs.DashboardWidgetDistributionDefinitionRequestRumQueryGroupBy> groupBies,

            string index,

            ImmutableArray<Outputs.DashboardWidgetDistributionDefinitionRequestRumQueryMultiCompute> multiComputes,

            Outputs.DashboardWidgetDistributionDefinitionRequestRumQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            MultiComputes = multiComputes;
            Search = search;
        }
    }
}
