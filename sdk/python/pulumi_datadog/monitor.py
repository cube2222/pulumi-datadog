# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables

class Monitor(pulumi.CustomResource):
    enable_logs_sample: pulumi.Output[bool]
    """
    A boolean indicating whether or not to include a list of log values which triggered the alert. Defaults to false. This is only used by log monitors.
    triggering tags into the title. Defaults to true.
    """
    escalation_message: pulumi.Output[str]
    """
    A message to include with a re-notification. Supports the '@username'
    notification allowed elsewhere.
    """
    evaluation_delay: pulumi.Output[float]
    include_tags: pulumi.Output[bool]
    """
    A boolean indicating whether notifications from this monitor automatically insert its triggering tags into the title. Defaults to true.
    """
    locked: pulumi.Output[bool]
    """
    A boolean indicating whether changes to to this monitor should be restricted to the creator or admins. Defaults to False.
    """
    message: pulumi.Output[str]
    """
    A message to include with notifications for this monitor.
    Email notifications can be sent to specific users by using the same '@username' notation as events.
    """
    name: pulumi.Output[str]
    """
    Name of Datadog monitor
    """
    new_host_delay: pulumi.Output[float]
    """
    Time (in seconds) to allow a host to boot and
    applications to fully start before starting the evaluation of monitor
    results. Should be a non negative integer. Defaults to 300.
    * `evaluation_delay` (Optional, only applies to metric alert) Time (in seconds) to delay evaluation, as a non-negative integer.
    For example, if the value is set to 300 (5min), the timeframe is set to last_5m and the time is 7:00,
    the monitor will evaluate data from 6:50 to 6:55. This is useful for AWS CloudWatch and other backfilled
    metrics to ensure the monitor will always have data during evaluation.
    """
    no_data_timeframe: pulumi.Output[float]
    """
    The number of minutes before a monitor will notify when data stops reporting. Must be at
    least 2x the monitor timeframe for metric alerts or 2 minutes for service checks. Default: 2x timeframe for
    metric alerts, 2 minutes for service checks. Defaults to 10 minutes.
    """
    notify_audit: pulumi.Output[bool]
    """
    A boolean indicating whether tagged users will be notified on changes to this monitor.
    Defaults to false.
    """
    notify_no_data: pulumi.Output[bool]
    """
    A boolean indicating whether this monitor will notify when data stops reporting. Defaults
    to false.
    """
    query: pulumi.Output[str]
    renotify_interval: pulumi.Output[float]
    """
    The number of minutes after the last notification before a monitor will re-notify
    on the current status. It will only re-notify if it's not resolved.
    """
    require_full_window: pulumi.Output[bool]
    """
    A boolean indicating whether this monitor needs a full window of data before it's evaluated.
    We highly recommend you set this to False for sparse metrics, otherwise some evaluations will be skipped.
    Default: True for "on average", "at all times" and "in total" aggregation. False otherwise.
    """
    silenced: pulumi.Output[dict]
    tags: pulumi.Output[list]
    """
    A list of tags to associate with your monitor. This can help you categorize and filter monitors in the manage monitors page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
    """
    threshold_windows: pulumi.Output[dict]
    """
    A mapping containing `recovery_window` and `trigger_window` values, e.g. `last_15m`. Can only be used for, and are required for, anomaly monitors.
    * `recovery_window` describes how long an anomalous metric must be normal before the alert recovers.

      * `recovery_window` (`str`)
      * `trigger_window` (`str`) - describes how long a metric must be anomalous before an alert triggers.
    """
    thresholds: pulumi.Output[dict]
    """

    * Metric alerts:
    A dictionary of thresholds by threshold type. Currently we have four threshold types for metric alerts: critical, critical recovery, warning, and warning recovery. Critical is defined in the query, but can also be specified in this option. Warning and recovery thresholds can only be specified using the thresholds option.
    Example usage:
    ```
    thresholds = {
    critical          = 90
    critical_recovery = 85
    warning           = 80
    warning_recovery  = 75
    }
    ```
    **Warning:** the `critical` threshold value must match the one contained in the `query` argument. The `threshold` from the previous example is valid along with a query like `avg(last_1h):avg:system.disk.in_use{role:sqlserver} by {host} > 90` but
    along with something like `avg(last_1h):avg:system.disk.in_use{role:sqlserver} by {host} > 95` would make the Datadog API return a HTTP error 400, complaining "The value provided for parameter 'query' is invalid".
    * Service checks:
    A dictionary of thresholds by status. Because service checks can have multiple thresholds, we don't define them directly in the query.
    Default values:
    ```
    thresholds = {
    ok       = 1
    critical = 1
    warning  = 1
    unknown  = 1
    }
    ```

      * `critical` (`float`)
      * `critical_recovery` (`float`)
      * `ok` (`float`)
      * `unknown` (`float`)
      * `warning` (`float`)
      * `warning_recovery` (`float`)
    """
    timeout_h: pulumi.Output[float]
    """
    The number of hours of the monitor not reporting data before it will automatically resolve
    from a triggered state. Defaults to false.
    """
    type: pulumi.Output[str]
    """
    The type of the monitor. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/?lang=python#create-a-monitor) page. The available options are below. **Note**: The monitor type cannot be changed after a monitor is created.
    * `metric alert`
    * `service check`
    * `event alert`
    * `query alert`
    * `composite`
    * `log alert`
    """
    def __init__(__self__, resource_name, opts=None, enable_logs_sample=None, escalation_message=None, evaluation_delay=None, include_tags=None, locked=None, message=None, name=None, new_host_delay=None, no_data_timeframe=None, notify_audit=None, notify_no_data=None, query=None, renotify_interval=None, require_full_window=None, silenced=None, tags=None, threshold_windows=None, thresholds=None, timeout_h=None, type=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides a Datadog monitor resource. This can be used to create and manage Datadog monitors.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/monitor.html.markdown.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] enable_logs_sample: A boolean indicating whether or not to include a list of log values which triggered the alert. Defaults to false. This is only used by log monitors.
               triggering tags into the title. Defaults to true.
        :param pulumi.Input[str] escalation_message: A message to include with a re-notification. Supports the '@username'
               notification allowed elsewhere.
        :param pulumi.Input[bool] include_tags: A boolean indicating whether notifications from this monitor automatically insert its triggering tags into the title. Defaults to true.
        :param pulumi.Input[bool] locked: A boolean indicating whether changes to to this monitor should be restricted to the creator or admins. Defaults to False.
        :param pulumi.Input[str] message: A message to include with notifications for this monitor.
               Email notifications can be sent to specific users by using the same '@username' notation as events.
        :param pulumi.Input[str] name: Name of Datadog monitor
        :param pulumi.Input[float] new_host_delay: Time (in seconds) to allow a host to boot and
               applications to fully start before starting the evaluation of monitor
               results. Should be a non negative integer. Defaults to 300.
               * `evaluation_delay` (Optional, only applies to metric alert) Time (in seconds) to delay evaluation, as a non-negative integer.
               For example, if the value is set to 300 (5min), the timeframe is set to last_5m and the time is 7:00,
               the monitor will evaluate data from 6:50 to 6:55. This is useful for AWS CloudWatch and other backfilled
               metrics to ensure the monitor will always have data during evaluation.
        :param pulumi.Input[float] no_data_timeframe: The number of minutes before a monitor will notify when data stops reporting. Must be at
               least 2x the monitor timeframe for metric alerts or 2 minutes for service checks. Default: 2x timeframe for
               metric alerts, 2 minutes for service checks. Defaults to 10 minutes.
        :param pulumi.Input[bool] notify_audit: A boolean indicating whether tagged users will be notified on changes to this monitor.
               Defaults to false.
        :param pulumi.Input[bool] notify_no_data: A boolean indicating whether this monitor will notify when data stops reporting. Defaults
               to false.
        :param pulumi.Input[float] renotify_interval: The number of minutes after the last notification before a monitor will re-notify
               on the current status. It will only re-notify if it's not resolved.
        :param pulumi.Input[bool] require_full_window: A boolean indicating whether this monitor needs a full window of data before it's evaluated.
               We highly recommend you set this to False for sparse metrics, otherwise some evaluations will be skipped.
               Default: True for "on average", "at all times" and "in total" aggregation. False otherwise.
        :param pulumi.Input[list] tags: A list of tags to associate with your monitor. This can help you categorize and filter monitors in the manage monitors page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
        :param pulumi.Input[dict] threshold_windows: A mapping containing `recovery_window` and `trigger_window` values, e.g. `last_15m`. Can only be used for, and are required for, anomaly monitors.
               * `recovery_window` describes how long an anomalous metric must be normal before the alert recovers.
        :param pulumi.Input[dict] thresholds: 
               * Metric alerts:
               A dictionary of thresholds by threshold type. Currently we have four threshold types for metric alerts: critical, critical recovery, warning, and warning recovery. Critical is defined in the query, but can also be specified in this option. Warning and recovery thresholds can only be specified using the thresholds option.
               Example usage:
               ```
               thresholds = {
               critical          = 90
               critical_recovery = 85
               warning           = 80
               warning_recovery  = 75
               }
               ```
               **Warning:** the `critical` threshold value must match the one contained in the `query` argument. The `threshold` from the previous example is valid along with a query like `avg(last_1h):avg:system.disk.in_use{role:sqlserver} by {host} > 90` but
               along with something like `avg(last_1h):avg:system.disk.in_use{role:sqlserver} by {host} > 95` would make the Datadog API return a HTTP error 400, complaining "The value provided for parameter 'query' is invalid".
               * Service checks:
               A dictionary of thresholds by status. Because service checks can have multiple thresholds, we don't define them directly in the query.
               Default values:
               ```
               thresholds = {
               ok       = 1
               critical = 1
               warning  = 1
               unknown  = 1
               }
               ```
        :param pulumi.Input[float] timeout_h: The number of hours of the monitor not reporting data before it will automatically resolve
               from a triggered state. Defaults to false.
        :param pulumi.Input[str] type: The type of the monitor. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/?lang=python#create-a-monitor) page. The available options are below. **Note**: The monitor type cannot be changed after a monitor is created.
               * `metric alert`
               * `service check`
               * `event alert`
               * `query alert`
               * `composite`
               * `log alert`

        The **threshold_windows** object supports the following:

          * `recovery_window` (`pulumi.Input[str]`)
          * `trigger_window` (`pulumi.Input[str]`) - describes how long a metric must be anomalous before an alert triggers.

        The **thresholds** object supports the following:

          * `critical` (`pulumi.Input[float]`)
          * `critical_recovery` (`pulumi.Input[float]`)
          * `ok` (`pulumi.Input[float]`)
          * `unknown` (`pulumi.Input[float]`)
          * `warning` (`pulumi.Input[float]`)
          * `warning_recovery` (`pulumi.Input[float]`)
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

            __props__['enable_logs_sample'] = enable_logs_sample
            __props__['escalation_message'] = escalation_message
            __props__['evaluation_delay'] = evaluation_delay
            __props__['include_tags'] = include_tags
            __props__['locked'] = locked
            if message is None:
                raise TypeError("Missing required property 'message'")
            __props__['message'] = message
            if name is None:
                raise TypeError("Missing required property 'name'")
            __props__['name'] = name
            __props__['new_host_delay'] = new_host_delay
            __props__['no_data_timeframe'] = no_data_timeframe
            __props__['notify_audit'] = notify_audit
            __props__['notify_no_data'] = notify_no_data
            if query is None:
                raise TypeError("Missing required property 'query'")
            __props__['query'] = query
            __props__['renotify_interval'] = renotify_interval
            __props__['require_full_window'] = require_full_window
            __props__['silenced'] = silenced
            __props__['tags'] = tags
            __props__['threshold_windows'] = threshold_windows
            __props__['thresholds'] = thresholds
            __props__['timeout_h'] = timeout_h
            if type is None:
                raise TypeError("Missing required property 'type'")
            __props__['type'] = type
        super(Monitor, __self__).__init__(
            'datadog:index/monitor:Monitor',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, enable_logs_sample=None, escalation_message=None, evaluation_delay=None, include_tags=None, locked=None, message=None, name=None, new_host_delay=None, no_data_timeframe=None, notify_audit=None, notify_no_data=None, query=None, renotify_interval=None, require_full_window=None, silenced=None, tags=None, threshold_windows=None, thresholds=None, timeout_h=None, type=None):
        """
        Get an existing Monitor resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] enable_logs_sample: A boolean indicating whether or not to include a list of log values which triggered the alert. Defaults to false. This is only used by log monitors.
               triggering tags into the title. Defaults to true.
        :param pulumi.Input[str] escalation_message: A message to include with a re-notification. Supports the '@username'
               notification allowed elsewhere.
        :param pulumi.Input[bool] include_tags: A boolean indicating whether notifications from this monitor automatically insert its triggering tags into the title. Defaults to true.
        :param pulumi.Input[bool] locked: A boolean indicating whether changes to to this monitor should be restricted to the creator or admins. Defaults to False.
        :param pulumi.Input[str] message: A message to include with notifications for this monitor.
               Email notifications can be sent to specific users by using the same '@username' notation as events.
        :param pulumi.Input[str] name: Name of Datadog monitor
        :param pulumi.Input[float] new_host_delay: Time (in seconds) to allow a host to boot and
               applications to fully start before starting the evaluation of monitor
               results. Should be a non negative integer. Defaults to 300.
               * `evaluation_delay` (Optional, only applies to metric alert) Time (in seconds) to delay evaluation, as a non-negative integer.
               For example, if the value is set to 300 (5min), the timeframe is set to last_5m and the time is 7:00,
               the monitor will evaluate data from 6:50 to 6:55. This is useful for AWS CloudWatch and other backfilled
               metrics to ensure the monitor will always have data during evaluation.
        :param pulumi.Input[float] no_data_timeframe: The number of minutes before a monitor will notify when data stops reporting. Must be at
               least 2x the monitor timeframe for metric alerts or 2 minutes for service checks. Default: 2x timeframe for
               metric alerts, 2 minutes for service checks. Defaults to 10 minutes.
        :param pulumi.Input[bool] notify_audit: A boolean indicating whether tagged users will be notified on changes to this monitor.
               Defaults to false.
        :param pulumi.Input[bool] notify_no_data: A boolean indicating whether this monitor will notify when data stops reporting. Defaults
               to false.
        :param pulumi.Input[float] renotify_interval: The number of minutes after the last notification before a monitor will re-notify
               on the current status. It will only re-notify if it's not resolved.
        :param pulumi.Input[bool] require_full_window: A boolean indicating whether this monitor needs a full window of data before it's evaluated.
               We highly recommend you set this to False for sparse metrics, otherwise some evaluations will be skipped.
               Default: True for "on average", "at all times" and "in total" aggregation. False otherwise.
        :param pulumi.Input[list] tags: A list of tags to associate with your monitor. This can help you categorize and filter monitors in the manage monitors page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
        :param pulumi.Input[dict] threshold_windows: A mapping containing `recovery_window` and `trigger_window` values, e.g. `last_15m`. Can only be used for, and are required for, anomaly monitors.
               * `recovery_window` describes how long an anomalous metric must be normal before the alert recovers.
        :param pulumi.Input[dict] thresholds: 
               * Metric alerts:
               A dictionary of thresholds by threshold type. Currently we have four threshold types for metric alerts: critical, critical recovery, warning, and warning recovery. Critical is defined in the query, but can also be specified in this option. Warning and recovery thresholds can only be specified using the thresholds option.
               Example usage:
               ```
               thresholds = {
               critical          = 90
               critical_recovery = 85
               warning           = 80
               warning_recovery  = 75
               }
               ```
               **Warning:** the `critical` threshold value must match the one contained in the `query` argument. The `threshold` from the previous example is valid along with a query like `avg(last_1h):avg:system.disk.in_use{role:sqlserver} by {host} > 90` but
               along with something like `avg(last_1h):avg:system.disk.in_use{role:sqlserver} by {host} > 95` would make the Datadog API return a HTTP error 400, complaining "The value provided for parameter 'query' is invalid".
               * Service checks:
               A dictionary of thresholds by status. Because service checks can have multiple thresholds, we don't define them directly in the query.
               Default values:
               ```
               thresholds = {
               ok       = 1
               critical = 1
               warning  = 1
               unknown  = 1
               }
               ```
        :param pulumi.Input[float] timeout_h: The number of hours of the monitor not reporting data before it will automatically resolve
               from a triggered state. Defaults to false.
        :param pulumi.Input[str] type: The type of the monitor. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/?lang=python#create-a-monitor) page. The available options are below. **Note**: The monitor type cannot be changed after a monitor is created.
               * `metric alert`
               * `service check`
               * `event alert`
               * `query alert`
               * `composite`
               * `log alert`

        The **threshold_windows** object supports the following:

          * `recovery_window` (`pulumi.Input[str]`)
          * `trigger_window` (`pulumi.Input[str]`) - describes how long a metric must be anomalous before an alert triggers.

        The **thresholds** object supports the following:

          * `critical` (`pulumi.Input[float]`)
          * `critical_recovery` (`pulumi.Input[float]`)
          * `ok` (`pulumi.Input[float]`)
          * `unknown` (`pulumi.Input[float]`)
          * `warning` (`pulumi.Input[float]`)
          * `warning_recovery` (`pulumi.Input[float]`)
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["enable_logs_sample"] = enable_logs_sample
        __props__["escalation_message"] = escalation_message
        __props__["evaluation_delay"] = evaluation_delay
        __props__["include_tags"] = include_tags
        __props__["locked"] = locked
        __props__["message"] = message
        __props__["name"] = name
        __props__["new_host_delay"] = new_host_delay
        __props__["no_data_timeframe"] = no_data_timeframe
        __props__["notify_audit"] = notify_audit
        __props__["notify_no_data"] = notify_no_data
        __props__["query"] = query
        __props__["renotify_interval"] = renotify_interval
        __props__["require_full_window"] = require_full_window
        __props__["silenced"] = silenced
        __props__["tags"] = tags
        __props__["threshold_windows"] = threshold_windows
        __props__["thresholds"] = thresholds
        __props__["timeout_h"] = timeout_h
        __props__["type"] = type
        return Monitor(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

