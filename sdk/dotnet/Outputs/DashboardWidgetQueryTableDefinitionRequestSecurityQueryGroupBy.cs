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
    public sealed class DashboardWidgetQueryTableDefinitionRequestSecurityQueryGroupBy
    {
        public readonly string? Facet;
        public readonly int? Limit;
        public readonly Outputs.DashboardWidgetQueryTableDefinitionRequestSecurityQueryGroupBySort? Sort;

        [OutputConstructor]
        private DashboardWidgetQueryTableDefinitionRequestSecurityQueryGroupBy(
            string? facet,

            int? limit,

            Outputs.DashboardWidgetQueryTableDefinitionRequestSecurityQueryGroupBySort? sort)
        {
            Facet = facet;
            Limit = limit;
            Sort = sort;
        }
    }
}
