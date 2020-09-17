// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetChangeDefinitionRequestGetArgs : Pulumi.ResourceArgs
    {
        [Input("apmQuery")]
        public Input<Inputs.DashboardWidgetChangeDefinitionRequestApmQueryGetArgs>? ApmQuery { get; set; }

        [Input("changeType")]
        public Input<string>? ChangeType { get; set; }

        [Input("compareTo")]
        public Input<string>? CompareTo { get; set; }

        [Input("increaseGood")]
        public Input<bool>? IncreaseGood { get; set; }

        [Input("logQuery")]
        public Input<Inputs.DashboardWidgetChangeDefinitionRequestLogQueryGetArgs>? LogQuery { get; set; }

        [Input("orderBy")]
        public Input<string>? OrderBy { get; set; }

        [Input("orderDir")]
        public Input<string>? OrderDir { get; set; }

        [Input("processQuery")]
        public Input<Inputs.DashboardWidgetChangeDefinitionRequestProcessQueryGetArgs>? ProcessQuery { get; set; }

        [Input("q")]
        public Input<string>? Q { get; set; }

        [Input("rumQuery")]
        public Input<Inputs.DashboardWidgetChangeDefinitionRequestRumQueryGetArgs>? RumQuery { get; set; }

        [Input("securityQuery")]
        public Input<Inputs.DashboardWidgetChangeDefinitionRequestSecurityQueryGetArgs>? SecurityQuery { get; set; }

        [Input("showPresent")]
        public Input<bool>? ShowPresent { get; set; }

        public DashboardWidgetChangeDefinitionRequestGetArgs()
        {
        }
    }
}
