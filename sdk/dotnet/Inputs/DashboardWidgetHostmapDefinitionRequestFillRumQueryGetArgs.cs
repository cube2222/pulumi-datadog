// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetHostmapDefinitionRequestFillRumQueryGetArgs : Pulumi.ResourceArgs
    {
        [Input("compute")]
        public Input<Inputs.DashboardWidgetHostmapDefinitionRequestFillRumQueryComputeGetArgs>? Compute { get; set; }

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetHostmapDefinitionRequestFillRumQueryGroupByGetArgs>? _groupBies;
        public InputList<Inputs.DashboardWidgetHostmapDefinitionRequestFillRumQueryGroupByGetArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetHostmapDefinitionRequestFillRumQueryGroupByGetArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        [Input("multiComputes")]
        private InputList<Inputs.DashboardWidgetHostmapDefinitionRequestFillRumQueryMultiComputeGetArgs>? _multiComputes;
        public InputList<Inputs.DashboardWidgetHostmapDefinitionRequestFillRumQueryMultiComputeGetArgs> MultiComputes
        {
            get => _multiComputes ?? (_multiComputes = new InputList<Inputs.DashboardWidgetHostmapDefinitionRequestFillRumQueryMultiComputeGetArgs>());
            set => _multiComputes = value;
        }

        [Input("search")]
        public Input<Inputs.DashboardWidgetHostmapDefinitionRequestFillRumQuerySearchGetArgs>? Search { get; set; }

        public DashboardWidgetHostmapDefinitionRequestFillRumQueryGetArgs()
        {
        }
    }
}
