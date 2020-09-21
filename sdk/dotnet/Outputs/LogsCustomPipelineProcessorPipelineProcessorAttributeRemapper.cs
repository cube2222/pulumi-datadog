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
    public sealed class LogsCustomPipelineProcessorPipelineProcessorAttributeRemapper
    {
        public readonly bool? IsEnabled;
        public readonly string? Name;
        public readonly bool? OverrideOnConflict;
        public readonly bool? PreserveSource;
        public readonly string SourceType;
        public readonly ImmutableArray<string> Sources;
        public readonly string Target;
        public readonly string TargetType;

        [OutputConstructor]
        private LogsCustomPipelineProcessorPipelineProcessorAttributeRemapper(
            bool? isEnabled,

            string? name,

            bool? overrideOnConflict,

            bool? preserveSource,

            string sourceType,

            ImmutableArray<string> sources,

            string target,

            string targetType)
        {
            IsEnabled = isEnabled;
            Name = name;
            OverrideOnConflict = overrideOnConflict;
            PreserveSource = preserveSource;
            SourceType = sourceType;
            Sources = sources;
            Target = target;
            TargetType = targetType;
        }
    }
}
