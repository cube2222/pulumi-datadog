// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class MonitorMonitorThresholdWindowsArgs : Pulumi.ResourceArgs
    {
        [Input("recoveryWindow")]
        public Input<string>? RecoveryWindow { get; set; }

        [Input("triggerWindow")]
        public Input<string>? TriggerWindow { get; set; }

        public MonitorMonitorThresholdWindowsArgs()
        {
        }
    }
}
