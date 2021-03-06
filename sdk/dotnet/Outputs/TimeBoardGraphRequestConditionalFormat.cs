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
    public sealed class TimeBoardGraphRequestConditionalFormat
    {
        public readonly string Comparator;
        public readonly string? CustomBgColor;
        public readonly string? CustomFgColor;
        public readonly string? Palette;
        public readonly string? Value;

        [OutputConstructor]
        private TimeBoardGraphRequestConditionalFormat(
            string comparator,

            string? customBgColor,

            string? customFgColor,

            string? palette,

            string? value)
        {
            Comparator = comparator;
            CustomBgColor = customBgColor;
            CustomFgColor = customFgColor;
            Palette = palette;
            Value = value;
        }
    }
}
