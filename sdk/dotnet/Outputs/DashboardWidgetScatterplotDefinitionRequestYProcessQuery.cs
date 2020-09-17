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
    public sealed class DashboardWidgetScatterplotDefinitionRequestYProcessQuery
    {
        public readonly ImmutableArray<string> FilterBies;
        public readonly int? Limit;
        public readonly string Metric;
        public readonly string? SearchBy;

        [OutputConstructor]
        private DashboardWidgetScatterplotDefinitionRequestYProcessQuery(
            ImmutableArray<string> filterBies,

            int? limit,

            string metric,

            string? searchBy)
        {
            FilterBies = filterBies;
            Limit = limit;
            Metric = metric;
            SearchBy = searchBy;
        }
    }
}
