// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides a Datadog service level objective resource. This can be used to create and manage Datadog service level objectives.
 * 
 * ## Example Usage
 * 
 * ### Metric-Based SLO
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 * 
 * // Create a new Datadog service level objective
 * const foo = new datadog.ServiceLevelObjective("foo", {
 *     description: "My custom metric SLO",
 *     name: "Example Metric SLO",
 *     query: {
 *         denominator: "sum:my.custom.count.metric{*}.as_count()",
 *         numerator: "sum:my.custom.count.metric{type:good_events}.as_count()",
 *     },
 *     tags: [
 *         "foo:bar",
 *         "baz",
 *     ],
 *     thresholds: [
 *         {
 *             target: 99.9,
 *             targetDisplay: "99.900",
 *             timeframe: "7d",
 *             warning: 99.99,
 *             warningDisplay: "99.990",
 *         },
 *         {
 *             target: 99.9,
 *             targetDisplay: "99.900",
 *             timeframe: "30d",
 *             warning: 99.99,
 *             warningDisplay: "99.990",
 *         },
 *     ],
 *     type: "metric",
 * });
 * ```
 * 
 * ### Monitor-Based SLO
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 * 
 * // Create a new Datadog service level objective
 * const bar = new datadog.ServiceLevelObjective("bar", {
 *     description: "My custom monitor SLO",
 *     monitorIds: [
 *         1,
 *         2,
 *         3,
 *     ],
 *     name: "Example Monitor SLO",
 *     tags: [
 *         "foo:bar",
 *         "baz",
 *     ],
 *     thresholds: [
 *         {
 *             target: 99.9,
 *             timeframe: "7d",
 *             warning: 99.99,
 *         },
 *         {
 *             target: 99.9,
 *             timeframe: "30d",
 *             warning: 99.99,
 *         },
 *     ],
 *     type: "monitor",
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/service_level_objective.html.markdown.
 */
export class ServiceLevelObjective extends pulumi.CustomResource {
    /**
     * Get an existing ServiceLevelObjective resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ServiceLevelObjectiveState, opts?: pulumi.CustomResourceOptions): ServiceLevelObjective {
        return new ServiceLevelObjective(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:index/serviceLevelObjective:ServiceLevelObjective';

    /**
     * Returns true if the given object is an instance of ServiceLevelObjective.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ServiceLevelObjective {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ServiceLevelObjective.__pulumiType;
    }

    /**
     * A description of this service level objective.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * A custom set of groups from the monitor(s) for which to use as the SLI instead of all the groups.
     */
    public readonly groups!: pulumi.Output<string[] | undefined>;
    /**
     * A list of numeric monitor IDs for which to use as SLIs. Their tags will be auto-imported into `monitorTags` field in the API resource. At least 1 of `monitorIds` or `monitorSearch` must be provided.
     */
    public readonly monitorIds!: pulumi.Output<number[] | undefined>;
    /**
     * The monitor query search used on the monitor search API to add monitorIds by searching. Their tags will be auto-imported into `monitorTags` field in the API resource. At least 1 of `monitorIds` or `monitorSearch` must be provided.
     */
    public readonly monitorSearch!: pulumi.Output<string | undefined>;
    /**
     * Name of Datadog service level objective
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The metric query configuration to use for the SLI. This is a dictionary and requires both the `numerator` and `denominator` fields which should be `count` metrics using the `sum` aggregator.
     */
    public readonly query!: pulumi.Output<outputs.ServiceLevelObjectiveQuery | undefined>;
    /**
     * A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
     */
    public readonly tags!: pulumi.Output<string[] | undefined>;
    /**
     * - A list of thresholds and targets that define the service level objectives from the provided SLIs.
     */
    public readonly thresholds!: pulumi.Output<outputs.ServiceLevelObjectiveThreshold[]>;
    /**
     * The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/?lang=python#create-a-service-level-objective) page. Available options to choose from are:
     * * `metric`
     * * `monitor`
     */
    public readonly type!: pulumi.Output<string>;

    /**
     * Create a ServiceLevelObjective resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ServiceLevelObjectiveArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ServiceLevelObjectiveArgs | ServiceLevelObjectiveState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ServiceLevelObjectiveState | undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["groups"] = state ? state.groups : undefined;
            inputs["monitorIds"] = state ? state.monitorIds : undefined;
            inputs["monitorSearch"] = state ? state.monitorSearch : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["query"] = state ? state.query : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["thresholds"] = state ? state.thresholds : undefined;
            inputs["type"] = state ? state.type : undefined;
        } else {
            const args = argsOrState as ServiceLevelObjectiveArgs | undefined;
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            if (!args || args.thresholds === undefined) {
                throw new Error("Missing required property 'thresholds'");
            }
            if (!args || args.type === undefined) {
                throw new Error("Missing required property 'type'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["groups"] = args ? args.groups : undefined;
            inputs["monitorIds"] = args ? args.monitorIds : undefined;
            inputs["monitorSearch"] = args ? args.monitorSearch : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["query"] = args ? args.query : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["thresholds"] = args ? args.thresholds : undefined;
            inputs["type"] = args ? args.type : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(ServiceLevelObjective.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ServiceLevelObjective resources.
 */
export interface ServiceLevelObjectiveState {
    /**
     * A description of this service level objective.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * A custom set of groups from the monitor(s) for which to use as the SLI instead of all the groups.
     */
    readonly groups?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A list of numeric monitor IDs for which to use as SLIs. Their tags will be auto-imported into `monitorTags` field in the API resource. At least 1 of `monitorIds` or `monitorSearch` must be provided.
     */
    readonly monitorIds?: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * The monitor query search used on the monitor search API to add monitorIds by searching. Their tags will be auto-imported into `monitorTags` field in the API resource. At least 1 of `monitorIds` or `monitorSearch` must be provided.
     */
    readonly monitorSearch?: pulumi.Input<string>;
    /**
     * Name of Datadog service level objective
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The metric query configuration to use for the SLI. This is a dictionary and requires both the `numerator` and `denominator` fields which should be `count` metrics using the `sum` aggregator.
     */
    readonly query?: pulumi.Input<inputs.ServiceLevelObjectiveQuery>;
    /**
     * A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
     */
    readonly tags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * - A list of thresholds and targets that define the service level objectives from the provided SLIs.
     */
    readonly thresholds?: pulumi.Input<pulumi.Input<inputs.ServiceLevelObjectiveThreshold>[]>;
    /**
     * The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/?lang=python#create-a-service-level-objective) page. Available options to choose from are:
     * * `metric`
     * * `monitor`
     */
    readonly type?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ServiceLevelObjective resource.
 */
export interface ServiceLevelObjectiveArgs {
    /**
     * A description of this service level objective.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * A custom set of groups from the monitor(s) for which to use as the SLI instead of all the groups.
     */
    readonly groups?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A list of numeric monitor IDs for which to use as SLIs. Their tags will be auto-imported into `monitorTags` field in the API resource. At least 1 of `monitorIds` or `monitorSearch` must be provided.
     */
    readonly monitorIds?: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * The monitor query search used on the monitor search API to add monitorIds by searching. Their tags will be auto-imported into `monitorTags` field in the API resource. At least 1 of `monitorIds` or `monitorSearch` must be provided.
     */
    readonly monitorSearch?: pulumi.Input<string>;
    /**
     * Name of Datadog service level objective
     */
    readonly name: pulumi.Input<string>;
    /**
     * The metric query configuration to use for the SLI. This is a dictionary and requires both the `numerator` and `denominator` fields which should be `count` metrics using the `sum` aggregator.
     */
    readonly query?: pulumi.Input<inputs.ServiceLevelObjectiveQuery>;
    /**
     * A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
     */
    readonly tags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * - A list of thresholds and targets that define the service level objectives from the provided SLIs.
     */
    readonly thresholds: pulumi.Input<pulumi.Input<inputs.ServiceLevelObjectiveThreshold>[]>;
    /**
     * The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/?lang=python#create-a-service-level-objective) page. Available options to choose from are:
     * * `metric`
     * * `monitor`
     */
    readonly type: pulumi.Input<string>;
}