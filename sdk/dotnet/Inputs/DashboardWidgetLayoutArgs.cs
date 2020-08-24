// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetLayoutArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The height of the widget.
        /// </summary>
        [Input("height", required: true)]
        public Input<double> Height { get; set; } = null!;

        /// <summary>
        /// The width of the widget.
        /// </summary>
        [Input("width", required: true)]
        public Input<double> Width { get; set; } = null!;

        /// <summary>
        /// The position of the widget on the x (horizontal) axis. Should be greater or equal to 0.
        /// </summary>
        [Input("x", required: true)]
        public Input<double> X { get; set; } = null!;

        /// <summary>
        /// The position of the widget on the y (vertical) axis. Should be greater or equal to 0.
        /// </summary>
        [Input("y", required: true)]
        public Input<double> Y { get; set; } = null!;

        public DashboardWidgetLayoutArgs()
        {
        }
    }
}
