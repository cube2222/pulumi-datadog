# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class ServiceObject(pulumi.CustomResource):
    service_key: pulumi.Output[str]
    service_name: pulumi.Output[str]
    """
    Your Service name in PagerDuty.
    """
    def __init__(__self__, resource_name, opts=None, service_key=None, service_name=None, __name__=None, __opts__=None):
        """
        Provides access to individual Service Objects of Datadog - PagerDuty integrations. Note that the Datadog - PagerDuty integration must be activated (either manually in the Datadog UI or by using [datadog_integration_pagerduty](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty.html)) in order for this resource to be usable.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] service_name: Your Service name in PagerDuty.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/integration_pagerduty_service_object.html.markdown.
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

        if service_key is None:
            raise TypeError("Missing required property 'service_key'")
        __props__['service_key'] = service_key

        if service_name is None:
            raise TypeError("Missing required property 'service_name'")
        __props__['service_name'] = service_name

        if opts is None:
            opts = pulumi.ResourceOptions()
        if opts.version is None:
            opts.version = utilities.get_version()
        super(ServiceObject, __self__).__init__(
            'datadog:pagerduty/serviceObject:ServiceObject',
            resource_name,
            __props__,
            opts)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

