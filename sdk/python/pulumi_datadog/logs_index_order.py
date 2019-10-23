# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables

class LogsIndexOrder(pulumi.CustomResource):
    indexes: pulumi.Output[list]
    """
    The index resource list. Logs are tested against the query filter of each index one by one following the order of the list.
    """
    name: pulumi.Output[str]
    """
    The unique name of the index order resource. 
    """
    def __init__(__self__, resource_name, opts=None, indexes=None, name=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides a Datadog [Logs Index API](https://docs.datadoghq.com/api/?lang=python#logs-indexes) resource. This can be used to manage the order of Datadog logs indexes.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[list] indexes: The index resource list. Logs are tested against the query filter of each index one by one following the order of the list.
        :param pulumi.Input[str] name: The unique name of the index order resource. 

        > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/logs_index_order.html.markdown.
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

            if indexes is None:
                raise TypeError("Missing required property 'indexes'")
            __props__['indexes'] = indexes
            if name is None:
                raise TypeError("Missing required property 'name'")
            __props__['name'] = name
        super(LogsIndexOrder, __self__).__init__(
            'datadog:index/logsIndexOrder:LogsIndexOrder',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, indexes=None, name=None):
        """
        Get an existing LogsIndexOrder resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[list] indexes: The index resource list. Logs are tested against the query filter of each index one by one following the order of the list.
        :param pulumi.Input[str] name: The unique name of the index order resource. 

        > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/logs_index_order.html.markdown.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["indexes"] = indexes
        __props__["name"] = name
        return LogsIndexOrder(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

