// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class LogsCustomPipelineProcessorPipelineProcessorTraceIdRemapperArgs : Pulumi.ResourceArgs
    {
        [Input("isEnabled")]
        public Input<bool>? IsEnabled { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("sources", required: true)]
        private InputList<string>? _sources;
        public InputList<string> Sources
        {
            get => _sources ?? (_sources = new InputList<string>());
            set => _sources = value;
        }

        public LogsCustomPipelineProcessorPipelineProcessorTraceIdRemapperArgs()
        {
        }
    }
}
