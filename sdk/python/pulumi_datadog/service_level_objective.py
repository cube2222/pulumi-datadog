# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from . import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = ['ServiceLevelObjective']


class ServiceLevelObjective(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 monitor_ids: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 query: Optional[pulumi.Input[pulumi.InputType['ServiceLevelObjectiveQueryArgs']]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 thresholds: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ServiceLevelObjectiveThresholdArgs']]]]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 validate: Optional[pulumi.Input[bool]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Provides a Datadog service level objective resource. This can be used to create and manage Datadog service level objectives.

        ## Example Usage
        ### Metric-Based SLO

        ```python
        import pulumi
        import pulumi_datadog as datadog

        # Create a new Datadog service level objective
        foo = datadog.ServiceLevelObjective("foo",
            description="My custom metric SLO",
            name="Example Metric SLO",
            query=datadog.ServiceLevelObjectiveQueryArgs(
                denominator="sum:my.custom.count.metric{*}.as_count()",
                numerator="sum:my.custom.count.metric{type:good_events}.as_count()",
            ),
            tags=[
                "foo:bar",
                "baz",
            ],
            thresholds=[
                datadog.ServiceLevelObjectiveThresholdArgs(
                    target=99.9,
                    target_display="99.900",
                    timeframe="7d",
                    warning=99.99,
                    warning_display="99.990",
                ),
                datadog.ServiceLevelObjectiveThresholdArgs(
                    target=99.9,
                    target_display="99.900",
                    timeframe="30d",
                    warning=99.99,
                    warning_display="99.990",
                ),
            ],
            type="metric")
        ```
        ### Monitor-Based SLO

        ```python
        import pulumi
        import pulumi_datadog as datadog

        # Create a new Datadog service level objective
        bar = datadog.ServiceLevelObjective("bar",
            description="My custom monitor SLO",
            monitor_ids=[
                1,
                2,
                3,
            ],
            name="Example Monitor SLO",
            tags=[
                "foo:bar",
                "baz",
            ],
            thresholds=[
                datadog.ServiceLevelObjectiveThresholdArgs(
                    target=99.9,
                    timeframe="7d",
                    warning=99.99,
                ),
                datadog.ServiceLevelObjectiveThresholdArgs(
                    target=99.9,
                    timeframe="30d",
                    warning=99.99,
                ),
            ],
            type="monitor")
        ```

        ## Import

        Service Level Objectives can be imported using their string ID, e.g.

        ```sh
         $ pulumi import datadog:index/serviceLevelObjective:ServiceLevelObjective baz 12345678901234567890123456789012
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] groups: A static set of groups to filter monitor-based SLOs
        :param pulumi.Input[Sequence[pulumi.Input[int]]] monitor_ids: A static set of monitor IDs to use as part of the SLO
        :param pulumi.Input[pulumi.InputType['ServiceLevelObjectiveQueryArgs']] query: The metric query of good / total events
        :param pulumi.Input[Sequence[pulumi.Input[str]]] tags: A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
               -   `thresholds`: (Required) - A list of thresholds and targets that define the service level objectives from the provided SLIs.
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

            __props__['description'] = description
            __props__['groups'] = groups
            __props__['monitor_ids'] = monitor_ids
            if name is None:
                raise TypeError("Missing required property 'name'")
            __props__['name'] = name
            __props__['query'] = query
            __props__['tags'] = tags
            if thresholds is None:
                raise TypeError("Missing required property 'thresholds'")
            __props__['thresholds'] = thresholds
            if type is None:
                raise TypeError("Missing required property 'type'")
            __props__['type'] = type
            __props__['validate'] = validate
        super(ServiceLevelObjective, __self__).__init__(
            'datadog:index/serviceLevelObjective:ServiceLevelObjective',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            monitor_ids: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
            name: Optional[pulumi.Input[str]] = None,
            query: Optional[pulumi.Input[pulumi.InputType['ServiceLevelObjectiveQueryArgs']]] = None,
            tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            thresholds: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ServiceLevelObjectiveThresholdArgs']]]]] = None,
            type: Optional[pulumi.Input[str]] = None,
            validate: Optional[pulumi.Input[bool]] = None) -> 'ServiceLevelObjective':
        """
        Get an existing ServiceLevelObjective resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] groups: A static set of groups to filter monitor-based SLOs
        :param pulumi.Input[Sequence[pulumi.Input[int]]] monitor_ids: A static set of monitor IDs to use as part of the SLO
        :param pulumi.Input[pulumi.InputType['ServiceLevelObjectiveQueryArgs']] query: The metric query of good / total events
        :param pulumi.Input[Sequence[pulumi.Input[str]]] tags: A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
               -   `thresholds`: (Required) - A list of thresholds and targets that define the service level objectives from the provided SLIs.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["description"] = description
        __props__["groups"] = groups
        __props__["monitor_ids"] = monitor_ids
        __props__["name"] = name
        __props__["query"] = query
        __props__["tags"] = tags
        __props__["thresholds"] = thresholds
        __props__["type"] = type
        __props__["validate"] = validate
        return ServiceLevelObjective(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def groups(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        A static set of groups to filter monitor-based SLOs
        """
        return pulumi.get(self, "groups")

    @property
    @pulumi.getter(name="monitorIds")
    def monitor_ids(self) -> pulumi.Output[Optional[Sequence[int]]]:
        """
        A static set of monitor IDs to use as part of the SLO
        """
        return pulumi.get(self, "monitor_ids")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def query(self) -> pulumi.Output[Optional['outputs.ServiceLevelObjectiveQuery']]:
        """
        The metric query of good / total events
        """
        return pulumi.get(self, "query")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
        -   `thresholds`: (Required) - A list of thresholds and targets that define the service level objectives from the provided SLIs.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def thresholds(self) -> pulumi.Output[Sequence['outputs.ServiceLevelObjectiveThreshold']]:
        return pulumi.get(self, "thresholds")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def validate(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "validate")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

