// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Outputs
{

    [OutputType]
    public sealed class ScreenBoardWidgetTileDef
    {
        public readonly bool? Autoscale;
        public readonly string? CustomUnit;
        public readonly ImmutableArray<Outputs.ScreenBoardWidgetTileDefEvent> Events;
        public readonly ImmutableArray<string> Groups;
        public readonly ImmutableArray<Outputs.ScreenBoardWidgetTileDefMarker> Markers;
        public readonly bool? NoGroupHosts;
        public readonly bool? NoMetricHosts;
        public readonly string? NodeType;
        public readonly string? Precision;
        public readonly ImmutableArray<Outputs.ScreenBoardWidgetTileDefRequest> Requests;
        public readonly ImmutableArray<string> Scopes;
        public readonly ImmutableDictionary<string, object>? Style;
        public readonly string? TextAlign;
        public readonly string Viz;

        [OutputConstructor]
        private ScreenBoardWidgetTileDef(
            bool? autoscale,

            string? customUnit,

            ImmutableArray<Outputs.ScreenBoardWidgetTileDefEvent> events,

            ImmutableArray<string> groups,

            ImmutableArray<Outputs.ScreenBoardWidgetTileDefMarker> markers,

            bool? noGroupHosts,

            bool? noMetricHosts,

            string? nodeType,

            string? precision,

            ImmutableArray<Outputs.ScreenBoardWidgetTileDefRequest> requests,

            ImmutableArray<string> scopes,

            ImmutableDictionary<string, object>? style,

            string? textAlign,

            string viz)
        {
            Autoscale = autoscale;
            CustomUnit = customUnit;
            Events = events;
            Groups = groups;
            Markers = markers;
            NoGroupHosts = noGroupHosts;
            NoMetricHosts = noMetricHosts;
            NodeType = nodeType;
            Precision = precision;
            Requests = requests;
            Scopes = scopes;
            Style = style;
            TextAlign = textAlign;
            Viz = viz;
        }
    }
}
