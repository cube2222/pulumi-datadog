// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetTimeseriesDefinitionRequestLogQueryArgs : Pulumi.ResourceArgs
    {
        [Input("compute")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionRequestLogQueryComputeArgs>? Compute { get; set; }

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestLogQueryGroupByArgs>? _groupBies;
        public InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestLogQueryGroupByArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestLogQueryGroupByArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        [Input("multiComputes")]
        private InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestLogQueryMultiComputeArgs>? _multiComputes;
        public InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestLogQueryMultiComputeArgs> MultiComputes
        {
            get => _multiComputes ?? (_multiComputes = new InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestLogQueryMultiComputeArgs>());
            set => _multiComputes = value;
        }

        [Input("search")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionRequestLogQuerySearchArgs>? Search { get; set; }

        public DashboardWidgetTimeseriesDefinitionRequestLogQueryArgs()
        {
        }
    }
}
