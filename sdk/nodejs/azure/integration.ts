// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a Datadog - Microsoft Azure integration resource. This can be used to create and manage the integrations.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * // Create a new Datadog - Microsoft Azure integration
 * const sandbox = new datadog.azure.Integration("sandbox", {
 *     clientId: "<azure_client_id>",
 *     clientSecret: "<azure_client_secret_key>",
 *     hostFilters: "examplefilter:true,example:true",
 *     tenantName: "<azure_tenant_name>",
 * });
 * ```
 *
 * ## Import
 *
 * Microsoft Azure integrations can be imported using their `tenant name` and `client id` separated with a colon (`:`).
 *
 * ```sh
 *  $ pulumi import datadog:azure/integration:Integration sandbox ${tenant_name}:${client_id}
 * ```
 */
export class Integration extends pulumi.CustomResource {
    /**
     * Get an existing Integration resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: IntegrationState, opts?: pulumi.CustomResourceOptions): Integration {
        return new Integration(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:azure/integration:Integration';

    /**
     * Returns true if the given object is an instance of Integration.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Integration {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Integration.__pulumiType;
    }

    /**
     * Your Azure web application ID.
     */
    public readonly clientId!: pulumi.Output<string>;
    /**
     * (Required for Initial Creation) Your Azure web application secret key.
     */
    public readonly clientSecret!: pulumi.Output<string>;
    /**
     * String of host tag(s) (in the form `key:value,key:value`) defines a filter that Datadog will use when collecting metrics
     * from Azure. Limit the Azure instances that are pulled into Datadog by using tags. Only hosts that match one of the
     * defined tags are imported into Datadog. e.x. `env:production,deploymentgroup:red`
     */
    public readonly hostFilters!: pulumi.Output<string | undefined>;
    /**
     * Your Azure Active Directory ID.
     */
    public readonly tenantName!: pulumi.Output<string>;

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
            const state = argsOrState as IntegrationState | undefined;
            inputs["clientId"] = state ? state.clientId : undefined;
            inputs["clientSecret"] = state ? state.clientSecret : undefined;
            inputs["hostFilters"] = state ? state.hostFilters : undefined;
            inputs["tenantName"] = state ? state.tenantName : undefined;
        } else {
            const args = argsOrState as IntegrationArgs | undefined;
            if ((!args || args.clientId === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'clientId'");
            }
            if ((!args || args.clientSecret === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'clientSecret'");
            }
            if ((!args || args.tenantName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'tenantName'");
            }
            inputs["clientId"] = args ? args.clientId : undefined;
            inputs["clientSecret"] = args ? args.clientSecret : undefined;
            inputs["hostFilters"] = args ? args.hostFilters : undefined;
            inputs["tenantName"] = args ? args.tenantName : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Integration.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Integration resources.
 */
export interface IntegrationState {
    /**
     * Your Azure web application ID.
     */
    readonly clientId?: pulumi.Input<string>;
    /**
     * (Required for Initial Creation) Your Azure web application secret key.
     */
    readonly clientSecret?: pulumi.Input<string>;
    /**
     * String of host tag(s) (in the form `key:value,key:value`) defines a filter that Datadog will use when collecting metrics
     * from Azure. Limit the Azure instances that are pulled into Datadog by using tags. Only hosts that match one of the
     * defined tags are imported into Datadog. e.x. `env:production,deploymentgroup:red`
     */
    readonly hostFilters?: pulumi.Input<string>;
    /**
     * Your Azure Active Directory ID.
     */
    readonly tenantName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Integration resource.
 */
export interface IntegrationArgs {
    /**
     * Your Azure web application ID.
     */
    readonly clientId: pulumi.Input<string>;
    /**
     * (Required for Initial Creation) Your Azure web application secret key.
     */
    readonly clientSecret: pulumi.Input<string>;
    /**
     * String of host tag(s) (in the form `key:value,key:value`) defines a filter that Datadog will use when collecting metrics
     * from Azure. Limit the Azure instances that are pulled into Datadog by using tags. Only hosts that match one of the
     * defined tags are imported into Datadog. e.x. `env:production,deploymentgroup:red`
     */
    readonly hostFilters?: pulumi.Input<string>;
    /**
     * Your Azure Active Directory ID.
     */
    readonly tenantName: pulumi.Input<string>;
}
