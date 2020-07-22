// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog
{
    public static class GetMonitor
    {
        /// <summary>
        /// Use this data source to retrieve information about an existing monitor for use in other resources.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Datadog = Pulumi.Datadog;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var test = Output.Create(Datadog.GetMonitor.InvokeAsync(new Datadog.GetMonitorArgs
        ///         {
        ///             MonitorTagsFilters = 
        ///             {
        ///                 "foo:bar",
        ///             },
        ///             NameFilter = "My awesome monitor",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetMonitorResult> InvokeAsync(GetMonitorArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetMonitorResult>("datadog:index/getMonitor:getMonitor", args ?? new GetMonitorArgs(), options.WithVersion());
    }


    public sealed class GetMonitorArgs : Pulumi.InvokeArgs
    {
        [Input("monitorTagsFilters")]
        private List<string>? _monitorTagsFilters;

        /// <summary>
        /// A list of monitor tags to limit the search. This filters on the tags set on the monitor itself.
        /// </summary>
        public List<string> MonitorTagsFilters
        {
            get => _monitorTagsFilters ?? (_monitorTagsFilters = new List<string>());
            set => _monitorTagsFilters = value;
        }

        /// <summary>
        /// A monitor name to limit the search.
        /// </summary>
        [Input("nameFilter")]
        public string? NameFilter { get; set; }

        [Input("tagsFilters")]
        private List<string>? _tagsFilters;

        /// <summary>
        /// A list of tags to limit the search. This filters on the monitor scope.
        /// </summary>
        public List<string> TagsFilters
        {
            get => _tagsFilters ?? (_tagsFilters = new List<string>());
            set => _tagsFilters = value;
        }

        public GetMonitorArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetMonitorResult
    {
        /// <summary>
        /// Whether or not a list of log values which triggered the alert is included. This is only used by log monitors.
        /// </summary>
        public readonly bool EnableLogsSample;
        /// <summary>
        /// Message included with a re-notification for this monitor.
        /// </summary>
        public readonly string EscalationMessage;
        /// <summary>
        /// Time (in seconds) for which evaluation is delayed. This is only used by metric monitors.
        /// </summary>
        public readonly int EvaluationDelay;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Whether or not notifications from the monitor automatically inserts its triggering tags into the title.
        /// </summary>
        public readonly bool IncludeTags;
        /// <summary>
        /// Whether or not changes to the monitor are restricted to the creator or admins.
        /// </summary>
        public readonly bool Locked;
        /// <summary>
        /// Message included with notifications for this monitor.
        /// </summary>
        public readonly string Message;
        public readonly ImmutableArray<string> MonitorTagsFilters;
        /// <summary>
        /// Name of the monitor.
        /// </summary>
        public readonly string Name;
        public readonly string? NameFilter;
        /// <summary>
        /// Time (in seconds) allowing a host to boot and
        /// applications to fully start before starting the evaluation of monitor
        /// results.
        /// </summary>
        public readonly int NewHostDelay;
        /// <summary>
        /// The number of minutes before the monitor notifies when data stops reporting.
        /// </summary>
        public readonly int NoDataTimeframe;
        /// <summary>
        /// Whether or not tagged users are notified on changes to the monitor.
        /// </summary>
        public readonly bool NotifyAudit;
        /// <summary>
        /// Whether or not this monitor notifies when data stops reporting.
        /// </summary>
        public readonly bool NotifyNoData;
        /// <summary>
        /// Query of the monitor.
        /// </summary>
        public readonly string Query;
        /// <summary>
        /// The number of minutes after the last notification before the monitor re-notifies on the current status.
        /// </summary>
        public readonly int RenotifyInterval;
        /// <summary>
        /// Whether or not the monitor needs a full window of data before it is evaluated.
        /// </summary>
        public readonly bool RequireFullWindow;
        /// <summary>
        /// List of tags associated with the monitor.
        /// </summary>
        public readonly ImmutableArray<string> Tags;
        public readonly ImmutableArray<string> TagsFilters;
        /// <summary>
        /// Mapping containing `recovery_window` and `trigger_window` values, e.g. `last_15m`. This is only used by anomaly monitors.
        /// </summary>
        public readonly Outputs.GetMonitorThresholdWindowsResult ThresholdWindows;
        /// <summary>
        /// Alert thresholds of the monitor.
        /// </summary>
        public readonly Outputs.GetMonitorThresholdsResult Thresholds;
        /// <summary>
        /// Number of hours of the monitor not reporting data before it automatically resolves from a triggered state.
        /// </summary>
        public readonly int TimeoutH;
        /// <summary>
        /// Type of the monitor.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetMonitorResult(
            bool enableLogsSample,

            string escalationMessage,

            int evaluationDelay,

            string id,

            bool includeTags,

            bool locked,

            string message,

            ImmutableArray<string> monitorTagsFilters,

            string name,

            string? nameFilter,

            int newHostDelay,

            int noDataTimeframe,

            bool notifyAudit,

            bool notifyNoData,

            string query,

            int renotifyInterval,

            bool requireFullWindow,

            ImmutableArray<string> tags,

            ImmutableArray<string> tagsFilters,

            Outputs.GetMonitorThresholdWindowsResult thresholdWindows,

            Outputs.GetMonitorThresholdsResult thresholds,

            int timeoutH,

            string type)
        {
            EnableLogsSample = enableLogsSample;
            EscalationMessage = escalationMessage;
            EvaluationDelay = evaluationDelay;
            Id = id;
            IncludeTags = includeTags;
            Locked = locked;
            Message = message;
            MonitorTagsFilters = monitorTagsFilters;
            Name = name;
            NameFilter = nameFilter;
            NewHostDelay = newHostDelay;
            NoDataTimeframe = noDataTimeframe;
            NotifyAudit = notifyAudit;
            NotifyNoData = notifyNoData;
            Query = query;
            RenotifyInterval = renotifyInterval;
            RequireFullWindow = requireFullWindow;
            Tags = tags;
            TagsFilters = tagsFilters;
            ThresholdWindows = thresholdWindows;
            Thresholds = thresholds;
            TimeoutH = timeoutH;
            Type = type;
        }
    }
}
