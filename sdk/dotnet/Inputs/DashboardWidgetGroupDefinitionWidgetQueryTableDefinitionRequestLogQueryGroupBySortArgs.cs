// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestLogQueryGroupBySortArgs : Pulumi.ResourceArgs
    {
        [Input("aggregation", required: true)]
        public Input<string> Aggregation { get; set; } = null!;

        [Input("facet")]
        public Input<string>? Facet { get; set; }

        [Input("order", required: true)]
        public Input<string> Order { get; set; } = null!;

        public DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestLogQueryGroupBySortArgs()
        {
        }
    }
}
