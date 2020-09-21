// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a Datadog - Amazon Web Services integration log collection resource. This can be used to manage which AWS services logs are collected from for an account.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * // Create a new Datadog - Amazon Web Services integration lambda arn
 * const main = new datadog.aws.IntegrationLogCollection("main", {
 *     accountId: "1234567890",
 *     services: ["lambda"],
 * });
 * ```
 */
export class IntegrationLogCollection extends pulumi.CustomResource {
    /**
     * Get an existing IntegrationLogCollection resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: IntegrationLogCollectionState, opts?: pulumi.CustomResourceOptions): IntegrationLogCollection {
        return new IntegrationLogCollection(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:aws/integrationLogCollection:IntegrationLogCollection';

    /**
     * Returns true if the given object is an instance of IntegrationLogCollection.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is IntegrationLogCollection {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === IntegrationLogCollection.__pulumiType;
    }

    public readonly accountId!: pulumi.Output<string>;
    public readonly services!: pulumi.Output<string[]>;

    /**
     * Create a IntegrationLogCollection resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: IntegrationLogCollectionArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: IntegrationLogCollectionArgs | IntegrationLogCollectionState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as IntegrationLogCollectionState | undefined;
            inputs["accountId"] = state ? state.accountId : undefined;
            inputs["services"] = state ? state.services : undefined;
        } else {
            const args = argsOrState as IntegrationLogCollectionArgs | undefined;
            if (!args || args.accountId === undefined) {
                throw new Error("Missing required property 'accountId'");
            }
            if (!args || args.services === undefined) {
                throw new Error("Missing required property 'services'");
            }
            inputs["accountId"] = args ? args.accountId : undefined;
            inputs["services"] = args ? args.services : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(IntegrationLogCollection.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering IntegrationLogCollection resources.
 */
export interface IntegrationLogCollectionState {
    readonly accountId?: pulumi.Input<string>;
    readonly services?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a IntegrationLogCollection resource.
 */
export interface IntegrationLogCollectionArgs {
    readonly accountId: pulumi.Input<string>;
    readonly services: pulumi.Input<pulumi.Input<string>[]>;
}
