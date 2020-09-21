// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetScatterplotDefinitionRequestXLogQueryArgs : Pulumi.ResourceArgs
    {
        [Input("compute")]
        public Input<Inputs.DashboardWidgetScatterplotDefinitionRequestXLogQueryComputeArgs>? Compute { get; set; }

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestXLogQueryGroupByArgs>? _groupBies;
        public InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestXLogQueryGroupByArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestXLogQueryGroupByArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        [Input("multiComputes")]
        private InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestXLogQueryMultiComputeArgs>? _multiComputes;
        public InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestXLogQueryMultiComputeArgs> MultiComputes
        {
            get => _multiComputes ?? (_multiComputes = new InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestXLogQueryMultiComputeArgs>());
            set => _multiComputes = value;
        }

        [Input("search")]
        public Input<Inputs.DashboardWidgetScatterplotDefinitionRequestXLogQuerySearchArgs>? Search { get; set; }

        public DashboardWidgetScatterplotDefinitionRequestXLogQueryArgs()
        {
        }
    }
}
