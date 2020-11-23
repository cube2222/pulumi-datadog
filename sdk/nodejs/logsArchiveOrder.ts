// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides a Datadog [Logs Archive API](https://docs.datadoghq.com/api/v2/logs-archives/) resource, which is used to manage Datadog log archives order.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * const sampleArchiveOrder = new datadog.LogsArchiveOrder("sample_archive_order", {
 *     archiveIds: [
 *         datadog_logs_archive_sample_archive_1.id,
 *         datadog_logs_archive_sample_archive_2.id,
 *     ],
 * });
 * ```
 *
 * ## Import
 *
 * There must be at most one `datadog_logs_archive_order` resource. You can import the `datadog_logs_archive_order` or create an archive order.
 *
 * ```sh
 *  $ pulumi import datadog:index/logsArchiveOrder:LogsArchiveOrder name> archiveOrderID
 * ```
 */
export class LogsArchiveOrder extends pulumi.CustomResource {
    /**
     * Get an existing LogsArchiveOrder resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: LogsArchiveOrderState, opts?: pulumi.CustomResourceOptions): LogsArchiveOrder {
        return new LogsArchiveOrder(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:index/logsArchiveOrder:LogsArchiveOrder';

    /**
     * Returns true if the given object is an instance of LogsArchiveOrder.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LogsArchiveOrder {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LogsArchiveOrder.__pulumiType;
    }

    public readonly archiveIds!: pulumi.Output<string[]>;

    /**
     * Create a LogsArchiveOrder resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: LogsArchiveOrderArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: LogsArchiveOrderArgs | LogsArchiveOrderState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as LogsArchiveOrderState | undefined;
            inputs["archiveIds"] = state ? state.archiveIds : undefined;
        } else {
            const args = argsOrState as LogsArchiveOrderArgs | undefined;
            inputs["archiveIds"] = args ? args.archiveIds : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(LogsArchiveOrder.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering LogsArchiveOrder resources.
 */
export interface LogsArchiveOrderState {
    readonly archiveIds?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a LogsArchiveOrder resource.
 */
export interface LogsArchiveOrderArgs {
    readonly archiveIds?: pulumi.Input<pulumi.Input<string>[]>;
}
