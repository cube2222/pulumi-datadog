// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetTimeseriesDefinitionRequestStyleGetArgs : Pulumi.ResourceArgs
    {
        [Input("lineType")]
        public Input<string>? LineType { get; set; }

        [Input("lineWidth")]
        public Input<string>? LineWidth { get; set; }

        [Input("palette")]
        public Input<string>? Palette { get; set; }

        public DashboardWidgetTimeseriesDefinitionRequestStyleGetArgs()
        {
        }
    }
}
