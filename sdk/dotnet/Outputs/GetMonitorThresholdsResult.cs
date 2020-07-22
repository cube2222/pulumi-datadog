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
    public sealed class GetMonitorThresholdsResult
    {
        public readonly double Critical;
        public readonly double CriticalRecovery;
        public readonly double Ok;
        public readonly double Unknown;
        public readonly double Warning;
        public readonly double WarningRecovery;

        [OutputConstructor]
        private GetMonitorThresholdsResult(
            double critical,

            double criticalRecovery,

            double ok,

            double unknown,

            double warning,

            double warningRecovery)
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
