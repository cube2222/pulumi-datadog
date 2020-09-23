// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetQueryValueDefinitionRequestRumQueryArgs : Pulumi.ResourceArgs
    {
        [Input("compute")]
        public Input<Inputs.DashboardWidgetQueryValueDefinitionRequestRumQueryComputeArgs>? Compute { get; set; }

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetQueryValueDefinitionRequestRumQueryGroupByArgs>? _groupBies;
        public InputList<Inputs.DashboardWidgetQueryValueDefinitionRequestRumQueryGroupByArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetQueryValueDefinitionRequestRumQueryGroupByArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        [Input("multiComputes")]
        private InputList<Inputs.DashboardWidgetQueryValueDefinitionRequestRumQueryMultiComputeArgs>? _multiComputes;
        public InputList<Inputs.DashboardWidgetQueryValueDefinitionRequestRumQueryMultiComputeArgs> MultiComputes
        {
            get => _multiComputes ?? (_multiComputes = new InputList<Inputs.DashboardWidgetQueryValueDefinitionRequestRumQueryMultiComputeArgs>());
            set => _multiComputes = value;
        }

        [Input("search")]
        public Input<Inputs.DashboardWidgetQueryValueDefinitionRequestRumQuerySearchArgs>? Search { get; set; }

        public DashboardWidgetQueryValueDefinitionRequestRumQueryArgs()
        {
        }
    }
}