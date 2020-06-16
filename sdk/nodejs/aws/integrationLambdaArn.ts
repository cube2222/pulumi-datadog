// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a Datadog - Amazon Web Services integration Lambda ARN resource. This can be used to create and manage the
 * log collection Lambdas for an account.
 *
 * Update operations are currently not supported with datadog API so any change forces a new resource.
 *
 * ## Example Usage
 *
 *
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * const mainCollector = new datadog.IntegrationAwsLambdaArn("mainCollector", {
 *     accountId: "1234567890",
 *     lambdaArn: "arn:aws:lambda:us-east-1:1234567890:function:datadog-forwarder-Forwarder",
 * });
 * ```
 */
export class IntegrationLambdaArn extends pulumi.CustomResource {
    /**
     * Get an existing IntegrationLambdaArn resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: IntegrationLambdaArnState, opts?: pulumi.CustomResourceOptions): IntegrationLambdaArn {
        return new IntegrationLambdaArn(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:aws/integrationLambdaArn:IntegrationLambdaArn';

    /**
     * Returns true if the given object is an instance of IntegrationLambdaArn.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is IntegrationLambdaArn {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === IntegrationLambdaArn.__pulumiType;
    }

    /**
     * Your AWS Account ID without dashes.
     */
    public readonly accountId!: pulumi.Output<string>;
    /**
     * The ARN of the Datadog forwarder Lambda.
     */
    public readonly lambdaArn!: pulumi.Output<string>;

    /**
     * Create a IntegrationLambdaArn resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: IntegrationLambdaArnArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: IntegrationLambdaArnArgs | IntegrationLambdaArnState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as IntegrationLambdaArnState | undefined;
            inputs["accountId"] = state ? state.accountId : undefined;
            inputs["lambdaArn"] = state ? state.lambdaArn : undefined;
        } else {
            const args = argsOrState as IntegrationLambdaArnArgs | undefined;
            if (!args || args.accountId === undefined) {
                throw new Error("Missing required property 'accountId'");
            }
            if (!args || args.lambdaArn === undefined) {
                throw new Error("Missing required property 'lambdaArn'");
            }
            inputs["accountId"] = args ? args.accountId : undefined;
            inputs["lambdaArn"] = args ? args.lambdaArn : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(IntegrationLambdaArn.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering IntegrationLambdaArn resources.
 */
export interface IntegrationLambdaArnState {
    /**
     * Your AWS Account ID without dashes.
     */
    readonly accountId?: pulumi.Input<string>;
    /**
     * The ARN of the Datadog forwarder Lambda.
     */
    readonly lambdaArn?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a IntegrationLambdaArn resource.
 */
export interface IntegrationLambdaArnArgs {
    /**
     * Your AWS Account ID without dashes.
     */
    readonly accountId: pulumi.Input<string>;
    /**
     * The ARN of the Datadog forwarder Lambda.
     */
    readonly lambdaArn: pulumi.Input<string>;
}
