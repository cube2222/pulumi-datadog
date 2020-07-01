// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides a Datadog dashboardList resource. This can be used to create and manage Datadog Dashboard Lists and the individual dashboards within them.
 *
 * ## Example Usage
 *
 * Create a new Dashboard list with two dashbaords
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * const time = new datadog.Dashboard("time", {
 *     description: "Created using the Datadog provider in TF",
 *     isReadOnly: true,
 *     layoutType: "ordered",
 *     title: "TF Test Layout Dashboard",
 *     widgets: [{
 *         alertGraphDefinition: {
 *             alertId: "1234",
 *             time: {
 *                 live_span: "1h",
 *             },
 *             title: "Widget Title",
 *             vizType: "timeseries",
 *         },
 *     }],
 * });
 * const screen = new datadog.Dashboard("screen", {
 *     description: "Created using the Datadog provider in TF",
 *     isReadOnly: false,
 *     layoutType: "free",
 *     title: "TF Test Free Layout Dashboard",
 *     widgets: [{
 *         eventStreamDefinition: {
 *             eventSize: "l",
 *             query: "*",
 *             time: {
 *                 live_span: "1h",
 *             },
 *             title: "Widget Title",
 *             titleAlign: "left",
 *             titleSize: "16",
 *         },
 *         layout: {
 *             height: 43,
 *             width: 32,
 *             x: 5,
 *             y: 5,
 *         },
 *     }],
 * });
 * const newList = new datadog.DashboardList("new_list", {
 *     dashItems: [
 *         {
 *             dashId: time.id,
 *             type: "custom_timeboard",
 *         },
 *         {
 *             dashId: screen.id,
 *             type: "custom_screenboard",
 *         },
 *     ],
 *     name: "TF Created List",
 * }, { dependsOn: [screen, time] });
 * ```
 */
export class DashboardList extends pulumi.CustomResource {
    /**
     * Get an existing DashboardList resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DashboardListState, opts?: pulumi.CustomResourceOptions): DashboardList {
        return new DashboardList(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:index/dashboardList:DashboardList';

    /**
     * Returns true if the given object is an instance of DashboardList.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DashboardList {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DashboardList.__pulumiType;
    }

    /**
     * An individual dashboard object to add to this Dashboard List. If present, must contain the following:
     */
    public readonly dashItems!: pulumi.Output<outputs.DashboardListDashItem[] | undefined>;
    /**
     * The name of this Dashbaord List.
     */
    public readonly name!: pulumi.Output<string>;

    /**
     * Create a DashboardList resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DashboardListArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DashboardListArgs | DashboardListState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as DashboardListState | undefined;
            inputs["dashItems"] = state ? state.dashItems : undefined;
            inputs["name"] = state ? state.name : undefined;
        } else {
            const args = argsOrState as DashboardListArgs | undefined;
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            inputs["dashItems"] = args ? args.dashItems : undefined;
            inputs["name"] = args ? args.name : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(DashboardList.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DashboardList resources.
 */
export interface DashboardListState {
    /**
     * An individual dashboard object to add to this Dashboard List. If present, must contain the following:
     */
    readonly dashItems?: pulumi.Input<pulumi.Input<inputs.DashboardListDashItem>[]>;
    /**
     * The name of this Dashbaord List.
     */
    readonly name?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a DashboardList resource.
 */
export interface DashboardListArgs {
    /**
     * An individual dashboard object to add to this Dashboard List. If present, must contain the following:
     */
    readonly dashItems?: pulumi.Input<pulumi.Input<inputs.DashboardListDashItem>[]>;
    /**
     * The name of this Dashbaord List.
     */
    readonly name: pulumi.Input<string>;
}
