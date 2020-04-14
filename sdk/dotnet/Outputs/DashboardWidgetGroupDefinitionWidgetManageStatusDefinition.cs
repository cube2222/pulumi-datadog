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
    public sealed class DashboardWidgetGroupDefinitionWidgetManageStatusDefinition
    {
        public readonly string? ColorPreference;
        public readonly int? Count;
        public readonly string? DisplayFormat;
        public readonly bool? HideZeroCounts;
        public readonly string Query;
        public readonly bool? ShowLastTriggered;
        public readonly string? Sort;
        public readonly int? Start;
        public readonly string? SummaryType;
        public readonly string? Title;
        public readonly string? TitleAlign;
        public readonly string? TitleSize;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetManageStatusDefinition(
            string? colorPreference,

            int? count,

            string? displayFormat,

            bool? hideZeroCounts,

            string query,

            bool? showLastTriggered,

            string? sort,

            int? start,

            string? summaryType,

            string? title,

            string? titleAlign,

            string? titleSize)
        {
            ColorPreference = colorPreference;
            Count = count;
            DisplayFormat = displayFormat;
            HideZeroCounts = hideZeroCounts;
            Query = query;
            ShowLastTriggered = showLastTriggered;
            Sort = sort;
            Start = start;
            SummaryType = summaryType;
            Title = title;
            TitleAlign = titleAlign;
            TitleSize = titleSize;
        }
    }
}
