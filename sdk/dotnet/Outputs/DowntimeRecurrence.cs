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
    public sealed class DowntimeRecurrence
    {
        public readonly int? Period;
        public readonly string? Rrule;
        public readonly string Type;
        public readonly int? UntilDate;
        public readonly int? UntilOccurrences;
        public readonly ImmutableArray<string> WeekDays;

        [OutputConstructor]
        private DowntimeRecurrence(
            int? period,

            string? rrule,

            string type,

            int? untilDate,

            int? untilOccurrences,

            ImmutableArray<string> weekDays)
        {
            Period = period;
            Rrule = rrule;
            Type = type;
            UntilDate = untilDate;
            UntilOccurrences = untilOccurrences;
            WeekDays = weekDays;
        }
    }
}
