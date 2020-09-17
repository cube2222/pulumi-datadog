// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeApmQueryArgs : Pulumi.ResourceArgs
    {
        [Input("compute")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeApmQueryComputeArgs>? Compute { get; set; }

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeApmQueryGroupByArgs>? _groupBies;
        public InputList<Inputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeApmQueryGroupByArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeApmQueryGroupByArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        [Input("multiComputes")]
        private InputList<Inputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeApmQueryMultiComputeArgs>? _multiComputes;
        public InputList<Inputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeApmQueryMultiComputeArgs> MultiComputes
        {
            get => _multiComputes ?? (_multiComputes = new InputList<Inputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeApmQueryMultiComputeArgs>());
            set => _multiComputes = value;
        }

        [Input("search")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeApmQuerySearchArgs>? Search { get; set; }

        public DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestSizeApmQueryArgs()
        {
        }
    }
}
