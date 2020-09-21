// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetToplistDefinitionRequestApmQueryArgs : Pulumi.ResourceArgs
    {
        [Input("compute")]
        public Input<Inputs.DashboardWidgetToplistDefinitionRequestApmQueryComputeArgs>? Compute { get; set; }

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetToplistDefinitionRequestApmQueryGroupByArgs>? _groupBies;
        public InputList<Inputs.DashboardWidgetToplistDefinitionRequestApmQueryGroupByArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetToplistDefinitionRequestApmQueryGroupByArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        [Input("multiComputes")]
        private InputList<Inputs.DashboardWidgetToplistDefinitionRequestApmQueryMultiComputeArgs>? _multiComputes;
        public InputList<Inputs.DashboardWidgetToplistDefinitionRequestApmQueryMultiComputeArgs> MultiComputes
        {
            get => _multiComputes ?? (_multiComputes = new InputList<Inputs.DashboardWidgetToplistDefinitionRequestApmQueryMultiComputeArgs>());
            set => _multiComputes = value;
        }

        [Input("search")]
        public Input<Inputs.DashboardWidgetToplistDefinitionRequestApmQuerySearchArgs>? Search { get; set; }

        public DashboardWidgetToplistDefinitionRequestApmQueryArgs()
        {
        }
    }
}
