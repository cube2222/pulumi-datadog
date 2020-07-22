# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables


class ServiceObject(pulumi.CustomResource):
    service_key: pulumi.Output[str]
    """
    Your Service name associated service key in PagerDuty. Note: Since the Datadog API never returns service keys, it is impossible to detect drifts.
    """
    service_name: pulumi.Output[str]
    """
    Your Service name in PagerDuty.
    """
    def __init__(__self__, resource_name, opts=None, service_key=None, service_name=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides access to individual Service Objects of Datadog - PagerDuty integrations. Note that the Datadog - PagerDuty integration must be activated in the Datadog UI in order for this resource to be usable.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_datadog as datadog

        testing_foo = datadog.pagerduty.ServiceObject("testingFoo",
            service_key="9876543210123456789",
            service_name="testing_foo")
        testing_bar = datadog.pagerduty.ServiceObject("testingBar",
            service_key="54321098765432109876",
            service_name="testing_bar")
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] service_key: Your Service name associated service key in PagerDuty. Note: Since the Datadog API never returns service keys, it is impossible to detect drifts.
        :param pulumi.Input[str] service_name: Your Service name in PagerDuty.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            if service_key is None:
                raise TypeError("Missing required property 'service_key'")
            __props__['service_key'] = service_key
            if service_name is None:
                raise TypeError("Missing required property 'service_name'")
            __props__['service_name'] = service_name
        super(ServiceObject, __self__).__init__(
            'datadog:pagerduty/serviceObject:ServiceObject',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, service_key=None, service_name=None):
        """
        Get an existing ServiceObject resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] service_key: Your Service name associated service key in PagerDuty. Note: Since the Datadog API never returns service keys, it is impossible to detect drifts.
        :param pulumi.Input[str] service_name: Your Service name in PagerDuty.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["service_key"] = service_key
        __props__["service_name"] = service_name
        return ServiceObject(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
