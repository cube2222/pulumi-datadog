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
    public sealed class DashboardWidgetToplistDefinitionRequestRumQuery
    {
        public readonly Outputs.DashboardWidgetToplistDefinitionRequestRumQueryCompute? Compute;
        public readonly ImmutableArray<Outputs.DashboardWidgetToplistDefinitionRequestRumQueryGroupBy> GroupBies;
        public readonly string Index;
        public readonly ImmutableArray<Outputs.DashboardWidgetToplistDefinitionRequestRumQueryMultiCompute> MultiComputes;
        public readonly Outputs.DashboardWidgetToplistDefinitionRequestRumQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetToplistDefinitionRequestRumQuery(
            Outputs.DashboardWidgetToplistDefinitionRequestRumQueryCompute? compute,

            ImmutableArray<Outputs.DashboardWidgetToplistDefinitionRequestRumQueryGroupBy> groupBies,

            string index,

            ImmutableArray<Outputs.DashboardWidgetToplistDefinitionRequestRumQueryMultiCompute> multiComputes,

            Outputs.DashboardWidgetToplistDefinitionRequestRumQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            MultiComputes = multiComputes;
            Search = search;
        }
    }
}