// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Outputs
{

    [OutputType]
    public sealed class DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestSecurityQueryMultiCompute
    {
        public readonly string Aggregation;
        public readonly string? Facet;
        public readonly int? Interval;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetToplistDefinitionRequestSecurityQueryMultiCompute(
            string aggregation,

            string? facet,

            int? interval)
        {
            Aggregation = aggregation;
            Facet = facet;
            Interval = interval;
        }
    }
}
