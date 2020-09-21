# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from . import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = ['TimeBoard']


class TimeBoard(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 graphs: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['TimeBoardGraphArgs']]]]] = None,
                 read_only: Optional[pulumi.Input[bool]] = None,
                 template_variables: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['TimeBoardTemplateVariableArgs']]]]] = None,
                 title: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Create a TimeBoard resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: A description of the dashboard's content.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['TimeBoardGraphArgs']]]] graphs: A list of graph definitions.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['TimeBoardTemplateVariableArgs']]]] template_variables: A list of template variables for using Dashboard templating.
        :param pulumi.Input[str] title: The name of the dashboard.
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
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            graphs: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['TimeBoardGraphArgs']]]]] = None,
            read_only: Optional[pulumi.Input[bool]] = None,
            template_variables: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['TimeBoardTemplateVariableArgs']]]]] = None,
            title: Optional[pulumi.Input[str]] = None) -> 'TimeBoard':
        """
        Get an existing TimeBoard resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: A description of the dashboard's content.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['TimeBoardGraphArgs']]]] graphs: A list of graph definitions.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['TimeBoardTemplateVariableArgs']]]] template_variables: A list of template variables for using Dashboard templating.
        :param pulumi.Input[str] title: The name of the dashboard.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["description"] = description
        __props__["graphs"] = graphs
        __props__["read_only"] = read_only
        __props__["template_variables"] = template_variables
        __props__["title"] = title
        return TimeBoard(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[str]:
        """
        A description of the dashboard's content.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def graphs(self) -> pulumi.Output[List['outputs.TimeBoardGraph']]:
        """
        A list of graph definitions.
        """
        return pulumi.get(self, "graphs")

    @property
    @pulumi.getter(name="readOnly")
    def read_only(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "read_only")

    @property
    @pulumi.getter(name="templateVariables")
    def template_variables(self) -> pulumi.Output[Optional[List['outputs.TimeBoardTemplateVariable']]]:
        """
        A list of template variables for using Dashboard templating.
        """
        return pulumi.get(self, "template_variables")

    @property
    @pulumi.getter
    def title(self) -> pulumi.Output[str]:
        """
        The name of the dashboard.
        """
        return pulumi.get(self, "title")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

