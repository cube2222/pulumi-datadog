// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetTimeseriesDefinitionRequestNetworkQueryGetArgs : Pulumi.ResourceArgs
    {
        [Input("compute")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionRequestNetworkQueryComputeGetArgs>? Compute { get; set; }

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestNetworkQueryGroupByGetArgs>? _groupBies;
        public InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestNetworkQueryGroupByGetArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestNetworkQueryGroupByGetArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        [Input("multiComputes")]
        private InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestNetworkQueryMultiComputeGetArgs>? _multiComputes;
        public InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestNetworkQueryMultiComputeGetArgs> MultiComputes
        {
            get => _multiComputes ?? (_multiComputes = new InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestNetworkQueryMultiComputeGetArgs>());
            set => _multiComputes = value;
        }

        [Input("search")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionRequestNetworkQuerySearchGetArgs>? Search { get; set; }

        public DashboardWidgetTimeseriesDefinitionRequestNetworkQueryGetArgs()
        {
        }
    }
}
