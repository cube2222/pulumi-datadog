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
