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
    public sealed class LogsCustomPipelineProcessorGrokParserGrok
    {
        /// <summary>
        /// Match rules for your grok parser.
        /// </summary>
        public readonly string MatchRules;
        /// <summary>
        /// Support rules for your grok parser.
        /// </summary>
        public readonly string SupportRules;

        [OutputConstructor]
        private LogsCustomPipelineProcessorGrokParserGrok(
            string matchRules,

            string supportRules)
        {
            MatchRules = matchRules;
            SupportRules = supportRules;
        }
    }
}
