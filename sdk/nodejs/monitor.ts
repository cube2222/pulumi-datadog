// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides a Datadog monitor resource. This can be used to create and manage Datadog monitors.
 *
 * ## Example Usage
 *
 *
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * // Create a new Datadog monitor
 * const foo = new datadog.Monitor("foo", {
 *     name: "Name for monitor foo",
 *     type: "metric alert",
 *     message: "Monitor triggered. Notify: @hipchat-channel",
 *     escalationMessage: "Escalation message @pagerduty",
 *     query: "avg(last_1h):avg:aws.ec2.cpu{environment:foo,host:foo} by {host} > 4",
 *     thresholds: {
 *         ok: 0,
 *         warning: 2,
 *         warning_recovery: 1,
 *         critical: 4,
 *         critical_recovery: 3,
 *     },
 *     notifyNoData: false,
 *     renotifyInterval: 60,
 *     notifyAudit: false,
 *     timeoutH: 60,
 *     includeTags: true,
 *     tags: [
 *         "foo:bar",
 *         "baz",
 *     ],
 * });
 * ```
 *
 * ## Silencing by Hand and by Downtimes
 *
 * There are two ways how to silence a single monitor:
 *
 * * Mute it by hand
 * * Create a Downtime
 *
 * Both of these actions add a new value to the `silenced` map. This can be problematic if the `silenced` attribute doesn't contain them in your application, as they would be removed on next `pulumi up` invocation. In order to prevent that from happening, you can add following to your monitor:
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * ```
 *
 * The above will make sure that any changes to the `silenced` attribute are ignored.
 *
 * This issue doesn't apply to multi-monitor downtimes (those that don't contain `monitorId`), as these don't influence contents of the `silenced` attribute.
 *
 * ## Composite Monitors
 *
 * You can compose monitors of all types in order to define more specific alert conditions (see the [doc](https://docs.datadoghq.com/monitors/monitor_types/composite/)).
 * You just need to reuse the ID of your `datadog..Monitor` resources.
 * You can also compose any monitor with a `datadog..SyntheticsTest` by passing the computed `monitorId` attribute in the query.
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * const bar = new datadog.Monitor("bar", {
 *     message: "This is a message",
 *     name: "Composite Monitor",
 *     query: pulumi.interpolate`${datadog_monitor_foo.id} || ${datadog_synthetics_test_foo.monitorId}`,
 *     type: "composite",
 * });
 * ```
 */
export class Monitor extends pulumi.CustomResource {
    /**
     * Get an existing Monitor resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MonitorState, opts?: pulumi.CustomResourceOptions): Monitor {
        return new Monitor(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:index/monitor:Monitor';

    /**
     * Returns true if the given object is an instance of Monitor.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Monitor {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Monitor.__pulumiType;
    }

    /**
     * A boolean indicating whether or not to include a list of log values which triggered the alert. Defaults to false. This is only used by log monitors.
     * triggering tags into the title. Defaults to true.
     */
    public readonly enableLogsSample!: pulumi.Output<boolean | undefined>;
    /**
     * A message to include with a re-notification. Supports the '@username'
     * notification allowed elsewhere.
     */
    public readonly escalationMessage!: pulumi.Output<string | undefined>;
    /**
     * Time (in seconds) to delay evaluation, as a non-negative integer.
     * For example, if the value is set to 300 (5min), the timeframe is set to last5m and the time is 7:00,
     * the monitor will evaluate data from 6:50 to 6:55. This is useful for AWS CloudWatch and other backfilled
     * metrics to ensure the monitor will always have data during evaluation.
     */
    public readonly evaluationDelay!: pulumi.Output<number>;
    /**
     * A boolean indicating whether notifications from this monitor automatically insert its triggering tags into the title. Defaults to true.
     */
    public readonly includeTags!: pulumi.Output<boolean | undefined>;
    /**
     * A boolean indicating whether changes to to this monitor should be restricted to the creator or admins. Defaults to False.
     */
    public readonly locked!: pulumi.Output<boolean | undefined>;
    /**
     * A message to include with notifications for this monitor.
     * Email notifications can be sent to specific users by using the same '@username' notation as events.
     */
    public readonly message!: pulumi.Output<string>;
    /**
     * Name of Datadog monitor
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Time (in seconds) to allow a host to boot and
     * applications to fully start before starting the evaluation of monitor
     * results. Should be a non negative integer. Defaults to 300.
     */
    public readonly newHostDelay!: pulumi.Output<number | undefined>;
    /**
     * The number of minutes before a monitor will notify when data stops reporting. Provider defaults to 10 minutes.
     * We recommend at least 2x the monitor timeframe for metric alerts or 2 minutes for service checks.
     */
    public readonly noDataTimeframe!: pulumi.Output<number | undefined>;
    /**
     * A boolean indicating whether tagged users will be notified on changes to this monitor.
     * Defaults to false.
     */
    public readonly notifyAudit!: pulumi.Output<boolean | undefined>;
    /**
     * A boolean indicating whether this monitor will notify when data stops reporting. Defaults
     * to false.
     */
    public readonly notifyNoData!: pulumi.Output<boolean | undefined>;
    /**
     * The monitor query to notify on. Note this is not the same query you see in the UI and
     * the syntax is different depending on the monitor `type`, please see the [API Reference](https://docs.datadoghq.com/api/v1/monitors/#create-a-monitor) for details. **Warning:** `pulumi preview` won't perform any validation of the query contents.
     */
    public readonly query!: pulumi.Output<string>;
    /**
     * The number of minutes after the last notification before a monitor will re-notify
     * on the current status. It will only re-notify if it's not resolved.
     */
    public readonly renotifyInterval!: pulumi.Output<number | undefined>;
    /**
     * A boolean indicating whether this monitor needs a full window of data before it's evaluated.
     * We highly recommend you set this to False for sparse metrics, otherwise some evaluations will be skipped.
     * Default: True for "on average", "at all times" and "in total" aggregation. False otherwise.
     */
    public readonly requireFullWindow!: pulumi.Output<boolean | undefined>;
    /**
     * Each scope will be muted until the given POSIX timestamp or forever if the value is 0. Use `-1` if you want to unmute the scope. **Deprecated** The `silenced` parameter is being deprecated in favor of the downtime resource.
     *
     * @deprecated use Downtime Resource instead
     */
    public readonly silenced!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * A list of tags to associate with your monitor. This can help you categorize and filter monitors in the manage monitors page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
     */
    public readonly tags!: pulumi.Output<string[] | undefined>;
    /**
     * A mapping containing `recoveryWindow` and `triggerWindow` values, e.g. `last15m`. Can only be used for, and are required for, anomaly monitors.
     */
    public readonly thresholdWindows!: pulumi.Output<outputs.MonitorThresholdWindows | undefined>;
    /**
     *
     * * Metric alerts:
     * A dictionary of thresholds by threshold type. Currently we have four threshold types for metric alerts: critical, critical recovery, warning, and warning recovery. Critical is defined in the query, but can also be specified in this option. Warning and recovery thresholds can only be specified using the thresholds option.
     * Example usage:
     * ```
     * thresholds = {
     * critical          = 90
     * criticalRecovery = 85
     * warning           = 80
     * warningRecovery  = 75
     * }
     * ```
     * **Warning:** the `critical` threshold value must match the one contained in the `query` argument. The `threshold` from the previous example is valid along with a query like `avg(last_1h):avg:system.disk.in_use{role:sqlserver} by {host} > 90` but
     * along with something like `avg(last_1h):avg:system.disk.in_use{role:sqlserver} by {host} > 95` would make the Datadog API return a HTTP error 400, complaining "The value provided for parameter 'query' is invalid".
     * * Service checks:
     * A dictionary of thresholds by status. Because service checks can have multiple thresholds, we don't define them directly in the query.
     * Default values:
     * ```
     * thresholds = {
     * ok       = 1
     * critical = 1
     * warning  = 1
     * unknown  = 1
     * }
     * ```
     */
    public readonly thresholds!: pulumi.Output<outputs.MonitorThresholds | undefined>;
    /**
     * The number of hours of the monitor not reporting data before it will automatically resolve
     * from a triggered state. Defaults to false.
     */
    public readonly timeoutH!: pulumi.Output<number | undefined>;
    /**
     * The type of the monitor. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/v1/monitors/#create-a-monitor) page. The available options are below. **Note**: The monitor type cannot be changed after a monitor is created.
     * * `metric alert`
     * * `service check`
     * * `event alert`
     * * `query alert`
     * * `composite`
     * * `log alert`
     */
    public readonly type!: pulumi.Output<string>;

    /**
     * Create a Monitor resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MonitorArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MonitorArgs | MonitorState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as MonitorState | undefined;
            inputs["enableLogsSample"] = state ? state.enableLogsSample : undefined;
            inputs["escalationMessage"] = state ? state.escalationMessage : undefined;
            inputs["evaluationDelay"] = state ? state.evaluationDelay : undefined;
            inputs["includeTags"] = state ? state.includeTags : undefined;
            inputs["locked"] = state ? state.locked : undefined;
            inputs["message"] = state ? state.message : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["newHostDelay"] = state ? state.newHostDelay : undefined;
            inputs["noDataTimeframe"] = state ? state.noDataTimeframe : undefined;
            inputs["notifyAudit"] = state ? state.notifyAudit : undefined;
            inputs["notifyNoData"] = state ? state.notifyNoData : undefined;
            inputs["query"] = state ? state.query : undefined;
            inputs["renotifyInterval"] = state ? state.renotifyInterval : undefined;
            inputs["requireFullWindow"] = state ? state.requireFullWindow : undefined;
            inputs["silenced"] = state ? state.silenced : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["thresholdWindows"] = state ? state.thresholdWindows : undefined;
            inputs["thresholds"] = state ? state.thresholds : undefined;
            inputs["timeoutH"] = state ? state.timeoutH : undefined;
            inputs["type"] = state ? state.type : undefined;
        } else {
            const args = argsOrState as MonitorArgs | undefined;
            if (!args || args.message === undefined) {
                throw new Error("Missing required property 'message'");
            }
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            if (!args || args.query === undefined) {
                throw new Error("Missing required property 'query'");
            }
            if (!args || args.type === undefined) {
                throw new Error("Missing required property 'type'");
            }
            inputs["enableLogsSample"] = args ? args.enableLogsSample : undefined;
            inputs["escalationMessage"] = args ? args.escalationMessage : undefined;
            inputs["evaluationDelay"] = args ? args.evaluationDelay : undefined;
            inputs["includeTags"] = args ? args.includeTags : undefined;
            inputs["locked"] = args ? args.locked : undefined;
            inputs["message"] = args ? args.message : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["newHostDelay"] = args ? args.newHostDelay : undefined;
            inputs["noDataTimeframe"] = args ? args.noDataTimeframe : undefined;
            inputs["notifyAudit"] = args ? args.notifyAudit : undefined;
            inputs["notifyNoData"] = args ? args.notifyNoData : undefined;
            inputs["query"] = args ? args.query : undefined;
            inputs["renotifyInterval"] = args ? args.renotifyInterval : undefined;
            inputs["requireFullWindow"] = args ? args.requireFullWindow : undefined;
            inputs["silenced"] = args ? args.silenced : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["thresholdWindows"] = args ? args.thresholdWindows : undefined;
            inputs["thresholds"] = args ? args.thresholds : undefined;
            inputs["timeoutH"] = args ? args.timeoutH : undefined;
            inputs["type"] = args ? args.type : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Monitor.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Monitor resources.
 */
export interface MonitorState {
    /**
     * A boolean indicating whether or not to include a list of log values which triggered the alert. Defaults to false. This is only used by log monitors.
     * triggering tags into the title. Defaults to true.
     */
    readonly enableLogsSample?: pulumi.Input<boolean>;
    /**
     * A message to include with a re-notification. Supports the '@username'
     * notification allowed elsewhere.
     */
    readonly escalationMessage?: pulumi.Input<string>;
    /**
     * Time (in seconds) to delay evaluation, as a non-negative integer.
     * For example, if the value is set to 300 (5min), the timeframe is set to last5m and the time is 7:00,
     * the monitor will evaluate data from 6:50 to 6:55. This is useful for AWS CloudWatch and other backfilled
     * metrics to ensure the monitor will always have data during evaluation.
     */
    readonly evaluationDelay?: pulumi.Input<number>;
    /**
     * A boolean indicating whether notifications from this monitor automatically insert its triggering tags into the title. Defaults to true.
     */
    readonly includeTags?: pulumi.Input<boolean>;
    /**
     * A boolean indicating whether changes to to this monitor should be restricted to the creator or admins. Defaults to False.
     */
    readonly locked?: pulumi.Input<boolean>;
    /**
     * A message to include with notifications for this monitor.
     * Email notifications can be sent to specific users by using the same '@username' notation as events.
     */
    readonly message?: pulumi.Input<string>;
    /**
     * Name of Datadog monitor
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Time (in seconds) to allow a host to boot and
     * applications to fully start before starting the evaluation of monitor
     * results. Should be a non negative integer. Defaults to 300.
     */
    readonly newHostDelay?: pulumi.Input<number>;
    /**
     * The number of minutes before a monitor will notify when data stops reporting. Provider defaults to 10 minutes.
     * We recommend at least 2x the monitor timeframe for metric alerts or 2 minutes for service checks.
     */
    readonly noDataTimeframe?: pulumi.Input<number>;
    /**
     * A boolean indicating whether tagged users will be notified on changes to this monitor.
     * Defaults to false.
     */
    readonly notifyAudit?: pulumi.Input<boolean>;
    /**
     * A boolean indicating whether this monitor will notify when data stops reporting. Defaults
     * to false.
     */
    readonly notifyNoData?: pulumi.Input<boolean>;
    /**
     * The monitor query to notify on. Note this is not the same query you see in the UI and
     * the syntax is different depending on the monitor `type`, please see the [API Reference](https://docs.datadoghq.com/api/v1/monitors/#create-a-monitor) for details. **Warning:** `pulumi preview` won't perform any validation of the query contents.
     */
    readonly query?: pulumi.Input<string>;
    /**
     * The number of minutes after the last notification before a monitor will re-notify
     * on the current status. It will only re-notify if it's not resolved.
     */
    readonly renotifyInterval?: pulumi.Input<number>;
    /**
     * A boolean indicating whether this monitor needs a full window of data before it's evaluated.
     * We highly recommend you set this to False for sparse metrics, otherwise some evaluations will be skipped.
     * Default: True for "on average", "at all times" and "in total" aggregation. False otherwise.
     */
    readonly requireFullWindow?: pulumi.Input<boolean>;
    /**
     * Each scope will be muted until the given POSIX timestamp or forever if the value is 0. Use `-1` if you want to unmute the scope. **Deprecated** The `silenced` parameter is being deprecated in favor of the downtime resource.
     *
     * @deprecated use Downtime Resource instead
     */
    readonly silenced?: pulumi.Input<{[key: string]: any}>;
    /**
     * A list of tags to associate with your monitor. This can help you categorize and filter monitors in the manage monitors page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
     */
    readonly tags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A mapping containing `recoveryWindow` and `triggerWindow` values, e.g. `last15m`. Can only be used for, and are required for, anomaly monitors.
     */
    readonly thresholdWindows?: pulumi.Input<inputs.MonitorThresholdWindows>;
    /**
     *
     * * Metric alerts:
     * A dictionary of thresholds by threshold type. Currently we have four threshold types for metric alerts: critical, critical recovery, warning, and warning recovery. Critical is defined in the query, but can also be specified in this option. Warning and recovery thresholds can only be specified using the thresholds option.
     * Example usage:
     * ```
     * thresholds = {
     * critical          = 90
     * criticalRecovery = 85
     * warning           = 80
     * warningRecovery  = 75
     * }
     * ```
     * **Warning:** the `critical` threshold value must match the one contained in the `query` argument. The `threshold` from the previous example is valid along with a query like `avg(last_1h):avg:system.disk.in_use{role:sqlserver} by {host} > 90` but
     * along with something like `avg(last_1h):avg:system.disk.in_use{role:sqlserver} by {host} > 95` would make the Datadog API return a HTTP error 400, complaining "The value provided for parameter 'query' is invalid".
     * * Service checks:
     * A dictionary of thresholds by status. Because service checks can have multiple thresholds, we don't define them directly in the query.
     * Default values:
     * ```
     * thresholds = {
     * ok       = 1
     * critical = 1
     * warning  = 1
     * unknown  = 1
     * }
     * ```
     */
    readonly thresholds?: pulumi.Input<inputs.MonitorThresholds>;
    /**
     * The number of hours of the monitor not reporting data before it will automatically resolve
     * from a triggered state. Defaults to false.
     */
    readonly timeoutH?: pulumi.Input<number>;
    /**
     * The type of the monitor. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/v1/monitors/#create-a-monitor) page. The available options are below. **Note**: The monitor type cannot be changed after a monitor is created.
     * * `metric alert`
     * * `service check`
     * * `event alert`
     * * `query alert`
     * * `composite`
     * * `log alert`
     */
    readonly type?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Monitor resource.
 */
export interface MonitorArgs {
    /**
     * A boolean indicating whether or not to include a list of log values which triggered the alert. Defaults to false. This is only used by log monitors.
     * triggering tags into the title. Defaults to true.
     */
    readonly enableLogsSample?: pulumi.Input<boolean>;
    /**
     * A message to include with a re-notification. Supports the '@username'
     * notification allowed elsewhere.
     */
    readonly escalationMessage?: pulumi.Input<string>;
    /**
     * Time (in seconds) to delay evaluation, as a non-negative integer.
     * For example, if the value is set to 300 (5min), the timeframe is set to last5m and the time is 7:00,
     * the monitor will evaluate data from 6:50 to 6:55. This is useful for AWS CloudWatch and other backfilled
     * metrics to ensure the monitor will always have data during evaluation.
     */
    readonly evaluationDelay?: pulumi.Input<number>;
    /**
     * A boolean indicating whether notifications from this monitor automatically insert its triggering tags into the title. Defaults to true.
     */
    readonly includeTags?: pulumi.Input<boolean>;
    /**
     * A boolean indicating whether changes to to this monitor should be restricted to the creator or admins. Defaults to False.
     */
    readonly locked?: pulumi.Input<boolean>;
    /**
     * A message to include with notifications for this monitor.
     * Email notifications can be sent to specific users by using the same '@username' notation as events.
     */
    readonly message: pulumi.Input<string>;
    /**
     * Name of Datadog monitor
     */
    readonly name: pulumi.Input<string>;
    /**
     * Time (in seconds) to allow a host to boot and
     * applications to fully start before starting the evaluation of monitor
     * results. Should be a non negative integer. Defaults to 300.
     */
    readonly newHostDelay?: pulumi.Input<number>;
    /**
     * The number of minutes before a monitor will notify when data stops reporting. Provider defaults to 10 minutes.
     * We recommend at least 2x the monitor timeframe for metric alerts or 2 minutes for service checks.
     */
    readonly noDataTimeframe?: pulumi.Input<number>;
    /**
     * A boolean indicating whether tagged users will be notified on changes to this monitor.
     * Defaults to false.
     */
    readonly notifyAudit?: pulumi.Input<boolean>;
    /**
     * A boolean indicating whether this monitor will notify when data stops reporting. Defaults
     * to false.
     */
    readonly notifyNoData?: pulumi.Input<boolean>;
    /**
     * The monitor query to notify on. Note this is not the same query you see in the UI and
     * the syntax is different depending on the monitor `type`, please see the [API Reference](https://docs.datadoghq.com/api/v1/monitors/#create-a-monitor) for details. **Warning:** `pulumi preview` won't perform any validation of the query contents.
     */
    readonly query: pulumi.Input<string>;
    /**
     * The number of minutes after the last notification before a monitor will re-notify
     * on the current status. It will only re-notify if it's not resolved.
     */
    readonly renotifyInterval?: pulumi.Input<number>;
    /**
     * A boolean indicating whether this monitor needs a full window of data before it's evaluated.
     * We highly recommend you set this to False for sparse metrics, otherwise some evaluations will be skipped.
     * Default: True for "on average", "at all times" and "in total" aggregation. False otherwise.
     */
    readonly requireFullWindow?: pulumi.Input<boolean>;
    /**
     * Each scope will be muted until the given POSIX timestamp or forever if the value is 0. Use `-1` if you want to unmute the scope. **Deprecated** The `silenced` parameter is being deprecated in favor of the downtime resource.
     *
     * @deprecated use Downtime Resource instead
     */
    readonly silenced?: pulumi.Input<{[key: string]: any}>;
    /**
     * A list of tags to associate with your monitor. This can help you categorize and filter monitors in the manage monitors page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
     */
    readonly tags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A mapping containing `recoveryWindow` and `triggerWindow` values, e.g. `last15m`. Can only be used for, and are required for, anomaly monitors.
     */
    readonly thresholdWindows?: pulumi.Input<inputs.MonitorThresholdWindows>;
    /**
     *
     * * Metric alerts:
     * A dictionary of thresholds by threshold type. Currently we have four threshold types for metric alerts: critical, critical recovery, warning, and warning recovery. Critical is defined in the query, but can also be specified in this option. Warning and recovery thresholds can only be specified using the thresholds option.
     * Example usage:
     * ```
     * thresholds = {
     * critical          = 90
     * criticalRecovery = 85
     * warning           = 80
     * warningRecovery  = 75
     * }
     * ```
     * **Warning:** the `critical` threshold value must match the one contained in the `query` argument. The `threshold` from the previous example is valid along with a query like `avg(last_1h):avg:system.disk.in_use{role:sqlserver} by {host} > 90` but
     * along with something like `avg(last_1h):avg:system.disk.in_use{role:sqlserver} by {host} > 95` would make the Datadog API return a HTTP error 400, complaining "The value provided for parameter 'query' is invalid".
     * * Service checks:
     * A dictionary of thresholds by status. Because service checks can have multiple thresholds, we don't define them directly in the query.
     * Default values:
     * ```
     * thresholds = {
     * ok       = 1
     * critical = 1
     * warning  = 1
     * unknown  = 1
     * }
     * ```
     */
    readonly thresholds?: pulumi.Input<inputs.MonitorThresholds>;
    /**
     * The number of hours of the monitor not reporting data before it will automatically resolve
     * from a triggered state. Defaults to false.
     */
    readonly timeoutH?: pulumi.Input<number>;
    /**
     * The type of the monitor. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/v1/monitors/#create-a-monitor) page. The available options are below. **Note**: The monitor type cannot be changed after a monitor is created.
     * * `metric alert`
     * * `service check`
     * * `event alert`
     * * `query alert`
     * * `composite`
     * * `log alert`
     */
    readonly type: pulumi.Input<string>;
}
