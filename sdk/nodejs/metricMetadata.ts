// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides a Datadog metricMetadata resource. This can be used to manage a metric's metadata.
 *
 * ## Example Usage
 *
 *
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * // Manage a Datadog metric's metadata
 * const requestTime = new datadog.MetricMetadata("requestTime", {
 *     description: "99th percentile request time in millseconds",
 *     metric: "request.time",
 *     shortName: "Request time",
 *     type: "gauge",
 *     unit: "millisecond",
 * });
 * ```
 */
export class MetricMetadata extends pulumi.CustomResource {
    /**
     * Get an existing MetricMetadata resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MetricMetadataState, opts?: pulumi.CustomResourceOptions): MetricMetadata {
        return new MetricMetadata(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:index/metricMetadata:MetricMetadata';

    /**
     * Returns true if the given object is an instance of MetricMetadata.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MetricMetadata {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MetricMetadata.__pulumiType;
    }

    /**
     * A description of the metric.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The name of the metric.
     */
    public readonly metric!: pulumi.Output<string>;
    /**
     * 'Per' unit of the metric such as 'second' in 'bytes per second'.
     */
    public readonly perUnit!: pulumi.Output<string | undefined>;
    /**
     * A short name of the metric.
     */
    public readonly shortName!: pulumi.Output<string | undefined>;
    /**
     * If applicable, stasd flush interval in seconds for the metric.
     */
    public readonly statsdInterval!: pulumi.Output<number | undefined>;
    public readonly type!: pulumi.Output<string | undefined>;
    /**
     * Primary unit of the metric such as 'byte' or 'operation'.
     */
    public readonly unit!: pulumi.Output<string | undefined>;

    /**
     * Create a MetricMetadata resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MetricMetadataArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MetricMetadataArgs | MetricMetadataState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as MetricMetadataState | undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["metric"] = state ? state.metric : undefined;
            inputs["perUnit"] = state ? state.perUnit : undefined;
            inputs["shortName"] = state ? state.shortName : undefined;
            inputs["statsdInterval"] = state ? state.statsdInterval : undefined;
            inputs["type"] = state ? state.type : undefined;
            inputs["unit"] = state ? state.unit : undefined;
        } else {
            const args = argsOrState as MetricMetadataArgs | undefined;
            if (!args || args.metric === undefined) {
                throw new Error("Missing required property 'metric'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["metric"] = args ? args.metric : undefined;
            inputs["perUnit"] = args ? args.perUnit : undefined;
            inputs["shortName"] = args ? args.shortName : undefined;
            inputs["statsdInterval"] = args ? args.statsdInterval : undefined;
            inputs["type"] = args ? args.type : undefined;
            inputs["unit"] = args ? args.unit : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(MetricMetadata.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering MetricMetadata resources.
 */
export interface MetricMetadataState {
    /**
     * A description of the metric.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * The name of the metric.
     */
    readonly metric?: pulumi.Input<string>;
    /**
     * 'Per' unit of the metric such as 'second' in 'bytes per second'.
     */
    readonly perUnit?: pulumi.Input<string>;
    /**
     * A short name of the metric.
     */
    readonly shortName?: pulumi.Input<string>;
    /**
     * If applicable, stasd flush interval in seconds for the metric.
     */
    readonly statsdInterval?: pulumi.Input<number>;
    readonly type?: pulumi.Input<string>;
    /**
     * Primary unit of the metric such as 'byte' or 'operation'.
     */
    readonly unit?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a MetricMetadata resource.
 */
export interface MetricMetadataArgs {
    /**
     * A description of the metric.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * The name of the metric.
     */
    readonly metric: pulumi.Input<string>;
    /**
     * 'Per' unit of the metric such as 'second' in 'bytes per second'.
     */
    readonly perUnit?: pulumi.Input<string>;
    /**
     * A short name of the metric.
     */
    readonly shortName?: pulumi.Input<string>;
    /**
     * If applicable, stasd flush interval in seconds for the metric.
     */
    readonly statsdInterval?: pulumi.Input<number>;
    readonly type?: pulumi.Input<string>;
    /**
     * Primary unit of the metric such as 'byte' or 'operation'.
     */
    readonly unit?: pulumi.Input<string>;
}
