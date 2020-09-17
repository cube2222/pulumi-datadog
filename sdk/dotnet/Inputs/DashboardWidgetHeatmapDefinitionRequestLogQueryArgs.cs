// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetHeatmapDefinitionRequestLogQueryArgs : Pulumi.ResourceArgs
    {
        [Input("compute")]
        public Input<Inputs.DashboardWidgetHeatmapDefinitionRequestLogQueryComputeArgs>? Compute { get; set; }

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetHeatmapDefinitionRequestLogQueryGroupByArgs>? _groupBies;
        public InputList<Inputs.DashboardWidgetHeatmapDefinitionRequestLogQueryGroupByArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetHeatmapDefinitionRequestLogQueryGroupByArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        [Input("multiComputes")]
        private InputList<Inputs.DashboardWidgetHeatmapDefinitionRequestLogQueryMultiComputeArgs>? _multiComputes;
        public InputList<Inputs.DashboardWidgetHeatmapDefinitionRequestLogQueryMultiComputeArgs> MultiComputes
        {
            get => _multiComputes ?? (_multiComputes = new InputList<Inputs.DashboardWidgetHeatmapDefinitionRequestLogQueryMultiComputeArgs>());
            set => _multiComputes = value;
        }

        [Input("search")]
        public Input<Inputs.DashboardWidgetHeatmapDefinitionRequestLogQuerySearchArgs>? Search { get; set; }

        public DashboardWidgetHeatmapDefinitionRequestLogQueryArgs()
        {
        }
    }
}
