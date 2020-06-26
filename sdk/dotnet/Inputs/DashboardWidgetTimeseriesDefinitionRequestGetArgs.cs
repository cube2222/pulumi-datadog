// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetTimeseriesDefinitionRequestGetArgs : Pulumi.ResourceArgs
    {
        [Input("apmQuery")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionRequestApmQueryGetArgs>? ApmQuery { get; set; }

        [Input("displayType")]
        public Input<string>? DisplayType { get; set; }

        [Input("logQuery")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionRequestLogQueryGetArgs>? LogQuery { get; set; }

        [Input("metadatas")]
        private InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestMetadataGetArgs>? _metadatas;
        public InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestMetadataGetArgs> Metadatas
        {
            get => _metadatas ?? (_metadatas = new InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestMetadataGetArgs>());
            set => _metadatas = value;
        }

        [Input("networkQuery")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionRequestNetworkQueryGetArgs>? NetworkQuery { get; set; }

        [Input("processQuery")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionRequestProcessQueryGetArgs>? ProcessQuery { get; set; }

        [Input("q")]
        public Input<string>? Q { get; set; }

        [Input("rumQuery")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionRequestRumQueryGetArgs>? RumQuery { get; set; }

        [Input("style")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionRequestStyleGetArgs>? Style { get; set; }

        public DashboardWidgetTimeseriesDefinitionRequestGetArgs()
        {
        }
    }
}
