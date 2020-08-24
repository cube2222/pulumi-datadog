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
    public sealed class DashboardWidgetGroupDefinitionWidgetEventStreamDefinition
    {
        /// <summary>
        /// The size of the events in the widget. Either "s" (small, title only) or "l" (large, full event).
        /// - `title`: (Optional) The title of the widget.
        /// - `title_size`: (Optional) The size of the widget's title. Default is 16.
        /// - `title_align`: (Optional) The alignment of the widget's title. One of "left", "center", or "right".
        /// - `time`: (Optional) Nested block describing the timeframe to use when displaying the widget. The structure of this block is described below.
        /// - `tags_execution`: (Optional) The execution method for multi-value filters. Can be either "and" or "or".
        /// - `event_timeline_definition`: The definition for a Event Timeline widget. Exactly one nested block is allowed with the following structure:
        /// - `query`: (Required) The query to use in the widget.
        /// - `title`: (Optional) The title of the widget.
        /// - `title_size`: (Optional) The size of the widget's title. Default is 16.
        /// - `title_align`: (Optional) The alignment of the widget's title. One of "left", "center", or "right".
        /// - `time`: (Optional) Nested block describing the timeframe to use when displaying the widget. The structure of this block is described below.
        /// - `tags_execution`: (Optional) The execution method for multi-value filters. Can be either "and" or "or".
        /// - `free_text_definition`: The definition for a Free Text. Exactly one nested block is allowed with the following structure:
        /// </summary>
        public readonly string? EventSize;
        public readonly string Query;
        public readonly string? TagsExecution;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetEventStreamDefinitionTime? Time;
        /// <summary>
        /// Title of the dashboard.
        /// </summary>
        public readonly string? Title;
        public readonly string? TitleAlign;
        public readonly string? TitleSize;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetEventStreamDefinition(
            string? eventSize,

            string query,

            string? tagsExecution,

            Outputs.DashboardWidgetGroupDefinitionWidgetEventStreamDefinitionTime? time,

            string? title,

            string? titleAlign,

            string? titleSize)
        {
            EventSize = eventSize;
            Query = query;
            TagsExecution = tagsExecution;
            Time = time;
            Title = title;
            TitleAlign = titleAlign;
            TitleSize = titleSize;
        }
    }
}
