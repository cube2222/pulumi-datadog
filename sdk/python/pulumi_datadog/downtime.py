# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables

class Downtime(pulumi.CustomResource):
    active: pulumi.Output[bool]
    """
    A flag indicating if the downtime is active now.
    """
    disabled: pulumi.Output[bool]
    """
    A flag indicating if the downtime was disabled.
    """
    end: pulumi.Output[float]
    """
    POSIX timestamp to end the downtime.
    """
    end_date: pulumi.Output[str]
    """
    String representing date and time to end the downtime in RFC3339 format.
    """
    message: pulumi.Output[str]
    """
    A message to include with notifications for this downtime.
    """
    monitor_id: pulumi.Output[float]
    """
    When specified, this downtime will only apply to this monitor
    """
    monitor_tags: pulumi.Output[list]
    """
    A list of monitor tags to match. The resulting downtime applies to monitors that match **all** provided monitor tags. This option conflicts with `monitor_id` as it will match all monitors that match these tags.
    """
    recurrence: pulumi.Output[dict]
    """
    A dictionary to configure the downtime to be recurring.

      * `period` (`float`) - How often to repeat as an integer. For example to repeat every 3 days, select a type of days and a period of 3.
      * `type` (`str`) - days, weeks, months, or years
      * `untilDate` (`float`) - The date at which the recurrence should end as a POSIX timestamp. `until_occurrences` and `until_date` are mutually exclusive.
      * `untilOccurrences` (`float`) - How many times the downtime will be rescheduled. `until_occurrences` and `until_date` are mutually exclusive.
      * `weekDays` (`list`) - A list of week days to repeat on. Choose from: Mon, Tue, Wed, Thu, Fri, Sat or Sun. Only applicable when type is weeks. First letter must be capitalized.
    """
    scopes: pulumi.Output[list]
    """
    A list of items to apply the downtime to, e.g. host:X
    """
    start: pulumi.Output[float]
    """
    POSIX timestamp to start the downtime.
    """
    start_date: pulumi.Output[str]
    """
    String representing date and time to start the downtime in RFC3339 format.
    """
    timezone: pulumi.Output[str]
    """
    The timezone for the downtime, default UTC. It must be a valid IANA Time Zone.
    """
    def __init__(__self__, resource_name, opts=None, active=None, disabled=None, end=None, end_date=None, message=None, monitor_id=None, monitor_tags=None, recurrence=None, scopes=None, start=None, start_date=None, timezone=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides a Datadog downtime resource. This can be used to create and manage Datadog downtimes.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/downtime.html.markdown.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] active: A flag indicating if the downtime is active now.
        :param pulumi.Input[bool] disabled: A flag indicating if the downtime was disabled.
        :param pulumi.Input[float] end: POSIX timestamp to end the downtime.
        :param pulumi.Input[str] end_date: String representing date and time to end the downtime in RFC3339 format.
        :param pulumi.Input[str] message: A message to include with notifications for this downtime.
        :param pulumi.Input[float] monitor_id: When specified, this downtime will only apply to this monitor
        :param pulumi.Input[list] monitor_tags: A list of monitor tags to match. The resulting downtime applies to monitors that match **all** provided monitor tags. This option conflicts with `monitor_id` as it will match all monitors that match these tags.
        :param pulumi.Input[dict] recurrence: A dictionary to configure the downtime to be recurring.
        :param pulumi.Input[list] scopes: A list of items to apply the downtime to, e.g. host:X
        :param pulumi.Input[float] start: POSIX timestamp to start the downtime.
        :param pulumi.Input[str] start_date: String representing date and time to start the downtime in RFC3339 format.
        :param pulumi.Input[str] timezone: The timezone for the downtime, default UTC. It must be a valid IANA Time Zone.

        The **recurrence** object supports the following:

          * `period` (`pulumi.Input[float]`) - How often to repeat as an integer. For example to repeat every 3 days, select a type of days and a period of 3.
          * `type` (`pulumi.Input[str]`) - days, weeks, months, or years
          * `untilDate` (`pulumi.Input[float]`) - The date at which the recurrence should end as a POSIX timestamp. `until_occurrences` and `until_date` are mutually exclusive.
          * `untilOccurrences` (`pulumi.Input[float]`) - How many times the downtime will be rescheduled. `until_occurrences` and `until_date` are mutually exclusive.
          * `weekDays` (`pulumi.Input[list]`) - A list of week days to repeat on. Choose from: Mon, Tue, Wed, Thu, Fri, Sat or Sun. Only applicable when type is weeks. First letter must be capitalized.
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
    def get(resource_name, id, opts=None, active=None, disabled=None, end=None, end_date=None, message=None, monitor_id=None, monitor_tags=None, recurrence=None, scopes=None, start=None, start_date=None, timezone=None):
        """
        Get an existing Downtime resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] active: A flag indicating if the downtime is active now.
        :param pulumi.Input[bool] disabled: A flag indicating if the downtime was disabled.
        :param pulumi.Input[float] end: POSIX timestamp to end the downtime.
        :param pulumi.Input[str] end_date: String representing date and time to end the downtime in RFC3339 format.
        :param pulumi.Input[str] message: A message to include with notifications for this downtime.
        :param pulumi.Input[float] monitor_id: When specified, this downtime will only apply to this monitor
        :param pulumi.Input[list] monitor_tags: A list of monitor tags to match. The resulting downtime applies to monitors that match **all** provided monitor tags. This option conflicts with `monitor_id` as it will match all monitors that match these tags.
        :param pulumi.Input[dict] recurrence: A dictionary to configure the downtime to be recurring.
        :param pulumi.Input[list] scopes: A list of items to apply the downtime to, e.g. host:X
        :param pulumi.Input[float] start: POSIX timestamp to start the downtime.
        :param pulumi.Input[str] start_date: String representing date and time to start the downtime in RFC3339 format.
        :param pulumi.Input[str] timezone: The timezone for the downtime, default UTC. It must be a valid IANA Time Zone.

        The **recurrence** object supports the following:

          * `period` (`pulumi.Input[float]`) - How often to repeat as an integer. For example to repeat every 3 days, select a type of days and a period of 3.
          * `type` (`pulumi.Input[str]`) - days, weeks, months, or years
          * `untilDate` (`pulumi.Input[float]`) - The date at which the recurrence should end as a POSIX timestamp. `until_occurrences` and `until_date` are mutually exclusive.
          * `untilOccurrences` (`pulumi.Input[float]`) - How many times the downtime will be rescheduled. `until_occurrences` and `until_date` are mutually exclusive.
          * `weekDays` (`pulumi.Input[list]`) - A list of week days to repeat on. Choose from: Mon, Tue, Wed, Thu, Fri, Sat or Sun. Only applicable when type is weeks. First letter must be capitalized.
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
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

