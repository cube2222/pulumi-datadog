// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * Use this data source to retrieve information about an existing dashboard list, for use in other resources. In particular, it can be used in a dashboard to register it in the list.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * const test = pulumi.output(datadog.getDashboardList({
 *     name: "My super list",
 * }, { async: true }));
 * ```
 */
export function getDashboardList(args: GetDashboardListArgs, opts?: pulumi.InvokeOptions): Promise<GetDashboardListResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("datadog:index/getDashboardList:getDashboardList", {
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getDashboardList.
 */
export interface GetDashboardListArgs {
    readonly name: string;
}

/**
 * A collection of values returned by getDashboardList.
 */
export interface GetDashboardListResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name: string;
}
