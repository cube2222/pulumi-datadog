// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetScatterplotDefinitionRequestXGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The aggregator to use for time aggregation. One of `avg`, `min`, `max`, `sum`, `last`.
        /// - `y`: (Optional) The query used for the Y-Axis. Exactly one nested block is allowed with the following structure:
        /// - `q`: (Required) The metric query to use in the widget.
        /// - `xaxis`: (Optional) Nested block describing the X-Axis Controls. The structure of this block is described below
        /// - `yaxis`: (Optional) Nested block describing the Y-Axis Controls. The structure of this block is described below
        /// </summary>
        [Input("aggregator")]
        public Input<string>? Aggregator { get; set; }

        [Input("apmQuery")]
        public Input<Inputs.DashboardWidgetScatterplotDefinitionRequestXApmQueryGetArgs>? ApmQuery { get; set; }

        [Input("logQuery")]
        public Input<Inputs.DashboardWidgetScatterplotDefinitionRequestXLogQueryGetArgs>? LogQuery { get; set; }

        [Input("processQuery")]
        public Input<Inputs.DashboardWidgetScatterplotDefinitionRequestXProcessQueryGetArgs>? ProcessQuery { get; set; }

        [Input("q")]
        public Input<string>? Q { get; set; }

        public DashboardWidgetScatterplotDefinitionRequestXGetArgs()
        {
        }
    }
}
