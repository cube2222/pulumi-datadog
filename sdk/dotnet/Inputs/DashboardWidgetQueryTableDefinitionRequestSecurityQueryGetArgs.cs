// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetQueryTableDefinitionRequestSecurityQueryGetArgs : Pulumi.ResourceArgs
    {
        [Input("compute")]
        public Input<Inputs.DashboardWidgetQueryTableDefinitionRequestSecurityQueryComputeGetArgs>? Compute { get; set; }

        [Input("groupBies")]
        private InputList<Inputs.DashboardWidgetQueryTableDefinitionRequestSecurityQueryGroupByGetArgs>? _groupBies;
        public InputList<Inputs.DashboardWidgetQueryTableDefinitionRequestSecurityQueryGroupByGetArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.DashboardWidgetQueryTableDefinitionRequestSecurityQueryGroupByGetArgs>());
            set => _groupBies = value;
        }

        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        [Input("multiComputes")]
        private InputList<Inputs.DashboardWidgetQueryTableDefinitionRequestSecurityQueryMultiComputeGetArgs>? _multiComputes;
        public InputList<Inputs.DashboardWidgetQueryTableDefinitionRequestSecurityQueryMultiComputeGetArgs> MultiComputes
        {
            get => _multiComputes ?? (_multiComputes = new InputList<Inputs.DashboardWidgetQueryTableDefinitionRequestSecurityQueryMultiComputeGetArgs>());
            set => _multiComputes = value;
        }

        [Input("search")]
        public Input<Inputs.DashboardWidgetQueryTableDefinitionRequestSecurityQuerySearchGetArgs>? Search { get; set; }

        public DashboardWidgetQueryTableDefinitionRequestSecurityQueryGetArgs()
        {
        }
    }
}