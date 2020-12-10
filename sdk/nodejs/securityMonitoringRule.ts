// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * Provides a Datadog [Security Monitoring Rule API](https://docs.datadoghq.com/api/v2/security-monitoring/) resource. This can be used to create and manage Datadog security monitoring rules. To change settings for a default rule use [datadogSecurityDefaultRule](https://www.terraform.io/resources/security_monitoring_default_rule) instead.
 *
 * ## Example Usage
 *
 * Create a simple security monitoring rule.
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * const myrule = new datadog.SecurityMonitoringRule("myrule", {
 *     cases: [{
 *         condition: "errors > 3 && warnings > 10",
 *         notifications: ["@user"],
 *         status: "high",
 *     }],
 *     enabled: true,
 *     message: "The rule has triggered.",
 *     name: "My rule",
 *     options: {
 *         evaluationWindow: 300,
 *         keepAlive: 600,
 *         maxSignalDuration: 900,
 *     },
 *     queries: [
 *         {
 *             aggregation: "count",
 *             groupByFields: ["host"],
 *             name: "errors",
 *             query: "status:error",
 *         },
 *         {
 *             aggregation: "count",
 *             groupByFields: ["host"],
 *             name: "warnings",
 *             query: "status:warning",
 *         },
 *     ],
 *     tags: ["type:dos"],
 * });
 * ```
 *
 * ## Import
 *
 * Security monitoring rules can be imported using ID, e.g. console
 *
 * ```sh
 *  $ pulumi import datadog:index/securityMonitoringRule:SecurityMonitoringRule my_monitor m0o-hto-lkb
 * ```
 */
export class SecurityMonitoringRule extends pulumi.CustomResource {
    /**
     * Get an existing SecurityMonitoringRule resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SecurityMonitoringRuleState, opts?: pulumi.CustomResourceOptions): SecurityMonitoringRule {
        return new SecurityMonitoringRule(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:index/securityMonitoringRule:SecurityMonitoringRule';

    /**
     * Returns true if the given object is an instance of SecurityMonitoringRule.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SecurityMonitoringRule {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SecurityMonitoringRule.__pulumiType;
    }

    /**
     * Cases for generating signals.
     */
    public readonly cases!: pulumi.Output<outputs.SecurityMonitoringRuleCase[]>;
    /**
     * Whether the rule is enabled.
     */
    public readonly enabled!: pulumi.Output<boolean | undefined>;
    /**
     * Message for generated signals.
     */
    public readonly message!: pulumi.Output<string>;
    /**
     * The name of the rule.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Options on rules.
     */
    public readonly options!: pulumi.Output<outputs.SecurityMonitoringRuleOptions | undefined>;
    /**
     * Queries for selecting logs which are part of the rule.
     */
    public readonly queries!: pulumi.Output<outputs.SecurityMonitoringRuleQuery[]>;
    /**
     * Tags for generated signals.
     */
    public readonly tags!: pulumi.Output<string[] | undefined>;

    /**
     * Create a SecurityMonitoringRule resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SecurityMonitoringRuleArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SecurityMonitoringRuleArgs | SecurityMonitoringRuleState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as SecurityMonitoringRuleState | undefined;
            inputs["cases"] = state ? state.cases : undefined;
            inputs["enabled"] = state ? state.enabled : undefined;
            inputs["message"] = state ? state.message : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["options"] = state ? state.options : undefined;
            inputs["queries"] = state ? state.queries : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as SecurityMonitoringRuleArgs | undefined;
            if ((!args || args.cases === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'cases'");
            }
            if ((!args || args.message === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'message'");
            }
            if ((!args || args.name === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.queries === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'queries'");
            }
            inputs["cases"] = args ? args.cases : undefined;
            inputs["enabled"] = args ? args.enabled : undefined;
            inputs["message"] = args ? args.message : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["options"] = args ? args.options : undefined;
            inputs["queries"] = args ? args.queries : undefined;
            inputs["tags"] = args ? args.tags : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(SecurityMonitoringRule.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SecurityMonitoringRule resources.
 */
export interface SecurityMonitoringRuleState {
    /**
     * Cases for generating signals.
     */
    readonly cases?: pulumi.Input<pulumi.Input<inputs.SecurityMonitoringRuleCase>[]>;
    /**
     * Whether the rule is enabled.
     */
    readonly enabled?: pulumi.Input<boolean>;
    /**
     * Message for generated signals.
     */
    readonly message?: pulumi.Input<string>;
    /**
     * The name of the rule.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Options on rules.
     */
    readonly options?: pulumi.Input<inputs.SecurityMonitoringRuleOptions>;
    /**
     * Queries for selecting logs which are part of the rule.
     */
    readonly queries?: pulumi.Input<pulumi.Input<inputs.SecurityMonitoringRuleQuery>[]>;
    /**
     * Tags for generated signals.
     */
    readonly tags?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a SecurityMonitoringRule resource.
 */
export interface SecurityMonitoringRuleArgs {
    /**
     * Cases for generating signals.
     */
    readonly cases: pulumi.Input<pulumi.Input<inputs.SecurityMonitoringRuleCase>[]>;
    /**
     * Whether the rule is enabled.
     */
    readonly enabled?: pulumi.Input<boolean>;
    /**
     * Message for generated signals.
     */
    readonly message: pulumi.Input<string>;
    /**
     * The name of the rule.
     */
    readonly name: pulumi.Input<string>;
    /**
     * Options on rules.
     */
    readonly options?: pulumi.Input<inputs.SecurityMonitoringRuleOptions>;
    /**
     * Queries for selecting logs which are part of the rule.
     */
    readonly queries: pulumi.Input<pulumi.Input<inputs.SecurityMonitoringRuleQuery>[]>;
    /**
     * Tags for generated signals.
     */
    readonly tags?: pulumi.Input<pulumi.Input<string>[]>;
}
