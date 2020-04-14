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
    public sealed class DashboardWidgetServiceLevelObjectiveDefinition
    {
        public readonly bool? ShowErrorBudget;
        public readonly string SloId;
        public readonly ImmutableArray<string> TimeWindows;
        public readonly string? Title;
        public readonly string? TitleAlign;
        public readonly string? TitleSize;
        public readonly string ViewMode;
        public readonly string ViewType;

        [OutputConstructor]
        private DashboardWidgetServiceLevelObjectiveDefinition(
            bool? showErrorBudget,

            string sloId,

            ImmutableArray<string> timeWindows,

            string? title,

            string? titleAlign,

            string? titleSize,

            string viewMode,

            string viewType)
        {
            ShowErrorBudget = showErrorBudget;
            SloId = sloId;
            TimeWindows = timeWindows;
            Title = title;
            TitleAlign = titleAlign;
            TitleSize = titleSize;
            ViewMode = viewMode;
            ViewType = viewType;
        }
    }
}
