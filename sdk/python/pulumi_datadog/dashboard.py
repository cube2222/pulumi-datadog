# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from . import utilities, tables

class Dashboard(pulumi.CustomResource):
    description: pulumi.Output[str]
    is_read_only: pulumi.Output[bool]
    layout_type: pulumi.Output[str]
    notify_lists: pulumi.Output[list]
    template_variables: pulumi.Output[list]
    title: pulumi.Output[str]
    widgets: pulumi.Output[list]
    def __init__(__self__, resource_name, opts=None, description=None, is_read_only=None, layout_type=None, notify_lists=None, template_variables=None, title=None, widgets=None, __name__=None, __opts__=None):
        """
        Provides a Datadog dashboard resource. This can be used to create and manage Datadog dashboards.
        
        > **Note:** This resource uses the new [Dashboard API](https://docs.datadoghq.com/api/#dashboards) which adds new features like better validation and support for the [Group widget](https://docs.datadoghq.com/graphing/widgets/group/). Additionally, this resource unifies `datadog_timeboard` and `datadog_screenboard` resources to allow you to manage all of your dashboards using a single format.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/dashboard.html.markdown.
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

        __props__['description'] = description

        __props__['is_read_only'] = is_read_only

        if layout_type is None:
            raise TypeError("Missing required property 'layout_type'")
        __props__['layout_type'] = layout_type

        __props__['notify_lists'] = notify_lists

        __props__['template_variables'] = template_variables

        if title is None:
            raise TypeError("Missing required property 'title'")
        __props__['title'] = title

        if widgets is None:
            raise TypeError("Missing required property 'widgets'")
        __props__['widgets'] = widgets

        super(Dashboard, __self__).__init__(
            'datadog:index/dashboard:Dashboard',
            resource_name,
            __props__,
            opts)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

