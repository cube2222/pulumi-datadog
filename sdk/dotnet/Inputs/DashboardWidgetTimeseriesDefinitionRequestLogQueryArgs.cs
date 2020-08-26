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
        /// <summary>
        /// . Exactly one nested block is required with the following structure:
        /// </summary>
        [Input("compute", required: true)]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionRequestLogQueryComputeArgs> Compute { get; set; } = null!;

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestLogQueryGroupByArgs>? _groupBies;

        /// <summary>
        /// When grouping = "cluster", indicates a list of tags to use for grouping.
        /// </summary>
        public InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestLogQueryGroupByArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestLogQueryGroupByArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        /// <summary>
        /// . One nested block is allowed with the following structure:
        /// </summary>
        [Input("search")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionRequestLogQuerySearchArgs>? Search { get; set; }

        public DashboardWidgetTimeseriesDefinitionRequestLogQueryArgs()
        {
        }
    }
}
