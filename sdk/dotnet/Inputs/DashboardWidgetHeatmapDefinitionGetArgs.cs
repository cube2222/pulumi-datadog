// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetHeatmapDefinitionGetArgs : Pulumi.ResourceArgs
    {
        [Input("events")]
        private InputList<Inputs.DashboardWidgetHeatmapDefinitionEventGetArgs>? _events;
        public InputList<Inputs.DashboardWidgetHeatmapDefinitionEventGetArgs> Events
        {
            get => _events ?? (_events = new InputList<Inputs.DashboardWidgetHeatmapDefinitionEventGetArgs>());
            set => _events = value;
        }

        [Input("legendSize")]
        public Input<string>? LegendSize { get; set; }

        [Input("requests")]
        private InputList<Inputs.DashboardWidgetHeatmapDefinitionRequestGetArgs>? _requests;
        public InputList<Inputs.DashboardWidgetHeatmapDefinitionRequestGetArgs> Requests
        {
            get => _requests ?? (_requests = new InputList<Inputs.DashboardWidgetHeatmapDefinitionRequestGetArgs>());
            set => _requests = value;
        }

        [Input("showLegend")]
        public Input<bool>? ShowLegend { get; set; }

        [Input("time")]
        public Input<Inputs.DashboardWidgetHeatmapDefinitionTimeGetArgs>? Time { get; set; }

        /// <summary>
        /// Title of the dashboard.
        /// </summary>
        [Input("title")]
        public Input<string>? Title { get; set; }

        [Input("titleAlign")]
        public Input<string>? TitleAlign { get; set; }

        [Input("titleSize")]
        public Input<string>? TitleSize { get; set; }

        [Input("yaxis")]
        public Input<Inputs.DashboardWidgetHeatmapDefinitionYaxisGetArgs>? Yaxis { get; set; }

        public DashboardWidgetHeatmapDefinitionGetArgs()
        {
        }
    }
}
