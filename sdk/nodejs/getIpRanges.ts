// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Use this data source to retrieve information about Datadog's IP addresses.
 * ## Example Usage
 * 
 * 
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 * 
 * const test = datadog.getIpRanges();
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/d/ip_ranges.html.markdown.
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
    /**
     * An Array of IPv4 addresses in CIDR format specifying the A records for the agent endpoint.
     */
    readonly agentsIpv4s: string[];
    /**
     * An Array of IPv6 addresses in CIDR format specifying the A records for the agent endpoint.
     */
    readonly agentsIpv6s: string[];
    /**
     * An Array of IPv4 addresses in CIDR format specifying the A records for the api endpoint.
     */
    readonly apiIpv4s: string[];
    /**
     * An Array of IPv6 addresses in CIDR format specifying the A records for the api endpoint.
     */
    readonly apiIpv6s: string[];
    /**
     * An Array of IPv4 addresses in CIDR format specifying the A records for the apm endpoint.
     */
    readonly apmIpv4s: string[];
    /**
     * An Array of IPv6 addresses in CIDR format specifying the A records for the apm endpoint.
     */
    readonly apmIpv6s: string[];
    /**
     * An Array of IPv4 addresses in CIDR format specifying the A records for the logs endpoint.
     */
    readonly logsIpv4s: string[];
    /**
     * An Array of IPv6 addresses in CIDR format specifying the A records for the logs endpoint.
     */
    readonly logsIpv6s: string[];
    /**
     * An Array of IPv4 addresses in CIDR format specifying the A records for the process endpoint.
     */
    readonly processIpv4s: string[];
    /**
     * An Array of IPv6 addresses in CIDR format specifying the A records for the process endpoint.
     */
    readonly processIpv6s: string[];
    /**
     * An Array of IPv4 addresses in CIDR format specifying the A records for the synthetics endpoint.
     */
    readonly syntheticsIpv4s: string[];
    /**
     * An Array of IPv6 addresses in CIDR format specifying the A records for the synthetics endpoint.
     */
    readonly syntheticsIpv6s: string[];
    /**
     * An Array of IPv4 addresses in CIDR format specifying the A records for the webhooks endpoint.
     */
    readonly webhooksIpv4s: string[];
    /**
     * An Array of IPv6 addresses in CIDR format specifying the A records for the webhooks endpoint.
     */
    readonly webhooksIpv6s: string[];
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
