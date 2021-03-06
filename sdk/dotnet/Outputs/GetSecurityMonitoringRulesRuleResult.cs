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
    public sealed class GetSecurityMonitoringRulesRuleResult
    {
        public readonly ImmutableArray<Outputs.GetSecurityMonitoringRulesRuleCaseResult> Cases;
        public readonly bool? Enabled;
        public readonly string Message;
        public readonly string Name;
        public readonly Outputs.GetSecurityMonitoringRulesRuleOptionsResult? Options;
        public readonly ImmutableArray<Outputs.GetSecurityMonitoringRulesRuleQueryResult> Queries;
        public readonly ImmutableArray<string> Tags;

        [OutputConstructor]
        private GetSecurityMonitoringRulesRuleResult(
            ImmutableArray<Outputs.GetSecurityMonitoringRulesRuleCaseResult> cases,

            bool? enabled,

            string message,

            string name,

            Outputs.GetSecurityMonitoringRulesRuleOptionsResult? options,

            ImmutableArray<Outputs.GetSecurityMonitoringRulesRuleQueryResult> queries,

            ImmutableArray<string> tags)
        {
            Cases = cases;
            Enabled = enabled;
            Message = message;
            Name = name;
            Options = options;
            Queries = queries;
            Tags = tags;
        }
    }
}
