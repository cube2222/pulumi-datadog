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
    public sealed class DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestNetworkQuery
    {
        /// <summary>
        /// . Exactly one nested block is required with the following structure:
        /// </summary>
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestNetworkQueryCompute Compute;
        /// <summary>
        /// When grouping = "cluster", indicates a list of tags to use for grouping.
        /// </summary>
        public readonly ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestNetworkQueryGroupBy> GroupBies;
        public readonly string Index;
        /// <summary>
        /// . One nested block is allowed with the following structure:
        /// </summary>
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestNetworkQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestNetworkQuery(
            Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestNetworkQueryCompute compute,

            ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestNetworkQueryGroupBy> groupBies,

            string index,

            Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestNetworkQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            Search = search;
        }
    }
}
