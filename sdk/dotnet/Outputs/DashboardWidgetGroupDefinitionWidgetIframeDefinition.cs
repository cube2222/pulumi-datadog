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
    public sealed class DashboardWidgetGroupDefinitionWidgetIframeDefinition
    {
        /// <summary>
        /// Read only field - The URL of the dashboard.
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private DashboardWidgetGroupDefinitionWidgetIframeDefinition(string url)
        {
            Url = url;
        }
    }
}
