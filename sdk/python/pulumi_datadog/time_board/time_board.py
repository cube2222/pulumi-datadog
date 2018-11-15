# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities, tables

class TimeBoard(pulumi.CustomResource):
    """
    Provides a Datadog timeboard resource. This can be used to create and manage Datadog timeboards.
    """
    def __init__(__self__, __name__, __opts__=None, description=None, graphs=None, read_only=None, template_variables=None, title=None):
        """Create a TimeBoard resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, str):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not description:
            raise TypeError('Missing required property description')
        __props__['description'] = description

        if not graphs:
            raise TypeError('Missing required property graphs')
        __props__['graphs'] = graphs

        __props__['read_only'] = read_only

        __props__['template_variables'] = template_variables

        if not title:
            raise TypeError('Missing required property title')
        __props__['title'] = title

        super(TimeBoard, __self__).__init__(
            'datadog:timeBoard:TimeBoard',
            __name__,
            __props__,
            __opts__)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

