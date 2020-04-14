// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetServiceLevelObjectiveDefinitionGetArgs : Pulumi.ResourceArgs
    {
        [Input("showErrorBudget")]
        public Input<bool>? ShowErrorBudget { get; set; }

        [Input("sloId", required: true)]
        public Input<string> SloId { get; set; } = null!;

        [Input("timeWindows", required: true)]
        private InputList<string>? _timeWindows;
        public InputList<string> TimeWindows
        {
            get => _timeWindows ?? (_timeWindows = new InputList<string>());
            set => _timeWindows = value;
        }

        [Input("title")]
        public Input<string>? Title { get; set; }

        [Input("titleAlign")]
        public Input<string>? TitleAlign { get; set; }

        [Input("titleSize")]
        public Input<string>? TitleSize { get; set; }

        [Input("viewMode", required: true)]
        public Input<string> ViewMode { get; set; } = null!;

        [Input("viewType", required: true)]
        public Input<string> ViewType { get; set; } = null!;

        public DashboardWidgetGroupDefinitionWidgetServiceLevelObjectiveDefinitionGetArgs()
        {
        }
    }
}
