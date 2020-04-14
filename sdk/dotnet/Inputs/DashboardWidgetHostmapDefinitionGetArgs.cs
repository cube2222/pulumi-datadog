// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetHostmapDefinitionGetArgs : Pulumi.ResourceArgs
    {
        [Input("groups")]
        private InputList<string>? _groups;
        public InputList<string> Groups
        {
            get => _groups ?? (_groups = new InputList<string>());
            set => _groups = value;
        }

        [Input("noGroupHosts")]
        public Input<bool>? NoGroupHosts { get; set; }

        [Input("noMetricHosts")]
        public Input<bool>? NoMetricHosts { get; set; }

        [Input("nodeType")]
        public Input<string>? NodeType { get; set; }

        [Input("request")]
        public Input<Inputs.DashboardWidgetHostmapDefinitionRequestGetArgs>? Request { get; set; }

        [Input("scopes")]
        private InputList<string>? _scopes;
        public InputList<string> Scopes
        {
            get => _scopes ?? (_scopes = new InputList<string>());
            set => _scopes = value;
        }

        [Input("style")]
        public Input<Inputs.DashboardWidgetHostmapDefinitionStyleGetArgs>? Style { get; set; }

        [Input("title")]
        public Input<string>? Title { get; set; }

        [Input("titleAlign")]
        public Input<string>? TitleAlign { get; set; }

        [Input("titleSize")]
        public Input<string>? TitleSize { get; set; }

        public DashboardWidgetHostmapDefinitionGetArgs()
        {
        }
    }
}
