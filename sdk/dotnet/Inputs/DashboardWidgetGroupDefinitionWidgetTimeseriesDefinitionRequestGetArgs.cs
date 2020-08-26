// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestGetArgs : Pulumi.ResourceArgs
    {
        [Input("apmQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestApmQueryGetArgs>? ApmQuery { get; set; }

        /// <summary>
        /// Type of display to use for the request. Available values are: `area`, `bars`, or `line`.
        /// </summary>
        [Input("displayType")]
        public Input<string>? DisplayType { get; set; }

        [Input("logQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestLogQueryGetArgs>? LogQuery { get; set; }

        [Input("metadatas")]
        private InputList<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestMetadataGetArgs>? _metadatas;

        /// <summary>
        /// . Used to define expression aliases. Multiple nested blocks are allowed with the following structure:
        /// </summary>
        public InputList<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestMetadataGetArgs> Metadatas
        {
            get => _metadatas ?? (_metadatas = new InputList<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestMetadataGetArgs>());
            set => _metadatas = value;
        }

        [Input("networkQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestNetworkQueryGetArgs>? NetworkQuery { get; set; }

        [Input("processQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestProcessQueryGetArgs>? ProcessQuery { get; set; }

        [Input("q")]
        public Input<string>? Q { get; set; }

        [Input("rumQuery")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestRumQueryGetArgs>? RumQuery { get; set; }

        /// <summary>
        /// Style of the widget graph. One nested block is allowed with the following structure:
        /// </summary>
        [Input("style")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestStyleGetArgs>? Style { get; set; }

        public DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestGetArgs()
        {
        }
    }
}
