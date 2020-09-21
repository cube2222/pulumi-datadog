// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetGroupDefinitionWidgetLogStreamDefinitionGetArgs : Pulumi.ResourceArgs
    {
        [Input("columns")]
        private InputList<string>? _columns;
        public InputList<string> Columns
        {
            get => _columns ?? (_columns = new InputList<string>());
            set => _columns = value;
        }

        [Input("indexes")]
        private InputList<string>? _indexes;
        public InputList<string> Indexes
        {
            get => _indexes ?? (_indexes = new InputList<string>());
            set => _indexes = value;
        }

        [Input("logset")]
        public Input<string>? Logset { get; set; }

        [Input("messageDisplay")]
        public Input<string>? MessageDisplay { get; set; }

        [Input("query")]
        public Input<string>? Query { get; set; }

        [Input("showDateColumn")]
        public Input<bool>? ShowDateColumn { get; set; }

        [Input("showMessageColumn")]
        public Input<bool>? ShowMessageColumn { get; set; }

        [Input("sort")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetLogStreamDefinitionSortGetArgs>? Sort { get; set; }

        [Input("time")]
        public Input<Inputs.DashboardWidgetGroupDefinitionWidgetLogStreamDefinitionTimeGetArgs>? Time { get; set; }

        [Input("title")]
        public Input<string>? Title { get; set; }

        [Input("titleAlign")]
        public Input<string>? TitleAlign { get; set; }

        [Input("titleSize")]
        public Input<string>? TitleSize { get; set; }

        public DashboardWidgetGroupDefinitionWidgetLogStreamDefinitionGetArgs()
        {
        }
    }
}
