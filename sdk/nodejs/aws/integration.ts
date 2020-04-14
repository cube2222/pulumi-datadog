// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a Datadog - Amazon Web Services integration resource. This can be used to create and manage Datadog - Amazon Web Services integration.
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
 * // Create a new Datadog - Amazon Web Services integration
 * const sandbox = new datadog.aws.Integration("sandbox", {
 *     accountId: "1234567890",
 *     accountSpecificNamespaceRules: {
 *         auto_scaling: false,
 *         opsworks: false,
 *     },
 *     filterTags: ["key:value"],
 *     hostTags: [
 *         "key:value",
 *         "key2:value2",
 *     ],
 *     roleName: "DatadogAWSIntegrationRole",
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/integration_aws.html.markdown.
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
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: IntegrationState, opts?: pulumi.CustomResourceOptions): Integration {
        return new Integration(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:aws/integration:Integration';

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
     * Your AWS Account ID without dashes.
     */
    public readonly accountId!: pulumi.Output<string>;
    /**
     * Enables or disables metric collection for specific AWS namespaces for this AWS account only. A list of namespaces can be found at the [available namespace rules API endpoint](https://api.datadoghq.com/api/v1/integration/aws/available_namespace_rules).
     */
    public readonly accountSpecificNamespaceRules!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * AWS External ID
     */
    public /*out*/ readonly externalId!: pulumi.Output<string>;
    /**
     * Array of EC2 tags (in the form `key:value`) defines a filter that Datadog use when collecting metrics from EC2. Wildcards, such as `?` (for single characters) and `*` (for multiple characters) can also be used.
     */
    public readonly filterTags!: pulumi.Output<string[] | undefined>;
    /**
     * Array of tags (in the form key:value) to add to all hosts and metrics reporting through this integration.
     */
    public readonly hostTags!: pulumi.Output<string[] | undefined>;
    /**
     * Your Datadog role delegation name.
     */
    public readonly roleName!: pulumi.Output<string>;

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
            inputs["accountId"] = state ? state.accountId : undefined;
            inputs["accountSpecificNamespaceRules"] = state ? state.accountSpecificNamespaceRules : undefined;
            inputs["externalId"] = state ? state.externalId : undefined;
            inputs["filterTags"] = state ? state.filterTags : undefined;
            inputs["hostTags"] = state ? state.hostTags : undefined;
            inputs["roleName"] = state ? state.roleName : undefined;
        } else {
            const args = argsOrState as IntegrationArgs | undefined;
            if (!args || args.accountId === undefined) {
                throw new Error("Missing required property 'accountId'");
            }
            if (!args || args.roleName === undefined) {
                throw new Error("Missing required property 'roleName'");
            }
            inputs["accountId"] = args ? args.accountId : undefined;
            inputs["accountSpecificNamespaceRules"] = args ? args.accountSpecificNamespaceRules : undefined;
            inputs["filterTags"] = args ? args.filterTags : undefined;
            inputs["hostTags"] = args ? args.hostTags : undefined;
            inputs["roleName"] = args ? args.roleName : undefined;
            inputs["externalId"] = undefined /*out*/;
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
     * Your AWS Account ID without dashes.
     */
    readonly accountId?: pulumi.Input<string>;
    /**
     * Enables or disables metric collection for specific AWS namespaces for this AWS account only. A list of namespaces can be found at the [available namespace rules API endpoint](https://api.datadoghq.com/api/v1/integration/aws/available_namespace_rules).
     */
    readonly accountSpecificNamespaceRules?: pulumi.Input<{[key: string]: any}>;
    /**
     * AWS External ID
     */
    readonly externalId?: pulumi.Input<string>;
    /**
     * Array of EC2 tags (in the form `key:value`) defines a filter that Datadog use when collecting metrics from EC2. Wildcards, such as `?` (for single characters) and `*` (for multiple characters) can also be used.
     */
    readonly filterTags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Array of tags (in the form key:value) to add to all hosts and metrics reporting through this integration.
     */
    readonly hostTags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Your Datadog role delegation name.
     */
    readonly roleName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Integration resource.
 */
export interface IntegrationArgs {
    /**
     * Your AWS Account ID without dashes.
     */
    readonly accountId: pulumi.Input<string>;
    /**
     * Enables or disables metric collection for specific AWS namespaces for this AWS account only. A list of namespaces can be found at the [available namespace rules API endpoint](https://api.datadoghq.com/api/v1/integration/aws/available_namespace_rules).
     */
    readonly accountSpecificNamespaceRules?: pulumi.Input<{[key: string]: any}>;
    /**
     * Array of EC2 tags (in the form `key:value`) defines a filter that Datadog use when collecting metrics from EC2. Wildcards, such as `?` (for single characters) and `*` (for multiple characters) can also be used.
     */
    readonly filterTags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Array of tags (in the form key:value) to add to all hosts and metrics reporting through this integration.
     */
    readonly hostTags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Your Datadog role delegation name.
     */
    readonly roleName: pulumi.Input<string>;
}
