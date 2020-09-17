// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetAlertGraphDefinitionGetArgs : Pulumi.ResourceArgs
    {
        [Input("alertId", required: true)]
        public Input<string> AlertId { get; set; } = null!;

        [Input("time")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetAlertGraphDefinitionTimeGetArgs>? Time { get; set; }

        [Input("title")]
        public Input<string>? Title { get; set; }

        [Input("titleAlign")]
        public Input<string>? TitleAlign { get; set; }

        [Input("titleSize")]
        public Input<string>? TitleSize { get; set; }

        [Input("vizType", required: true)]
        public Input<string> VizType { get; set; } = null!;

        public DashboardWidgetGroupDefinitionWidgetAlertGraphDefinitionGetArgs()
        {
        }
    }
}
