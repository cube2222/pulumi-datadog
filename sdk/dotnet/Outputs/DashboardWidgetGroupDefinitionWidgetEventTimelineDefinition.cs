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
    public sealed class DashboardWidgetGroupDefinitionWidgetEventTimelineDefinition
    {
        public readonly string Query;
        public readonly string? TagsExecution;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetEventTimelineDefinitionTime? Time;
        /// <summary>
        /// Title of the dashboard.
        /// </summary>
        public readonly string? Title;
        public readonly string? TitleAlign;
        public readonly string? TitleSize;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetEventTimelineDefinition(
            string query,

            string? tagsExecution,

            Outputs.DashboardWidgetGroupDefinitionWidgetEventTimelineDefinitionTime? time,

            string? title,

            string? titleAlign,

            string? titleSize)
        {
            Query = query;
            TagsExecution = tagsExecution;
            Time = time;
            Title = title;
            TitleAlign = titleAlign;
            TitleSize = titleSize;
        }
    }
}
