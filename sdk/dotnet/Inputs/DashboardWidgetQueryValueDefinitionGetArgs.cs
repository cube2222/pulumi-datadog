// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetQueryValueDefinitionGetArgs : Pulumi.ResourceArgs
    {
        [Input("autoscale")]
        public Input<bool>? Autoscale { get; set; }

        [Input("customUnit")]
        public Input<string>? CustomUnit { get; set; }

        [Input("precision")]
        public Input<int>? Precision { get; set; }

        [Input("requests")]
        private InputList<Inputs.DashboardWidgetQueryValueDefinitionRequestGetArgs>? _requests;
        public InputList<Inputs.DashboardWidgetQueryValueDefinitionRequestGetArgs> Requests
        {
            get => _requests ?? (_requests = new InputList<Inputs.DashboardWidgetQueryValueDefinitionRequestGetArgs>());
            set => _requests = value;
        }

        [Input("textAlign")]
        public Input<string>? TextAlign { get; set; }

        [Input("time")]
        public Input<Inputs.DashboardWidgetQueryValueDefinitionTimeGetArgs>? Time { get; set; }

        [Input("title")]
        public Input<string>? Title { get; set; }

        [Input("titleAlign")]
        public Input<string>? TitleAlign { get; set; }

        [Input("titleSize")]
        public Input<string>? TitleSize { get; set; }

        public DashboardWidgetQueryValueDefinitionGetArgs()
        {
        }
    }
}