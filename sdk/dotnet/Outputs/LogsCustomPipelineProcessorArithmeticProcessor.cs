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
    public sealed class LogsCustomPipelineProcessorArithmeticProcessor
    {
        /// <summary>
        /// Arithmetic operation between one or more log attributes.
        /// </summary>
        public readonly string Expression;
        /// <summary>
        /// If the processor is enabled or not.
        /// </summary>
        public readonly bool? IsEnabled;
        /// <summary>
        /// If it replaces all missing attributes of `template` by an empty string.
        /// * trace_id_remapper
        /// </summary>
        public readonly bool? IsReplaceMissing;
        /// <summary>
        /// Name of the processor
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Name of the parent attribute that contains all the extracted details from the sources.
        /// </summary>
        public readonly string Target;

        [OutputConstructor]
        private LogsCustomPipelineProcessorArithmeticProcessor(
            string expression,

            bool? isEnabled,

            bool? isReplaceMissing,

            string? name,

            string target)
        {
            Expression = expression;
            IsEnabled = isEnabled;
            IsReplaceMissing = isReplaceMissing;
            Name = name;
            Target = target;
        }
    }
}
