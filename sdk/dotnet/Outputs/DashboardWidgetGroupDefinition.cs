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
    public sealed class DashboardWidgetGroupDefinition
    {
        /// <summary>
        /// Layout type of the dashboard. Available values are: `ordered` (previous timeboard) or `free` (previous screenboard layout).
        /// &lt;br&gt;**Note: This value cannot be changed. Converting a dashboard from `free` &lt;&gt; `ordered` requires destroying and re-creating the dashboard.** Instead of using `ForceNew`, this is a manual action as many underlying widget configs need to be updated to work for the updated layout, otherwise the new dashboard won't be created properly.
        /// </summary>
        public readonly string LayoutType;
        /// <summary>
        /// Title of the dashboard.
        /// </summary>
        public readonly string? Title;
        /// <summary>
        /// Nested block describing a widget. The structure of this block is described below. Multiple `widget` blocks are allowed within a `datadog.Dashboard` resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidget> Widgets;

        [OutputConstructor]
        private DashboardWidgetGroupDefinition(
            string layoutType,

            string? title,

            ImmutableArray<Outputs.DashboardWidgetGroupDefinitionWidget> widgets)
        {
            LayoutType = layoutType;
            Title = title;
            Widgets = widgets;
        }
    }
}
