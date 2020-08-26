// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionYaxisGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Always include zero or fit the axis to the data range.
        /// </summary>
        [Input("includeZero")]
        public Input<bool>? IncludeZero { get; set; }

        /// <summary>
        /// The label of the axis to display on the graph.
        /// </summary>
        [Input("label")]
        public Input<string>? Label { get; set; }

        /// <summary>
        /// Specify the minimum value to show on y-axis.
        /// </summary>
        [Input("max")]
        public Input<string>? Max { get; set; }

        /// <summary>
        /// Specify the minimum value to show on y-axis.
        /// </summary>
        [Input("min")]
        public Input<string>? Min { get; set; }

        /// <summary>
        /// Specifies the scale type. One of "linear", "log", "pow", "sqrt".
        /// </summary>
        [Input("scale")]
        public Input<string>? Scale { get; set; }

        public DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionYaxisGetArgs()
        {
        }
    }
}
