// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class LogsArchiveGcsGetArgs : Pulumi.ResourceArgs
    {
        [Input("bucket", required: true)]
        public Input<string> Bucket { get; set; } = null!;

        [Input("clientEmail", required: true)]
        public Input<string> ClientEmail { get; set; } = null!;

        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        [Input("projectId", required: true)]
        public Input<string> ProjectId { get; set; } = null!;

        public LogsArchiveGcsGetArgs()
        {
        }
    }
}
