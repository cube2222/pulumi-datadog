# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class Integration(pulumi.CustomResource):
    api_token: pulumi.Output[str]
    """
    Your PagerDuty API token.
    """
    individual_services: pulumi.Output[bool]
    """
    Boolean to specify whether or not individual service objects specified by [pagerduty.ServiceObject](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty_service_object.html) resource are to be used. Mutually exclusive with `services` key.
    """
    schedules: pulumi.Output[list]
    """
    Array of your schedule URLs.
    """
    services: pulumi.Output[list]
    """
    Array of PagerDuty service objects. **Deprecated** The `services` list is now deprecated in favour of [pagerduty.ServiceObject](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty_service_object.html) resource. Note that `individual_services` must be set to `true` to ignore the `service` attribute and use individual services properly.
    
      * `service_key` (`str`) - Your Service name associated service key in Pagerduty.
      * `service_name` (`str`) - Your Service name in PagerDuty.
    """
    subdomain: pulumi.Output[str]
    """
    Your PagerDuty account’s personalized subdomain name.
    """
    def __init__(__self__, resource_name, opts=None, api_token=None, individual_services=None, schedules=None, services=None, subdomain=None, __props__=None, __name__=None, __opts__=None):
        """
        Create a Integration resource with the given unique name, props, and options.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] api_token: Your PagerDuty API token.
        :param pulumi.Input[bool] individual_services: Boolean to specify whether or not individual service objects specified by [pagerduty.ServiceObject](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty_service_object.html) resource are to be used. Mutually exclusive with `services` key.
        :param pulumi.Input[list] schedules: Array of your schedule URLs.
        :param pulumi.Input[list] services: Array of PagerDuty service objects. **Deprecated** The `services` list is now deprecated in favour of [pagerduty.ServiceObject](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty_service_object.html) resource. Note that `individual_services` must be set to `true` to ignore the `service` attribute and use individual services properly.
        :param pulumi.Input[str] subdomain: Your PagerDuty account’s personalized subdomain name.
        
        The **services** object supports the following:
        
          * `service_key` (`pulumi.Input[str]`) - Your Service name associated service key in Pagerduty.
          * `service_name` (`pulumi.Input[str]`) - Your Service name in PagerDuty.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/integration_pagerduty.html.markdown.
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

            __props__['api_token'] = api_token
            __props__['individual_services'] = individual_services
            __props__['schedules'] = schedules
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
    def get(resource_name, id, opts=None, api_token=None, individual_services=None, schedules=None, services=None, subdomain=None):
        """
        Get an existing Integration resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] api_token: Your PagerDuty API token.
        :param pulumi.Input[bool] individual_services: Boolean to specify whether or not individual service objects specified by [pagerduty.ServiceObject](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty_service_object.html) resource are to be used. Mutually exclusive with `services` key.
        :param pulumi.Input[list] schedules: Array of your schedule URLs.
        :param pulumi.Input[list] services: Array of PagerDuty service objects. **Deprecated** The `services` list is now deprecated in favour of [pagerduty.ServiceObject](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty_service_object.html) resource. Note that `individual_services` must be set to `true` to ignore the `service` attribute and use individual services properly.
        :param pulumi.Input[str] subdomain: Your PagerDuty account’s personalized subdomain name.
        
        The **services** object supports the following:
        
          * `service_key` (`pulumi.Input[str]`) - Your Service name associated service key in Pagerduty.
          * `service_name` (`pulumi.Input[str]`) - Your Service name in PagerDuty.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/integration_pagerduty.html.markdown.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["api_token"] = api_token
        __props__["individual_services"] = individual_services
        __props__["schedules"] = schedules
        __props__["services"] = services
        __props__["subdomain"] = subdomain
        return Integration(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

