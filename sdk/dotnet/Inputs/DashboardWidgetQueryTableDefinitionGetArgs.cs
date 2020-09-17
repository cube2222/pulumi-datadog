// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetQueryTableDefinitionGetArgs : Pulumi.ResourceArgs
    {
        [Input("requests")]
        private InputList<Inputs.DashboardWidgetQueryTableDefinitionRequestGetArgs>? _requests;
        public InputList<Inputs.DashboardWidgetQueryTableDefinitionRequestGetArgs> Requests
        {
            get => _requests ?? (_requests = new InputList<Inputs.DashboardWidgetQueryTableDefinitionRequestGetArgs>());
            set => _requests = value;
        }

        [Input("time")]
        public Input<Inputs.DashboardWidgetQueryTableDefinitionTimeGetArgs>? Time { get; set; }

        [Input("title")]
        public Input<string>? Title { get; set; }

        [Input("titleAlign")]
        public Input<string>? TitleAlign { get; set; }

        [Input("titleSize")]
        public Input<string>? TitleSize { get; set; }

        public DashboardWidgetQueryTableDefinitionGetArgs()
        {
        }
    }
}
