# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities, tables

class Monitor(pulumi.CustomResource):
    """
    Provides a Datadog monitor resource. This can be used to create and manage Datadog monitors.
    """
    def __init__(__self__, __name__, __opts__=None, escalation_message=None, evaluation_delay=None, include_tags=None, locked=None, message=None, name=None, new_host_delay=None, no_data_timeframe=None, notify_audit=None, notify_no_data=None, query=None, renotify_interval=None, require_full_window=None, silenced=None, tags=None, thresholds=None, timeout_h=None, type=None):
        """Create a Monitor resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, str):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        __props__['escalation_message'] = escalation_message

        __props__['evaluation_delay'] = evaluation_delay

        __props__['include_tags'] = include_tags

        __props__['locked'] = locked

        if not message:
            raise TypeError('Missing required property message')
        __props__['message'] = message

        if not name:
            raise TypeError('Missing required property name')
        __props__['name'] = name

        __props__['new_host_delay'] = new_host_delay

        __props__['no_data_timeframe'] = no_data_timeframe

        __props__['notify_audit'] = notify_audit

        __props__['notify_no_data'] = notify_no_data

        if not query:
            raise TypeError('Missing required property query')
        __props__['query'] = query

        __props__['renotify_interval'] = renotify_interval

        __props__['require_full_window'] = require_full_window

        __props__['silenced'] = silenced

        __props__['tags'] = tags

        __props__['thresholds'] = thresholds

        __props__['timeout_h'] = timeout_h

        if not type:
            raise TypeError('Missing required property type')
        __props__['type'] = type

        super(Monitor, __self__).__init__(
            'datadog:monitor:Monitor',
            __name__,
            __props__,
            __opts__)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

