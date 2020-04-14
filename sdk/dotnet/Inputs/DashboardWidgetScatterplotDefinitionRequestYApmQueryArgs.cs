// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetScatterplotDefinitionRequestYApmQueryArgs : Pulumi.ResourceArgs
    {
        [Input("compute", required: true)]
        public Input<Inputs.DashboardWidgetScatterplotDefinitionRequestYApmQueryComputeArgs> Compute { get; set; } = null!;

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestYApmQueryGroupByArgs>? _groupBies;
        public InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestYApmQueryGroupByArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestYApmQueryGroupByArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        [Input("search")]
        public Input<Inputs.DashboardWidgetScatterplotDefinitionRequestYApmQuerySearchArgs>? Search { get; set; }

        public DashboardWidgetScatterplotDefinitionRequestYApmQueryArgs()
        {
        }
    }
}
