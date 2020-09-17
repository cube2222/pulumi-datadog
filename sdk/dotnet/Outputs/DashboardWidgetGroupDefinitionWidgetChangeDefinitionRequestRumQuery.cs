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
    public sealed class DashboardWidgetGroupDefinitionWidgetChangeDefinitionRequestRumQuery
    {
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetChangeDefinitionRequestRumQueryCompute? Compute;
        public readonly ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetChangeDefinitionRequestRumQueryGroupBy> GroupBies;
        public readonly string Index;
        public readonly ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetChangeDefinitionRequestRumQueryMultiCompute> MultiComputes;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetChangeDefinitionRequestRumQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetChangeDefinitionRequestRumQuery(
            Outputs.DashboardWidgetGroupDefinitionWidgetChangeDefinitionRequestRumQueryCompute? compute,

            ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetChangeDefinitionRequestRumQueryGroupBy> groupBies,

            string index,

            ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetChangeDefinitionRequestRumQueryMultiCompute> multiComputes,

            Outputs.DashboardWidgetGroupDefinitionWidgetChangeDefinitionRequestRumQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            MultiComputes = multiComputes;
            Search = search;
        }
    }
}
