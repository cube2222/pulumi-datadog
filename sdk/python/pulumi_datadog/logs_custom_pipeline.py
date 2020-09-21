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

__all__ = ['LogsCustomPipeline']


class LogsCustomPipeline(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 filters: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['LogsCustomPipelineFilterArgs']]]]] = None,
                 is_enabled: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 processors: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['LogsCustomPipelineProcessorArgs']]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Provides a Datadog [Logs Pipeline API](https://docs.datadoghq.com/api/v1/logs-pipelines/) resource, which is used to create and manage Datadog logs custom pipelines.

        ## Example Usage

        Create a Datadog logs pipeline:

        ```python
        import pulumi
        import pulumi_datadog as datadog

        sample_pipeline = datadog.LogsCustomPipeline("samplePipeline",
            filters=[datadog.LogsCustomPipelineFilterArgs(
                query="source:foo",
            )],
            is_enabled=True,
            name="sample pipeline",
            processors=[
                datadog.LogsCustomPipelineProcessorArgs(
                    arithmetic_processor=datadog.LogsCustomPipelineProcessorArithmeticProcessorArgs(
                        expression="(time1 - time2)*1000",
                        is_enabled=True,
                        is_replace_missing=True,
                        name="sample arithmetic processor",
                        target="my_arithmetic",
                    ),
                ),
                datadog.LogsCustomPipelineProcessorArgs(
                    attribute_remapper=datadog.LogsCustomPipelineProcessorAttributeRemapperArgs(
                        is_enabled=True,
                        name="sample attribute processor",
                        override_on_conflict=False,
                        preserve_source=True,
                        source_type="tag",
                        sources=["db.instance"],
                        target="db",
                        target_type="tag",
                    ),
                ),
                datadog.LogsCustomPipelineProcessorArgs(
                    category_processor=datadog.LogsCustomPipelineProcessorCategoryProcessorArgs(
                        category=[
                            {
                                "filter": {
                                    "query": "@severity: \".\"",
                                },
                                "name": "debug",
                            },
                            {
                                "filter": {
                                    "query": "@severity: \"-\"",
                                },
                                "name": "verbose",
                            },
                        ],
                        is_enabled=True,
                        name="sample category processor",
                        target="foo.severity",
                    ),
                ),
                datadog.LogsCustomPipelineProcessorArgs(
                    date_remapper=datadog.LogsCustomPipelineProcessorDateRemapperArgs(
                        is_enabled=True,
                        name="sample date remapper",
                        sources=[
                            "_timestamp",
                            "published_date",
                        ],
                    ),
                ),
                datadog.LogsCustomPipelineProcessorArgs(
                    geo_ip_parser=datadog.LogsCustomPipelineProcessorGeoIpParserArgs(
                        is_enabled=True,
                        name="sample geo ip parser",
                        sources=["network.client.ip"],
                        target="network.client.geoip",
                    ),
                ),
                datadog.LogsCustomPipelineProcessorArgs(
                    grok_parser=datadog.LogsCustomPipelineProcessorGrokParserArgs(
                        grok=datadog.LogsCustomPipelineProcessorGrokParserGrokArgs(
                            match_rules="Rule %{word:my_word2} %{number:my_float2}",
                            support_rules="",
                        ),
                        is_enabled=True,
                        name="sample grok parser",
                        samples=["sample log 1"],
                        source="message",
                    ),
                ),
                datadog.LogsCustomPipelineProcessorArgs(
                    lookup_processor=datadog.LogsCustomPipelineProcessorLookupProcessorArgs(
                        default_lookup="unknown service",
                        is_enabled=True,
                        lookup_table=["1,my service"],
                        name="sample lookup processor",
                        source="service_id",
                        target="service_name",
                    ),
                ),
                datadog.LogsCustomPipelineProcessorArgs(
                    message_remapper=datadog.LogsCustomPipelineProcessorMessageRemapperArgs(
                        is_enabled=True,
                        name="sample message remapper",
                        sources=["msg"],
                    ),
                ),
                datadog.LogsCustomPipelineProcessorArgs(
                    pipeline=datadog.LogsCustomPipelineProcessorPipelineArgs(
                        filter=[{
                            "query": "source:foo",
                        }],
                        is_enabled=True,
                        name="nested pipeline",
                        processor=[{
                            "urlParser": {
                                "name": "sample url parser",
                                "normalizeEndingSlashes": True,
                                "sources": [
                                    "url",
                                    "extra",
                                ],
                                "target": "http_url",
                            },
                        }],
                    ),
                ),
                datadog.LogsCustomPipelineProcessorArgs(
                    service_remapper=datadog.LogsCustomPipelineProcessorServiceRemapperArgs(
                        is_enabled=True,
                        name="sample service remapper",
                        sources=["service"],
                    ),
                ),
                datadog.LogsCustomPipelineProcessorArgs(
                    status_remapper=datadog.LogsCustomPipelineProcessorStatusRemapperArgs(
                        is_enabled=True,
                        name="sample status remapper",
                        sources=[
                            "info",
                            "trace",
                        ],
                    ),
                ),
                datadog.LogsCustomPipelineProcessorArgs(
                    string_builder_processor=datadog.LogsCustomPipelineProcessorStringBuilderProcessorArgs(
                        is_enabled=True,
                        is_replace_missing=False,
                        name="sample string builder processor",
                        target="user_activity",
                        template="%{user.name} logged in at %{timestamp}",
                    ),
                ),
                datadog.LogsCustomPipelineProcessorArgs(
                    trace_id_remapper=datadog.LogsCustomPipelineProcessorTraceIdRemapperArgs(
                        is_enabled=True,
                        name="sample trace id remapper",
                        sources=["dd.trace_id"],
                    ),
                ),
                datadog.LogsCustomPipelineProcessorArgs(
                    user_agent_parser=datadog.LogsCustomPipelineProcessorUserAgentParserArgs(
                        is_enabled=True,
                        is_encoded=False,
                        name="sample user agent parser",
                        sources=[
                            "user",
                            "agent",
                        ],
                        target="http_agent",
                    ),
                ),
            ])
        ```
        ## Important Notes

        Each `LogsCustomPipeline` resource defines a complete pipeline. The order of the pipelines is maintained in a different resource datadog_logs_pipeline_order. When creating a new pipeline, you need to **explicitly** add this pipeline to the `LogsPipelineOrder` resource to track the pipeline. Similarly, when a pipeline needs to be destroyed, remove its references from the `LogsPipelineOrder` resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
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

            if filters is None:
                raise TypeError("Missing required property 'filters'")
            __props__['filters'] = filters
            __props__['is_enabled'] = is_enabled
            if name is None:
                raise TypeError("Missing required property 'name'")
            __props__['name'] = name
            __props__['processors'] = processors
        super(LogsCustomPipeline, __self__).__init__(
            'datadog:index/logsCustomPipeline:LogsCustomPipeline',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            filters: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['LogsCustomPipelineFilterArgs']]]]] = None,
            is_enabled: Optional[pulumi.Input[bool]] = None,
            name: Optional[pulumi.Input[str]] = None,
            processors: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['LogsCustomPipelineProcessorArgs']]]]] = None) -> 'LogsCustomPipeline':
        """
        Get an existing LogsCustomPipeline resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["filters"] = filters
        __props__["is_enabled"] = is_enabled
        __props__["name"] = name
        __props__["processors"] = processors
        return LogsCustomPipeline(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def filters(self) -> pulumi.Output[List['outputs.LogsCustomPipelineFilter']]:
        return pulumi.get(self, "filters")

    @property
    @pulumi.getter(name="isEnabled")
    def is_enabled(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "is_enabled")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def processors(self) -> pulumi.Output[Optional[List['outputs.LogsCustomPipelineProcessor']]]:
        return pulumi.get(self, "processors")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

