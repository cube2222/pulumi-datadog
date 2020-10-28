// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetHeatmapDefinitionArgs : Pulumi.ResourceArgs
    {
        [Input("customLinks")]
        private InputList<Inputs.DashboardWidgetHeatmapDefinitionCustomLinkArgs>? _customLinks;
        public InputList<Inputs.DashboardWidgetHeatmapDefinitionCustomLinkArgs> CustomLinks
        {
            get => _customLinks ?? (_customLinks = new InputList<Inputs.DashboardWidgetHeatmapDefinitionCustomLinkArgs>());
            set => _customLinks = value;
        }

        [Input("events")]
        private InputList<Inputs.DashboardWidgetHeatmapDefinitionEventArgs>? _events;
        public InputList<Inputs.DashboardWidgetHeatmapDefinitionEventArgs> Events
        {
            get => _events ?? (_events = new InputList<Inputs.DashboardWidgetHeatmapDefinitionEventArgs>());
            set => _events = value;
        }

        [Input("legendSize")]
        public Input<string>? LegendSize { get; set; }

        [Input("requests")]
        private InputList<Inputs.DashboardWidgetHeatmapDefinitionRequestArgs>? _requests;
        public InputList<Inputs.DashboardWidgetHeatmapDefinitionRequestArgs> Requests
        {
            get => _requests ?? (_requests = new InputList<Inputs.DashboardWidgetHeatmapDefinitionRequestArgs>());
            set => _requests = value;
        }

        [Input("showLegend")]
        public Input<bool>? ShowLegend { get; set; }

        [Input("time")]
        public Input<Inputs.DashboardWidgetHeatmapDefinitionTimeArgs>? Time { get; set; }

        [Input("title")]
        public Input<string>? Title { get; set; }

        [Input("titleAlign")]
        public Input<string>? TitleAlign { get; set; }

        [Input("titleSize")]
        public Input<string>? TitleSize { get; set; }

        [Input("yaxis")]
        public Input<Inputs.DashboardWidgetHeatmapDefinitionYaxisArgs>? Yaxis { get; set; }

        public DashboardWidgetHeatmapDefinitionArgs()
        {
        }
    }
}
