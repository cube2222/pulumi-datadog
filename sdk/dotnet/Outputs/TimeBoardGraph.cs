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
    public sealed class TimeBoardGraph
    {
        public readonly bool? Autoscale;
        public readonly string? CustomUnit;
        public readonly ImmutableArray<string> Events;
        public readonly ImmutableArray<string> Groups;
        public readonly bool? IncludeNoMetricHosts;
        public readonly bool? IncludeUngroupedHosts;
        public readonly ImmutableArray<Outputs.TimeBoardGraphMarker> Markers;
        public readonly string? NodeType;
        public readonly string? Precision;
        public readonly ImmutableArray<Outputs.TimeBoardGraphRequest> Requests;
        public readonly ImmutableArray<string> Scopes;
        public readonly ImmutableDictionary<string, object>? Style;
        public readonly string? TextAlign;
        public readonly string Title;
        public readonly string Viz;
        public readonly ImmutableDictionary<string, object>? Yaxis;

        [OutputConstructor]
        private TimeBoardGraph(
            bool? autoscale,

            string? customUnit,

            ImmutableArray<string> events,

            ImmutableArray<string> groups,

            bool? includeNoMetricHosts,

            bool? includeUngroupedHosts,

            ImmutableArray<Outputs.TimeBoardGraphMarker> markers,

            string? nodeType,

            string? precision,

            ImmutableArray<Outputs.TimeBoardGraphRequest> requests,

            ImmutableArray<string> scopes,

            ImmutableDictionary<string, object>? style,

            string? textAlign,

            string title,

            string viz,

            ImmutableDictionary<string, object>? yaxis)
        {
            Autoscale = autoscale;
            CustomUnit = customUnit;
            Events = events;
            Groups = groups;
            IncludeNoMetricHosts = includeNoMetricHosts;
            IncludeUngroupedHosts = includeUngroupedHosts;
            Markers = markers;
            NodeType = nodeType;
            Precision = precision;
            Requests = requests;
            Scopes = scopes;
            Style = style;
            TextAlign = textAlign;
            Title = title;
            Viz = viz;
            Yaxis = yaxis;
        }
    }
}
