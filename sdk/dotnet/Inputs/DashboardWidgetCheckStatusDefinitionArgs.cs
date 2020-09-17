// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetCheckStatusDefinitionArgs : Pulumi.ResourceArgs
    {
        [Input("check", required: true)]
        public Input<string> Check { get; set; } = null!;

        [Input("group")]
        public Input<string>? Group { get; set; }

        [Input("groupBies")]
        private InputList<string>? _groupBies;
        public InputList<string> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<string>());
            set => _groupBies = value;
        }

        [Input("grouping", required: true)]
        public Input<string> Grouping { get; set; } = null!;

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("time")]
        public Input<Inputs.DashboardWidgetCheckStatusDefinitionTimeArgs>? Time { get; set; }

        [Input("title")]
        public Input<string>? Title { get; set; }

        [Input("titleAlign")]
        public Input<string>? TitleAlign { get; set; }

        [Input("titleSize")]
        public Input<string>? TitleSize { get; set; }

        public DashboardWidgetCheckStatusDefinitionArgs()
        {
        }
    }
}
