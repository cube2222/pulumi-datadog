// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestSecurityQueryGroupByGetArgs : Pulumi.ResourceArgs
    {
        [Input("facet")]
        public Input<string>? Facet { get; set; }

        [Input("limit")]
        public Input<int>? Limit { get; set; }

        [Input("sort")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestSecurityQueryGroupBySortGetArgs>? Sort { get; set; }

        public DashboardWidgetGroupDefinitionWidgetTimeseriesDefinitionRequestSecurityQueryGroupByGetArgs()
        {
        }
    }
}
