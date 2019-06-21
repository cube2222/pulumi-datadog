# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class Integration(pulumi.CustomResource):
    api_token: pulumi.Output[str]
    """
    Your PagerDuty API token.
    """
    schedules: pulumi.Output[list]
    """
    Array of your schedule URLs.
    """
    services: pulumi.Output[list]
    """
    Array of PagerDuty service objects.
    """
    subdomain: pulumi.Output[str]
    """
    Your PagerDuty account’s personalized subdomain name.
    """
    def __init__(__self__, resource_name, opts=None, api_token=None, schedules=None, services=None, subdomain=None, __name__=None, __opts__=None):
        """
        Provides a Datadog - PagerDuty resource. This can be used to create and manage Datadog - PagerDuty integration.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] api_token: Your PagerDuty API token.
        :param pulumi.Input[list] schedules: Array of your schedule URLs.
        :param pulumi.Input[list] services: Array of PagerDuty service objects.
        :param pulumi.Input[str] subdomain: Your PagerDuty account’s personalized subdomain name.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if not resource_name:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(resource_name, str):
            raise TypeError('Expected resource name to be a string')
        if opts and not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        __props__['api_token'] = api_token

        __props__['schedules'] = schedules

        if services is None:
            raise TypeError("Missing required property 'services'")
        __props__['services'] = services

        if subdomain is None:
            raise TypeError("Missing required property 'subdomain'")
        __props__['subdomain'] = subdomain

        super(Integration, __self__).__init__(
            'datadog:pagerduty/integration:Integration',
            resource_name,
            __props__,
            opts)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

