// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Outputs
{

    [OutputType]
    public sealed class MonitorThresholdWindows
    {
        public readonly string? RecoveryWindow;
        /// <summary>
        /// describes how long a metric must be anomalous before an alert triggers.
        /// </summary>
        public readonly string? TriggerWindow;

        [OutputConstructor]
        private MonitorThresholdWindows(
            string? recoveryWindow,

            string? triggerWindow)
        {
            RecoveryWindow = recoveryWindow;
            TriggerWindow = triggerWindow;
        }
    }
}
