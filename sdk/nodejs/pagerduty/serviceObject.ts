// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides access to individual Service Objects of Datadog - PagerDuty integrations. Note that the Datadog - PagerDuty integration must be activated (either manually in the Datadog UI or by using [datadog.pagerduty.Integration](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty.html)) in order for this resource to be usable.
 * 
 * ## Example Usage
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
 * const testingBar = new datadog.pagerduty.ServiceObject("testingBar", {
 *     serviceKey: "54321098765432109876",
 *     serviceName: "testingBar",
 * }, {dependsOn: [pd]});
 * const testingFoo = new datadog.pagerduty.ServiceObject("testingFoo", {
 *     serviceKey: "9876543210123456789",
 *     serviceName: "testingFoo",
 * }, {dependsOn: [pd]});
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/integration_pagerduty_service_object.html.markdown.
 */
export class ServiceObject extends pulumi.CustomResource {
    /**
     * Get an existing ServiceObject resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ServiceObjectState, opts?: pulumi.CustomResourceOptions): ServiceObject {
        return new ServiceObject(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:pagerduty/serviceObject:ServiceObject';

    /**
     * Returns true if the given object is an instance of ServiceObject.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ServiceObject {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ServiceObject.__pulumiType;
    }

    public readonly serviceKey!: pulumi.Output<string>;
    /**
     * Your Service name in PagerDuty.
     */
    public readonly serviceName!: pulumi.Output<string>;

    /**
     * Create a ServiceObject resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ServiceObjectArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ServiceObjectArgs | ServiceObjectState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ServiceObjectState | undefined;
            inputs["serviceKey"] = state ? state.serviceKey : undefined;
            inputs["serviceName"] = state ? state.serviceName : undefined;
        } else {
            const args = argsOrState as ServiceObjectArgs | undefined;
            if (!args || args.serviceKey === undefined) {
                throw new Error("Missing required property 'serviceKey'");
            }
            if (!args || args.serviceName === undefined) {
                throw new Error("Missing required property 'serviceName'");
            }
            inputs["serviceKey"] = args ? args.serviceKey : undefined;
            inputs["serviceName"] = args ? args.serviceName : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(ServiceObject.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ServiceObject resources.
 */
export interface ServiceObjectState {
    readonly serviceKey?: pulumi.Input<string>;
    /**
     * Your Service name in PagerDuty.
     */
    readonly serviceName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ServiceObject resource.
 */
export interface ServiceObjectArgs {
    readonly serviceKey: pulumi.Input<string>;
    /**
     * Your Service name in PagerDuty.
     */
    readonly serviceName: pulumi.Input<string>;
}
