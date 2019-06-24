// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides a Datadog downtime resource. This can be used to create and manage Datadog downtimes.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 * 
 * // Create a new daily 1700-0900 Datadog downtime
 * const foo = new datadog.Downtime("foo", {
 *     end: 1483365600,
 *     recurrence: {
 *         period: 1,
 *         type: "days",
 *     },
 *     scopes: ["*"],
 *     start: 1483308000,
 * });
 * ```
 */
export class Downtime extends pulumi.CustomResource {
    /**
     * Get an existing Downtime resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DowntimeState, opts?: pulumi.CustomResourceOptions): Downtime {
        return new Downtime(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:index/downtime:Downtime';

    /**
     * Returns true if the given object is an instance of Downtime.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Downtime {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Downtime.__pulumiType;
    }

    /**
     * A flag indicating if the downtime is active now.
     */
    public readonly active!: pulumi.Output<boolean | undefined>;
    /**
     * A flag indicating if the downtime was disabled.
     */
    public readonly disabled!: pulumi.Output<boolean | undefined>;
    /**
     * POSIX timestamp to end the downtime.
     */
    public readonly end!: pulumi.Output<number | undefined>;
    /**
     * String representing date and time to end the downtime in RFC3339 format.
     */
    public readonly endDate!: pulumi.Output<string | undefined>;
    /**
     * A message to include with notifications for this downtime.
     */
    public readonly message!: pulumi.Output<string | undefined>;
    /**
     * Reference to which monitor this downtime is applied. When scheduling downtime for a given monitor, datadog changes `silenced` property of the monitor to match the `end` POSIX timestamp. **Note:** this will effectively change the `silenced` attribute of the referenced monitor. If that monitor is also tracked by Terraform and you don't want it to be unmuted on the next `terraform apply`, see [details](https://www.terraform.io/docs/providers/datadog/r/monitor.html#silencing-by-hand-and-by-downtimes) in the monitor resource documentation. This option also conflicts with `monitor_tags` use none or one or the other.
     */
    public readonly monitorId!: pulumi.Output<number | undefined>;
    /**
     * A list of monitor tags to match. The resulting downtime applies to monitors that match **all** provided monitor tags. This option conflicts with `monitor_id` as it will match all monitors that match these tags.
     */
    public readonly monitorTags!: pulumi.Output<string[] | undefined>;
    /**
     * A dictionary to configure the downtime to be recurring.
     */
    public readonly recurrence!: pulumi.Output<{ period: number, type: string, untilDate?: number, untilOccurrences?: number, weekDays?: string[] } | undefined>;
    /**
     * A list of items to apply the downtime to, e.g. host:X
     */
    public readonly scopes!: pulumi.Output<string[]>;
    /**
     * POSIX timestamp to start the downtime.
     */
    public readonly start!: pulumi.Output<number | undefined>;
    /**
     * String representing date and time to start the downtime in RFC3339 format.
     */
    public readonly startDate!: pulumi.Output<string | undefined>;
    /**
     * The timezone for the downtime, default UTC. It must be a valid IANA Time Zone.
     */
    public readonly timezone!: pulumi.Output<string | undefined>;

    /**
     * Create a Downtime resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DowntimeArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DowntimeArgs | DowntimeState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as DowntimeState | undefined;
            inputs["active"] = state ? state.active : undefined;
            inputs["disabled"] = state ? state.disabled : undefined;
            inputs["end"] = state ? state.end : undefined;
            inputs["endDate"] = state ? state.endDate : undefined;
            inputs["message"] = state ? state.message : undefined;
            inputs["monitorId"] = state ? state.monitorId : undefined;
            inputs["monitorTags"] = state ? state.monitorTags : undefined;
            inputs["recurrence"] = state ? state.recurrence : undefined;
            inputs["scopes"] = state ? state.scopes : undefined;
            inputs["start"] = state ? state.start : undefined;
            inputs["startDate"] = state ? state.startDate : undefined;
            inputs["timezone"] = state ? state.timezone : undefined;
        } else {
            const args = argsOrState as DowntimeArgs | undefined;
            if (!args || args.scopes === undefined) {
                throw new Error("Missing required property 'scopes'");
            }
            inputs["active"] = args ? args.active : undefined;
            inputs["disabled"] = args ? args.disabled : undefined;
            inputs["end"] = args ? args.end : undefined;
            inputs["endDate"] = args ? args.endDate : undefined;
            inputs["message"] = args ? args.message : undefined;
            inputs["monitorId"] = args ? args.monitorId : undefined;
            inputs["monitorTags"] = args ? args.monitorTags : undefined;
            inputs["recurrence"] = args ? args.recurrence : undefined;
            inputs["scopes"] = args ? args.scopes : undefined;
            inputs["start"] = args ? args.start : undefined;
            inputs["startDate"] = args ? args.startDate : undefined;
            inputs["timezone"] = args ? args.timezone : undefined;
        }
        super(Downtime.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Downtime resources.
 */
export interface DowntimeState {
    /**
     * A flag indicating if the downtime is active now.
     */
    readonly active?: pulumi.Input<boolean>;
    /**
     * A flag indicating if the downtime was disabled.
     */
    readonly disabled?: pulumi.Input<boolean>;
    /**
     * POSIX timestamp to end the downtime.
     */
    readonly end?: pulumi.Input<number>;
    /**
     * String representing date and time to end the downtime in RFC3339 format.
     */
    readonly endDate?: pulumi.Input<string>;
    /**
     * A message to include with notifications for this downtime.
     */
    readonly message?: pulumi.Input<string>;
    /**
     * Reference to which monitor this downtime is applied. When scheduling downtime for a given monitor, datadog changes `silenced` property of the monitor to match the `end` POSIX timestamp. **Note:** this will effectively change the `silenced` attribute of the referenced monitor. If that monitor is also tracked by Terraform and you don't want it to be unmuted on the next `terraform apply`, see [details](https://www.terraform.io/docs/providers/datadog/r/monitor.html#silencing-by-hand-and-by-downtimes) in the monitor resource documentation. This option also conflicts with `monitor_tags` use none or one or the other.
     */
    readonly monitorId?: pulumi.Input<number>;
    /**
     * A list of monitor tags to match. The resulting downtime applies to monitors that match **all** provided monitor tags. This option conflicts with `monitor_id` as it will match all monitors that match these tags.
     */
    readonly monitorTags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A dictionary to configure the downtime to be recurring.
     */
    readonly recurrence?: pulumi.Input<{ period: pulumi.Input<number>, type: pulumi.Input<string>, untilDate?: pulumi.Input<number>, untilOccurrences?: pulumi.Input<number>, weekDays?: pulumi.Input<pulumi.Input<string>[]> }>;
    /**
     * A list of items to apply the downtime to, e.g. host:X
     */
    readonly scopes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * POSIX timestamp to start the downtime.
     */
    readonly start?: pulumi.Input<number>;
    /**
     * String representing date and time to start the downtime in RFC3339 format.
     */
    readonly startDate?: pulumi.Input<string>;
    /**
     * The timezone for the downtime, default UTC. It must be a valid IANA Time Zone.
     */
    readonly timezone?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Downtime resource.
 */
export interface DowntimeArgs {
    /**
     * A flag indicating if the downtime is active now.
     */
    readonly active?: pulumi.Input<boolean>;
    /**
     * A flag indicating if the downtime was disabled.
     */
    readonly disabled?: pulumi.Input<boolean>;
    /**
     * POSIX timestamp to end the downtime.
     */
    readonly end?: pulumi.Input<number>;
    /**
     * String representing date and time to end the downtime in RFC3339 format.
     */
    readonly endDate?: pulumi.Input<string>;
    /**
     * A message to include with notifications for this downtime.
     */
    readonly message?: pulumi.Input<string>;
    /**
     * Reference to which monitor this downtime is applied. When scheduling downtime for a given monitor, datadog changes `silenced` property of the monitor to match the `end` POSIX timestamp. **Note:** this will effectively change the `silenced` attribute of the referenced monitor. If that monitor is also tracked by Terraform and you don't want it to be unmuted on the next `terraform apply`, see [details](https://www.terraform.io/docs/providers/datadog/r/monitor.html#silencing-by-hand-and-by-downtimes) in the monitor resource documentation. This option also conflicts with `monitor_tags` use none or one or the other.
     */
    readonly monitorId?: pulumi.Input<number>;
    /**
     * A list of monitor tags to match. The resulting downtime applies to monitors that match **all** provided monitor tags. This option conflicts with `monitor_id` as it will match all monitors that match these tags.
     */
    readonly monitorTags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A dictionary to configure the downtime to be recurring.
     */
    readonly recurrence?: pulumi.Input<{ period: pulumi.Input<number>, type: pulumi.Input<string>, untilDate?: pulumi.Input<number>, untilOccurrences?: pulumi.Input<number>, weekDays?: pulumi.Input<pulumi.Input<string>[]> }>;
    /**
     * A list of items to apply the downtime to, e.g. host:X
     */
    readonly scopes: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * POSIX timestamp to start the downtime.
     */
    readonly start?: pulumi.Input<number>;
    /**
     * String representing date and time to start the downtime in RFC3339 format.
     */
    readonly startDate?: pulumi.Input<string>;
    /**
     * The timezone for the downtime, default UTC. It must be a valid IANA Time Zone.
     */
    readonly timezone?: pulumi.Input<string>;
}
