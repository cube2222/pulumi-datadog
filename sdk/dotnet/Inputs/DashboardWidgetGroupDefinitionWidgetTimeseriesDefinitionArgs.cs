// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionArgs : Pulumi.ResourceArgs
    {
        [Input("events")]
        private InputList<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionEventArgs>? _events;
        public InputList<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionEventArgs> Events
        {
            get => _events ?? (_events = new InputList<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionEventArgs>());
            set => _events = value;
        }

        [Input("legendSize")]
        public Input<string>? LegendSize { get; set; }

        [Input("markers")]
        private InputList<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionMarkerArgs>? _markers;
        public InputList<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionMarkerArgs> Markers
        {
            get => _markers ?? (_markers = new InputList<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionMarkerArgs>());
            set => _markers = value;
        }

        [Input("requests")]
        private InputList<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestArgs>? _requests;
        public InputList<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestArgs> Requests
        {
            get => _requests ?? (_requests = new InputList<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestArgs>());
            set => _requests = value;
        }

        [Input("showLegend")]
        public Input<bool>? ShowLegend { get; set; }

        [Input("time")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionTimeArgs>? Time { get; set; }

        [Input("title")]
        public Input<string>? Title { get; set; }

        [Input("titleAlign")]
        public Input<string>? TitleAlign { get; set; }

        [Input("titleSize")]
        public Input<string>? TitleSize { get; set; }

        [Input("yaxis")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionYaxisArgs>? Yaxis { get; set; }

        public DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionArgs()
        {
        }
    }
}