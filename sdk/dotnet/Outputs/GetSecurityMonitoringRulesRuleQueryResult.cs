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
    public sealed class GetSecurityMonitoringRulesRuleQueryResult
    {
        public readonly string? Aggregation;
        public readonly ImmutableArray<string> DistinctFields;
        public readonly ImmutableArray<string> GroupByFields;
        public readonly string? Metric;
        public readonly string? Name;
        public readonly string Query;

        [OutputConstructor]
        private GetSecurityMonitoringRulesRuleQueryResult(
            string? aggregation,

            ImmutableArray<string> distinctFields,

            ImmutableArray<string> groupByFields,

            string? metric,

            string? name,

            string query)
        {
            Aggregation = aggregation;
            DistinctFields = distinctFields;
            GroupByFields = groupByFields;
            Metric = metric;
            Name = name;
            Query = query;
        }
    }
}