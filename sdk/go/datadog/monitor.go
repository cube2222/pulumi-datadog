// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// ## Import
//
// Import is supported using the following syntax
//
// ```sh
//  $ pulumi import datadog:index/monitor:Monitor bytes_received_localhost 2081
// ```
type Monitor struct {
	pulumi.CustomResourceState

	// A boolean indicating whether or not to include a list of log values which triggered the alert. This is only used by log
	// monitors. Defaults to `false`.
	EnableLogsSample pulumi.BoolPtrOutput `pulumi:"enableLogsSample"`
	// A message to include with a re-notification. Supports the `@username` notification allowed elsewhere.
	EscalationMessage pulumi.StringPtrOutput `pulumi:"escalationMessage"`
	// (Only applies to metric alert) Time (in seconds) to delay evaluation, as a non-negative integer. For example, if the
	// value is set to `300` (5min), the `timeframe` is set to `last_5m` and the time is 7:00, the monitor will evaluate data
	// from 6:50 to 6:55. This is useful for AWS CloudWatch and other backfilled metrics to ensure the monitor will always have
	// data during evaluation.
	EvaluationDelay pulumi.IntOutput `pulumi:"evaluationDelay"`
	// A boolean indicating whether this monitor can be deleted even if it’s referenced by other resources (e.g. SLO,
	// composite monitor).
	ForceDelete pulumi.BoolPtrOutput `pulumi:"forceDelete"`
	// A boolean indicating whether notifications from this monitor automatically insert its triggering tags into the title.
	// Defaults to `true`.
	IncludeTags pulumi.BoolPtrOutput `pulumi:"includeTags"`
	// A boolean indicating whether changes to to this monitor should be restricted to the creator or admins. Defaults to
	// `false`.
	Locked pulumi.BoolPtrOutput `pulumi:"locked"`
	// A message to include with notifications for this monitor. Email notifications can be sent to specific users by using the
	// same `@username` notation as events.
	Message pulumi.StringOutput `pulumi:"message"`
	// A mapping containing `recovery_window` and `trigger_window` values, e.g. `last_15m` . Can only be used for, and are
	// required for, anomaly monitors.
	MonitorThresholdWindows MonitorMonitorThresholdWindowsPtrOutput `pulumi:"monitorThresholdWindows"`
	// Alert thresholds of the monitor.
	MonitorThresholds MonitorMonitorThresholdsPtrOutput `pulumi:"monitorThresholds"`
	// Name of Datadog monitor.
	Name pulumi.StringOutput `pulumi:"name"`
	// Time (in seconds) to allow a host to boot and applications to fully start before starting the evaluation of monitor
	// results. Should be a non negative integer. Defaults to `300`.
	NewHostDelay pulumi.IntPtrOutput `pulumi:"newHostDelay"`
	// The number of minutes before a monitor will notify when data stops reporting. Provider defaults to 10 minutes. We
	// recommend at least 2x the monitor timeframe for metric alerts or 2 minutes for service checks.
	NoDataTimeframe pulumi.IntPtrOutput `pulumi:"noDataTimeframe"`
	// A boolean indicating whether tagged users will be notified on changes to this monitor. Defaults to `false`.
	NotifyAudit pulumi.BoolPtrOutput `pulumi:"notifyAudit"`
	// A boolean indicating whether this monitor will notify when data stops reporting. Defaults to false.
	NotifyNoData pulumi.BoolPtrOutput `pulumi:"notifyNoData"`
	Priority     pulumi.IntPtrOutput  `pulumi:"priority"`
	// The monitor query to notify on. Note this is not the same query you see in the UI and the syntax is different depending
	// on the monitor type, please see the [API Reference](https://docs.datadoghq.com/api/v1/monitors/#create-a-monitor) for
	// details. Warning: `terraform plan` won't perform any validation of the query contents.
	Query pulumi.StringOutput `pulumi:"query"`
	// The number of minutes after the last notification before a monitor will re-notify on the current status. It will only
	// re-notify if it's not resolved.
	RenotifyInterval pulumi.IntPtrOutput `pulumi:"renotifyInterval"`
	// A boolean indicating whether this monitor needs a full window of data before it's evaluated. We highly recommend you set
	// this to `false` for s metrics, otherwise some evaluations will be skipped. Default: `true` for `on average`, `at all
	// times` and `in total` aggregation. `false` otherwise.
	RequireFullWindow pulumi.BoolPtrOutput `pulumi:"requireFullWindow"`
	// Each scope will be muted until the given POSIX timestamp or forever if the value is `0`. Use `-1` if you want to unmute
	// the scope. Deprecated: the silenced parameter is being deprecated in favor of the downtime resource. This will be
	// removed in the next major version of the Terraform Provider.
	//
	// Deprecated: use Downtime Resource instead
	Silenced pulumi.MapOutput `pulumi:"silenced"`
	// A list of tags to associate with your monitor. This can help you categorize and filter monitors in the manage monitors
	// page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	Tags pulumi.StringArrayOutput `pulumi:"tags"`
	// A mapping containing `recovery_window` and `trigger_window` values, e.g. `last_15m`. Can only be used for, and are
	// required for, anomaly monitors.
	//
	// Deprecated: Define `monitor_threshold_windows` list with one element instead.
	ThresholdWindows MonitorThresholdWindowsPtrOutput `pulumi:"thresholdWindows"`
	// Alert thresholds of the monitor.
	//
	// Deprecated: Define `monitor_thresholds` list with one element instead.
	Thresholds MonitorThresholdsPtrOutput `pulumi:"thresholds"`
	// The number of hours of the monitor not reporting data before it will automatically resolve from a triggered state.
	// Defaults to `false`.
	TimeoutH pulumi.IntPtrOutput `pulumi:"timeoutH"`
	// The type of the monitor. The mapping from these types to the types found in the Datadog Web UI can be found in the
	// Datadog API [documentation page](https://docs.datadoghq.com/api/v1/monitors/#create-a-monitor). Note: The monitor type
	// cannot be changed after a monitor is created.
	Type pulumi.StringOutput `pulumi:"type"`
	// If set to `false`, skip the validation call done during plan.
	Validate pulumi.BoolPtrOutput `pulumi:"validate"`
}

// NewMonitor registers a new resource with the given unique name, arguments, and options.
func NewMonitor(ctx *pulumi.Context,
	name string, args *MonitorArgs, opts ...pulumi.ResourceOption) (*Monitor, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Message == nil {
		return nil, errors.New("invalid value for required argument 'Message'")
	}
	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.Query == nil {
		return nil, errors.New("invalid value for required argument 'Query'")
	}
	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	var resource Monitor
	err := ctx.RegisterResource("datadog:index/monitor:Monitor", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMonitor gets an existing Monitor resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMonitor(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MonitorState, opts ...pulumi.ResourceOption) (*Monitor, error) {
	var resource Monitor
	err := ctx.ReadResource("datadog:index/monitor:Monitor", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Monitor resources.
type monitorState struct {
	// A boolean indicating whether or not to include a list of log values which triggered the alert. This is only used by log
	// monitors. Defaults to `false`.
	EnableLogsSample *bool `pulumi:"enableLogsSample"`
	// A message to include with a re-notification. Supports the `@username` notification allowed elsewhere.
	EscalationMessage *string `pulumi:"escalationMessage"`
	// (Only applies to metric alert) Time (in seconds) to delay evaluation, as a non-negative integer. For example, if the
	// value is set to `300` (5min), the `timeframe` is set to `last_5m` and the time is 7:00, the monitor will evaluate data
	// from 6:50 to 6:55. This is useful for AWS CloudWatch and other backfilled metrics to ensure the monitor will always have
	// data during evaluation.
	EvaluationDelay *int `pulumi:"evaluationDelay"`
	// A boolean indicating whether this monitor can be deleted even if it’s referenced by other resources (e.g. SLO,
	// composite monitor).
	ForceDelete *bool `pulumi:"forceDelete"`
	// A boolean indicating whether notifications from this monitor automatically insert its triggering tags into the title.
	// Defaults to `true`.
	IncludeTags *bool `pulumi:"includeTags"`
	// A boolean indicating whether changes to to this monitor should be restricted to the creator or admins. Defaults to
	// `false`.
	Locked *bool `pulumi:"locked"`
	// A message to include with notifications for this monitor. Email notifications can be sent to specific users by using the
	// same `@username` notation as events.
	Message *string `pulumi:"message"`
	// A mapping containing `recovery_window` and `trigger_window` values, e.g. `last_15m` . Can only be used for, and are
	// required for, anomaly monitors.
	MonitorThresholdWindows *MonitorMonitorThresholdWindows `pulumi:"monitorThresholdWindows"`
	// Alert thresholds of the monitor.
	MonitorThresholds *MonitorMonitorThresholds `pulumi:"monitorThresholds"`
	// Name of Datadog monitor.
	Name *string `pulumi:"name"`
	// Time (in seconds) to allow a host to boot and applications to fully start before starting the evaluation of monitor
	// results. Should be a non negative integer. Defaults to `300`.
	NewHostDelay *int `pulumi:"newHostDelay"`
	// The number of minutes before a monitor will notify when data stops reporting. Provider defaults to 10 minutes. We
	// recommend at least 2x the monitor timeframe for metric alerts or 2 minutes for service checks.
	NoDataTimeframe *int `pulumi:"noDataTimeframe"`
	// A boolean indicating whether tagged users will be notified on changes to this monitor. Defaults to `false`.
	NotifyAudit *bool `pulumi:"notifyAudit"`
	// A boolean indicating whether this monitor will notify when data stops reporting. Defaults to false.
	NotifyNoData *bool `pulumi:"notifyNoData"`
	Priority     *int  `pulumi:"priority"`
	// The monitor query to notify on. Note this is not the same query you see in the UI and the syntax is different depending
	// on the monitor type, please see the [API Reference](https://docs.datadoghq.com/api/v1/monitors/#create-a-monitor) for
	// details. Warning: `terraform plan` won't perform any validation of the query contents.
	Query *string `pulumi:"query"`
	// The number of minutes after the last notification before a monitor will re-notify on the current status. It will only
	// re-notify if it's not resolved.
	RenotifyInterval *int `pulumi:"renotifyInterval"`
	// A boolean indicating whether this monitor needs a full window of data before it's evaluated. We highly recommend you set
	// this to `false` for s metrics, otherwise some evaluations will be skipped. Default: `true` for `on average`, `at all
	// times` and `in total` aggregation. `false` otherwise.
	RequireFullWindow *bool `pulumi:"requireFullWindow"`
	// Each scope will be muted until the given POSIX timestamp or forever if the value is `0`. Use `-1` if you want to unmute
	// the scope. Deprecated: the silenced parameter is being deprecated in favor of the downtime resource. This will be
	// removed in the next major version of the Terraform Provider.
	//
	// Deprecated: use Downtime Resource instead
	Silenced map[string]interface{} `pulumi:"silenced"`
	// A list of tags to associate with your monitor. This can help you categorize and filter monitors in the manage monitors
	// page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	Tags []string `pulumi:"tags"`
	// A mapping containing `recovery_window` and `trigger_window` values, e.g. `last_15m`. Can only be used for, and are
	// required for, anomaly monitors.
	//
	// Deprecated: Define `monitor_threshold_windows` list with one element instead.
	ThresholdWindows *MonitorThresholdWindows `pulumi:"thresholdWindows"`
	// Alert thresholds of the monitor.
	//
	// Deprecated: Define `monitor_thresholds` list with one element instead.
	Thresholds *MonitorThresholds `pulumi:"thresholds"`
	// The number of hours of the monitor not reporting data before it will automatically resolve from a triggered state.
	// Defaults to `false`.
	TimeoutH *int `pulumi:"timeoutH"`
	// The type of the monitor. The mapping from these types to the types found in the Datadog Web UI can be found in the
	// Datadog API [documentation page](https://docs.datadoghq.com/api/v1/monitors/#create-a-monitor). Note: The monitor type
	// cannot be changed after a monitor is created.
	Type *string `pulumi:"type"`
	// If set to `false`, skip the validation call done during plan.
	Validate *bool `pulumi:"validate"`
}

type MonitorState struct {
	// A boolean indicating whether or not to include a list of log values which triggered the alert. This is only used by log
	// monitors. Defaults to `false`.
	EnableLogsSample pulumi.BoolPtrInput
	// A message to include with a re-notification. Supports the `@username` notification allowed elsewhere.
	EscalationMessage pulumi.StringPtrInput
	// (Only applies to metric alert) Time (in seconds) to delay evaluation, as a non-negative integer. For example, if the
	// value is set to `300` (5min), the `timeframe` is set to `last_5m` and the time is 7:00, the monitor will evaluate data
	// from 6:50 to 6:55. This is useful for AWS CloudWatch and other backfilled metrics to ensure the monitor will always have
	// data during evaluation.
	EvaluationDelay pulumi.IntPtrInput
	// A boolean indicating whether this monitor can be deleted even if it’s referenced by other resources (e.g. SLO,
	// composite monitor).
	ForceDelete pulumi.BoolPtrInput
	// A boolean indicating whether notifications from this monitor automatically insert its triggering tags into the title.
	// Defaults to `true`.
	IncludeTags pulumi.BoolPtrInput
	// A boolean indicating whether changes to to this monitor should be restricted to the creator or admins. Defaults to
	// `false`.
	Locked pulumi.BoolPtrInput
	// A message to include with notifications for this monitor. Email notifications can be sent to specific users by using the
	// same `@username` notation as events.
	Message pulumi.StringPtrInput
	// A mapping containing `recovery_window` and `trigger_window` values, e.g. `last_15m` . Can only be used for, and are
	// required for, anomaly monitors.
	MonitorThresholdWindows MonitorMonitorThresholdWindowsPtrInput
	// Alert thresholds of the monitor.
	MonitorThresholds MonitorMonitorThresholdsPtrInput
	// Name of Datadog monitor.
	Name pulumi.StringPtrInput
	// Time (in seconds) to allow a host to boot and applications to fully start before starting the evaluation of monitor
	// results. Should be a non negative integer. Defaults to `300`.
	NewHostDelay pulumi.IntPtrInput
	// The number of minutes before a monitor will notify when data stops reporting. Provider defaults to 10 minutes. We
	// recommend at least 2x the monitor timeframe for metric alerts or 2 minutes for service checks.
	NoDataTimeframe pulumi.IntPtrInput
	// A boolean indicating whether tagged users will be notified on changes to this monitor. Defaults to `false`.
	NotifyAudit pulumi.BoolPtrInput
	// A boolean indicating whether this monitor will notify when data stops reporting. Defaults to false.
	NotifyNoData pulumi.BoolPtrInput
	Priority     pulumi.IntPtrInput
	// The monitor query to notify on. Note this is not the same query you see in the UI and the syntax is different depending
	// on the monitor type, please see the [API Reference](https://docs.datadoghq.com/api/v1/monitors/#create-a-monitor) for
	// details. Warning: `terraform plan` won't perform any validation of the query contents.
	Query pulumi.StringPtrInput
	// The number of minutes after the last notification before a monitor will re-notify on the current status. It will only
	// re-notify if it's not resolved.
	RenotifyInterval pulumi.IntPtrInput
	// A boolean indicating whether this monitor needs a full window of data before it's evaluated. We highly recommend you set
	// this to `false` for s metrics, otherwise some evaluations will be skipped. Default: `true` for `on average`, `at all
	// times` and `in total` aggregation. `false` otherwise.
	RequireFullWindow pulumi.BoolPtrInput
	// Each scope will be muted until the given POSIX timestamp or forever if the value is `0`. Use `-1` if you want to unmute
	// the scope. Deprecated: the silenced parameter is being deprecated in favor of the downtime resource. This will be
	// removed in the next major version of the Terraform Provider.
	//
	// Deprecated: use Downtime Resource instead
	Silenced pulumi.MapInput
	// A list of tags to associate with your monitor. This can help you categorize and filter monitors in the manage monitors
	// page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	Tags pulumi.StringArrayInput
	// A mapping containing `recovery_window` and `trigger_window` values, e.g. `last_15m`. Can only be used for, and are
	// required for, anomaly monitors.
	//
	// Deprecated: Define `monitor_threshold_windows` list with one element instead.
	ThresholdWindows MonitorThresholdWindowsPtrInput
	// Alert thresholds of the monitor.
	//
	// Deprecated: Define `monitor_thresholds` list with one element instead.
	Thresholds MonitorThresholdsPtrInput
	// The number of hours of the monitor not reporting data before it will automatically resolve from a triggered state.
	// Defaults to `false`.
	TimeoutH pulumi.IntPtrInput
	// The type of the monitor. The mapping from these types to the types found in the Datadog Web UI can be found in the
	// Datadog API [documentation page](https://docs.datadoghq.com/api/v1/monitors/#create-a-monitor). Note: The monitor type
	// cannot be changed after a monitor is created.
	Type pulumi.StringPtrInput
	// If set to `false`, skip the validation call done during plan.
	Validate pulumi.BoolPtrInput
}

func (MonitorState) ElementType() reflect.Type {
	return reflect.TypeOf((*monitorState)(nil)).Elem()
}

type monitorArgs struct {
	// A boolean indicating whether or not to include a list of log values which triggered the alert. This is only used by log
	// monitors. Defaults to `false`.
	EnableLogsSample *bool `pulumi:"enableLogsSample"`
	// A message to include with a re-notification. Supports the `@username` notification allowed elsewhere.
	EscalationMessage *string `pulumi:"escalationMessage"`
	// (Only applies to metric alert) Time (in seconds) to delay evaluation, as a non-negative integer. For example, if the
	// value is set to `300` (5min), the `timeframe` is set to `last_5m` and the time is 7:00, the monitor will evaluate data
	// from 6:50 to 6:55. This is useful for AWS CloudWatch and other backfilled metrics to ensure the monitor will always have
	// data during evaluation.
	EvaluationDelay *int `pulumi:"evaluationDelay"`
	// A boolean indicating whether this monitor can be deleted even if it’s referenced by other resources (e.g. SLO,
	// composite monitor).
	ForceDelete *bool `pulumi:"forceDelete"`
	// A boolean indicating whether notifications from this monitor automatically insert its triggering tags into the title.
	// Defaults to `true`.
	IncludeTags *bool `pulumi:"includeTags"`
	// A boolean indicating whether changes to to this monitor should be restricted to the creator or admins. Defaults to
	// `false`.
	Locked *bool `pulumi:"locked"`
	// A message to include with notifications for this monitor. Email notifications can be sent to specific users by using the
	// same `@username` notation as events.
	Message string `pulumi:"message"`
	// A mapping containing `recovery_window` and `trigger_window` values, e.g. `last_15m` . Can only be used for, and are
	// required for, anomaly monitors.
	MonitorThresholdWindows *MonitorMonitorThresholdWindows `pulumi:"monitorThresholdWindows"`
	// Alert thresholds of the monitor.
	MonitorThresholds *MonitorMonitorThresholds `pulumi:"monitorThresholds"`
	// Name of Datadog monitor.
	Name string `pulumi:"name"`
	// Time (in seconds) to allow a host to boot and applications to fully start before starting the evaluation of monitor
	// results. Should be a non negative integer. Defaults to `300`.
	NewHostDelay *int `pulumi:"newHostDelay"`
	// The number of minutes before a monitor will notify when data stops reporting. Provider defaults to 10 minutes. We
	// recommend at least 2x the monitor timeframe for metric alerts or 2 minutes for service checks.
	NoDataTimeframe *int `pulumi:"noDataTimeframe"`
	// A boolean indicating whether tagged users will be notified on changes to this monitor. Defaults to `false`.
	NotifyAudit *bool `pulumi:"notifyAudit"`
	// A boolean indicating whether this monitor will notify when data stops reporting. Defaults to false.
	NotifyNoData *bool `pulumi:"notifyNoData"`
	Priority     *int  `pulumi:"priority"`
	// The monitor query to notify on. Note this is not the same query you see in the UI and the syntax is different depending
	// on the monitor type, please see the [API Reference](https://docs.datadoghq.com/api/v1/monitors/#create-a-monitor) for
	// details. Warning: `terraform plan` won't perform any validation of the query contents.
	Query string `pulumi:"query"`
	// The number of minutes after the last notification before a monitor will re-notify on the current status. It will only
	// re-notify if it's not resolved.
	RenotifyInterval *int `pulumi:"renotifyInterval"`
	// A boolean indicating whether this monitor needs a full window of data before it's evaluated. We highly recommend you set
	// this to `false` for s metrics, otherwise some evaluations will be skipped. Default: `true` for `on average`, `at all
	// times` and `in total` aggregation. `false` otherwise.
	RequireFullWindow *bool `pulumi:"requireFullWindow"`
	// Each scope will be muted until the given POSIX timestamp or forever if the value is `0`. Use `-1` if you want to unmute
	// the scope. Deprecated: the silenced parameter is being deprecated in favor of the downtime resource. This will be
	// removed in the next major version of the Terraform Provider.
	//
	// Deprecated: use Downtime Resource instead
	Silenced map[string]interface{} `pulumi:"silenced"`
	// A list of tags to associate with your monitor. This can help you categorize and filter monitors in the manage monitors
	// page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	Tags []string `pulumi:"tags"`
	// A mapping containing `recovery_window` and `trigger_window` values, e.g. `last_15m`. Can only be used for, and are
	// required for, anomaly monitors.
	//
	// Deprecated: Define `monitor_threshold_windows` list with one element instead.
	ThresholdWindows *MonitorThresholdWindows `pulumi:"thresholdWindows"`
	// Alert thresholds of the monitor.
	//
	// Deprecated: Define `monitor_thresholds` list with one element instead.
	Thresholds *MonitorThresholds `pulumi:"thresholds"`
	// The number of hours of the monitor not reporting data before it will automatically resolve from a triggered state.
	// Defaults to `false`.
	TimeoutH *int `pulumi:"timeoutH"`
	// The type of the monitor. The mapping from these types to the types found in the Datadog Web UI can be found in the
	// Datadog API [documentation page](https://docs.datadoghq.com/api/v1/monitors/#create-a-monitor). Note: The monitor type
	// cannot be changed after a monitor is created.
	Type string `pulumi:"type"`
	// If set to `false`, skip the validation call done during plan.
	Validate *bool `pulumi:"validate"`
}

// The set of arguments for constructing a Monitor resource.
type MonitorArgs struct {
	// A boolean indicating whether or not to include a list of log values which triggered the alert. This is only used by log
	// monitors. Defaults to `false`.
	EnableLogsSample pulumi.BoolPtrInput
	// A message to include with a re-notification. Supports the `@username` notification allowed elsewhere.
	EscalationMessage pulumi.StringPtrInput
	// (Only applies to metric alert) Time (in seconds) to delay evaluation, as a non-negative integer. For example, if the
	// value is set to `300` (5min), the `timeframe` is set to `last_5m` and the time is 7:00, the monitor will evaluate data
	// from 6:50 to 6:55. This is useful for AWS CloudWatch and other backfilled metrics to ensure the monitor will always have
	// data during evaluation.
	EvaluationDelay pulumi.IntPtrInput
	// A boolean indicating whether this monitor can be deleted even if it’s referenced by other resources (e.g. SLO,
	// composite monitor).
	ForceDelete pulumi.BoolPtrInput
	// A boolean indicating whether notifications from this monitor automatically insert its triggering tags into the title.
	// Defaults to `true`.
	IncludeTags pulumi.BoolPtrInput
	// A boolean indicating whether changes to to this monitor should be restricted to the creator or admins. Defaults to
	// `false`.
	Locked pulumi.BoolPtrInput
	// A message to include with notifications for this monitor. Email notifications can be sent to specific users by using the
	// same `@username` notation as events.
	Message pulumi.StringInput
	// A mapping containing `recovery_window` and `trigger_window` values, e.g. `last_15m` . Can only be used for, and are
	// required for, anomaly monitors.
	MonitorThresholdWindows MonitorMonitorThresholdWindowsPtrInput
	// Alert thresholds of the monitor.
	MonitorThresholds MonitorMonitorThresholdsPtrInput
	// Name of Datadog monitor.
	Name pulumi.StringInput
	// Time (in seconds) to allow a host to boot and applications to fully start before starting the evaluation of monitor
	// results. Should be a non negative integer. Defaults to `300`.
	NewHostDelay pulumi.IntPtrInput
	// The number of minutes before a monitor will notify when data stops reporting. Provider defaults to 10 minutes. We
	// recommend at least 2x the monitor timeframe for metric alerts or 2 minutes for service checks.
	NoDataTimeframe pulumi.IntPtrInput
	// A boolean indicating whether tagged users will be notified on changes to this monitor. Defaults to `false`.
	NotifyAudit pulumi.BoolPtrInput
	// A boolean indicating whether this monitor will notify when data stops reporting. Defaults to false.
	NotifyNoData pulumi.BoolPtrInput
	Priority     pulumi.IntPtrInput
	// The monitor query to notify on. Note this is not the same query you see in the UI and the syntax is different depending
	// on the monitor type, please see the [API Reference](https://docs.datadoghq.com/api/v1/monitors/#create-a-monitor) for
	// details. Warning: `terraform plan` won't perform any validation of the query contents.
	Query pulumi.StringInput
	// The number of minutes after the last notification before a monitor will re-notify on the current status. It will only
	// re-notify if it's not resolved.
	RenotifyInterval pulumi.IntPtrInput
	// A boolean indicating whether this monitor needs a full window of data before it's evaluated. We highly recommend you set
	// this to `false` for s metrics, otherwise some evaluations will be skipped. Default: `true` for `on average`, `at all
	// times` and `in total` aggregation. `false` otherwise.
	RequireFullWindow pulumi.BoolPtrInput
	// Each scope will be muted until the given POSIX timestamp or forever if the value is `0`. Use `-1` if you want to unmute
	// the scope. Deprecated: the silenced parameter is being deprecated in favor of the downtime resource. This will be
	// removed in the next major version of the Terraform Provider.
	//
	// Deprecated: use Downtime Resource instead
	Silenced pulumi.MapInput
	// A list of tags to associate with your monitor. This can help you categorize and filter monitors in the manage monitors
	// page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	Tags pulumi.StringArrayInput
	// A mapping containing `recovery_window` and `trigger_window` values, e.g. `last_15m`. Can only be used for, and are
	// required for, anomaly monitors.
	//
	// Deprecated: Define `monitor_threshold_windows` list with one element instead.
	ThresholdWindows MonitorThresholdWindowsPtrInput
	// Alert thresholds of the monitor.
	//
	// Deprecated: Define `monitor_thresholds` list with one element instead.
	Thresholds MonitorThresholdsPtrInput
	// The number of hours of the monitor not reporting data before it will automatically resolve from a triggered state.
	// Defaults to `false`.
	TimeoutH pulumi.IntPtrInput
	// The type of the monitor. The mapping from these types to the types found in the Datadog Web UI can be found in the
	// Datadog API [documentation page](https://docs.datadoghq.com/api/v1/monitors/#create-a-monitor). Note: The monitor type
	// cannot be changed after a monitor is created.
	Type pulumi.StringInput
	// If set to `false`, skip the validation call done during plan.
	Validate pulumi.BoolPtrInput
}

func (MonitorArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*monitorArgs)(nil)).Elem()
}

type MonitorInput interface {
	pulumi.Input

	ToMonitorOutput() MonitorOutput
	ToMonitorOutputWithContext(ctx context.Context) MonitorOutput
}

func (Monitor) ElementType() reflect.Type {
	return reflect.TypeOf((*Monitor)(nil)).Elem()
}

func (i Monitor) ToMonitorOutput() MonitorOutput {
	return i.ToMonitorOutputWithContext(context.Background())
}

func (i Monitor) ToMonitorOutputWithContext(ctx context.Context) MonitorOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MonitorOutput)
}

type MonitorOutput struct {
	*pulumi.OutputState
}

func (MonitorOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*MonitorOutput)(nil)).Elem()
}

func (o MonitorOutput) ToMonitorOutput() MonitorOutput {
	return o
}

func (o MonitorOutput) ToMonitorOutputWithContext(ctx context.Context) MonitorOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(MonitorOutput{})
}
