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
    public sealed class DashboardWidgetHostmapDefinitionRequestSizeSecurityQueryGroupBy
    {
        public readonly string? Facet;
        public readonly int? Limit;
        public readonly Outputs.DashboardWidgetHostmapDefinitionRequestSizeSecurityQueryGroupBySort? Sort;

        [OutputConstructor]
        private DashboardWidgetHostmapDefinitionRequestSizeSecurityQueryGroupBy(
            string? facet,

            int? limit,

            Outputs.DashboardWidgetHostmapDefinitionRequestSizeSecurityQueryGroupBySort? sort)
        {
            Facet = facet;
            Limit = limit;
            Sort = sort;
        }
    }
}