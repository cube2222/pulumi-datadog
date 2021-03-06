// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetHostmapDefinitionRequestSizeApmQueryArgs : Pulumi.ResourceArgs
    {
        [Input("compute")]
        public Input<Inputs.DashboardWidgetHostmapDefinitionRequestSizeApmQueryComputeArgs>? Compute { get; set; }

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetHostmapDefinitionRequestSizeApmQueryGroupByArgs>? _groupBies;
        public InputList<Inputs.DashboardWidgetHostmapDefinitionRequestSizeApmQueryGroupByArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetHostmapDefinitionRequestSizeApmQueryGroupByArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        [Input("multiComputes")]
        private InputList<Inputs.DashboardWidgetHostmapDefinitionRequestSizeApmQueryMultiComputeArgs>? _multiComputes;
        public InputList<Inputs.DashboardWidgetHostmapDefinitionRequestSizeApmQueryMultiComputeArgs> MultiComputes
        {
            get => _multiComputes ?? (_multiComputes = new InputList<Inputs.DashboardWidgetHostmapDefinitionRequestSizeApmQueryMultiComputeArgs>());
            set => _multiComputes = value;
        }

        [Input("search")]
        public Input<Inputs.DashboardWidgetHostmapDefinitionRequestSizeApmQuerySearchArgs>? Search { get; set; }

        public DashboardWidgetHostmapDefinitionRequestSizeApmQueryArgs()
        {
        }
    }
}
