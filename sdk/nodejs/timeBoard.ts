// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides a Datadog timeboard resource. This can be used to create and manage Datadog timeboards.
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/timeboard.html.markdown.
 */
export class TimeBoard extends pulumi.CustomResource {
    /**
     * Get an existing TimeBoard resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: TimeBoardState, opts?: pulumi.CustomResourceOptions): TimeBoard {
        return new TimeBoard(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:index/timeBoard:TimeBoard';

    /**
     * Returns true if the given object is an instance of TimeBoard.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is TimeBoard {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === TimeBoard.__pulumiType;
    }

    /**
     * A description of the dashboard's content.
     */
    public readonly description!: pulumi.Output<string>;
    /**
     * Nested block describing a graph definition. The structure of this block is described below. Multiple graph blocks are allowed within a datadog_timeboard resource.
     */
    public readonly graphs!: pulumi.Output<{ autoscale?: boolean, customUnit?: string, events?: string[], groups?: string[], includeNoMetricHosts?: boolean, includeUngroupedHosts?: boolean, markers?: { label?: string, type: string, value: string }[], nodeType?: string, precision?: string, requests: { aggregator?: string, changeType?: string, compareTo?: string, conditionalFormats?: { comparator: string, customBgColor?: string, customFgColor?: string, palette?: string, value?: string }[], extraCol?: string, increaseGood?: boolean, metadataJson?: string, orderBy?: string, orderDirection?: string, q: string, stacked?: boolean, style?: {[key: string]: any}, type?: string }[], scopes?: string[], style?: {[key: string]: any}, textAlign?: string, title: string, viz: string, yaxis?: {[key: string]: any} }[]>;
    /**
     * The read-only status of the timeboard. Default is false.
     */
    public readonly readOnly!: pulumi.Output<boolean | undefined>;
    /**
     * Nested block describing a template variable. The structure of this block is described below. Multiple template_variable blocks are allowed within a datadog_timeboard resource.
     */
    public readonly templateVariables!: pulumi.Output<{ default?: string, name: string, prefix?: string }[] | undefined>;
    /**
     * The name of the dashboard.
     */
    public readonly title!: pulumi.Output<string>;

    /**
     * Create a TimeBoard resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: TimeBoardArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: TimeBoardArgs | TimeBoardState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as TimeBoardState | undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["graphs"] = state ? state.graphs : undefined;
            inputs["readOnly"] = state ? state.readOnly : undefined;
            inputs["templateVariables"] = state ? state.templateVariables : undefined;
            inputs["title"] = state ? state.title : undefined;
        } else {
            const args = argsOrState as TimeBoardArgs | undefined;
            if (!args || args.description === undefined) {
                throw new Error("Missing required property 'description'");
            }
            if (!args || args.graphs === undefined) {
                throw new Error("Missing required property 'graphs'");
            }
            if (!args || args.title === undefined) {
                throw new Error("Missing required property 'title'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["graphs"] = args ? args.graphs : undefined;
            inputs["readOnly"] = args ? args.readOnly : undefined;
            inputs["templateVariables"] = args ? args.templateVariables : undefined;
            inputs["title"] = args ? args.title : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(TimeBoard.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering TimeBoard resources.
 */
export interface TimeBoardState {
    /**
     * A description of the dashboard's content.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Nested block describing a graph definition. The structure of this block is described below. Multiple graph blocks are allowed within a datadog_timeboard resource.
     */
    readonly graphs?: pulumi.Input<pulumi.Input<{ autoscale?: pulumi.Input<boolean>, customUnit?: pulumi.Input<string>, events?: pulumi.Input<pulumi.Input<string>[]>, groups?: pulumi.Input<pulumi.Input<string>[]>, includeNoMetricHosts?: pulumi.Input<boolean>, includeUngroupedHosts?: pulumi.Input<boolean>, markers?: pulumi.Input<pulumi.Input<{ label?: pulumi.Input<string>, type: pulumi.Input<string>, value: pulumi.Input<string> }>[]>, nodeType?: pulumi.Input<string>, precision?: pulumi.Input<string>, requests: pulumi.Input<pulumi.Input<{ aggregator?: pulumi.Input<string>, changeType?: pulumi.Input<string>, compareTo?: pulumi.Input<string>, conditionalFormats?: pulumi.Input<pulumi.Input<{ comparator: pulumi.Input<string>, customBgColor?: pulumi.Input<string>, customFgColor?: pulumi.Input<string>, palette?: pulumi.Input<string>, value?: pulumi.Input<string> }>[]>, extraCol?: pulumi.Input<string>, increaseGood?: pulumi.Input<boolean>, metadataJson?: pulumi.Input<string>, orderBy?: pulumi.Input<string>, orderDirection?: pulumi.Input<string>, q: pulumi.Input<string>, stacked?: pulumi.Input<boolean>, style?: pulumi.Input<{[key: string]: any}>, type?: pulumi.Input<string> }>[]>, scopes?: pulumi.Input<pulumi.Input<string>[]>, style?: pulumi.Input<{[key: string]: any}>, textAlign?: pulumi.Input<string>, title: pulumi.Input<string>, viz: pulumi.Input<string>, yaxis?: pulumi.Input<{[key: string]: any}> }>[]>;
    /**
     * The read-only status of the timeboard. Default is false.
     */
    readonly readOnly?: pulumi.Input<boolean>;
    /**
     * Nested block describing a template variable. The structure of this block is described below. Multiple template_variable blocks are allowed within a datadog_timeboard resource.
     */
    readonly templateVariables?: pulumi.Input<pulumi.Input<{ default?: pulumi.Input<string>, name: pulumi.Input<string>, prefix?: pulumi.Input<string> }>[]>;
    /**
     * The name of the dashboard.
     */
    readonly title?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a TimeBoard resource.
 */
export interface TimeBoardArgs {
    /**
     * A description of the dashboard's content.
     */
    readonly description: pulumi.Input<string>;
    /**
     * Nested block describing a graph definition. The structure of this block is described below. Multiple graph blocks are allowed within a datadog_timeboard resource.
     */
    readonly graphs: pulumi.Input<pulumi.Input<{ autoscale?: pulumi.Input<boolean>, customUnit?: pulumi.Input<string>, events?: pulumi.Input<pulumi.Input<string>[]>, groups?: pulumi.Input<pulumi.Input<string>[]>, includeNoMetricHosts?: pulumi.Input<boolean>, includeUngroupedHosts?: pulumi.Input<boolean>, markers?: pulumi.Input<pulumi.Input<{ label?: pulumi.Input<string>, type: pulumi.Input<string>, value: pulumi.Input<string> }>[]>, nodeType?: pulumi.Input<string>, precision?: pulumi.Input<string>, requests: pulumi.Input<pulumi.Input<{ aggregator?: pulumi.Input<string>, changeType?: pulumi.Input<string>, compareTo?: pulumi.Input<string>, conditionalFormats?: pulumi.Input<pulumi.Input<{ comparator: pulumi.Input<string>, customBgColor?: pulumi.Input<string>, customFgColor?: pulumi.Input<string>, palette?: pulumi.Input<string>, value?: pulumi.Input<string> }>[]>, extraCol?: pulumi.Input<string>, increaseGood?: pulumi.Input<boolean>, metadataJson?: pulumi.Input<string>, orderBy?: pulumi.Input<string>, orderDirection?: pulumi.Input<string>, q: pulumi.Input<string>, stacked?: pulumi.Input<boolean>, style?: pulumi.Input<{[key: string]: any}>, type?: pulumi.Input<string> }>[]>, scopes?: pulumi.Input<pulumi.Input<string>[]>, style?: pulumi.Input<{[key: string]: any}>, textAlign?: pulumi.Input<string>, title: pulumi.Input<string>, viz: pulumi.Input<string>, yaxis?: pulumi.Input<{[key: string]: any}> }>[]>;
    /**
     * The read-only status of the timeboard. Default is false.
     */
    readonly readOnly?: pulumi.Input<boolean>;
    /**
     * Nested block describing a template variable. The structure of this block is described below. Multiple template_variable blocks are allowed within a datadog_timeboard resource.
     */
    readonly templateVariables?: pulumi.Input<pulumi.Input<{ default?: pulumi.Input<string>, name: pulumi.Input<string>, prefix?: pulumi.Input<string> }>[]>;
    /**
     * The name of the dashboard.
     */
    readonly title: pulumi.Input<string>;
}
