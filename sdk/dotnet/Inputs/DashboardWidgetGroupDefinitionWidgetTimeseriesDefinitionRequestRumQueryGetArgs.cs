// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestRumQueryGetArgs : Pulumi.ResourceArgs
    {
        [Input("compute")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestRumQueryComputeGetArgs>? Compute { get; set; }

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestRumQueryGroupByGetArgs>? _groupBies;
        public InputList<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestRumQueryGroupByGetArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestRumQueryGroupByGetArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        [Input("multiComputes")]
        private InputList<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestRumQueryMultiComputeGetArgs>? _multiComputes;
        public InputList<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestRumQueryMultiComputeGetArgs> MultiComputes
        {
            get => _multiComputes ?? (_multiComputes = new InputList<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestRumQueryMultiComputeGetArgs>());
            set => _multiComputes = value;
        }

        [Input("search")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestRumQuerySearchGetArgs>? Search { get; set; }

        public DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestRumQueryGetArgs()
        {
        }
    }
}
