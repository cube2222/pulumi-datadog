// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestApmQueryGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// . Exactly one nested block is required with the following structure:
        /// </summary>
        [Input("compute", required: true)]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestApmQueryComputeGetArgs> Compute { get; set; } = null!;

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestApmQueryGroupByGetArgs>? _groupBies;

        /// <summary>
        /// . Multiple nested blocks are allowed with the following structure:
        /// </summary>
        public InputList<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestApmQueryGroupByGetArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestApmQueryGroupByGetArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        /// <summary>
        /// . One nested block is allowed with the following structure:
        /// </summary>
        [Input("search")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestApmQuerySearchGetArgs>? Search { get; set; }

        public DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestApmQueryGetArgs()
        {
        }
    }
}
