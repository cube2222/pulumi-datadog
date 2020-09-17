// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Use this data source to retrieve information about Datadog's IP addresses.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * const test = pulumi.output(datadog.getIpRanges({ async: true }));
 * ```
 */
export function getIpRanges(opts?: pulumi.InvokeOptions): Promise<GetIpRangesResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("datadog:index/getIpRanges:getIpRanges", {
    }, opts);
}

/**
 * A collection of values returned by getIpRanges.
 */
export interface GetIpRangesResult {
    readonly agentsIpv4s: string[];
    readonly agentsIpv6s: string[];
    readonly apiIpv4s: string[];
    readonly apiIpv6s: string[];
    readonly apmIpv4s: string[];
    readonly apmIpv6s: string[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly logsIpv4s: string[];
    readonly logsIpv6s: string[];
    readonly processIpv4s: string[];
    readonly processIpv6s: string[];
    readonly syntheticsIpv4s: string[];
    readonly syntheticsIpv6s: string[];
    readonly webhooksIpv4s: string[];
    readonly webhooksIpv6s: string[];
}
