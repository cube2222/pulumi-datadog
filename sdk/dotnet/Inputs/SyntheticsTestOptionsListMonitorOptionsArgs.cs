// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class SyntheticsTestOptionsListMonitorOptionsArgs : Pulumi.ResourceArgs
    {
        [Input("renotifyInterval")]
        public Input<int>? RenotifyInterval { get; set; }

        public SyntheticsTestOptionsListMonitorOptionsArgs()
        {
        }
    }
}
