// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides a Datadog [Logs Pipeline API](https://docs.datadoghq.com/api/v1/logs-pipelines/) resource, which is used to manage Datadog log pipelines order.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * const samplePipelineOrder = new datadog.LogsPipelineOrder("samplePipelineOrder", {
 *     name: "sample_pipeline_order",
 *     pipelines: [
 *         datadog_logs_custom_pipeline.sample_pipeline.id,
 *         datadog_logs_integration_pipeline.python.id,
 *     ],
 * }, {
 *     dependsOn: [
 *         "datadog_logs_custom_pipeline.sample_pipeline",
 *         "datadog_logs_integration_pipeline.python",
 *     ],
 * });
 * ```
 *
 * ## Import
 *
 * There must be at most one `datadog_logs_pipeline_order` resource. Pipeline order creation is not supported from logs config API. You can import the `datadog_logs_pipeline_order` or create a pipeline order (which is actually doing the update operation).
 *
 * ```sh
 *  $ pulumi import datadog:index/logsPipelineOrder:LogsPipelineOrder name> <name>
 * ```
 */
export class LogsPipelineOrder extends pulumi.CustomResource {
    /**
     * Get an existing LogsPipelineOrder resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: LogsPipelineOrderState, opts?: pulumi.CustomResourceOptions): LogsPipelineOrder {
        return new LogsPipelineOrder(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:index/logsPipelineOrder:LogsPipelineOrder';

    /**
     * Returns true if the given object is an instance of LogsPipelineOrder.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LogsPipelineOrder {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LogsPipelineOrder.__pulumiType;
    }

    public readonly name!: pulumi.Output<string>;
    public readonly pipelines!: pulumi.Output<string[]>;

    /**
     * Create a LogsPipelineOrder resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LogsPipelineOrderArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: LogsPipelineOrderArgs | LogsPipelineOrderState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as LogsPipelineOrderState | undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["pipelines"] = state ? state.pipelines : undefined;
        } else {
            const args = argsOrState as LogsPipelineOrderArgs | undefined;
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            if (!args || args.pipelines === undefined) {
                throw new Error("Missing required property 'pipelines'");
            }
            inputs["name"] = args ? args.name : undefined;
            inputs["pipelines"] = args ? args.pipelines : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(LogsPipelineOrder.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering LogsPipelineOrder resources.
 */
export interface LogsPipelineOrderState {
    readonly name?: pulumi.Input<string>;
    readonly pipelines?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a LogsPipelineOrder resource.
 */
export interface LogsPipelineOrderArgs {
    readonly name: pulumi.Input<string>;
    readonly pipelines: pulumi.Input<pulumi.Input<string>[]>;
}
