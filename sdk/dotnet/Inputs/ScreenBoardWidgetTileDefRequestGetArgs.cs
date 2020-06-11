// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class ScreenBoardWidgetTileDefRequestGetArgs : Pulumi.ResourceArgs
    {
        [Input("aggregator")]
        public Input<string>? Aggregator { get; set; }

        [Input("apmQuery")]
        public Input<Inputs.ScreenBoardWidgetTileDefRequestApmQueryGetArgs>? ApmQuery { get; set; }

        [Input("changeType")]
        public Input<string>? ChangeType { get; set; }

        [Input("compareTo")]
        public Input<string>? CompareTo { get; set; }

        [Input("conditionalFormats")]
        private InputList<Inputs.ScreenBoardWidgetTileDefRequestConditionalFormatGetArgs>? _conditionalFormats;
        public InputList<Inputs.ScreenBoardWidgetTileDefRequestConditionalFormatGetArgs> ConditionalFormats
        {
            get => _conditionalFormats ?? (_conditionalFormats = new InputList<Inputs.ScreenBoardWidgetTileDefRequestConditionalFormatGetArgs>());
            set => _conditionalFormats = value;
        }

        [Input("extraCol")]
        public Input<string>? ExtraCol { get; set; }

        [Input("increaseGood")]
        public Input<bool>? IncreaseGood { get; set; }

        [Input("limit")]
        public Input<int>? Limit { get; set; }

        [Input("logQuery")]
        public Input<Inputs.ScreenBoardWidgetTileDefRequestLogQueryGetArgs>? LogQuery { get; set; }

        /// <summary>
        /// A JSON blob representing mapping of query expressions to alias names. Note that the query expressions in `metadata_json` will be ignored if they're not present in the query. For example:
        /// ```
        /// metadata_json = jsonencode({
        /// "avg:redis.info.latency_ms{$host}": {
        /// "alias": "Redis latency"
        /// }
        /// })
        /// ```
        /// </summary>
        [Input("metadataJson")]
        public Input<string>? MetadataJson { get; set; }

        [Input("metric")]
        public Input<string>? Metric { get; set; }

        [Input("orderBy")]
        public Input<string>? OrderBy { get; set; }

        [Input("orderDir")]
        public Input<string>? OrderDir { get; set; }

        [Input("processQuery")]
        public Input<Inputs.ScreenBoardWidgetTileDefRequestProcessQueryGetArgs>? ProcessQuery { get; set; }

        [Input("q")]
        public Input<string>? Q { get; set; }

        [Input("queryType")]
        public Input<string>? QueryType { get; set; }

        [Input("style")]
        private InputMap<object>? _style;
        public InputMap<object> Style
        {
            get => _style ?? (_style = new InputMap<object>());
            set => _style = value;
        }

        [Input("tagFilters")]
        private InputList<string>? _tagFilters;
        public InputList<string> TagFilters
        {
            get => _tagFilters ?? (_tagFilters = new InputList<string>());
            set => _tagFilters = value;
        }

        [Input("textFilter")]
        public Input<string>? TextFilter { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        public ScreenBoardWidgetTileDefRequestGetArgs()
        {
        }
    }
}
