// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetToplistDefinitionGetArgs : Pulumi.ResourceArgs
    {
        [Input("requests")]
        private InputList<Inputs.DashboardWidgetToplistDefinitionRequestGetArgs>? _requests;
        public InputList<Inputs.DashboardWidgetToplistDefinitionRequestGetArgs> Requests
        {
            get => _requests ?? (_requests = new InputList<Inputs.DashboardWidgetToplistDefinitionRequestGetArgs>());
            set => _requests = value;
        }

        [Input("time")]
        public Input<Inputs.DashboardWidgetToplistDefinitionTimeGetArgs>? Time { get; set; }

        /// <summary>
        /// Title of the dashboard.
        /// </summary>
        [Input("title")]
        public Input<string>? Title { get; set; }

        [Input("titleAlign")]
        public Input<string>? TitleAlign { get; set; }

        [Input("titleSize")]
        public Input<string>? TitleSize { get; set; }

        public DashboardWidgetToplistDefinitionGetArgs()
        {
        }
    }
}
