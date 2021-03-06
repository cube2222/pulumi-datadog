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
    public sealed class DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestSecurityQuery
    {
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestSecurityQueryCompute? Compute;
        public readonly ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestSecurityQueryGroupBy> GroupBies;
        public readonly string Index;
        public readonly ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestSecurityQueryMultiCompute> MultiComputes;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestSecurityQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestSecurityQuery(
            Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestSecurityQueryCompute? compute,

            ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestSecurityQueryGroupBy> groupBies,

            string index,

            ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestSecurityQueryMultiCompute> multiComputes,

            Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestSecurityQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            MultiComputes = multiComputes;
            Search = search;
        }
    }
}
