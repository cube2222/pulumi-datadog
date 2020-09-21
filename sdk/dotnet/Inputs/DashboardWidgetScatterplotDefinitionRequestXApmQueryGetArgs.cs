// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetScatterplotDefinitionRequestXApmQueryGetArgs : Pulumi.ResourceArgs
    {
        [Input("compute")]
        public Input<Inputs.DashboardWidgetScatterplotDefinitionRequestXApmQueryComputeGetArgs>? Compute { get; set; }

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestXApmQueryGroupByGetArgs>? _groupBies;
        public InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestXApmQueryGroupByGetArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestXApmQueryGroupByGetArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        [Input("multiComputes")]
        private InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestXApmQueryMultiComputeGetArgs>? _multiComputes;
        public InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestXApmQueryMultiComputeGetArgs> MultiComputes
        {
            get => _multiComputes ?? (_multiComputes = new InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestXApmQueryMultiComputeGetArgs>());
            set => _multiComputes = value;
        }

        [Input("search")]
        public Input<Inputs.DashboardWidgetScatterplotDefinitionRequestXApmQuerySearchGetArgs>? Search { get; set; }

        public DashboardWidgetScatterplotDefinitionRequestXApmQueryGetArgs()
        {
        }
    }
}
