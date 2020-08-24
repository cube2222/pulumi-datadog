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
    public sealed class DashboardWidgetScatterplotDefinitionRequestYApmQuery
    {
        /// <summary>
        /// . Exactly one nested block is required with the following structure:
        /// </summary>
        public readonly Outputs.DashboardWidgetScatterplotDefinitionRequestYApmQueryCompute Compute;
        /// <summary>
        /// . Multiple nested blocks are allowed with the following structure:
        /// </summary>
        public readonly ImmutableArray<Outputs.DashboardWidgetScatterplotDefinitionRequestYApmQueryGroupBy> GroupBies;
        public readonly string Index;
        /// <summary>
        /// . One nested block is allowed with the following structure:
        /// </summary>
        public readonly Outputs.DashboardWidgetScatterplotDefinitionRequestYApmQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetScatterplotDefinitionRequestYApmQuery(
            Outputs.DashboardWidgetScatterplotDefinitionRequestYApmQueryCompute compute,

            ImmutableArray<Outputs.DashboardWidgetScatterplotDefinitionRequestYApmQueryGroupBy> groupBies,

            string index,

            Outputs.DashboardWidgetScatterplotDefinitionRequestYApmQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            Search = search;
        }
    }
}
