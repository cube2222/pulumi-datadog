// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetDistributionDefinitionRequestProcessQueryArgs : Pulumi.ResourceArgs
    {
        [Input("filterBies")]
        private InputList<string>? _filterBies;
        public InputList<string> FilterBies
        {
            get => _filterBies ?? (_filterBies = new InputList<string>());
            set => _filterBies = value;
        }

        /// <summary>
        /// The number of lines to show in the table.
        /// </summary>
        [Input("limit")]
        public Input<int>? Limit { get; set; }

        [Input("metric", required: true)]
        public Input<string> Metric { get; set; } = null!;

        [Input("searchBy")]
        public Input<string>? SearchBy { get; set; }

        public DashboardWidgetDistributionDefinitionRequestProcessQueryArgs()
        {
        }
    }
}
