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
    public sealed class DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQueryGroupBy
    {
        public readonly string? Facet;
        public readonly int? Limit;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQueryGroupBySort? Sort;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQueryGroupBy(
            string? facet,

            int? limit,

            Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQueryGroupBySort? sort)
        {
            Facet = facet;
            Limit = limit;
            Sort = sort;
        }
    }
}