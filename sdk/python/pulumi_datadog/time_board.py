# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from . import utilities, tables

class TimeBoard(pulumi.CustomResource):
    description: pulumi.Output[str]
    """
    A description of the dashboard's content.
    """
    graphs: pulumi.Output[list]
    """
    Nested block describing a graph definition. The structure of this block is described below. Multiple graph blocks are allowed within a .TimeBoard resource.
    """
    read_only: pulumi.Output[bool]
    """
    The read-only status of the timeboard. Default is false.
    """
    template_variables: pulumi.Output[list]
    """
    Nested block describing a template variable. The structure of this block is described below. Multiple template_variable blocks are allowed within a .TimeBoard resource.
    """
    title: pulumi.Output[str]
    """
    The name of the dashboard.
    """
    def __init__(__self__, resource_name, opts=None, description=None, graphs=None, read_only=None, template_variables=None, title=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides a Datadog timeboard resource. This can be used to create and manage Datadog timeboards.
        
        > **Note:**This resource is outdated. Use the new `.Dashboard` resource instead.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: A description of the dashboard's content.
        :param pulumi.Input[list] graphs: Nested block describing a graph definition. The structure of this block is described below. Multiple graph blocks are allowed within a .TimeBoard resource.
        :param pulumi.Input[bool] read_only: The read-only status of the timeboard. Default is false.
        :param pulumi.Input[list] template_variables: Nested block describing a template variable. The structure of this block is described below. Multiple template_variable blocks are allowed within a .TimeBoard resource.
        :param pulumi.Input[str] title: The name of the dashboard.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/timeboard.html.markdown.
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

            if description is None:
                raise TypeError("Missing required property 'description'")
            __props__['description'] = description
            if graphs is None:
                raise TypeError("Missing required property 'graphs'")
            __props__['graphs'] = graphs
            __props__['read_only'] = read_only
            __props__['template_variables'] = template_variables
            if title is None:
                raise TypeError("Missing required property 'title'")
            __props__['title'] = title
        super(TimeBoard, __self__).__init__(
            'datadog:index/timeBoard:TimeBoard',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, description=None, graphs=None, read_only=None, template_variables=None, title=None):
        """
        Get an existing TimeBoard resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: A description of the dashboard's content.
        :param pulumi.Input[list] graphs: Nested block describing a graph definition. The structure of this block is described below. Multiple graph blocks are allowed within a .TimeBoard resource.
        :param pulumi.Input[bool] read_only: The read-only status of the timeboard. Default is false.
        :param pulumi.Input[list] template_variables: Nested block describing a template variable. The structure of this block is described below. Multiple template_variable blocks are allowed within a .TimeBoard resource.
        :param pulumi.Input[str] title: The name of the dashboard.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/timeboard.html.markdown.
        """
        opts = pulumi.ResourceOptions(id=id) if opts is None else opts.merge(pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["description"] = description
        __props__["graphs"] = graphs
        __props__["read_only"] = read_only
        __props__["template_variables"] = template_variables
        __props__["title"] = title
        return TimeBoard(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

