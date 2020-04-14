// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class LogsCustomPipelineProcessorStringBuilderProcessorArgs : Pulumi.ResourceArgs
    {
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

        /// <summary>
        /// The formula with one or more attributes and raw text.
        /// </summary>
        [Input("template", required: true)]
        public Input<string> Template { get; set; } = null!;

        public LogsCustomPipelineProcessorStringBuilderProcessorArgs()
        {
        }
    }
}
