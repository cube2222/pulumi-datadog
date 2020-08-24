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
    public sealed class DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQuery
    {
        /// <summary>
        /// . Exactly one nested block is required with the following structure:
        /// </summary>
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQueryCompute Compute;
        /// <summary>
        /// . Multiple nested blocks are allowed with the following structure:
        /// </summary>
        public readonly ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQueryGroupBy> GroupBies;
        public readonly string Index;
        /// <summary>
        /// . One nested block is allowed with the following structure:
        /// </summary>
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQuery(
            Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQueryCompute compute,

            ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQueryGroupBy> groupBies,

            string index,

            Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            Search = search;
        }
    }
}
