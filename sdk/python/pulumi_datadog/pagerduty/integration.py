# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = ['Integration']


class Integration(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 api_token: Optional[pulumi.Input[str]] = None,
                 individual_services: Optional[pulumi.Input[bool]] = None,
                 schedules: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 services: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['IntegrationServiceArgs']]]]] = None,
                 subdomain: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Provides a Datadog - PagerDuty resource. This can be used to create and manage Datadog - PagerDuty integration. This resource is deprecated and should only be used for legacy purposes.

        ## Example Usage
        ### Services as Individual Resources

        ```python
        import pulumi
        import pulumi_datadog as datadog

        pd = datadog.pagerduty.Integration("pd",
            api_token="38457822378273432587234242874",
            individual_services=True,
            schedules=[
                "https://ddog.pagerduty.com/schedules/X123VF",
                "https://ddog.pagerduty.com/schedules/X321XX",
            ],
            subdomain="ddog")
        testing_foo = datadog.pagerduty.ServiceObject("testingFoo",
            service_key="9876543210123456789",
            service_name="testing_foo",
            opts=ResourceOptions(depends_on=["datadog_integration_pagerduty.pd"]))
        testing_bar = datadog.pagerduty.ServiceObject("testingBar",
            service_key="54321098765432109876",
            service_name="testing_bar",
            opts=ResourceOptions(depends_on=["datadog_integration_pagerduty.pd"]))
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['IntegrationServiceArgs']]]] services: A list of service names and service keys.
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
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['api_token'] = api_token
            __props__['individual_services'] = individual_services
            __props__['schedules'] = schedules
            if services is not None:
                warnings.warn("set \"individual_services\" to true and use datadog_pagerduty_integration_service_object", DeprecationWarning)
                pulumi.log.warn("services is deprecated: set \"individual_services\" to true and use datadog_pagerduty_integration_service_object")
            __props__['services'] = services
            if subdomain is None:
                raise TypeError("Missing required property 'subdomain'")
            __props__['subdomain'] = subdomain
        super(Integration, __self__).__init__(
            'datadog:pagerduty/integration:Integration',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            api_token: Optional[pulumi.Input[str]] = None,
            individual_services: Optional[pulumi.Input[bool]] = None,
            schedules: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            services: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['IntegrationServiceArgs']]]]] = None,
            subdomain: Optional[pulumi.Input[str]] = None) -> 'Integration':
        """
        Get an existing Integration resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['IntegrationServiceArgs']]]] services: A list of service names and service keys.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["api_token"] = api_token
        __props__["individual_services"] = individual_services
        __props__["schedules"] = schedules
        __props__["services"] = services
        __props__["subdomain"] = subdomain
        return Integration(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="apiToken")
    def api_token(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "api_token")

    @property
    @pulumi.getter(name="individualServices")
    def individual_services(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "individual_services")

    @property
    @pulumi.getter
    def schedules(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "schedules")

    @property
    @pulumi.getter
    def services(self) -> pulumi.Output[Optional[Sequence['outputs.IntegrationService']]]:
        """
        A list of service names and service keys.
        """
        return pulumi.get(self, "services")

    @property
    @pulumi.getter
    def subdomain(self) -> pulumi.Output[str]:
        return pulumi.get(self, "subdomain")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

