# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables

class MetricMetadata(pulumi.CustomResource):
    description: pulumi.Output[str]
    """
    A description of the metric.
    """
    metric: pulumi.Output[str]
    """
    The name of the metric.
    """
    per_unit: pulumi.Output[str]
    """
    'Per' unit of the metric such as 'second' in 'bytes per second'.
    """
    short_name: pulumi.Output[str]
    """
    A short name of the metric.
    """
    statsd_interval: pulumi.Output[float]
    """
    If applicable, stasd flush interval in seconds for the metric.
    """
    type: pulumi.Output[str]
    unit: pulumi.Output[str]
    """
    Primary unit of the metric such as 'byte' or 'operation'.
    """
    def __init__(__self__, resource_name, opts=None, description=None, metric=None, per_unit=None, short_name=None, statsd_interval=None, type=None, unit=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides a Datadog metric_metadata resource. This can be used to manage a metric's metadata.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: A description of the metric.
        :param pulumi.Input[str] metric: The name of the metric.
        :param pulumi.Input[str] per_unit: 'Per' unit of the metric such as 'second' in 'bytes per second'.
        :param pulumi.Input[str] short_name: A short name of the metric.
        :param pulumi.Input[float] statsd_interval: If applicable, stasd flush interval in seconds for the metric.
        :param pulumi.Input[str] unit: Primary unit of the metric such as 'byte' or 'operation'.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/metric_metadata.html.markdown.
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

            __props__['description'] = description
            if metric is None:
                raise TypeError("Missing required property 'metric'")
            __props__['metric'] = metric
            __props__['per_unit'] = per_unit
            __props__['short_name'] = short_name
            __props__['statsd_interval'] = statsd_interval
            __props__['type'] = type
            __props__['unit'] = unit
        super(MetricMetadata, __self__).__init__(
            'datadog:index/metricMetadata:MetricMetadata',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, description=None, metric=None, per_unit=None, short_name=None, statsd_interval=None, type=None, unit=None):
        """
        Get an existing MetricMetadata resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: A description of the metric.
        :param pulumi.Input[str] metric: The name of the metric.
        :param pulumi.Input[str] per_unit: 'Per' unit of the metric such as 'second' in 'bytes per second'.
        :param pulumi.Input[str] short_name: A short name of the metric.
        :param pulumi.Input[float] statsd_interval: If applicable, stasd flush interval in seconds for the metric.
        :param pulumi.Input[str] unit: Primary unit of the metric such as 'byte' or 'operation'.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/metric_metadata.html.markdown.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["description"] = description
        __props__["metric"] = metric
        __props__["per_unit"] = per_unit
        __props__["short_name"] = short_name
        __props__["statsd_interval"] = statsd_interval
        __props__["type"] = type
        __props__["unit"] = unit
        return MetricMetadata(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

