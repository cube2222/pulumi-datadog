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
    public sealed class DashboardWidgetGroupDefinitionWidgetQueryTableDefinition
    {
        public readonly ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequest> Requests;
        public readonly Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionTime? Time;
        public readonly string? Title;
        public readonly string? TitleAlign;
        public readonly string? TitleSize;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetQueryTableDefinition(
            ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionRequest> requests,

            Outputs.DashboardWidgetGroupDefinitionWidgetQueryTableDefinitionTime? time,

            string? title,

            string? titleAlign,

            string? titleSize)
        {
            Requests = requests;
            Time = time;
            Title = title;
            TitleAlign = titleAlign;
            TitleSize = titleSize;
        }
    }
}
