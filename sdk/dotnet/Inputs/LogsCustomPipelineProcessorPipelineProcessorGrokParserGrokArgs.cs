// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class LogsCustomPipelineProcessorPipelineProcessorGrokParserGrokArgs : Pulumi.ResourceArgs
    {
        [Input("matchRules", required: true)]
        public Input<string> MatchRules { get; set; } = null!;

        [Input("supportRules", required: true)]
        public Input<string> SupportRules { get; set; } = null!;

        public LogsCustomPipelineProcessorPipelineProcessorGrokParserGrokArgs()
        {
        }
    }
}
