// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides a Datadog [Logs Index API](https://docs.datadoghq.com/api/v1/logs-indexes/) resource. This can be used to manage the order of Datadog logs indexes.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * const sampleIndexOrder = new datadog.LogsIndexOrder("sampleIndexOrder", {
 *     name: "sample_index_order",
 *     indexes: [datadog_logs_index.sample_index.id],
 * }, {
 *     dependsOn: ["datadog_logs_index.sample_index"],
 * });
 * ```
 *
 * ## Import
 *
 * ```sh
 *  $ pulumi import datadog:index/logsIndexOrder:LogsIndexOrder The current Datadog Terraform provider version does not support the creation and deletion of index orders. Do `<datadog_logs_index_order.name> <name>` to import index order to Terraform. There must be at most one `datadog_logs_index_order` resource.
 * ```
 */
export class LogsIndexOrder extends pulumi.CustomResource {
    /**
     * Get an existing LogsIndexOrder resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: LogsIndexOrderState, opts?: pulumi.CustomResourceOptions): LogsIndexOrder {
        return new LogsIndexOrder(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:index/logsIndexOrder:LogsIndexOrder';

    /**
     * Returns true if the given object is an instance of LogsIndexOrder.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LogsIndexOrder {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LogsIndexOrder.__pulumiType;
    }

    public readonly indexes!: pulumi.Output<string[]>;
    public readonly name!: pulumi.Output<string>;

    /**
     * Create a LogsIndexOrder resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LogsIndexOrderArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: LogsIndexOrderArgs | LogsIndexOrderState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as LogsIndexOrderState | undefined;
            inputs["indexes"] = state ? state.indexes : undefined;
            inputs["name"] = state ? state.name : undefined;
        } else {
            const args = argsOrState as LogsIndexOrderArgs | undefined;
            if (!args || args.indexes === undefined) {
                throw new Error("Missing required property 'indexes'");
            }
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            inputs["indexes"] = args ? args.indexes : undefined;
            inputs["name"] = args ? args.name : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(LogsIndexOrder.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering LogsIndexOrder resources.
 */
export interface LogsIndexOrderState {
    readonly indexes?: pulumi.Input<pulumi.Input<string>[]>;
    readonly name?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a LogsIndexOrder resource.
 */
export interface LogsIndexOrderArgs {
    readonly indexes: pulumi.Input<pulumi.Input<string>[]>;
    readonly name: pulumi.Input<string>;
}
