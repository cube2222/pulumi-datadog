# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from . import _utilities, _tables

__all__ = ['LogsPipelineOrder']


class LogsPipelineOrder(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 pipelines: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Provides a Datadog [Logs Pipeline API](https://docs.datadoghq.com/api/v1/logs-pipelines/) resource, which is used to manage Datadog log pipelines order.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_datadog as datadog

        sample_pipeline_order = datadog.LogsPipelineOrder("samplePipelineOrder",
            name="sample_pipeline_order",
            pipelines=[
                datadog_logs_custom_pipeline["sample_pipeline"]["id"],
                datadog_logs_integration_pipeline["python"]["id"],
            ],
            opts=pulumi.ResourceOptions(depends_on=[
                    "datadog_logs_custom_pipeline.sample_pipeline",
                    "datadog_logs_integration_pipeline.python",
                ]))
        ```

        ## Import

        There must be at most one `datadog_logs_pipeline_order` resource. Pipeline order creation is not supported from logs config API. You can import the `datadog_logs_pipeline_order` or create a pipeline order (which is actually doing the update operation).

        ```sh
         $ pulumi import datadog:index/logsPipelineOrder:LogsPipelineOrder name> <name>
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: The name attribute in the resource `datadog_logs_pipeline_order` needs to be unique. It's recommended to use the same
               value as the resource name. No related field is available in [Logs Pipeline
               API](https://docs.datadoghq.com/api/v1/logs-pipelines/#get-pipeline-order).
        :param pulumi.Input[Sequence[pulumi.Input[str]]] pipelines: The pipeline IDs list. The order of pipeline IDs in this attribute defines the overall pipeline order for logs.
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

            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__['name'] = name
            if pipelines is None and not opts.urn:
                raise TypeError("Missing required property 'pipelines'")
            __props__['pipelines'] = pipelines
        super(LogsPipelineOrder, __self__).__init__(
            'datadog:index/logsPipelineOrder:LogsPipelineOrder',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            name: Optional[pulumi.Input[str]] = None,
            pipelines: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None) -> 'LogsPipelineOrder':
        """
        Get an existing LogsPipelineOrder resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: The name attribute in the resource `datadog_logs_pipeline_order` needs to be unique. It's recommended to use the same
               value as the resource name. No related field is available in [Logs Pipeline
               API](https://docs.datadoghq.com/api/v1/logs-pipelines/#get-pipeline-order).
        :param pulumi.Input[Sequence[pulumi.Input[str]]] pipelines: The pipeline IDs list. The order of pipeline IDs in this attribute defines the overall pipeline order for logs.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["name"] = name
        __props__["pipelines"] = pipelines
        return LogsPipelineOrder(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name attribute in the resource `datadog_logs_pipeline_order` needs to be unique. It's recommended to use the same
        value as the resource name. No related field is available in [Logs Pipeline
        API](https://docs.datadoghq.com/api/v1/logs-pipelines/#get-pipeline-order).
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def pipelines(self) -> pulumi.Output[Sequence[str]]:
        """
        The pipeline IDs list. The order of pipeline IDs in this attribute defines the overall pipeline order for logs.
        """
        return pulumi.get(self, "pipelines")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

