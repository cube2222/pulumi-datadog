// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog
{
    /// <summary>
    /// Provides a Datadog downtime resource. This can be used to create and manage Datadog downtimes.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/downtime.html.markdown.
    /// </summary>
    public partial class Downtime : Pulumi.CustomResource
    {
        /// <summary>
        /// A flag indicating if the downtime is active now.
        /// </summary>
        [Output("active")]
        public Output<bool?> Active { get; private set; } = null!;

        /// <summary>
        /// A flag indicating if the downtime was disabled.
        /// </summary>
        [Output("disabled")]
        public Output<bool?> Disabled { get; private set; } = null!;

        /// <summary>
        /// POSIX timestamp to end the downtime.
        /// </summary>
        [Output("end")]
        public Output<int?> End { get; private set; } = null!;

        /// <summary>
        /// String representing date and time to end the downtime in RFC3339 format.
        /// </summary>
        [Output("endDate")]
        public Output<string?> EndDate { get; private set; } = null!;

        /// <summary>
        /// A message to include with notifications for this downtime.
        /// </summary>
        [Output("message")]
        public Output<string?> Message { get; private set; } = null!;

        /// <summary>
        /// When specified, this downtime will only apply to this monitor
        /// </summary>
        [Output("monitorId")]
        public Output<int?> MonitorId { get; private set; } = null!;

        /// <summary>
        /// A list of monitor tags to match. The resulting downtime applies to monitors that match **all** provided monitor tags. This option conflicts with `monitor_id` as it will match all monitors that match these tags.
        /// </summary>
        [Output("monitorTags")]
        public Output<ImmutableArray<string>> MonitorTags { get; private set; } = null!;

        /// <summary>
        /// A dictionary to configure the downtime to be recurring.
        /// </summary>
        [Output("recurrence")]
        public Output<Outputs.DowntimeRecurrence?> Recurrence { get; private set; } = null!;

        /// <summary>
        /// A list of items to apply the downtime to, e.g. host:X
        /// </summary>
        [Output("scopes")]
        public Output<ImmutableArray<string>> Scopes { get; private set; } = null!;

        /// <summary>
        /// POSIX timestamp to start the downtime.
        /// </summary>
        [Output("start")]
        public Output<int?> Start { get; private set; } = null!;

        /// <summary>
        /// String representing date and time to start the downtime in RFC3339 format.
        /// </summary>
        [Output("startDate")]
        public Output<string?> StartDate { get; private set; } = null!;

        /// <summary>
        /// The timezone for the downtime, default UTC. It must be a valid IANA Time Zone.
        /// </summary>
        [Output("timezone")]
        public Output<string?> Timezone { get; private set; } = null!;


        /// <summary>
        /// Create a Downtime resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Downtime(string name, DowntimeArgs args, CustomResourceOptions? options = null)
            : base("datadog:index/downtime:Downtime", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Downtime(string name, Input<string> id, DowntimeState? state = null, CustomResourceOptions? options = null)
            : base("datadog:index/downtime:Downtime", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Downtime resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Downtime Get(string name, Input<string> id, DowntimeState? state = null, CustomResourceOptions? options = null)
        {
            return new Downtime(name, id, state, options);
        }
    }

    public sealed class DowntimeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A flag indicating if the downtime is active now.
        /// </summary>
        [Input("active")]
        public Input<bool>? Active { get; set; }

        /// <summary>
        /// A flag indicating if the downtime was disabled.
        /// </summary>
        [Input("disabled")]
        public Input<bool>? Disabled { get; set; }

        /// <summary>
        /// POSIX timestamp to end the downtime.
        /// </summary>
        [Input("end")]
        public Input<int>? End { get; set; }

        /// <summary>
        /// String representing date and time to end the downtime in RFC3339 format.
        /// </summary>
        [Input("endDate")]
        public Input<string>? EndDate { get; set; }

        /// <summary>
        /// A message to include with notifications for this downtime.
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// When specified, this downtime will only apply to this monitor
        /// </summary>
        [Input("monitorId")]
        public Input<int>? MonitorId { get; set; }

        [Input("monitorTags")]
        private InputList<string>? _monitorTags;

        /// <summary>
        /// A list of monitor tags to match. The resulting downtime applies to monitors that match **all** provided monitor tags. This option conflicts with `monitor_id` as it will match all monitors that match these tags.
        /// </summary>
        public InputList<string> MonitorTags
        {
            get => _monitorTags ?? (_monitorTags = new InputList<string>());
            set => _monitorTags = value;
        }

        /// <summary>
        /// A dictionary to configure the downtime to be recurring.
        /// </summary>
        [Input("recurrence")]
        public Input<Inputs.DowntimeRecurrenceArgs>? Recurrence { get; set; }

        [Input("scopes", required: true)]
        private InputList<string>? _scopes;

        /// <summary>
        /// A list of items to apply the downtime to, e.g. host:X
        /// </summary>
        public InputList<string> Scopes
        {
            get => _scopes ?? (_scopes = new InputList<string>());
            set => _scopes = value;
        }

        /// <summary>
        /// POSIX timestamp to start the downtime.
        /// </summary>
        [Input("start")]
        public Input<int>? Start { get; set; }

        /// <summary>
        /// String representing date and time to start the downtime in RFC3339 format.
        /// </summary>
        [Input("startDate")]
        public Input<string>? StartDate { get; set; }

        /// <summary>
        /// The timezone for the downtime, default UTC. It must be a valid IANA Time Zone.
        /// </summary>
        [Input("timezone")]
        public Input<string>? Timezone { get; set; }

        public DowntimeArgs()
        {
        }
    }

    public sealed class DowntimeState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A flag indicating if the downtime is active now.
        /// </summary>
        [Input("active")]
        public Input<bool>? Active { get; set; }

        /// <summary>
        /// A flag indicating if the downtime was disabled.
        /// </summary>
        [Input("disabled")]
        public Input<bool>? Disabled { get; set; }

        /// <summary>
        /// POSIX timestamp to end the downtime.
        /// </summary>
        [Input("end")]
        public Input<int>? End { get; set; }

        /// <summary>
        /// String representing date and time to end the downtime in RFC3339 format.
        /// </summary>
        [Input("endDate")]
        public Input<string>? EndDate { get; set; }

        /// <summary>
        /// A message to include with notifications for this downtime.
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// When specified, this downtime will only apply to this monitor
        /// </summary>
        [Input("monitorId")]
        public Input<int>? MonitorId { get; set; }

        [Input("monitorTags")]
        private InputList<string>? _monitorTags;

        /// <summary>
        /// A list of monitor tags to match. The resulting downtime applies to monitors that match **all** provided monitor tags. This option conflicts with `monitor_id` as it will match all monitors that match these tags.
        /// </summary>
        public InputList<string> MonitorTags
        {
            get => _monitorTags ?? (_monitorTags = new InputList<string>());
            set => _monitorTags = value;
        }

        /// <summary>
        /// A dictionary to configure the downtime to be recurring.
        /// </summary>
        [Input("recurrence")]
        public Input<Inputs.DowntimeRecurrenceGetArgs>? Recurrence { get; set; }

        [Input("scopes")]
        private InputList<string>? _scopes;

        /// <summary>
        /// A list of items to apply the downtime to, e.g. host:X
        /// </summary>
        public InputList<string> Scopes
        {
            get => _scopes ?? (_scopes = new InputList<string>());
            set => _scopes = value;
        }

        /// <summary>
        /// POSIX timestamp to start the downtime.
        /// </summary>
        [Input("start")]
        public Input<int>? Start { get; set; }

        /// <summary>
        /// String representing date and time to start the downtime in RFC3339 format.
        /// </summary>
        [Input("startDate")]
        public Input<string>? StartDate { get; set; }

        /// <summary>
        /// The timezone for the downtime, default UTC. It must be a valid IANA Time Zone.
        /// </summary>
        [Input("timezone")]
        public Input<string>? Timezone { get; set; }

        public DowntimeState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class DowntimeRecurrenceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// How often to repeat as an integer. For example to repeat every 3 days, select a type of days and a period of 3.
        /// </summary>
        [Input("period", required: true)]
        public Input<int> Period { get; set; } = null!;

        /// <summary>
        /// days, weeks, months, or years
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// The date at which the recurrence should end as a POSIX timestamp. `until_occurrences` and `until_date` are mutually exclusive.
        /// </summary>
        [Input("untilDate")]
        public Input<int>? UntilDate { get; set; }

        /// <summary>
        /// How many times the downtime will be rescheduled. `until_occurrences` and `until_date` are mutually exclusive.
        /// </summary>
        [Input("untilOccurrences")]
        public Input<int>? UntilOccurrences { get; set; }

        [Input("weekDays")]
        private InputList<string>? _weekDays;

        /// <summary>
        /// A list of week days to repeat on. Choose from: Mon, Tue, Wed, Thu, Fri, Sat or Sun. Only applicable when type is weeks. First letter must be capitalized.
        /// </summary>
        public InputList<string> WeekDays
        {
            get => _weekDays ?? (_weekDays = new InputList<string>());
            set => _weekDays = value;
        }

        public DowntimeRecurrenceArgs()
        {
        }
    }

    public sealed class DowntimeRecurrenceGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// How often to repeat as an integer. For example to repeat every 3 days, select a type of days and a period of 3.
        /// </summary>
        [Input("period", required: true)]
        public Input<int> Period { get; set; } = null!;

        /// <summary>
        /// days, weeks, months, or years
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// The date at which the recurrence should end as a POSIX timestamp. `until_occurrences` and `until_date` are mutually exclusive.
        /// </summary>
        [Input("untilDate")]
        public Input<int>? UntilDate { get; set; }

        /// <summary>
        /// How many times the downtime will be rescheduled. `until_occurrences` and `until_date` are mutually exclusive.
        /// </summary>
        [Input("untilOccurrences")]
        public Input<int>? UntilOccurrences { get; set; }

        [Input("weekDays")]
        private InputList<string>? _weekDays;

        /// <summary>
        /// A list of week days to repeat on. Choose from: Mon, Tue, Wed, Thu, Fri, Sat or Sun. Only applicable when type is weeks. First letter must be capitalized.
        /// </summary>
        public InputList<string> WeekDays
        {
            get => _weekDays ?? (_weekDays = new InputList<string>());
            set => _weekDays = value;
        }

        public DowntimeRecurrenceGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class DowntimeRecurrence
    {
        /// <summary>
        /// How often to repeat as an integer. For example to repeat every 3 days, select a type of days and a period of 3.
        /// </summary>
        public readonly int Period;
        /// <summary>
        /// days, weeks, months, or years
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The date at which the recurrence should end as a POSIX timestamp. `until_occurrences` and `until_date` are mutually exclusive.
        /// </summary>
        public readonly int? UntilDate;
        /// <summary>
        /// How many times the downtime will be rescheduled. `until_occurrences` and `until_date` are mutually exclusive.
        /// </summary>
        public readonly int? UntilOccurrences;
        /// <summary>
        /// A list of week days to repeat on. Choose from: Mon, Tue, Wed, Thu, Fri, Sat or Sun. Only applicable when type is weeks. First letter must be capitalized.
        /// </summary>
        public readonly ImmutableArray<string> WeekDays;

        [OutputConstructor]
        private DowntimeRecurrence(
            int period,
            string type,
            int? untilDate,
            int? untilOccurrences,
            ImmutableArray<string> weekDays)
        {
            Period = period;
            Type = type;
            UntilDate = untilDate;
            UntilOccurrences = untilOccurrences;
            WeekDays = weekDays;
        }
    }
    }
}
