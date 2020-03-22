# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables

class LogsIntegrationPipeline(pulumi.CustomResource):
    is_enabled: pulumi.Output[bool]
    """
    Boolean value to enable your pipeline.
    """
    def __init__(__self__, resource_name, opts=None, is_enabled=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides a Datadog [Logs Pipeline API](https://docs.datadoghq.com/api/?lang=python#logs-pipelines) resource to manage
        the [integrations](https://docs.datadoghq.com/logs/log_collection/?tab=tcpussite).

        Integration pipelines are the pipelines that are automatically installed for your organization when sending the logs with 
        specific sources. You don't need to maintain or update these types of pipelines. Keeping them as resources, however, 
        allows you to manage the order of your pipelines by referencing them in your 
        .LogsPipelineOrder resource. If you don't need the
        `pipeline_order` feature, this resource declaration can be omitted.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/logs_integration_pipeline.html.markdown.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] is_enabled: Boolean value to enable your pipeline.
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

            __props__['is_enabled'] = is_enabled
        super(LogsIntegrationPipeline, __self__).__init__(
            'datadog:index/logsIntegrationPipeline:LogsIntegrationPipeline',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, is_enabled=None):
        """
        Get an existing LogsIntegrationPipeline resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] is_enabled: Boolean value to enable your pipeline.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["is_enabled"] = is_enabled
        return LogsIntegrationPipeline(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

