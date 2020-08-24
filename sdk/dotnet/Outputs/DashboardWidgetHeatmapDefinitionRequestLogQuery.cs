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
    public sealed class DashboardWidgetHeatmapDefinitionRequestLogQuery
    {
        /// <summary>
        /// . Exactly one nested block is required with the following structure:
        /// </summary>
        public readonly Outputs.DashboardWidgetHeatmapDefinitionRequestLogQueryCompute Compute;
        /// <summary>
        /// When grouping = "cluster", indicates a list of tags to use for grouping.
        /// </summary>
        public readonly ImmutableArray<Outputs.DashboardWidgetHeatmapDefinitionRequestLogQueryGroupBy> GroupBies;
        public readonly string Index;
        /// <summary>
        /// . One nested block is allowed with the following structure:
        /// </summary>
        public readonly Outputs.DashboardWidgetHeatmapDefinitionRequestLogQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetHeatmapDefinitionRequestLogQuery(
            Outputs.DashboardWidgetHeatmapDefinitionRequestLogQueryCompute compute,

            ImmutableArray<Outputs.DashboardWidgetHeatmapDefinitionRequestLogQueryGroupBy> groupBies,

            string index,

            Outputs.DashboardWidgetHeatmapDefinitionRequestLogQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            Search = search;
        }
    }
}
