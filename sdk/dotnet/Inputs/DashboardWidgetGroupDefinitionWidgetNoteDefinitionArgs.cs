// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetNoteDefinitionArgs : Pulumi.ResourceArgs
    {
        [Input("backgroundColor")]
        public Input<string>? BackgroundColor { get; set; }

        [Input("content", required: true)]
        public Input<string> Content { get; set; } = null!;

        [Input("fontSize")]
        public Input<string>? FontSize { get; set; }

        [Input("showTick")]
        public Input<bool>? ShowTick { get; set; }

        [Input("textAlign")]
        public Input<string>? TextAlign { get; set; }

        [Input("tickEdge")]
        public Input<string>? TickEdge { get; set; }

        [Input("tickPos")]
        public Input<string>? TickPos { get; set; }

        public DashboardWidgetGroupDefinitionWidgetNoteDefinitionArgs()
        {
        }
    }
}
