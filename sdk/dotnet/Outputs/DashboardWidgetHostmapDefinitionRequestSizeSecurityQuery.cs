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
    public sealed class DashboardWidgetHostmapDefinitionRequestSizeSecurityQuery
    {
        public readonly Outputs.DashboardWidgetHostmapDefinitionRequestSizeSecurityQueryCompute? Compute;
        public readonly ImmutableArray<Outputs.DashboardWidgetHostmapDefinitionRequestSizeSecurityQueryGroupBy> GroupBies;
        public readonly string Index;
        public readonly ImmutableArray<Outputs.DashboardWidgetHostmapDefinitionRequestSizeSecurityQueryMultiCompute> MultiComputes;
        public readonly Outputs.DashboardWidgetHostmapDefinitionRequestSizeSecurityQuerySearch? Search;

        [OutputConstructor]
        private DashboardWidgetHostmapDefinitionRequestSizeSecurityQuery(
            Outputs.DashboardWidgetHostmapDefinitionRequestSizeSecurityQueryCompute? compute,

            ImmutableArray<Outputs.DashboardWidgetHostmapDefinitionRequestSizeSecurityQueryGroupBy> groupBies,

            string index,

            ImmutableArray<Outputs.DashboardWidgetHostmapDefinitionRequestSizeSecurityQueryMultiCompute> multiComputes,

            Outputs.DashboardWidgetHostmapDefinitionRequestSizeSecurityQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            MultiComputes = multiComputes;
            Search = search;
        }
    }
}