// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillRumQueryArgs : Pulumi.ResourceArgs
    {
        [Input("compute")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillRumQueryComputeArgs>? Compute { get; set; }

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillRumQueryGroupByArgs>? _groupBies;
        public InputList<Inputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillRumQueryGroupByArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillRumQueryGroupByArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        [Input("multiComputes")]
        private InputList<Inputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillRumQueryMultiComputeArgs>? _multiComputes;
        public InputList<Inputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillRumQueryMultiComputeArgs> MultiComputes
        {
            get => _multiComputes ?? (_multiComputes = new InputList<Inputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillRumQueryMultiComputeArgs>());
            set => _multiComputes = value;
        }

        [Input("search")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillRumQuerySearchArgs>? Search { get; set; }

        public DashboardWidgetGroupDefinitionWidgetHostmapDefinitionRequestFillRumQueryArgs()
        {
        }
    }
}
