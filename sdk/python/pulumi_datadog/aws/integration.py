# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class Integration(pulumi.CustomResource):
    account_id: pulumi.Output[str]
    """
    Your AWS Account ID without dashes.
    """
    account_specific_namespace_rules: pulumi.Output[dict]
    """
    Enables or disables metric collection for specific AWS namespaces for this AWS account only. A list of namespaces can be found at the [available namespace rules API endpoint](https://api.datadoghq.com/api/v1/integration/aws/available_namespace_rules).
    """
    external_id: pulumi.Output[str]
    """
    AWS External ID
    """
    filter_tags: pulumi.Output[list]
    """
    Array of EC2 tags (in the form `key:value`) defines a filter that Datadog use when collecting metrics from EC2. Wildcards, such as `?` (for single characters) and `*` (for multiple characters) can also be used.
    """
    host_tags: pulumi.Output[list]
    """
    Array of tags (in the form key:value) to add to all hosts and metrics reporting through this integration.
    """
    role_name: pulumi.Output[str]
    """
    Your Datadog role delegation name.
    """
    def __init__(__self__, resource_name, opts=None, account_id=None, account_specific_namespace_rules=None, filter_tags=None, host_tags=None, role_name=None, __name__=None, __opts__=None):
        """
        Provides a Datadog - Amazon Web Services integration resource. This can be used to create and manage Datadog - Amazon Web Services integration.
        
        Update operations are currently not supported with datadog API so any change forces a new resource.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] account_id: Your AWS Account ID without dashes.
        :param pulumi.Input[dict] account_specific_namespace_rules: Enables or disables metric collection for specific AWS namespaces for this AWS account only. A list of namespaces can be found at the [available namespace rules API endpoint](https://api.datadoghq.com/api/v1/integration/aws/available_namespace_rules).
        :param pulumi.Input[list] filter_tags: Array of EC2 tags (in the form `key:value`) defines a filter that Datadog use when collecting metrics from EC2. Wildcards, such as `?` (for single characters) and `*` (for multiple characters) can also be used.
        :param pulumi.Input[list] host_tags: Array of tags (in the form key:value) to add to all hosts and metrics reporting through this integration.
        :param pulumi.Input[str] role_name: Your Datadog role delegation name.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if not resource_name:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(resource_name, str):
            raise TypeError('Expected resource name to be a string')
        if opts and not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if account_id is None:
            raise TypeError("Missing required property 'account_id'")
        __props__['account_id'] = account_id

        __props__['account_specific_namespace_rules'] = account_specific_namespace_rules

        __props__['filter_tags'] = filter_tags

        __props__['host_tags'] = host_tags

        if role_name is None:
            raise TypeError("Missing required property 'role_name'")
        __props__['role_name'] = role_name

        __props__['external_id'] = None

        super(Integration, __self__).__init__(
            'datadog:aws/integration:Integration',
            resource_name,
            __props__,
            opts)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
