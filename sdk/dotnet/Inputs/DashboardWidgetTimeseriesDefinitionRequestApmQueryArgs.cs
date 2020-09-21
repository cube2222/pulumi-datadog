// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetTimeseriesDefinitionRequestApmQueryArgs : Pulumi.ResourceArgs
    {
        [Input("compute")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionRequestApmQueryComputeArgs>? Compute { get; set; }

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestApmQueryGroupByArgs>? _groupBies;
        public InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestApmQueryGroupByArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestApmQueryGroupByArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        [Input("multiComputes")]
        private InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestApmQueryMultiComputeArgs>? _multiComputes;
        public InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestApmQueryMultiComputeArgs> MultiComputes
        {
            get => _multiComputes ?? (_multiComputes = new InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestApmQueryMultiComputeArgs>());
            set => _multiComputes = value;
        }

        [Input("search")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionRequestApmQuerySearchArgs>? Search { get; set; }

        public DashboardWidgetTimeseriesDefinitionRequestApmQueryArgs()
        {
        }
    }
}
