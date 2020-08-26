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
    public sealed class ScreenBoardWidget
    {
        /// <summary>
        /// The ID of the monitor used by the widget.
        /// </summary>
        public readonly int? AlertId;
        /// <summary>
        /// Boolean indicating whether the widget is refreshed automatically.
        /// </summary>
        public readonly bool? AutoRefresh;
        /// <summary>
        /// The color of the background of the widget.
        /// </summary>
        public readonly string? Bgcolor;
        /// <summary>
        /// The check to use in the widget.
        /// </summary>
        public readonly string? Check;
        /// <summary>
        /// The color of the text in the widget.
        /// </summary>
        public readonly string? Color;
        /// <summary>
        /// Whether to colorize text or background. One of "text", "background".
        /// </summary>
        public readonly string? ColorPreference;
        /// <summary>
        /// Stringified list of columns to use. Example: `"[\"column1\",\"column2\",\"column3\"]"`
        /// </summary>
        public readonly string? Columns;
        /// <summary>
        /// The display setting to use. One of "counts", "list", or "countsAndList".
        /// </summary>
        public readonly string? DisplayFormat;
        /// <summary>
        /// The environment to use.
        /// </summary>
        public readonly string? Env;
        /// <summary>
        /// The size of the events in the widget. Either "s" (small, title only) or "l" (large, full event).
        /// </summary>
        public readonly string? EventSize;
        /// <summary>
        /// The size of the text in the widget.
        /// </summary>
        public readonly string? FontSize;
        /// <summary>
        /// The list of tags to group nodes by.
        /// </summary>
        public readonly string? Group;
        /// <summary>
        /// When grouping = "cluster", indicates a list of tags to use for grouping.
        /// </summary>
        public readonly ImmutableArray<string> GroupBies;
        /// <summary>
        /// Either "check" or "cluster", depending on whether the widget should use a single check or a cluster of checks.
        /// </summary>
        public readonly string? Grouping;
        /// <summary>
        /// The height of the widget. Default is 15.
        /// </summary>
        public readonly int? Height;
        /// <summary>
        /// Boolean indicating whether to hide empty categories.
        /// </summary>
        public readonly bool? HideZeroCounts;
        /// <summary>
        /// The content of the widget. HTML tags supported.
        /// </summary>
        public readonly string? Html;
        /// <summary>
        /// The number of columns to use when displaying values. One of "one_column", "two_column", "three_column".
        /// </summary>
        public readonly string? LayoutVersion;
        /// <summary>
        /// Boolean indicating whether to display a legend in the widget.
        /// </summary>
        public readonly bool? Legend;
        /// <summary>
        /// The size of the legend displayed in the widget.
        /// </summary>
        public readonly string? LegendSize;
        /// <summary>
        /// ID of the logset to use.
        /// </summary>
        public readonly string? Logset;
        /// <summary>
        /// Boolean indicating whether to show a title.
        /// </summary>
        public readonly bool? ManageStatusShowTitle;
        /// <summary>
        /// The alignment of the widget's title. One of "left", "center", or "right".
        /// </summary>
        public readonly string? ManageStatusTitleAlign;
        /// <summary>
        /// The size of the widget's title.
        /// </summary>
        public readonly string? ManageStatusTitleSize;
        /// <summary>
        /// The title of the widget.
        /// </summary>
        public readonly string? ManageStatusTitleText;
        /// <summary>
        /// The margins to use around the image. Either "small" or "large".
        /// </summary>
        public readonly string? Margin;
        public readonly ImmutableDictionary<string, string>? Monitor;
        /// <summary>
        /// Boolean indicating whether to display breakdown.
        /// </summary>
        public readonly bool? MustShowBreakdown;
        /// <summary>
        /// Boolean indicating whether to display distribution.
        /// </summary>
        public readonly bool? MustShowDistribution;
        /// <summary>
        /// Boolean indicating whether to display errors.
        /// </summary>
        public readonly bool? MustShowErrors;
        /// <summary>
        /// Boolean indicating whether to display hits.
        /// </summary>
        public readonly bool? MustShowHits;
        /// <summary>
        /// Boolean indicating whether to display latency.
        /// </summary>
        public readonly bool? MustShowLatency;
        /// <summary>
        /// Boolean indicating whether to display resources.
        /// </summary>
        public readonly bool? MustShowResourceList;
        /// <summary>
        /// Nested block describing the monitors to display. The structure of this block is described below. At most one such block should be present in a given widget.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Params;
        /// <summary>
        /// The precision to use when displaying the tile.
        /// </summary>
        public readonly string? Precision;
        /// <summary>
        /// The query to use in the widget.
        /// </summary>
        public readonly string? Query;
        public readonly ImmutableArray<Outputs.ScreenBoardWidgetRule> Rules;
        /// <summary>
        /// The name of the service to use.
        /// </summary>
        public readonly string? ServiceName;
        /// <summary>
        /// The trace service to use.
        /// </summary>
        public readonly string? ServiceService;
        /// <summary>
        /// Boolean indicating whether to show when monitors/groups last triggered.
        /// </summary>
        public readonly bool? ShowLastTriggered;
        /// <summary>
        /// The size of the widget. One of "small", "medium", "large".
        /// </summary>
        public readonly string? SizeVersion;
        /// <summary>
        /// The preferred method to adapt the dimensions of the image to those of the widget. One of "center" (center the image in the tile), "zoom" (zoom the image to cover the whole tile) or "fit" (fit the image dimensions to those of the tile).
        /// </summary>
        public readonly string? Sizing;
        /// <summary>
        /// The monitor summary type to use. One of "monitors", "groups", or "combined". Defaults to "monitors".
        /// </summary>
        public readonly string? SummaryType;
        /// <summary>
        /// List of tags to use in the widget.
        /// </summary>
        public readonly ImmutableArray<string> Tags;
        /// <summary>
        /// The query to use to get monitors. Example: "status:alert".
        /// </summary>
        public readonly string? Text;
        /// <summary>
        /// The alignment of the text.
        /// </summary>
        public readonly string? TextAlign;
        /// <summary>
        /// The size of the text in the widget.
        /// </summary>
        public readonly string? TextSize;
        /// <summary>
        /// Boolean indicating whether a tick should be displayed on the border of the widget.
        /// </summary>
        public readonly bool? Tick;
        /// <summary>
        /// When tick = true, string indicating on which side of the widget the tick should be displayed. One of "bottom", "top", "left", "right".
        /// </summary>
        public readonly string? TickEdge;
        /// <summary>
        /// When tick = true, string with a percent sign indicating the position of the tick. Example: use tick_pos = "50%" for centered alignment.
        /// </summary>
        public readonly string? TickPos;
        /// <summary>
        /// Nested block describing the content to display in the widget. The structure of this block is described below. At most one such block should be present in a given widget.
        /// </summary>
        public readonly ImmutableArray<Outputs.ScreenBoardWidgetTileDef> TileDeves;
        /// <summary>
        /// Nested block describing the timeframe to use when displaying the widget. The structure of this block is described below. At most one such block should be present in a given widget.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Time;
        public readonly ImmutableArray<string> Timeframes;
        /// <summary>
        /// The title of the widget.
        /// </summary>
        public readonly string? Title;
        /// <summary>
        /// The alignment of the widget's title. One of "left", "center", or "right".
        /// </summary>
        public readonly string? TitleAlign;
        /// <summary>
        /// The size of the widget's title. Default is 16.
        /// </summary>
        public readonly int? TitleSize;
        /// <summary>
        /// Choose the type of representation to use for this query. For widgets of type "timeseries" and "query_value", use one of "line", "bars" or "area". For widgets of type "hostmap", use "fill" or "size".
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The unit for the value displayed in the widget.
        /// </summary>
        public readonly string? Unit;
        /// <summary>
        /// The URL to use as a data source for the widget.
        /// </summary>
        public readonly string? Url;
        /// <summary>
        /// Type of visualization to use when displaying the widget. Either "timeseries" or "toplist".
        /// </summary>
        public readonly string? VizType;
        /// <summary>
        /// The width of the widget. Default is 50.
        /// </summary>
        public readonly int? Width;
        /// <summary>
        /// The position of the widget on the x (horizontal) axis. Should be greater or equal to 0.
        /// </summary>
        public readonly int X;
        /// <summary>
        /// The position of the widget on the y (vertical) axis. Should be greater or equal to 0.
        /// </summary>
        public readonly int Y;

        [OutputConstructor]
        private ScreenBoardWidget(
            int? alertId,

            bool? autoRefresh,

            string? bgcolor,

            string? check,

            string? color,

            string? colorPreference,

            string? columns,

            string? displayFormat,

            string? env,

            string? eventSize,

            string? fontSize,

            string? group,

            ImmutableArray<string> groupBies,

            string? grouping,

            int? height,

            bool? hideZeroCounts,

            string? html,

            string? layoutVersion,

            bool? legend,

            string? legendSize,

            string? logset,

            bool? manageStatusShowTitle,

            string? manageStatusTitleAlign,

            string? manageStatusTitleSize,

            string? manageStatusTitleText,

            string? margin,

            ImmutableDictionary<string, string>? monitor,

            bool? mustShowBreakdown,

            bool? mustShowDistribution,

            bool? mustShowErrors,

            bool? mustShowHits,

            bool? mustShowLatency,

            bool? mustShowResourceList,

            ImmutableDictionary<string, string>? @params,

            string? precision,

            string? query,

            ImmutableArray<Outputs.ScreenBoardWidgetRule> rules,

            string? serviceName,

            string? serviceService,

            bool? showLastTriggered,

            string? sizeVersion,

            string? sizing,

            string? summaryType,

            ImmutableArray<string> tags,

            string? text,

            string? textAlign,

            string? textSize,

            bool? tick,

            string? tickEdge,

            string? tickPos,

            ImmutableArray<Outputs.ScreenBoardWidgetTileDef> tileDeves,

            ImmutableDictionary<string, string>? time,

            ImmutableArray<string> timeframes,

            string? title,

            string? titleAlign,

            int? titleSize,

            string type,

            string? unit,

            string? url,

            string? vizType,

            int? width,

            int x,

            int y)
        {
            AlertId = alertId;
            AutoRefresh = autoRefresh;
            Bgcolor = bgcolor;
            Check = check;
            Color = color;
            ColorPreference = colorPreference;
            Columns = columns;
            DisplayFormat = displayFormat;
            Env = env;
            EventSize = eventSize;
            FontSize = fontSize;
            Group = group;
            GroupBies = groupBies;
            Grouping = grouping;
            Height = height;
            HideZeroCounts = hideZeroCounts;
            Html = html;
            LayoutVersion = layoutVersion;
            Legend = legend;
            LegendSize = legendSize;
            Logset = logset;
            ManageStatusShowTitle = manageStatusShowTitle;
            ManageStatusTitleAlign = manageStatusTitleAlign;
            ManageStatusTitleSize = manageStatusTitleSize;
            ManageStatusTitleText = manageStatusTitleText;
            Margin = margin;
            Monitor = monitor;
            MustShowBreakdown = mustShowBreakdown;
            MustShowDistribution = mustShowDistribution;
            MustShowErrors = mustShowErrors;
            MustShowHits = mustShowHits;
            MustShowLatency = mustShowLatency;
            MustShowResourceList = mustShowResourceList;
            Params = @params;
            Precision = precision;
            Query = query;
            Rules = rules;
            ServiceName = serviceName;
            ServiceService = serviceService;
            ShowLastTriggered = showLastTriggered;
            SizeVersion = sizeVersion;
            Sizing = sizing;
            SummaryType = summaryType;
            Tags = tags;
            Text = text;
            TextAlign = textAlign;
            TextSize = textSize;
            Tick = tick;
            TickEdge = tickEdge;
            TickPos = tickPos;
            TileDeves = tileDeves;
            Time = time;
            Timeframes = timeframes;
            Title = title;
            TitleAlign = titleAlign;
            TitleSize = titleSize;
            Type = type;
            Unit = unit;
            Url = url;
            VizType = vizType;
            Width = width;
            X = x;
            Y = y;
        }
    }
}
