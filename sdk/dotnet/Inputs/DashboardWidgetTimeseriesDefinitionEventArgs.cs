// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetTimeseriesDefinitionEventArgs : Pulumi.ResourceArgs
    {
        [Input("q", required: true)]
        public Input<string> Q { get; set; } = null!;

        [Input("tagsExecution")]
        public Input<string>? TagsExecution { get; set; }

        public DashboardWidgetTimeseriesDefinitionEventArgs()
        {
        }
    }
}
