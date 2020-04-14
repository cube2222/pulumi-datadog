// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class LogsCustomPipelineProcessorArithmeticProcessorArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Arithmetic operation between one or more log attributes.
        /// </summary>
        [Input("expression", required: true)]
        public Input<string> Expression { get; set; } = null!;

        /// <summary>
        /// If the processor is enabled or not.
        /// </summary>
        [Input("isEnabled")]
        public Input<bool>? IsEnabled { get; set; }

        /// <summary>
        /// If it replaces all missing attributes of `template` by an empty string.
        /// * trace_id_remapper
        /// </summary>
        [Input("isReplaceMissing")]
        public Input<bool>? IsReplaceMissing { get; set; }

        /// <summary>
        /// Name of the processor
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Name of the parent attribute that contains all the extracted details from the sources.
        /// </summary>
        [Input("target", required: true)]
        public Input<string> Target { get; set; } = null!;

        public LogsCustomPipelineProcessorArithmeticProcessorArgs()
        {
        }
    }
}
