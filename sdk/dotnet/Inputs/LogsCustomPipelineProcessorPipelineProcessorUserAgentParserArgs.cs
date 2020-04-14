// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class LogsCustomPipelineProcessorPipelineProcessorUserAgentParserArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// If the processor is enabled or not.
        /// </summary>
        [Input("isEnabled")]
        public Input<bool>? IsEnabled { get; set; }

        /// <summary>
        /// If the source attribute is URL encoded or not.
        /// </summary>
        [Input("isEncoded")]
        public Input<bool>? IsEncoded { get; set; }

        /// <summary>
        /// Name of the processor
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("sources", required: true)]
        private InputList<string>? _sources;

        /// <summary>
        /// List of source attributes.
        /// </summary>
        public InputList<string> Sources
        {
            get => _sources ?? (_sources = new InputList<string>());
            set => _sources = value;
        }

        /// <summary>
        /// Name of the parent attribute that contains all the extracted details from the sources.
        /// </summary>
        [Input("target", required: true)]
        public Input<string> Target { get; set; } = null!;

        public LogsCustomPipelineProcessorPipelineProcessorUserAgentParserArgs()
        {
        }
    }
}
