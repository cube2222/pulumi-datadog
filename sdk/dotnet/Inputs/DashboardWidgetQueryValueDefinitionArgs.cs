// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetQueryValueDefinitionArgs : Pulumi.ResourceArgs
    {
        [Input("autoscale")]
        public Input<bool>? Autoscale { get; set; }

        [Input("customLinks")]
        private InputList<Inputs.DashboardWidgetQueryValueDefinitionCustomLinkArgs>? _customLinks;
        public InputList<Inputs.DashboardWidgetQueryValueDefinitionCustomLinkArgs> CustomLinks
        {
            get => _customLinks ?? (_customLinks = new InputList<Inputs.DashboardWidgetQueryValueDefinitionCustomLinkArgs>());
            set => _customLinks = value;
        }

        [Input("customUnit")]
        public Input<string>? CustomUnit { get; set; }

        [Input("precision")]
        public Input<int>? Precision { get; set; }

        [Input("requests")]
        private InputList<Inputs.DashboardWidgetQueryValueDefinitionRequestArgs>? _requests;
        public InputList<Inputs.DashboardWidgetQueryValueDefinitionRequestArgs> Requests
        {
            get => _requests ?? (_requests = new InputList<Inputs.DashboardWidgetQueryValueDefinitionRequestArgs>());
            set => _requests = value;
        }

        [Input("textAlign")]
        public Input<string>? TextAlign { get; set; }

        [Input("time")]
        public Input<Inputs.DashboardWidgetQueryValueDefinitionTimeArgs>? Time { get; set; }

        [Input("title")]
        public Input<string>? Title { get; set; }

        [Input("titleAlign")]
        public Input<string>? TitleAlign { get; set; }

        [Input("titleSize")]
        public Input<string>? TitleSize { get; set; }

        public DashboardWidgetQueryValueDefinitionArgs()
        {
        }
    }
}
