// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class LogsCustomPipelineProcessorCategoryProcessorCategoryFilterGetArgs : Pulumi.ResourceArgs
    {
        [Input("query", required: true)]
        public Input<string> Query { get; set; } = null!;

        public LogsCustomPipelineProcessorCategoryProcessorCategoryFilterGetArgs()
        {
        }
    }
}
