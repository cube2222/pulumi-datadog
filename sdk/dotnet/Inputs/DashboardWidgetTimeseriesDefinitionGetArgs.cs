// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetTimeseriesDefinitionGetArgs : Pulumi.ResourceArgs
    {
        [Input("customLinks")]
        private InputList<Inputs.DashboardWidgetTimeseriesDefinitionCustomLinkGetArgs>? _customLinks;
        public InputList<Inputs.DashboardWidgetTimeseriesDefinitionCustomLinkGetArgs> CustomLinks
        {
            get => _customLinks ?? (_customLinks = new InputList<Inputs.DashboardWidgetTimeseriesDefinitionCustomLinkGetArgs>());
            set => _customLinks = value;
        }

        [Input("events")]
        private InputList<Inputs.DashboardWidgetTimeseriesDefinitionEventGetArgs>? _events;
        public InputList<Inputs.DashboardWidgetTimeseriesDefinitionEventGetArgs> Events
        {
            get => _events ?? (_events = new InputList<Inputs.DashboardWidgetTimeseriesDefinitionEventGetArgs>());
            set => _events = value;
        }

        [Input("legendSize")]
        public Input<string>? LegendSize { get; set; }

        [Input("markers")]
        private InputList<Inputs.DashboardWidgetTimeseriesDefinitionMarkerGetArgs>? _markers;
        public InputList<Inputs.DashboardWidgetTimeseriesDefinitionMarkerGetArgs> Markers
        {
            get => _markers ?? (_markers = new InputList<Inputs.DashboardWidgetTimeseriesDefinitionMarkerGetArgs>());
            set => _markers = value;
        }

        [Input("requests")]
        private InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestGetArgs>? _requests;
        public InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestGetArgs> Requests
        {
            get => _requests ?? (_requests = new InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestGetArgs>());
            set => _requests = value;
        }

        [Input("rightYaxis")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionRightYaxisGetArgs>? RightYaxis { get; set; }

        [Input("showLegend")]
        public Input<bool>? ShowLegend { get; set; }

        [Input("time")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionTimeGetArgs>? Time { get; set; }

        [Input("title")]
        public Input<string>? Title { get; set; }

        [Input("titleAlign")]
        public Input<string>? TitleAlign { get; set; }

        [Input("titleSize")]
        public Input<string>? TitleSize { get; set; }

        [Input("yaxis")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionYaxisGetArgs>? Yaxis { get; set; }

        public DashboardWidgetTimeseriesDefinitionGetArgs()
        {
        }
    }
}
