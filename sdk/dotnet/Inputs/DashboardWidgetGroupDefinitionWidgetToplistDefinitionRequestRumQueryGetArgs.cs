// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestRumQueryGetArgs : Pulumi.ResourceArgs
    {
        [Input("compute")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestRumQueryComputeGetArgs>? Compute { get; set; }

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestRumQueryGroupByGetArgs>? _groupBies;
        public InputList<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestRumQueryGroupByGetArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestRumQueryGroupByGetArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        [Input("multiComputes")]
        private InputList<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestRumQueryMultiComputeGetArgs>? _multiComputes;
        public InputList<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestRumQueryMultiComputeGetArgs> MultiComputes
        {
            get => _multiComputes ?? (_multiComputes = new InputList<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestRumQueryMultiComputeGetArgs>());
            set => _multiComputes = value;
        }

        [Input("search")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestRumQuerySearchGetArgs>? Search { get; set; }

        public DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestRumQueryGetArgs()
        {
        }
    }
}
