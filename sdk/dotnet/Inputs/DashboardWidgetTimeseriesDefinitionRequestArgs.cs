// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetTimeseriesDefinitionRequestArgs : Pulumi.ResourceArgs
    {
        [Input("apmQuery")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionRequestApmQueryArgs>? ApmQuery { get; set; }

        [Input("displayType")]
        public Input<string>? DisplayType { get; set; }

        [Input("logQuery")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionRequestLogQueryArgs>? LogQuery { get; set; }

        [Input("metadatas")]
        private InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestMetadataArgs>? _metadatas;
        public InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestMetadataArgs> Metadatas
        {
            get => _metadatas ?? (_metadatas = new InputList<Inputs.DashboardWidgetTimeseriesDefinitionRequestMetadataArgs>());
            set => _metadatas = value;
        }

        [Input("processQuery")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionRequestProcessQueryArgs>? ProcessQuery { get; set; }

        [Input("q")]
        public Input<string>? Q { get; set; }

        [Input("style")]
        public Input<Inputs.DashboardWidgetTimeseriesDefinitionRequestStyleArgs>? Style { get; set; }

        public DashboardWidgetTimeseriesDefinitionRequestArgs()
        {
        }
    }
}
