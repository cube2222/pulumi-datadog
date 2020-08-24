// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetChangeDefinitionRequestGetArgs : Pulumi.ResourceArgs
    {
        [Input("apmQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetChangeDefinitionRequestApmQueryGetArgs>? ApmQuery { get; set; }

        [Input("changeType")]
        public Input<string>? ChangeType { get; set; }

        /// <summary>
        /// Choose from when to compare current data to. One of "hour_before", "day_before", "week_before" or "month_before".
        /// </summary>
        [Input("compareTo")]
        public Input<string>? CompareTo { get; set; }

        /// <summary>
        /// Boolean indicating whether an increase in the value is good (thus displayed in green) or not (thus displayed in red).
        /// </summary>
        [Input("increaseGood")]
        public Input<bool>? IncreaseGood { get; set; }

        [Input("logQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetChangeDefinitionRequestLogQueryGetArgs>? LogQuery { get; set; }

        /// <summary>
        /// One of "change", "name", "present" (present value) or "past" (past value).
        /// </summary>
        [Input("orderBy")]
        public Input<string>? OrderBy { get; set; }

        /// <summary>
        /// Either "asc" (ascending) or "desc" (descending).
        /// </summary>
        [Input("orderDir")]
        public Input<string>? OrderDir { get; set; }

        [Input("processQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetChangeDefinitionRequestProcessQueryGetArgs>? ProcessQuery { get; set; }

        [Input("q")]
        public Input<string>? Q { get; set; }

        /// <summary>
        /// If set to "true", displays current value.
        /// - `title`: (Optional) The title of the widget.
        /// - `title_size`: (Optional) The size of the widget's title. Default is 16.
        /// - `title_align`: (Optional) The alignment of the widget's title. One of "left", "center", or "right".
        /// - `time`: (Optional) Nested block describing the timeframe to use when displaying the widget. The structure of this block is described below.
        /// - `check_status_definition`: The definition for a Check Status widget. Exactly one nested block is allowed with the following structure:
        /// </summary>
        [Input("showPresent")]
        public Input<bool>? ShowPresent { get; set; }

        public DashboardWidgetGroupDefinitionWidgetChangeDefinitionRequestGetArgs()
        {
        }
    }
}
