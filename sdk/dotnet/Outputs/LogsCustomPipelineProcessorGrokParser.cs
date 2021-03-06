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
    public sealed class LogsCustomPipelineProcessorGrokParser
    {
        public readonly Outputs.LogsCustomPipelineProcessorGrokParserGrok Grok;
        public readonly bool? IsEnabled;
        public readonly string? Name;
        public readonly ImmutableArray<string> Samples;
        public readonly string Source;

        [OutputConstructor]
        private LogsCustomPipelineProcessorGrokParser(
            Outputs.LogsCustomPipelineProcessorGrokParserGrok grok,

            bool? isEnabled,

            string? name,

            ImmutableArray<string> samples,

            string source)
        {
            Grok = grok;
            IsEnabled = isEnabled;
            Name = name;
            Samples = samples;
            Source = source;
        }
    }
}
