// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetCheckStatusDefinitionGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The check to use in the widget.
        /// </summary>
        [Input("check", required: true)]
        public Input<string> Check { get; set; } = null!;

        /// <summary>
        /// The check group to use in the widget.
        /// </summary>
        [Input("group")]
        public Input<string>? Group { get; set; }

        [Input("groupBies")]
        private InputList<string>? _groupBies;

        /// <summary>
        /// When grouping = "cluster", indicates a list of tags to use for grouping.
        /// </summary>
        public InputList<string> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<string>());
            set => _groupBies = value;
        }

        /// <summary>
        /// Either "check" or "cluster", depending on whether the widget should use a single check or a cluster of checks.
        /// </summary>
        [Input("grouping", required: true)]
        public Input<string> Grouping { get; set; } = null!;

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// List of tags to use in the widget.
        /// - `title`: (Optional) The title of the widget.
        /// - `title`: (Optional) The title of the widget.
        /// - `title_size`: (Optional) The size of the widget's title. Default is 16.
        /// - `title_align`: (Optional) The alignment of the widget's title. One of "left", "center", or "right".
        /// - `time`: (Optional) Nested block describing the timeframe to use when displaying the widget. The structure of this block is described below.
        /// - `distribution_definition`: The definition for a Distribution widget. Exactly one nested block is allowed with the following structure:
        /// - `request`: (Required) Nested block describing the request to use when displaying the widget. Multiple request blocks are allowed with the following structure:
        /// - `q`: (Required) The metric query to use in the widget.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("time")]
        public Input<Inputs.DashboardWidgetCheckStatusDefinitionTimeGetArgs>? Time { get; set; }

        /// <summary>
        /// Title of the dashboard.
        /// </summary>
        [Input("title")]
        public Input<string>? Title { get; set; }

        [Input("titleAlign")]
        public Input<string>? TitleAlign { get; set; }

        [Input("titleSize")]
        public Input<string>? TitleSize { get; set; }

        public DashboardWidgetCheckStatusDefinitionGetArgs()
        {
        }
    }
}
