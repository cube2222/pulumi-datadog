// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides a Datadog screenboard resource. This can be used to create and manage Datadog screenboards.
 * 
 * > **Note:** This resource is outdated. Use the new `datadog..Dashboard` resource instead.
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/screenboard.html.markdown.
 */
export class ScreenBoard extends pulumi.CustomResource {
    /**
     * Get an existing ScreenBoard resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ScreenBoardState, opts?: pulumi.CustomResourceOptions): ScreenBoard {
        return new ScreenBoard(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:index/screenBoard:ScreenBoard';

    /**
     * Returns true if the given object is an instance of ScreenBoard.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ScreenBoard {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ScreenBoard.__pulumiType;
    }

    /**
     * Height of the screenboard
     */
    public readonly height!: pulumi.Output<string | undefined>;
    public readonly readOnly!: pulumi.Output<boolean | undefined>;
    /**
     * Whether the screenboard is shared or not
     */
    public readonly shared!: pulumi.Output<boolean | undefined>;
    /**
     * A list of template variables for using Dashboard templating.
     */
    public readonly templateVariables!: pulumi.Output<outputs.ScreenBoardTemplateVariable[] | undefined>;
    /**
     * Name of the screenboard
     */
    public readonly title!: pulumi.Output<string>;
    /**
     * A list of widget definitions.
     */
    public readonly widgets!: pulumi.Output<outputs.ScreenBoardWidget[]>;
    /**
     * Width of the screenboard
     */
    public readonly width!: pulumi.Output<string | undefined>;

    /**
     * Create a ScreenBoard resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ScreenBoardArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ScreenBoardArgs | ScreenBoardState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ScreenBoardState | undefined;
            inputs["height"] = state ? state.height : undefined;
            inputs["readOnly"] = state ? state.readOnly : undefined;
            inputs["shared"] = state ? state.shared : undefined;
            inputs["templateVariables"] = state ? state.templateVariables : undefined;
            inputs["title"] = state ? state.title : undefined;
            inputs["widgets"] = state ? state.widgets : undefined;
            inputs["width"] = state ? state.width : undefined;
        } else {
            const args = argsOrState as ScreenBoardArgs | undefined;
            if (!args || args.title === undefined) {
                throw new Error("Missing required property 'title'");
            }
            if (!args || args.widgets === undefined) {
                throw new Error("Missing required property 'widgets'");
            }
            inputs["height"] = args ? args.height : undefined;
            inputs["readOnly"] = args ? args.readOnly : undefined;
            inputs["shared"] = args ? args.shared : undefined;
            inputs["templateVariables"] = args ? args.templateVariables : undefined;
            inputs["title"] = args ? args.title : undefined;
            inputs["widgets"] = args ? args.widgets : undefined;
            inputs["width"] = args ? args.width : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(ScreenBoard.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ScreenBoard resources.
 */
export interface ScreenBoardState {
    /**
     * Height of the screenboard
     */
    readonly height?: pulumi.Input<string>;
    readonly readOnly?: pulumi.Input<boolean>;
    /**
     * Whether the screenboard is shared or not
     */
    readonly shared?: pulumi.Input<boolean>;
    /**
     * A list of template variables for using Dashboard templating.
     */
    readonly templateVariables?: pulumi.Input<pulumi.Input<inputs.ScreenBoardTemplateVariable>[]>;
    /**
     * Name of the screenboard
     */
    readonly title?: pulumi.Input<string>;
    /**
     * A list of widget definitions.
     */
    readonly widgets?: pulumi.Input<pulumi.Input<inputs.ScreenBoardWidget>[]>;
    /**
     * Width of the screenboard
     */
    readonly width?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ScreenBoard resource.
 */
export interface ScreenBoardArgs {
    /**
     * Height of the screenboard
     */
    readonly height?: pulumi.Input<string>;
    readonly readOnly?: pulumi.Input<boolean>;
    /**
     * Whether the screenboard is shared or not
     */
    readonly shared?: pulumi.Input<boolean>;
    /**
     * A list of template variables for using Dashboard templating.
     */
    readonly templateVariables?: pulumi.Input<pulumi.Input<inputs.ScreenBoardTemplateVariable>[]>;
    /**
     * Name of the screenboard
     */
    readonly title: pulumi.Input<string>;
    /**
     * A list of widget definitions.
     */
    readonly widgets: pulumi.Input<pulumi.Input<inputs.ScreenBoardWidget>[]>;
    /**
     * Width of the screenboard
     */
    readonly width?: pulumi.Input<string>;
}
