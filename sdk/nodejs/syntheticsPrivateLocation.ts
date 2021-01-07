// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides a Datadog synthetics private location resource. This can be used to create and manage Datadog synthetics private locations.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * const privateLocation = new datadog.SyntheticsPrivateLocation("private_location", {
 *     description: "Description of the private location",
 *     name: "First private location",
 *     tags: [
 *         "foo:bar",
 *         "env:test",
 *     ],
 * });
 * ```
 *
 * ## Import
 *
 * Synthetics private locations can be imported using their string ID, e.g.
 *
 * ```sh
 *  $ pulumi import datadog:index/syntheticsPrivateLocation:SyntheticsPrivateLocation bar pl:private-location-name-abcdef123456
 * ```
 */
export class SyntheticsPrivateLocation extends pulumi.CustomResource {
    /**
     * Get an existing SyntheticsPrivateLocation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SyntheticsPrivateLocationState, opts?: pulumi.CustomResourceOptions): SyntheticsPrivateLocation {
        return new SyntheticsPrivateLocation(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:index/syntheticsPrivateLocation:SyntheticsPrivateLocation';

    /**
     * Returns true if the given object is an instance of SyntheticsPrivateLocation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SyntheticsPrivateLocation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SyntheticsPrivateLocation.__pulumiType;
    }

    /**
     * Configuration skeleton for the private location. See installation instructions of the private location on how to use
     * this configuration.
     */
    public /*out*/ readonly config!: pulumi.Output<string>;
    /**
     * Description of the private location.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Synthetics private location name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * A list of tags to associate with your synthetics private location.
     */
    public readonly tags!: pulumi.Output<string[] | undefined>;

    /**
     * Create a SyntheticsPrivateLocation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SyntheticsPrivateLocationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SyntheticsPrivateLocationArgs | SyntheticsPrivateLocationState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as SyntheticsPrivateLocationState | undefined;
            inputs["config"] = state ? state.config : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as SyntheticsPrivateLocationArgs | undefined;
            if ((!args || args.name === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'name'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["config"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(SyntheticsPrivateLocation.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SyntheticsPrivateLocation resources.
 */
export interface SyntheticsPrivateLocationState {
    /**
     * Configuration skeleton for the private location. See installation instructions of the private location on how to use
     * this configuration.
     */
    readonly config?: pulumi.Input<string>;
    /**
     * Description of the private location.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Synthetics private location name.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A list of tags to associate with your synthetics private location.
     */
    readonly tags?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a SyntheticsPrivateLocation resource.
 */
export interface SyntheticsPrivateLocationArgs {
    /**
     * Description of the private location.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Synthetics private location name.
     */
    readonly name: pulumi.Input<string>;
    /**
     * A list of tags to associate with your synthetics private location.
     */
    readonly tags?: pulumi.Input<pulumi.Input<string>[]>;
}
