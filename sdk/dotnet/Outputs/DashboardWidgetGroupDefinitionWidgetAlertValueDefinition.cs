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
    public sealed class DashboardWidgetGroupDefinitionWidgetAlertValueDefinition
    {
        public readonly string AlertId;
        public readonly int? Precision;
        public readonly string? TextAlign;
        public readonly string? Title;
        public readonly string? TitleAlign;
        public readonly string? TitleSize;
        public readonly string? Unit;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetAlertValueDefinition(
            string alertId,

            int? precision,

            string? textAlign,

            string? title,

            string? titleAlign,

            string? titleSize,

            string? unit)
        {
            AlertId = alertId;
            Precision = precision;
            TextAlign = textAlign;
            Title = title;
            TitleAlign = titleAlign;
            TitleSize = titleSize;
            Unit = unit;
        }
    }
}
