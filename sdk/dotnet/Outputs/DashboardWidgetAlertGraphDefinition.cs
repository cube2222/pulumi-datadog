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
    public sealed class DashboardWidgetAlertGraphDefinition
    {
        public readonly string AlertId;
        public readonly Outputs.DashboardWidgetAlertGraphDefinitionTime? Time;
        /// <summary>
        /// Title of the dashboard.
        /// </summary>
        public readonly string? Title;
        public readonly string? TitleAlign;
        public readonly string? TitleSize;
        public readonly string VizType;

        [OutputConstructor]
        private DashboardWidgetAlertGraphDefinition(
            string alertId,

            Outputs.DashboardWidgetAlertGraphDefinitionTime? time,

            string? title,

            string? titleAlign,

            string? titleSize,

            string vizType)
        {
            AlertId = alertId;
            Time = time;
            Title = title;
            TitleAlign = titleAlign;
            TitleSize = titleSize;
            VizType = vizType;
        }
    }
}
