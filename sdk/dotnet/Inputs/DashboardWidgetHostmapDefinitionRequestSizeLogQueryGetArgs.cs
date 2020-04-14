// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetHostmapDefinitionRequestSizeLogQueryGetArgs : Pulumi.ResourceArgs
    {
        [Input("compute", required: true)]
        public Input<Inputs.DashboardWidgetHostmapDefinitionRequestSizeLogQueryComputeGetArgs> Compute { get; set; } = null!;

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetHostmapDefinitionRequestSizeLogQueryGroupByGetArgs>? _groupBies;
        public InputList<Inputs.DashboardWidgetHostmapDefinitionRequestSizeLogQueryGroupByGetArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetHostmapDefinitionRequestSizeLogQueryGroupByGetArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        [Input("search")]
        public Input<Inputs.DashboardWidgetHostmapDefinitionRequestSizeLogQuerySearchGetArgs>? Search { get; set; }

        public DashboardWidgetHostmapDefinitionRequestSizeLogQueryGetArgs()
        {
        }
    }
}
