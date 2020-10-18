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

__all__ = ['Downtime']


class Downtime(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 active: Optional[pulumi.Input[bool]] = None,
                 disabled: Optional[pulumi.Input[bool]] = None,
                 end: Optional[pulumi.Input[int]] = None,
                 end_date: Optional[pulumi.Input[str]] = None,
                 message: Optional[pulumi.Input[str]] = None,
                 monitor_id: Optional[pulumi.Input[int]] = None,
                 monitor_tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 recurrence: Optional[pulumi.Input[pulumi.InputType['DowntimeRecurrenceArgs']]] = None,
                 scopes: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 start: Optional[pulumi.Input[int]] = None,
                 start_date: Optional[pulumi.Input[str]] = None,
                 timezone: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Provides a Datadog downtime resource. This can be used to create and manage Datadog downtimes.

        ## Example: downtime for a specific monitor

        ```python
        import pulumi
        import pulumi_datadog as datadog

        # Create a new daily 1700-0900 Datadog downtime for a specific monitor id
        foo = datadog.Downtime("foo",
            end=1483365600,
            monitor_id=12345,
            recurrence=datadog.DowntimeRecurrenceArgs(
                period=1,
                type="days",
            ),
            scopes=["*"],
            start=1483308000)
        ```

        ## Example: downtime for all monitors

        ```python
        import pulumi
        import pulumi_datadog as datadog

        # Create a new daily 1700-0900 Datadog downtime for all monitors
        foo = datadog.Downtime("foo",
            end=1483365600,
            recurrence=datadog.DowntimeRecurrenceArgs(
                period=1,
                type="days",
            ),
            scopes=["*"],
            start=1483308000)
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] active: When true indicates this downtime is being actively applied
        :param pulumi.Input[bool] disabled: When true indicates this downtime is not being applied
        :param pulumi.Input[int] end: Optionally specify an end date when this downtime should expire
        :param pulumi.Input[str] message: An optional message to provide when creating the downtime, can include notification handles
        :param pulumi.Input[int] monitor_id: When specified, this downtime will only apply to this monitor
        :param pulumi.Input[Sequence[pulumi.Input[str]]] monitor_tags: A list of monitor tags (up to 25), i.e. tags that are applied directly to monitors to which the downtime applies
        :param pulumi.Input[pulumi.InputType['DowntimeRecurrenceArgs']] recurrence: Optional recurring schedule for this downtime
        :param pulumi.Input[Sequence[pulumi.Input[str]]] scopes: specify the group scope to which this downtime applies. For everything use '*'
        :param pulumi.Input[int] start: Specify when this downtime should start
        :param pulumi.Input[str] timezone: The timezone for the downtime, default UTC
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

            __props__['active'] = active
            __props__['disabled'] = disabled
            __props__['end'] = end
            __props__['end_date'] = end_date
            __props__['message'] = message
            __props__['monitor_id'] = monitor_id
            __props__['monitor_tags'] = monitor_tags
            __props__['recurrence'] = recurrence
            if scopes is None:
                raise TypeError("Missing required property 'scopes'")
            __props__['scopes'] = scopes
            __props__['start'] = start
            __props__['start_date'] = start_date
            __props__['timezone'] = timezone
        super(Downtime, __self__).__init__(
            'datadog:index/downtime:Downtime',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            active: Optional[pulumi.Input[bool]] = None,
            disabled: Optional[pulumi.Input[bool]] = None,
            end: Optional[pulumi.Input[int]] = None,
            end_date: Optional[pulumi.Input[str]] = None,
            message: Optional[pulumi.Input[str]] = None,
            monitor_id: Optional[pulumi.Input[int]] = None,
            monitor_tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            recurrence: Optional[pulumi.Input[pulumi.InputType['DowntimeRecurrenceArgs']]] = None,
            scopes: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            start: Optional[pulumi.Input[int]] = None,
            start_date: Optional[pulumi.Input[str]] = None,
            timezone: Optional[pulumi.Input[str]] = None) -> 'Downtime':
        """
        Get an existing Downtime resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] active: When true indicates this downtime is being actively applied
        :param pulumi.Input[bool] disabled: When true indicates this downtime is not being applied
        :param pulumi.Input[int] end: Optionally specify an end date when this downtime should expire
        :param pulumi.Input[str] message: An optional message to provide when creating the downtime, can include notification handles
        :param pulumi.Input[int] monitor_id: When specified, this downtime will only apply to this monitor
        :param pulumi.Input[Sequence[pulumi.Input[str]]] monitor_tags: A list of monitor tags (up to 25), i.e. tags that are applied directly to monitors to which the downtime applies
        :param pulumi.Input[pulumi.InputType['DowntimeRecurrenceArgs']] recurrence: Optional recurring schedule for this downtime
        :param pulumi.Input[Sequence[pulumi.Input[str]]] scopes: specify the group scope to which this downtime applies. For everything use '*'
        :param pulumi.Input[int] start: Specify when this downtime should start
        :param pulumi.Input[str] timezone: The timezone for the downtime, default UTC
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["active"] = active
        __props__["disabled"] = disabled
        __props__["end"] = end
        __props__["end_date"] = end_date
        __props__["message"] = message
        __props__["monitor_id"] = monitor_id
        __props__["monitor_tags"] = monitor_tags
        __props__["recurrence"] = recurrence
        __props__["scopes"] = scopes
        __props__["start"] = start
        __props__["start_date"] = start_date
        __props__["timezone"] = timezone
        return Downtime(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def active(self) -> pulumi.Output[Optional[bool]]:
        """
        When true indicates this downtime is being actively applied
        """
        return pulumi.get(self, "active")

    @property
    @pulumi.getter
    def disabled(self) -> pulumi.Output[Optional[bool]]:
        """
        When true indicates this downtime is not being applied
        """
        return pulumi.get(self, "disabled")

    @property
    @pulumi.getter
    def end(self) -> pulumi.Output[Optional[int]]:
        """
        Optionally specify an end date when this downtime should expire
        """
        return pulumi.get(self, "end")

    @property
    @pulumi.getter(name="endDate")
    def end_date(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "end_date")

    @property
    @pulumi.getter
    def message(self) -> pulumi.Output[Optional[str]]:
        """
        An optional message to provide when creating the downtime, can include notification handles
        """
        return pulumi.get(self, "message")

    @property
    @pulumi.getter(name="monitorId")
    def monitor_id(self) -> pulumi.Output[Optional[int]]:
        """
        When specified, this downtime will only apply to this monitor
        """
        return pulumi.get(self, "monitor_id")

    @property
    @pulumi.getter(name="monitorTags")
    def monitor_tags(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        A list of monitor tags (up to 25), i.e. tags that are applied directly to monitors to which the downtime applies
        """
        return pulumi.get(self, "monitor_tags")

    @property
    @pulumi.getter
    def recurrence(self) -> pulumi.Output[Optional['outputs.DowntimeRecurrence']]:
        """
        Optional recurring schedule for this downtime
        """
        return pulumi.get(self, "recurrence")

    @property
    @pulumi.getter
    def scopes(self) -> pulumi.Output[Sequence[str]]:
        """
        specify the group scope to which this downtime applies. For everything use '*'
        """
        return pulumi.get(self, "scopes")

    @property
    @pulumi.getter
    def start(self) -> pulumi.Output[Optional[int]]:
        """
        Specify when this downtime should start
        """
        return pulumi.get(self, "start")

    @property
    @pulumi.getter(name="startDate")
    def start_date(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "start_date")

    @property
    @pulumi.getter
    def timezone(self) -> pulumi.Output[Optional[str]]:
        """
        The timezone for the downtime, default UTC
        """
        return pulumi.get(self, "timezone")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

