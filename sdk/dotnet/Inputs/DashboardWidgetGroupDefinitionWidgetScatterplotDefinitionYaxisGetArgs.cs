// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionYaxisGetArgs : Pulumi.ResourceArgs
    {
        [Input("includeZero")]
        public Input<bool>? IncludeZero { get; set; }

        [Input("label")]
        public Input<string>? Label { get; set; }

        [Input("max")]
        public Input<string>? Max { get; set; }

        [Input("min")]
        public Input<string>? Min { get; set; }

        [Input("scale")]
        public Input<string>? Scale { get; set; }

        public DashboardWidgetGroupDefinitionWidgetScatterplotDefinitionYaxisGetArgs()
        {
        }
    }
}
