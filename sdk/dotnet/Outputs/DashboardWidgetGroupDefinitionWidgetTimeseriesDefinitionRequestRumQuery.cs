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
    public sealed class DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestRumQuery
    {
        /// <summary>
        /// . Exactly one nested block is required with the following structure:
        /// </summary>
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestRumQueryCompute Compute;
        /// <summary>
        /// When grouping = "cluster", indicates a list of tags to use for grouping.
        /// </summary>
        public readonly ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestRumQueryGroupBy> GroupBies;
        public readonly string Index;
        /// <summary>
        /// . One nested block is allowed with the following structure:
        /// </summary>
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestRumQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestRumQuery(
            Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestRumQueryCompute compute,

            ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestRumQueryGroupBy> groupBies,

            string index,

            Outputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestRumQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            Search = search;
        }
    }
}
