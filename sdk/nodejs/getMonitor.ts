// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Use this data source to retrieve information about an existing monitor for use in other resources.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * const test = pulumi.output(datadog.getMonitor({
 *     monitorTagsFilters: ["foo:bar"],
 *     nameFilter: "My awesome monitor",
 * }, { async: true }));
 * ```
 */
export function getMonitor(args?: GetMonitorArgs, opts?: pulumi.InvokeOptions): Promise<GetMonitorResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("datadog:index/getMonitor:getMonitor", {
        "monitorTagsFilters": args.monitorTagsFilters,
        "nameFilter": args.nameFilter,
        "tagsFilters": args.tagsFilters,
    }, opts);
}

/**
 * A collection of arguments for invoking getMonitor.
 */
export interface GetMonitorArgs {
    /**
     * A list of monitor tags to limit the search. This filters on the tags set on the monitor itself.
     */
    readonly monitorTagsFilters?: string[];
    /**
     * A monitor name to limit the search.
     */
    readonly nameFilter?: string;
    /**
     * A list of tags to limit the search. This filters on the monitor scope.
     */
    readonly tagsFilters?: string[];
}

/**
 * A collection of values returned by getMonitor.
 */
export interface GetMonitorResult {
    /**
     * Whether or not a list of log values which triggered the alert is included. This is only used by log monitors.
     */
    readonly enableLogsSample: boolean;
    /**
     * Message included with a re-notification for this monitor.
     */
    readonly escalationMessage: string;
    /**
     * Time (in seconds) for which evaluation is delayed. This is only used by metric monitors.
     */
    readonly evaluationDelay: number;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Whether or not notifications from the monitor automatically inserts its triggering tags into the title.
     */
    readonly includeTags: boolean;
    /**
     * Whether or not changes to the monitor are restricted to the creator or admins.
     */
    readonly locked: boolean;
    /**
     * Message included with notifications for this monitor.
     */
    readonly message: string;
    readonly monitorTagsFilters?: string[];
    /**
     * Name of the monitor.
     */
    readonly name: string;
    readonly nameFilter?: string;
    /**
     * Time (in seconds) allowing a host to boot and
     * applications to fully start before starting the evaluation of monitor
     * results.
     */
    readonly newHostDelay: number;
    /**
     * The number of minutes before the monitor notifies when data stops reporting.
     */
    readonly noDataTimeframe: number;
    /**
     * Whether or not tagged users are notified on changes to the monitor.
     */
    readonly notifyAudit: boolean;
    /**
     * Whether or not this monitor notifies when data stops reporting.
     */
    readonly notifyNoData: boolean;
    /**
     * Query of the monitor.
     */
    readonly query: string;
    /**
     * The number of minutes after the last notification before the monitor re-notifies on the current status.
     */
    readonly renotifyInterval: number;
    /**
     * Whether or not the monitor needs a full window of data before it is evaluated.
     */
    readonly requireFullWindow: boolean;
    /**
     * List of tags associated with the monitor.
     */
    readonly tags: string[];
    readonly tagsFilters?: string[];
    /**
     * Mapping containing `recoveryWindow` and `triggerWindow` values, e.g. `last15m`. This is only used by anomaly monitors.
     */
    readonly thresholdWindows: outputs.GetMonitorThresholdWindows;
    /**
     * Alert thresholds of the monitor.
     */
    readonly thresholds: outputs.GetMonitorThresholds;
    /**
     * Number of hours of the monitor not reporting data before it automatically resolves from a triggered state.
     */
    readonly timeoutH: number;
    /**
     * Type of the monitor.
     */
    readonly type: string;
}
