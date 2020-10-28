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
    public sealed class DashboardWidgetChangeDefinition
    {
        public readonly ImmutableArray<Outputs.DashboardWidgetChangeDefinitionCustomLink> CustomLinks;
        public readonly ImmutableArray<Outputs.DashboardWidgetChangeDefinitionRequest> Requests;
        public readonly Outputs.DashboardWidgetChangeDefinitionTime? Time;
        public readonly string? Title;
        public readonly string? TitleAlign;
        public readonly string? TitleSize;

        [OutputConstructor]
        private DashboardWidgetChangeDefinition(
            ImmutableArray<Outputs.DashboardWidgetChangeDefinitionCustomLink> customLinks,

            ImmutableArray<Outputs.DashboardWidgetChangeDefinitionRequest> requests,

            Outputs.DashboardWidgetChangeDefinitionTime? time,

            string? title,

            string? titleAlign,

            string? titleSize)
        {
            CustomLinks = customLinks;
            Requests = requests;
            Time = time;
            Title = title;
            TitleAlign = titleAlign;
            TitleSize = titleSize;
        }
    }
}
