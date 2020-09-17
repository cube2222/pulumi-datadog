// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetQueryValueDefinitionRequestConditionalFormatGetArgs : Pulumi.ResourceArgs
    {
        [Input("comparator", required: true)]
        public Input<string> Comparator { get; set; } = null!;

        [Input("customBgColor")]
        public Input<string>? CustomBgColor { get; set; }

        [Input("customFgColor")]
        public Input<string>? CustomFgColor { get; set; }

        [Input("hideValue")]
        public Input<bool>? HideValue { get; set; }

        [Input("imageUrl")]
        public Input<string>? ImageUrl { get; set; }

        [Input("metric")]
        public Input<string>? Metric { get; set; }

        [Input("palette", required: true)]
        public Input<string> Palette { get; set; } = null!;

        [Input("timeframe")]
        public Input<string>? Timeframe { get; set; }

        [Input("value", required: true)]
        public Input<double> Value { get; set; } = null!;

        public DashboardWidgetGroupDefinitionWidgetQueryValueDefinitionRequestConditionalFormatGetArgs()
        {
        }
    }
}
