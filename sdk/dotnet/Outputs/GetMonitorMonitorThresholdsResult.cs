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
    public sealed class GetMonitorMonitorThresholdsResult
    {
        public readonly string Critical;
        public readonly string CriticalRecovery;
        public readonly string Ok;
        public readonly string Unknown;
        public readonly string Warning;
        public readonly string WarningRecovery;

        [OutputConstructor]
        private GetMonitorMonitorThresholdsResult(
            string critical,

            string criticalRecovery,

            string ok,

            string unknown,

            string warning,

            string warningRecovery)
        {
            Critical = critical;
            CriticalRecovery = criticalRecovery;
            Ok = ok;
            Unknown = unknown;
            Warning = warning;
            WarningRecovery = warningRecovery;
        }
    }
}
