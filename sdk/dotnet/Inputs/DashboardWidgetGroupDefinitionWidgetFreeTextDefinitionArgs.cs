// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetFreeTextDefinitionArgs : Pulumi.ResourceArgs
    {
        [Input("color")]
        public Input<string>? Color { get; set; }

        [Input("fontSize")]
        public Input<string>? FontSize { get; set; }

        [Input("text", required: true)]
        public Input<string> Text { get; set; } = null!;

        [Input("textAlign")]
        public Input<string>? TextAlign { get; set; }

        public DashboardWidgetGroupDefinitionWidgetFreeTextDefinitionArgs()
        {
        }
    }
}
