// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQueryArgs : Pulumi.ResourceArgs
    {
        [Input("compute")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQueryComputeArgs>? Compute { get; set; }

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQueryGroupByArgs>? _groupBies;
        public InputList<Inputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQueryGroupByArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQueryGroupByArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        [Input("multiComputes")]
        private InputList<Inputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQueryMultiComputeArgs>? _multiComputes;
        public InputList<Inputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQueryMultiComputeArgs> MultiComputes
        {
            get => _multiComputes ?? (_multiComputes = new InputList<Inputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQueryMultiComputeArgs>());
            set => _multiComputes = value;
        }

        [Input("search")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQuerySearchArgs>? Search { get; set; }

        public DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmQueryArgs()
        {
        }
    }
}
