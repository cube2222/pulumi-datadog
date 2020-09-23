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
    public sealed class DashboardWidgetScatterplotDefinitionRequestYRumQuery
    {
        public readonly Outputs.DashboardWidgetScatterplotDefinitionRequestYRumQueryCompute? Compute;
        public readonly ImmutableArray<Outputs.DashboardWidgetScatterplotDefinitionRequestYRumQueryGroupBy> GroupBies;
        public readonly string Index;
        public readonly ImmutableArray<Outputs.DashboardWidgetScatterplotDefinitionRequestYRumQueryMultiCompute> MultiComputes;
        public readonly Outputs.DashboardWidgetScatterplotDefinitionRequestYRumQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetScatterplotDefinitionRequestYRumQuery(
            Outputs.DashboardWidgetScatterplotDefinitionRequestYRumQueryCompute? compute,

            ImmutableArray<Outputs.DashboardWidgetScatterplotDefinitionRequestYRumQueryGroupBy> groupBies,

            string index,

            ImmutableArray<Outputs.DashboardWidgetScatterplotDefinitionRequestYRumQueryMultiCompute> multiComputes,

            Outputs.DashboardWidgetScatterplotDefinitionRequestYRumQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            MultiComputes = multiComputes;
            Search = search;
        }
    }
}