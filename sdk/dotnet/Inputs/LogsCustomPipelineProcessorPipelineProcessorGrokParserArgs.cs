// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class LogsCustomPipelineProcessorPipelineProcessorGrokParserArgs : Pulumi.ResourceArgs
    {
        [Input("grok", required: true)]
        public Input<Inputs.LogsCustomPipelineProcessorPipelineProcessorGrokParserGrokArgs> Grok { get; set; } = null!;

        [Input("isEnabled")]
        public Input<bool>? IsEnabled { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("samples")]
        private InputList<string>? _samples;
        public InputList<string> Samples
        {
            get => _samples ?? (_samples = new InputList<string>());
            set => _samples = value;
        }

        [Input("source", required: true)]
        public Input<string> Source { get; set; } = null!;

        public LogsCustomPipelineProcessorPipelineProcessorGrokParserArgs()
        {
        }
    }
}
