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
    public sealed class LogsCustomPipelineProcessorPipelineProcessorStatusRemapper
    {
        public readonly bool? IsEnabled;
        public readonly string? Name;
        public readonly ImmutableArray<string> Sources;

        [OutputConstructor]
        private LogsCustomPipelineProcessorPipelineProcessorStatusRemapper(
            bool? isEnabled,

            string? name,

            ImmutableArray<string> sources)
        {
            IsEnabled = isEnabled;
            Name = name;
            Sources = sources;
        }
    }
}
