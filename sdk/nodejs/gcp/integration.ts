// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a Datadog - Google Cloud Platform integration resource. This can be used to create and manage Datadog - Google Cloud Platform integration.
 */
export class Integration extends pulumi.CustomResource {
    /**
     * Get an existing Integration resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: IntegrationState): Integration {
        return new Integration(name, <any>state, { id });
    }

    /**
     * Your email found in your JSON service account key.
     */
    public readonly clientEmail: pulumi.Output<string>;
    /**
     * Your ID found in your JSON service account key.
     */
    public readonly clientId: pulumi.Output<string>;
    /**
     * Limit the GCE instances that are pulled into Datadog by using tags. Only hosts that match one of the defined tags are imported into Datadog.
     */
    public readonly hostFilters: pulumi.Output<string | undefined>;
    /**
     * Your private key name found in your JSON service account key.
     */
    public readonly privateKey: pulumi.Output<string>;
    /**
     * Your private key ID found in your JSON service account key.
     */
    public readonly privateKeyId: pulumi.Output<string>;
    /**
     * Your Google Cloud project ID found in your JSON service account key.
     */
    public readonly projectId: pulumi.Output<string>;

    /**
     * Create a Integration resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: IntegrationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: IntegrationArgs | IntegrationState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: IntegrationState = argsOrState as IntegrationState | undefined;
            inputs["clientEmail"] = state ? state.clientEmail : undefined;
            inputs["clientId"] = state ? state.clientId : undefined;
            inputs["hostFilters"] = state ? state.hostFilters : undefined;
            inputs["privateKey"] = state ? state.privateKey : undefined;
            inputs["privateKeyId"] = state ? state.privateKeyId : undefined;
            inputs["projectId"] = state ? state.projectId : undefined;
        } else {
            const args = argsOrState as IntegrationArgs | undefined;
            if (!args || args.clientEmail === undefined) {
                throw new Error("Missing required property 'clientEmail'");
            }
            if (!args || args.clientId === undefined) {
                throw new Error("Missing required property 'clientId'");
            }
            if (!args || args.privateKey === undefined) {
                throw new Error("Missing required property 'privateKey'");
            }
            if (!args || args.privateKeyId === undefined) {
                throw new Error("Missing required property 'privateKeyId'");
            }
            if (!args || args.projectId === undefined) {
                throw new Error("Missing required property 'projectId'");
            }
            inputs["clientEmail"] = args ? args.clientEmail : undefined;
            inputs["clientId"] = args ? args.clientId : undefined;
            inputs["hostFilters"] = args ? args.hostFilters : undefined;
            inputs["privateKey"] = args ? args.privateKey : undefined;
            inputs["privateKeyId"] = args ? args.privateKeyId : undefined;
            inputs["projectId"] = args ? args.projectId : undefined;
        }
        super("datadog:gcp/integration:Integration", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Integration resources.
 */
export interface IntegrationState {
    /**
     * Your email found in your JSON service account key.
     */
    readonly clientEmail?: pulumi.Input<string>;
    /**
     * Your ID found in your JSON service account key.
     */
    readonly clientId?: pulumi.Input<string>;
    /**
     * Limit the GCE instances that are pulled into Datadog by using tags. Only hosts that match one of the defined tags are imported into Datadog.
     */
    readonly hostFilters?: pulumi.Input<string>;
    /**
     * Your private key name found in your JSON service account key.
     */
    readonly privateKey?: pulumi.Input<string>;
    /**
     * Your private key ID found in your JSON service account key.
     */
    readonly privateKeyId?: pulumi.Input<string>;
    /**
     * Your Google Cloud project ID found in your JSON service account key.
     */
    readonly projectId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Integration resource.
 */
export interface IntegrationArgs {
    /**
     * Your email found in your JSON service account key.
     */
    readonly clientEmail: pulumi.Input<string>;
    /**
     * Your ID found in your JSON service account key.
     */
    readonly clientId: pulumi.Input<string>;
    /**
     * Limit the GCE instances that are pulled into Datadog by using tags. Only hosts that match one of the defined tags are imported into Datadog.
     */
    readonly hostFilters?: pulumi.Input<string>;
    /**
     * Your private key name found in your JSON service account key.
     */
    readonly privateKey: pulumi.Input<string>;
    /**
     * Your private key ID found in your JSON service account key.
     */
    readonly privateKeyId: pulumi.Input<string>;
    /**
     * Your Google Cloud project ID found in your JSON service account key.
     */
    readonly projectId: pulumi.Input<string>;
}
