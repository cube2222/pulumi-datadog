// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

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

    /**
     * Your PagerDuty API token.
     */
    public readonly apiToken!: pulumi.Output<string | undefined>;
    /**
     * Boolean to specify whether or not individual service objects specified by [datadog.pagerduty.ServiceObject](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty_service_object.html) resource are to be used. Mutually exclusive with `services` key.
     */
    public readonly individualServices!: pulumi.Output<boolean | undefined>;
    /**
     * Array of your schedule URLs.
     */
    public readonly schedules!: pulumi.Output<string[] | undefined>;
    /**
     * Array of PagerDuty service objects. **Deprecated** The `services` list is now deprecated in favour of [datadog.pagerduty.ServiceObject](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty_service_object.html) resource. Note that `individualServices` must be set to `true` to ignore the `service` attribute and use individual services properly.
     */
    public readonly services!: pulumi.Output<outputs.pagerduty.IntegrationService[] | undefined>;
    /**
     * Your PagerDuty account’s personalized subdomain name.
     */
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
    /**
     * Your PagerDuty API token.
     */
    readonly apiToken?: pulumi.Input<string>;
    /**
     * Boolean to specify whether or not individual service objects specified by [datadog.pagerduty.ServiceObject](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty_service_object.html) resource are to be used. Mutually exclusive with `services` key.
     */
    readonly individualServices?: pulumi.Input<boolean>;
    /**
     * Array of your schedule URLs.
     */
    readonly schedules?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Array of PagerDuty service objects. **Deprecated** The `services` list is now deprecated in favour of [datadog.pagerduty.ServiceObject](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty_service_object.html) resource. Note that `individualServices` must be set to `true` to ignore the `service` attribute and use individual services properly.
     * 
     * @deprecated set "individual_services" to true and use datadog_pagerduty_integration_service_object
     */
    readonly services?: pulumi.Input<pulumi.Input<inputs.pagerduty.IntegrationService>[]>;
    /**
     * Your PagerDuty account’s personalized subdomain name.
     */
    readonly subdomain?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Integration resource.
 */
export interface IntegrationArgs {
    /**
     * Your PagerDuty API token.
     */
    readonly apiToken?: pulumi.Input<string>;
    /**
     * Boolean to specify whether or not individual service objects specified by [datadog.pagerduty.ServiceObject](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty_service_object.html) resource are to be used. Mutually exclusive with `services` key.
     */
    readonly individualServices?: pulumi.Input<boolean>;
    /**
     * Array of your schedule URLs.
     */
    readonly schedules?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Array of PagerDuty service objects. **Deprecated** The `services` list is now deprecated in favour of [datadog.pagerduty.ServiceObject](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty_service_object.html) resource. Note that `individualServices` must be set to `true` to ignore the `service` attribute and use individual services properly.
     * 
     * @deprecated set "individual_services" to true and use datadog_pagerduty_integration_service_object
     */
    readonly services?: pulumi.Input<pulumi.Input<inputs.pagerduty.IntegrationService>[]>;
    /**
     * Your PagerDuty account’s personalized subdomain name.
     */
    readonly subdomain: pulumi.Input<string>;
}
