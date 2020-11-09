// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a Datadog - PagerDuty resource. This can be used to create and manage Datadog - PagerDuty integration. This resource is deprecated and should only be used for legacy purposes.
 *
 * ## Example Usage
 * ### Services as Individual Resources
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * const pd = new datadog.pagerduty.Integration("pd", {
 *     apiToken: "38457822378273432587234242874",
 *     individualServices: true,
 *     schedules: [
 *         "https://ddog.pagerduty.com/schedules/X123VF",
 *         "https://ddog.pagerduty.com/schedules/X321XX",
 *     ],
 *     subdomain: "ddog",
 * });
 * const testingFoo = new datadog.pagerduty.ServiceObject("testing_foo", {
 *     serviceKey: "9876543210123456789",
 *     serviceName: "testing_foo",
 * }, { dependsOn: [pd] });
 * const testingBar = new datadog.pagerduty.ServiceObject("testing_bar", {
 *     serviceKey: "54321098765432109876",
 *     serviceName: "testing_bar",
 * }, { dependsOn: [pd] });
 * ```
 * ### Inline Services
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * const pdServices = {
 *     testing_foo: "9876543210123456789",
 *     testing_bar: "54321098765432109876",
 * };
 * // Create a new Datadog - PagerDuty integration
 * const pd = new datadog.pagerduty.Integration("pd", {
 *     dynamic: [{
 *         forEach: pdServices,
 *         content: [{
 *             serviceName: services.key,
 *             serviceKey: services.value,
 *         }],
 *     }],
 *     schedules: [
 *         "https://ddog.pagerduty.com/schedules/X123VF",
 *         "https://ddog.pagerduty.com/schedules/X321XX",
 *     ],
 *     subdomain: "ddog",
 *     apiToken: "38457822378273432587234242874",
 * });
 * ```
 * ### Migrating from Inline Services to Individual Resources
 *
 * Migrating from usage of inline services to individual resources is very simple. The following example shows how to convert an existing inline services configuration to configuration using individual resources. Doing analogous change and running `pulumi up` after every step is all that's necessary to migrate.
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * const pdServices = {
 *     testing_foo: "9876543210123456789",
 *     testing_bar: "54321098765432109876",
 * };
 * // Create a new Datadog - PagerDuty integration
 * const pd = new datadog.pagerduty.Integration("pd", {
 *     dynamic: [{
 *         forEach: pdServices,
 *         content: [{
 *             serviceName: services.key,
 *             serviceKey: services.value,
 *         }],
 *     }],
 *     schedules: [
 *         "https://ddog.pagerduty.com/schedules/X123VF",
 *         "https://ddog.pagerduty.com/schedules/X321XX",
 *     ],
 *     subdomain: "ddog",
 *     apiToken: "38457822378273432587234242874",
 * });
 * ```
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * // Second step - this will remove the inline-defined service objects
 * // Note that during this step, `individual_services` must not be defined
 * const pd = new datadog.pagerduty.Integration("pd", {
 *     apiToken: "38457822378273432587234242874",
 *     // `services` was removed
 *     schedules: [
 *         "https://ddog.pagerduty.com/schedules/X123VF",
 *         "https://ddog.pagerduty.com/schedules/X321XX",
 *     ],
 *     subdomain: "ddog",
 * });
 * ```
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * const pd = new datadog.pagerduty.Integration("pd", {
 *     apiToken: "38457822378273432587234242874",
 *     // `individual_services = true` was added
 *     individualServices: true,
 *     schedules: [
 *         "https://ddog.pagerduty.com/schedules/X123VF",
 *         "https://ddog.pagerduty.com/schedules/X321XX",
 *     ],
 *     subdomain: "ddog",
 * });
 * const testingFoo = new datadog.pagerduty.ServiceObject("testing_foo", {
 *     serviceKey: "9876543210123456789",
 *     serviceName: "testing_foo",
 * }, { dependsOn: [pd] });
 * const testingBar = new datadog.pagerduty.ServiceObject("testing_bar", {
 *     serviceKey: "54321098765432109876",
 *     serviceName: "testing_bar",
 * }, { dependsOn: [pd] });
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
    public static readonly __pulumiType = 'datadog:pagerduty/integration:Integration';

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

    public readonly apiToken!: pulumi.Output<string | undefined>;
    public readonly individualServices!: pulumi.Output<boolean | undefined>;
    public readonly schedules!: pulumi.Output<string[] | undefined>;
    /**
     * A list of service names and service keys.
     *
     * @deprecated set "individual_services" to true and use datadog_pagerduty_integration_service_object
     */
    public readonly services!: pulumi.Output<outputs.pagerduty.IntegrationService[] | undefined>;
    public readonly subdomain!: pulumi.Output<string>;

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
            inputs["apiToken"] = state ? state.apiToken : undefined;
            inputs["individualServices"] = state ? state.individualServices : undefined;
            inputs["schedules"] = state ? state.schedules : undefined;
            inputs["services"] = state ? state.services : undefined;
            inputs["subdomain"] = state ? state.subdomain : undefined;
        } else {
            const args = argsOrState as IntegrationArgs | undefined;
            if (!args || args.subdomain === undefined) {
                throw new Error("Missing required property 'subdomain'");
            }
            inputs["apiToken"] = args ? args.apiToken : undefined;
            inputs["individualServices"] = args ? args.individualServices : undefined;
            inputs["schedules"] = args ? args.schedules : undefined;
            inputs["services"] = args ? args.services : undefined;
            inputs["subdomain"] = args ? args.subdomain : undefined;
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
    readonly apiToken?: pulumi.Input<string>;
    readonly individualServices?: pulumi.Input<boolean>;
    readonly schedules?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A list of service names and service keys.
     *
     * @deprecated set "individual_services" to true and use datadog_pagerduty_integration_service_object
     */
    readonly services?: pulumi.Input<pulumi.Input<inputs.pagerduty.IntegrationService>[]>;
    readonly subdomain?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Integration resource.
 */
export interface IntegrationArgs {
    readonly apiToken?: pulumi.Input<string>;
    readonly individualServices?: pulumi.Input<boolean>;
    readonly schedules?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A list of service names and service keys.
     *
     * @deprecated set "individual_services" to true and use datadog_pagerduty_integration_service_object
     */
    readonly services?: pulumi.Input<pulumi.Input<inputs.pagerduty.IntegrationService>[]>;
    readonly subdomain: pulumi.Input<string>;
}
