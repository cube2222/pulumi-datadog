// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetImageDefinitionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The margins to use around the image. Either "small" or "large".
        /// - `log_stream_definition`: The definition for a Log Stream widget. Exactly one nested block is allowed with the following structure:
        /// </summary>
        [Input("margin")]
        public Input<string>? Margin { get; set; }

        /// <summary>
        /// The preferred method to adapt the dimensions of the image to those of the widget. One of "center" (center the image in the tile), "zoom" (zoom the image to cover the whole tile) or "fit" (fit the image dimensions to those of the tile).
        /// </summary>
        [Input("sizing")]
        public Input<string>? Sizing { get; set; }

        /// <summary>
        /// Read only field - The URL of the dashboard.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public DashboardWidgetGroupDefinitionWidgetImageDefinitionArgs()
        {
        }
    }
}
