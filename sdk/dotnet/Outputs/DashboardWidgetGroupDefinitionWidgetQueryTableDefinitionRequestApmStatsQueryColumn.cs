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
    public sealed class DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmStatsQueryColumn
    {
        public readonly string? Alias;
        public readonly string? CellDisplayMode;
        public readonly string Name;
        public readonly string? Order;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequestApmStatsQueryColumn(
            string? alias,

            string? cellDisplayMode,

            string name,

            string? order)
        {
            Alias = alias;
            CellDisplayMode = cellDisplayMode;
            Name = name;
            Order = order;
        }
    }
}
