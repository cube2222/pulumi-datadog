// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/synthetics_test.html.markdown.
 */
export class SyntheticsTest extends pulumi.CustomResource {
    /**
     * Get an existing SyntheticsTest resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SyntheticsTestState, opts?: pulumi.CustomResourceOptions): SyntheticsTest {
        return new SyntheticsTest(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:index/syntheticsTest:SyntheticsTest';

    /**
     * Returns true if the given object is an instance of SyntheticsTest.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SyntheticsTest {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SyntheticsTest.__pulumiType;
    }

    public readonly assertions!: pulumi.Output<{[key: string]: any}[] | undefined>;
    public readonly deviceIds!: pulumi.Output<string[] | undefined>;
    public readonly locations!: pulumi.Output<string[]>;
    public readonly message!: pulumi.Output<string | undefined>;
    public /*out*/ readonly monitorId!: pulumi.Output<number>;
    public readonly name!: pulumi.Output<string>;
    public readonly options!: pulumi.Output<outputs.SyntheticsTestOptions | undefined>;
    public readonly request!: pulumi.Output<outputs.SyntheticsTestRequest>;
    public readonly requestHeaders!: pulumi.Output<{[key: string]: any} | undefined>;
    public readonly status!: pulumi.Output<string>;
    public readonly subtype!: pulumi.Output<string | undefined>;
    public readonly tags!: pulumi.Output<string[]>;
    public readonly type!: pulumi.Output<string>;

    /**
     * Create a SyntheticsTest resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SyntheticsTestArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SyntheticsTestArgs | SyntheticsTestState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as SyntheticsTestState | undefined;
            inputs["assertions"] = state ? state.assertions : undefined;
            inputs["deviceIds"] = state ? state.deviceIds : undefined;
            inputs["locations"] = state ? state.locations : undefined;
            inputs["message"] = state ? state.message : undefined;
            inputs["monitorId"] = state ? state.monitorId : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["options"] = state ? state.options : undefined;
            inputs["request"] = state ? state.request : undefined;
            inputs["requestHeaders"] = state ? state.requestHeaders : undefined;
            inputs["status"] = state ? state.status : undefined;
            inputs["subtype"] = state ? state.subtype : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["type"] = state ? state.type : undefined;
        } else {
            const args = argsOrState as SyntheticsTestArgs | undefined;
            if (!args || args.locations === undefined) {
                throw new Error("Missing required property 'locations'");
            }
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            if (!args || args.request === undefined) {
                throw new Error("Missing required property 'request'");
            }
            if (!args || args.status === undefined) {
                throw new Error("Missing required property 'status'");
            }
            if (!args || args.tags === undefined) {
                throw new Error("Missing required property 'tags'");
            }
            if (!args || args.type === undefined) {
                throw new Error("Missing required property 'type'");
            }
            inputs["assertions"] = args ? args.assertions : undefined;
            inputs["deviceIds"] = args ? args.deviceIds : undefined;
            inputs["locations"] = args ? args.locations : undefined;
            inputs["message"] = args ? args.message : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["options"] = args ? args.options : undefined;
            inputs["request"] = args ? args.request : undefined;
            inputs["requestHeaders"] = args ? args.requestHeaders : undefined;
            inputs["status"] = args ? args.status : undefined;
            inputs["subtype"] = args ? args.subtype : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["type"] = args ? args.type : undefined;
            inputs["monitorId"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(SyntheticsTest.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SyntheticsTest resources.
 */
export interface SyntheticsTestState {
    readonly assertions?: pulumi.Input<pulumi.Input<{[key: string]: any}>[]>;
    readonly deviceIds?: pulumi.Input<pulumi.Input<string>[]>;
    readonly locations?: pulumi.Input<pulumi.Input<string>[]>;
    readonly message?: pulumi.Input<string>;
    readonly monitorId?: pulumi.Input<number>;
    readonly name?: pulumi.Input<string>;
    readonly options?: pulumi.Input<inputs.SyntheticsTestOptions>;
    readonly request?: pulumi.Input<inputs.SyntheticsTestRequest>;
    readonly requestHeaders?: pulumi.Input<{[key: string]: any}>;
    readonly status?: pulumi.Input<string>;
    readonly subtype?: pulumi.Input<string>;
    readonly tags?: pulumi.Input<pulumi.Input<string>[]>;
    readonly type?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a SyntheticsTest resource.
 */
export interface SyntheticsTestArgs {
    readonly assertions?: pulumi.Input<pulumi.Input<{[key: string]: any}>[]>;
    readonly deviceIds?: pulumi.Input<pulumi.Input<string>[]>;
    readonly locations: pulumi.Input<pulumi.Input<string>[]>;
    readonly message?: pulumi.Input<string>;
    readonly name: pulumi.Input<string>;
    readonly options?: pulumi.Input<inputs.SyntheticsTestOptions>;
    readonly request: pulumi.Input<inputs.SyntheticsTestRequest>;
    readonly requestHeaders?: pulumi.Input<{[key: string]: any}>;
    readonly status: pulumi.Input<string>;
    readonly subtype?: pulumi.Input<string>;
    readonly tags: pulumi.Input<pulumi.Input<string>[]>;
    readonly type: pulumi.Input<string>;
}
