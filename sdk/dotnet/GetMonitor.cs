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
        /// ## Schema
        /// 
        /// ### Optional
        /// 
        /// - **id** (String) The ID of this resource.
        /// - **monitor_tags_filter** (List of String) A list of monitor tags to limit the search. This filters on the tags set on the monitor itself.
        /// - **name_filter** (String) A monitor name to limit the search.
        /// - **tags_filter** (List of String) A list of tags to limit the search. This filters on the monitor scope.
        /// 
        /// ### Read-only
        /// 
        /// - **enable_logs_sample** (Boolean) Whether or not a list of log values which triggered the alert is included. This is only used by log monitors.
        /// - **escalation_message** (String) Message included with a re-notification for this monitor.
        /// - **evaluation_delay** (Number) Time (in seconds) for which evaluation is delayed. This is only used by metric monitors.
        /// - **include_tags** (Boolean) Whether or not notifications from the monitor automatically inserts its triggering tags into the title.
        /// - **locked** (Boolean) Whether or not changes to the monitor are restricted to the creator or admins.
        /// - **message** (String) Message included with notifications for this monitor
        /// - **monitor_threshold_windows** (List of Object) Mapping containing `recovery_window` and `trigger_window` values, e.g. `last_15m`. This is only used by anomaly monitors. (see below for nested schema)
        /// - **monitor_thresholds** (List of Object) Alert thresholds of the monitor. (see below for nested schema)
        /// - **name** (String) Name of the monitor
        /// - **new_host_delay** (Number) Time (in seconds) allowing a host to boot and applications to fully start before starting the evaluation of monitor results.
        /// - **no_data_timeframe** (Number) The number of minutes before the monitor notifies when data stops reporting.
        /// - **notify_audit** (Boolean) Whether or not tagged users are notified on changes to the monitor.
        /// - **notify_no_data** (Boolean) Whether or not this monitor notifies when data stops reporting.
        /// - **query** (String) Query of the monitor.
        /// - **renotify_interval** (Number) The number of minutes after the last notification before the monitor re-notifies on the current status.
        /// - **require_full_window** (Boolean) Whether or not the monitor needs a full window of data before it is evaluated.
        /// - **tags** (Set of String) List of tags associated with the monitor.
        /// - **threshold_windows** (Map of String, Deprecated) Mapping containing `recovery_window` and `trigger_window` values, e.g. `last_15m`. This is only used by anomaly monitors.
        /// - **thresholds** (Map of String, Deprecated) Alert thresholds of the monitor.
        /// - **timeout_h** (Number) Number of hours of the monitor not reporting data before it automatically resolves from a triggered state.
        /// - **type** (String) Type of the monitor.
        /// 
        /// &lt;a id="nestedatt--monitor_threshold_windows"&gt;&lt;/a&gt;
        /// ### Nested Schema for `monitor_threshold_windows`
        /// 
        /// Read-only:
        /// 
        /// - **recovery_window** (String)
        /// - **trigger_window** (String)
        /// 
        /// 
        /// &lt;a id="nestedatt--monitor_thresholds"&gt;&lt;/a&gt;
        /// ### Nested Schema for `monitor_thresholds`
        /// 
        /// Read-only:
        /// 
        /// - **critical** (String)
        /// - **critical_recovery** (String)
        /// - **ok** (String)
        /// - **unknown** (String)
        /// - **warning** (String)
        /// - **warning_recovery** (String)
        /// </summary>
        public static Task<GetMonitorResult> InvokeAsync(GetMonitorArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetMonitorResult>("datadog:index/getMonitor:getMonitor", args ?? new GetMonitorArgs(), options.WithVersion());
    }


    public sealed class GetMonitorArgs : Pulumi.InvokeArgs
    {
        [Input("monitorTagsFilters")]
        private List<string>? _monitorTagsFilters;
        public List<string> MonitorTagsFilters
        {
            get => _monitorTagsFilters ?? (_monitorTagsFilters = new List<string>());
            set => _monitorTagsFilters = value;
        }

        [Input("nameFilter")]
        public string? NameFilter { get; set; }

        [Input("tagsFilters")]
        private List<string>? _tagsFilters;
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
        public readonly bool EnableLogsSample;
        public readonly string EscalationMessage;
        public readonly int EvaluationDelay;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly bool IncludeTags;
        public readonly bool Locked;
        public readonly string Message;
        public readonly ImmutableArray<string> MonitorTagsFilters;
        public readonly Outputs.GetMonitorMonitorThresholdWindowsResult MonitorThresholdWindows;
        public readonly Outputs.GetMonitorMonitorThresholdsResult MonitorThresholds;
        public readonly string Name;
        public readonly string? NameFilter;
        public readonly int NewHostDelay;
        public readonly int NoDataTimeframe;
        public readonly bool NotifyAudit;
        public readonly bool NotifyNoData;
        public readonly string Query;
        public readonly int RenotifyInterval;
        public readonly bool RequireFullWindow;
        public readonly ImmutableArray<string> Tags;
        public readonly ImmutableArray<string> TagsFilters;
        public readonly Outputs.GetMonitorThresholdWindowsResult ThresholdWindows;
        public readonly Outputs.GetMonitorThresholdsResult Thresholds;
        public readonly int TimeoutH;
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

            Outputs.GetMonitorMonitorThresholdWindowsResult monitorThresholdWindows,

            Outputs.GetMonitorMonitorThresholdsResult monitorThresholds,

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
            MonitorThresholdWindows = monitorThresholdWindows;
            MonitorThresholds = monitorThresholds;
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
