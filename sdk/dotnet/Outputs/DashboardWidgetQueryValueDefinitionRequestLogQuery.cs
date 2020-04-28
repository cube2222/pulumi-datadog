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
    public sealed class DashboardWidgetQueryValueDefinitionRequestLogQuery
    {
        public readonly Outputs.DashboardWidgetQueryValueDefinitionRequestLogQueryCompute Compute;
        public readonly ImmutableArray<Outputs.DashboardWidgetQueryValueDefinitionRequestLogQueryGroupBy> GroupBies;
        public readonly string Index;
        public readonly Outputs.DashboardWidgetQueryValueDefinitionRequestLogQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetQueryValueDefinitionRequestLogQuery(
            Outputs.DashboardWidgetQueryValueDefinitionRequestLogQueryCompute compute,

            ImmutableArray<Outputs.DashboardWidgetQueryValueDefinitionRequestLogQueryGroupBy> groupBies,

            string index,

            Outputs.DashboardWidgetQueryValueDefinitionRequestLogQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            Search = search;
        }
    }
}