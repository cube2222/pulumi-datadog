// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Datadog monitor resource. This can be used to create and manage Datadog monitors.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/monitor.html.markdown.
type Monitor struct {
	s *pulumi.ResourceState
}

// NewMonitor registers a new resource with the given unique name, arguments, and options.
func NewMonitor(ctx *pulumi.Context,
	name string, args *MonitorArgs, opts ...pulumi.ResourceOpt) (*Monitor, error) {
	if args == nil || args.Message == nil {
		return nil, errors.New("missing required argument 'Message'")
	}
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.Query == nil {
		return nil, errors.New("missing required argument 'Query'")
	}
	if args == nil || args.Type == nil {
		return nil, errors.New("missing required argument 'Type'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["enableLogsSample"] = nil
		inputs["escalationMessage"] = nil
		inputs["evaluationDelay"] = nil
		inputs["includeTags"] = nil
		inputs["locked"] = nil
		inputs["message"] = nil
		inputs["name"] = nil
		inputs["newHostDelay"] = nil
		inputs["noDataTimeframe"] = nil
		inputs["notifyAudit"] = nil
		inputs["notifyNoData"] = nil
		inputs["query"] = nil
		inputs["renotifyInterval"] = nil
		inputs["requireFullWindow"] = nil
		inputs["silenced"] = nil
		inputs["tags"] = nil
		inputs["thresholdWindows"] = nil
		inputs["thresholds"] = nil
		inputs["timeoutH"] = nil
		inputs["type"] = nil
	} else {
		inputs["enableLogsSample"] = args.EnableLogsSample
		inputs["escalationMessage"] = args.EscalationMessage
		inputs["evaluationDelay"] = args.EvaluationDelay
		inputs["includeTags"] = args.IncludeTags
		inputs["locked"] = args.Locked
		inputs["message"] = args.Message
		inputs["name"] = args.Name
		inputs["newHostDelay"] = args.NewHostDelay
		inputs["noDataTimeframe"] = args.NoDataTimeframe
		inputs["notifyAudit"] = args.NotifyAudit
		inputs["notifyNoData"] = args.NotifyNoData
		inputs["query"] = args.Query
		inputs["renotifyInterval"] = args.RenotifyInterval
		inputs["requireFullWindow"] = args.RequireFullWindow
		inputs["silenced"] = args.Silenced
		inputs["tags"] = args.Tags
		inputs["thresholdWindows"] = args.ThresholdWindows
		inputs["thresholds"] = args.Thresholds
		inputs["timeoutH"] = args.TimeoutH
		inputs["type"] = args.Type
	}
	s, err := ctx.RegisterResource("datadog:index/monitor:Monitor", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Monitor{s: s}, nil
}

// GetMonitor gets an existing Monitor resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMonitor(ctx *pulumi.Context,
	name string, id pulumi.ID, state *MonitorState, opts ...pulumi.ResourceOpt) (*Monitor, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["enableLogsSample"] = state.EnableLogsSample
		inputs["escalationMessage"] = state.EscalationMessage
		inputs["evaluationDelay"] = state.EvaluationDelay
		inputs["includeTags"] = state.IncludeTags
		inputs["locked"] = state.Locked
		inputs["message"] = state.Message
		inputs["name"] = state.Name
		inputs["newHostDelay"] = state.NewHostDelay
		inputs["noDataTimeframe"] = state.NoDataTimeframe
		inputs["notifyAudit"] = state.NotifyAudit
		inputs["notifyNoData"] = state.NotifyNoData
		inputs["query"] = state.Query
		inputs["renotifyInterval"] = state.RenotifyInterval
		inputs["requireFullWindow"] = state.RequireFullWindow
		inputs["silenced"] = state.Silenced
		inputs["tags"] = state.Tags
		inputs["thresholdWindows"] = state.ThresholdWindows
		inputs["thresholds"] = state.Thresholds
		inputs["timeoutH"] = state.TimeoutH
		inputs["type"] = state.Type
	}
	s, err := ctx.ReadResource("datadog:index/monitor:Monitor", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Monitor{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Monitor) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Monitor) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// A boolean indicating whether or not to include a list of log values which triggered the alert. Defaults to false. This is only used by log monitors.
// triggering tags into the title. Defaults to true.
func (r *Monitor) EnableLogsSample() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["enableLogsSample"])
}

// A message to include with a re-notification. Supports the '@username'
// notification allowed elsewhere.
func (r *Monitor) EscalationMessage() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["escalationMessage"])
}

func (r *Monitor) EvaluationDelay() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["evaluationDelay"])
}

// A boolean indicating whether notifications from this monitor automatically insert its triggering tags into the title. Defaults to true.
func (r *Monitor) IncludeTags() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["includeTags"])
}

// A boolean indicating whether changes to to this monitor should be restricted to the creator or admins. Defaults to False.
func (r *Monitor) Locked() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["locked"])
}

// A message to include with notifications for this monitor.
// Email notifications can be sent to specific users by using the same '@username' notation as events.
func (r *Monitor) Message() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["message"])
}

// Name of Datadog monitor
func (r *Monitor) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// Time (in seconds) to allow a host to boot and
// applications to fully start before starting the evaluation of monitor
// results. Should be a non negative integer. Defaults to 300.
// * `evaluationDelay` (Optional, only applies to metric alert) Time (in seconds) to delay evaluation, as a non-negative integer.
// For example, if the value is set to 300 (5min), the timeframe is set to last5m and the time is 7:00,
// the monitor will evaluate data from 6:50 to 6:55. This is useful for AWS CloudWatch and other backfilled
// metrics to ensure the monitor will always have data during evaluation.
func (r *Monitor) NewHostDelay() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["newHostDelay"])
}

// The number of minutes before a monitor will notify when data stops reporting. Must be at
// least 2x the monitor timeframe for metric alerts or 2 minutes for service checks. Default: 2x timeframe for
// metric alerts, 2 minutes for service checks. Defaults to 10 minutes.
func (r *Monitor) NoDataTimeframe() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["noDataTimeframe"])
}

// A boolean indicating whether tagged users will be notified on changes to this monitor.
// Defaults to false.
func (r *Monitor) NotifyAudit() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["notifyAudit"])
}

// A boolean indicating whether this monitor will notify when data stops reporting. Defaults
// to false.
func (r *Monitor) NotifyNoData() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["notifyNoData"])
}

func (r *Monitor) Query() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["query"])
}

// The number of minutes after the last notification before a monitor will re-notify
// on the current status. It will only re-notify if it's not resolved.
func (r *Monitor) RenotifyInterval() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["renotifyInterval"])
}

// A boolean indicating whether this monitor needs a full window of data before it's evaluated.
// We highly recommend you set this to False for sparse metrics, otherwise some evaluations will be skipped.
// Default: True for "on average", "at all times" and "in total" aggregation. False otherwise.
func (r *Monitor) RequireFullWindow() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["requireFullWindow"])
}

func (r *Monitor) Silenced() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["silenced"])
}

// A list of tags to associate with your monitor. This can help you categorize and filter monitors in the manage monitors page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
func (r *Monitor) Tags() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["tags"])
}

// A mapping containing `recoveryWindow` and `triggerWindow` values, e.g. `last15m`. Can only be used for, and are required for, anomaly monitors.
// * `recoveryWindow` describes how long an anomalous metric must be normal before the alert recovers.
func (r *Monitor) ThresholdWindows() *pulumi.Output {
	return r.s.State["thresholdWindows"]
}

// 
// * Metric alerts:
// A dictionary of thresholds by threshold type. Currently we have four threshold types for metric alerts: critical, critical recovery, warning, and warning recovery. Critical is defined in the query, but can also be specified in this option. Warning and recovery thresholds can only be specified using the thresholds option.
// Example usage:
// ```
// thresholds = {
// critical          = 90
// criticalRecovery = 85
// warning           = 80
// warningRecovery  = 75
// }
// ```
// **Warning:** the `critical` threshold value must match the one contained in the `query` argument. The `threshold` from the previous example is valid along with a query like `avg(last_1h):avg:system.disk.in_use{role:sqlserver} by {host} > 90` but
// along with something like `avg(last_1h):avg:system.disk.in_use{role:sqlserver} by {host} > 95` would make the Datadog API return a HTTP error 400, complaining "The value provided for parameter 'query' is invalid".
// * Service checks:
// A dictionary of thresholds by status. Because service checks can have multiple thresholds, we don't define them directly in the query.
// Default values:
// ```
// thresholds = {
// ok       = 1
// critical = 1
// warning  = 1
// unknown  = 1
// }
// ```
func (r *Monitor) Thresholds() *pulumi.Output {
	return r.s.State["thresholds"]
}

// The number of hours of the monitor not reporting data before it will automatically resolve
// from a triggered state. Defaults to false.
func (r *Monitor) TimeoutH() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["timeoutH"])
}

// The type of the monitor. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/?lang=python#create-a-monitor) page. Available options to choose from are:
// * `metric alert`
// * `service check`
// * `event alert`
// * `query alert`
// * `composite`
// * `log alert`
func (r *Monitor) Type() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["type"])
}

// Input properties used for looking up and filtering Monitor resources.
type MonitorState struct {
	// A boolean indicating whether or not to include a list of log values which triggered the alert. Defaults to false. This is only used by log monitors.
	// triggering tags into the title. Defaults to true.
	EnableLogsSample interface{}
	// A message to include with a re-notification. Supports the '@username'
	// notification allowed elsewhere.
	EscalationMessage interface{}
	EvaluationDelay interface{}
	// A boolean indicating whether notifications from this monitor automatically insert its triggering tags into the title. Defaults to true.
	IncludeTags interface{}
	// A boolean indicating whether changes to to this monitor should be restricted to the creator or admins. Defaults to False.
	Locked interface{}
	// A message to include with notifications for this monitor.
	// Email notifications can be sent to specific users by using the same '@username' notation as events.
	Message interface{}
	// Name of Datadog monitor
	Name interface{}
	// Time (in seconds) to allow a host to boot and
	// applications to fully start before starting the evaluation of monitor
	// results. Should be a non negative integer. Defaults to 300.
	// * `evaluationDelay` (Optional, only applies to metric alert) Time (in seconds) to delay evaluation, as a non-negative integer.
	// For example, if the value is set to 300 (5min), the timeframe is set to last5m and the time is 7:00,
	// the monitor will evaluate data from 6:50 to 6:55. This is useful for AWS CloudWatch and other backfilled
	// metrics to ensure the monitor will always have data during evaluation.
	NewHostDelay interface{}
	// The number of minutes before a monitor will notify when data stops reporting. Must be at
	// least 2x the monitor timeframe for metric alerts or 2 minutes for service checks. Default: 2x timeframe for
	// metric alerts, 2 minutes for service checks. Defaults to 10 minutes.
	NoDataTimeframe interface{}
	// A boolean indicating whether tagged users will be notified on changes to this monitor.
	// Defaults to false.
	NotifyAudit interface{}
	// A boolean indicating whether this monitor will notify when data stops reporting. Defaults
	// to false.
	NotifyNoData interface{}
	Query interface{}
	// The number of minutes after the last notification before a monitor will re-notify
	// on the current status. It will only re-notify if it's not resolved.
	RenotifyInterval interface{}
	// A boolean indicating whether this monitor needs a full window of data before it's evaluated.
	// We highly recommend you set this to False for sparse metrics, otherwise some evaluations will be skipped.
	// Default: True for "on average", "at all times" and "in total" aggregation. False otherwise.
	RequireFullWindow interface{}
	Silenced interface{}
	// A list of tags to associate with your monitor. This can help you categorize and filter monitors in the manage monitors page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	Tags interface{}
	// A mapping containing `recoveryWindow` and `triggerWindow` values, e.g. `last15m`. Can only be used for, and are required for, anomaly monitors.
	// * `recoveryWindow` describes how long an anomalous metric must be normal before the alert recovers.
	ThresholdWindows interface{}
	// 
	// * Metric alerts:
	// A dictionary of thresholds by threshold type. Currently we have four threshold types for metric alerts: critical, critical recovery, warning, and warning recovery. Critical is defined in the query, but can also be specified in this option. Warning and recovery thresholds can only be specified using the thresholds option.
	// Example usage:
	// ```
	// thresholds = {
	// critical          = 90
	// criticalRecovery = 85
	// warning           = 80
	// warningRecovery  = 75
	// }
	// ```
	// **Warning:** the `critical` threshold value must match the one contained in the `query` argument. The `threshold` from the previous example is valid along with a query like `avg(last_1h):avg:system.disk.in_use{role:sqlserver} by {host} > 90` but
	// along with something like `avg(last_1h):avg:system.disk.in_use{role:sqlserver} by {host} > 95` would make the Datadog API return a HTTP error 400, complaining "The value provided for parameter 'query' is invalid".
	// * Service checks:
	// A dictionary of thresholds by status. Because service checks can have multiple thresholds, we don't define them directly in the query.
	// Default values:
	// ```
	// thresholds = {
	// ok       = 1
	// critical = 1
	// warning  = 1
	// unknown  = 1
	// }
	// ```
	Thresholds interface{}
	// The number of hours of the monitor not reporting data before it will automatically resolve
	// from a triggered state. Defaults to false.
	TimeoutH interface{}
	// The type of the monitor. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/?lang=python#create-a-monitor) page. Available options to choose from are:
	// * `metric alert`
	// * `service check`
	// * `event alert`
	// * `query alert`
	// * `composite`
	// * `log alert`
	Type interface{}
}

// The set of arguments for constructing a Monitor resource.
type MonitorArgs struct {
	// A boolean indicating whether or not to include a list of log values which triggered the alert. Defaults to false. This is only used by log monitors.
	// triggering tags into the title. Defaults to true.
	EnableLogsSample interface{}
	// A message to include with a re-notification. Supports the '@username'
	// notification allowed elsewhere.
	EscalationMessage interface{}
	EvaluationDelay interface{}
	// A boolean indicating whether notifications from this monitor automatically insert its triggering tags into the title. Defaults to true.
	IncludeTags interface{}
	// A boolean indicating whether changes to to this monitor should be restricted to the creator or admins. Defaults to False.
	Locked interface{}
	// A message to include with notifications for this monitor.
	// Email notifications can be sent to specific users by using the same '@username' notation as events.
	Message interface{}
	// Name of Datadog monitor
	Name interface{}
	// Time (in seconds) to allow a host to boot and
	// applications to fully start before starting the evaluation of monitor
	// results. Should be a non negative integer. Defaults to 300.
	// * `evaluationDelay` (Optional, only applies to metric alert) Time (in seconds) to delay evaluation, as a non-negative integer.
	// For example, if the value is set to 300 (5min), the timeframe is set to last5m and the time is 7:00,
	// the monitor will evaluate data from 6:50 to 6:55. This is useful for AWS CloudWatch and other backfilled
	// metrics to ensure the monitor will always have data during evaluation.
	NewHostDelay interface{}
	// The number of minutes before a monitor will notify when data stops reporting. Must be at
	// least 2x the monitor timeframe for metric alerts or 2 minutes for service checks. Default: 2x timeframe for
	// metric alerts, 2 minutes for service checks. Defaults to 10 minutes.
	NoDataTimeframe interface{}
	// A boolean indicating whether tagged users will be notified on changes to this monitor.
	// Defaults to false.
	NotifyAudit interface{}
	// A boolean indicating whether this monitor will notify when data stops reporting. Defaults
	// to false.
	NotifyNoData interface{}
	Query interface{}
	// The number of minutes after the last notification before a monitor will re-notify
	// on the current status. It will only re-notify if it's not resolved.
	RenotifyInterval interface{}
	// A boolean indicating whether this monitor needs a full window of data before it's evaluated.
	// We highly recommend you set this to False for sparse metrics, otherwise some evaluations will be skipped.
	// Default: True for "on average", "at all times" and "in total" aggregation. False otherwise.
	RequireFullWindow interface{}
	Silenced interface{}
	// A list of tags to associate with your monitor. This can help you categorize and filter monitors in the manage monitors page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	Tags interface{}
	// A mapping containing `recoveryWindow` and `triggerWindow` values, e.g. `last15m`. Can only be used for, and are required for, anomaly monitors.
	// * `recoveryWindow` describes how long an anomalous metric must be normal before the alert recovers.
	ThresholdWindows interface{}
	// 
	// * Metric alerts:
	// A dictionary of thresholds by threshold type. Currently we have four threshold types for metric alerts: critical, critical recovery, warning, and warning recovery. Critical is defined in the query, but can also be specified in this option. Warning and recovery thresholds can only be specified using the thresholds option.
	// Example usage:
	// ```
	// thresholds = {
	// critical          = 90
	// criticalRecovery = 85
	// warning           = 80
	// warningRecovery  = 75
	// }
	// ```
	// **Warning:** the `critical` threshold value must match the one contained in the `query` argument. The `threshold` from the previous example is valid along with a query like `avg(last_1h):avg:system.disk.in_use{role:sqlserver} by {host} > 90` but
	// along with something like `avg(last_1h):avg:system.disk.in_use{role:sqlserver} by {host} > 95` would make the Datadog API return a HTTP error 400, complaining "The value provided for parameter 'query' is invalid".
	// * Service checks:
	// A dictionary of thresholds by status. Because service checks can have multiple thresholds, we don't define them directly in the query.
	// Default values:
	// ```
	// thresholds = {
	// ok       = 1
	// critical = 1
	// warning  = 1
	// unknown  = 1
	// }
	// ```
	Thresholds interface{}
	// The number of hours of the monitor not reporting data before it will automatically resolve
	// from a triggered state. Defaults to false.
	TimeoutH interface{}
	// The type of the monitor. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/?lang=python#create-a-monitor) page. Available options to choose from are:
	// * `metric alert`
	// * `service check`
	// * `event alert`
	// * `query alert`
	// * `composite`
	// * `log alert`
	Type interface{}
}
