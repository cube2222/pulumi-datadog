# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables

class GetIpRangesResult:
    """
    A collection of values returned by getIpRanges.
    """
    def __init__(__self__, agents_ipv4s=None, agents_ipv6s=None, api_ipv4s=None, api_ipv6s=None, apm_ipv4s=None, apm_ipv6s=None, logs_ipv4s=None, logs_ipv6s=None, process_ipv4s=None, process_ipv6s=None, synthetics_ipv4s=None, synthetics_ipv6s=None, webhooks_ipv4s=None, webhooks_ipv6s=None, id=None):
        if agents_ipv4s and not isinstance(agents_ipv4s, list):
            raise TypeError("Expected argument 'agents_ipv4s' to be a list")
        __self__.agents_ipv4s = agents_ipv4s
        """
        An Array of IPv4 addresses in CIDR format specifying the A records for the agent endpoint.
        """
        if agents_ipv6s and not isinstance(agents_ipv6s, list):
            raise TypeError("Expected argument 'agents_ipv6s' to be a list")
        __self__.agents_ipv6s = agents_ipv6s
        """
        An Array of IPv6 addresses in CIDR format specifying the A records for the agent endpoint.
        """
        if api_ipv4s and not isinstance(api_ipv4s, list):
            raise TypeError("Expected argument 'api_ipv4s' to be a list")
        __self__.api_ipv4s = api_ipv4s
        """
        An Array of IPv4 addresses in CIDR format specifying the A records for the api endpoint.
        """
        if api_ipv6s and not isinstance(api_ipv6s, list):
            raise TypeError("Expected argument 'api_ipv6s' to be a list")
        __self__.api_ipv6s = api_ipv6s
        """
        An Array of IPv6 addresses in CIDR format specifying the A records for the api endpoint.
        """
        if apm_ipv4s and not isinstance(apm_ipv4s, list):
            raise TypeError("Expected argument 'apm_ipv4s' to be a list")
        __self__.apm_ipv4s = apm_ipv4s
        """
        An Array of IPv4 addresses in CIDR format specifying the A records for the apm endpoint.
        """
        if apm_ipv6s and not isinstance(apm_ipv6s, list):
            raise TypeError("Expected argument 'apm_ipv6s' to be a list")
        __self__.apm_ipv6s = apm_ipv6s
        """
        An Array of IPv6 addresses in CIDR format specifying the A records for the apm endpoint.
        """
        if logs_ipv4s and not isinstance(logs_ipv4s, list):
            raise TypeError("Expected argument 'logs_ipv4s' to be a list")
        __self__.logs_ipv4s = logs_ipv4s
        """
        An Array of IPv4 addresses in CIDR format specifying the A records for the logs endpoint.
        """
        if logs_ipv6s and not isinstance(logs_ipv6s, list):
            raise TypeError("Expected argument 'logs_ipv6s' to be a list")
        __self__.logs_ipv6s = logs_ipv6s
        """
        An Array of IPv6 addresses in CIDR format specifying the A records for the logs endpoint.
        """
        if process_ipv4s and not isinstance(process_ipv4s, list):
            raise TypeError("Expected argument 'process_ipv4s' to be a list")
        __self__.process_ipv4s = process_ipv4s
        """
        An Array of IPv4 addresses in CIDR format specifying the A records for the process endpoint.
        """
        if process_ipv6s and not isinstance(process_ipv6s, list):
            raise TypeError("Expected argument 'process_ipv6s' to be a list")
        __self__.process_ipv6s = process_ipv6s
        """
        An Array of IPv6 addresses in CIDR format specifying the A records for the process endpoint.
        """
        if synthetics_ipv4s and not isinstance(synthetics_ipv4s, list):
            raise TypeError("Expected argument 'synthetics_ipv4s' to be a list")
        __self__.synthetics_ipv4s = synthetics_ipv4s
        """
        An Array of IPv4 addresses in CIDR format specifying the A records for the synthetics endpoint.
        """
        if synthetics_ipv6s and not isinstance(synthetics_ipv6s, list):
            raise TypeError("Expected argument 'synthetics_ipv6s' to be a list")
        __self__.synthetics_ipv6s = synthetics_ipv6s
        """
        An Array of IPv6 addresses in CIDR format specifying the A records for the synthetics endpoint.
        """
        if webhooks_ipv4s and not isinstance(webhooks_ipv4s, list):
            raise TypeError("Expected argument 'webhooks_ipv4s' to be a list")
        __self__.webhooks_ipv4s = webhooks_ipv4s
        """
        An Array of IPv4 addresses in CIDR format specifying the A records for the webhooks endpoint.
        """
        if webhooks_ipv6s and not isinstance(webhooks_ipv6s, list):
            raise TypeError("Expected argument 'webhooks_ipv6s' to be a list")
        __self__.webhooks_ipv6s = webhooks_ipv6s
        """
        An Array of IPv6 addresses in CIDR format specifying the A records for the webhooks endpoint.
        """
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """
class AwaitableGetIpRangesResult(GetIpRangesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetIpRangesResult(
            agents_ipv4s=self.agents_ipv4s,
            agents_ipv6s=self.agents_ipv6s,
            api_ipv4s=self.api_ipv4s,
            api_ipv6s=self.api_ipv6s,
            apm_ipv4s=self.apm_ipv4s,
            apm_ipv6s=self.apm_ipv6s,
            logs_ipv4s=self.logs_ipv4s,
            logs_ipv6s=self.logs_ipv6s,
            process_ipv4s=self.process_ipv4s,
            process_ipv6s=self.process_ipv6s,
            synthetics_ipv4s=self.synthetics_ipv4s,
            synthetics_ipv6s=self.synthetics_ipv6s,
            webhooks_ipv4s=self.webhooks_ipv4s,
            webhooks_ipv6s=self.webhooks_ipv6s,
            id=self.id)

def get_ip_ranges(opts=None):
    """
    Use this data source to retrieve information about Datadog's IP addresses.

    > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/d/ip_ranges.html.markdown.
    """
    __args__ = dict()

    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('datadog:index/getIpRanges:getIpRanges', __args__, opts=opts).value

    return AwaitableGetIpRangesResult(
        agents_ipv4s=__ret__.get('agentsIpv4s'),
        agents_ipv6s=__ret__.get('agentsIpv6s'),
        api_ipv4s=__ret__.get('apiIpv4s'),
        api_ipv6s=__ret__.get('apiIpv6s'),
        apm_ipv4s=__ret__.get('apmIpv4s'),
        apm_ipv6s=__ret__.get('apmIpv6s'),
        logs_ipv4s=__ret__.get('logsIpv4s'),
        logs_ipv6s=__ret__.get('logsIpv6s'),
        process_ipv4s=__ret__.get('processIpv4s'),
        process_ipv6s=__ret__.get('processIpv6s'),
        synthetics_ipv4s=__ret__.get('syntheticsIpv4s'),
        synthetics_ipv6s=__ret__.get('syntheticsIpv6s'),
        webhooks_ipv4s=__ret__.get('webhooksIpv4s'),
        webhooks_ipv6s=__ret__.get('webhooksIpv6s'),
        id=__ret__.get('id'))
