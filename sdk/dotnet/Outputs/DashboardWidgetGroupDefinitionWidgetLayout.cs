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
    public sealed class DashboardWidgetGroupDefinitionWidgetLayout
    {
        /// <summary>
        /// The height of the widget.
        /// </summary>
        public readonly double Height;
        /// <summary>
        /// The width of the widget.
        /// </summary>
        public readonly double Width;
        /// <summary>
        /// The position of the widget on the x (horizontal) axis. Should be greater or equal to 0.
        /// </summary>
        public readonly double X;
        /// <summary>
        /// The position of the widget on the y (vertical) axis. Should be greater or equal to 0.
        /// </summary>
        public readonly double Y;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetLayout(
            double height,

            double width,

            double x,

            double y)
        {
            Height = height;
            Width = width;
            X = x;
            Y = y;
        }
    }
}
