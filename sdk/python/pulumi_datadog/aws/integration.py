# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables


class Integration(pulumi.CustomResource):
    account_id: pulumi.Output[str]
    """
    Your AWS Account ID without dashes.
    """
    account_specific_namespace_rules: pulumi.Output[dict]
    """
    Enables or disables metric collection for specific AWS namespaces for this AWS account only. A list of namespaces can be found at the [available namespace rules API endpoint](https://docs.datadoghq.com/api/v1/aws-integration/#list-namespace-rules).
    """
    excluded_regions: pulumi.Output[list]
    """
    An array of AWS regions to exclude from metrics collection.
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
    def __init__(__self__, resource_name, opts=None, account_id=None, account_specific_namespace_rules=None, excluded_regions=None, filter_tags=None, host_tags=None, role_name=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides a Datadog - Amazon Web Services integration resource. This can be used to create and manage Datadog - Amazon Web Services integration.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_datadog as datadog

        # Create a new Datadog - Amazon Web Services integration
        sandbox = datadog.aws.Integration("sandbox",
            account_id="1234567890",
            account_specific_namespace_rules={
                "auto_scaling": False,
                "opsworks": False,
            },
            excluded_regions=[
                "us-east-1",
                "us-west-2",
            ],
            filter_tags=["key:value"],
            host_tags=[
                "key:value",
                "key2:value2",
            ],
            role_name="DatadogAWSIntegrationRole")
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] account_id: Your AWS Account ID without dashes.
        :param pulumi.Input[dict] account_specific_namespace_rules: Enables or disables metric collection for specific AWS namespaces for this AWS account only. A list of namespaces can be found at the [available namespace rules API endpoint](https://docs.datadoghq.com/api/v1/aws-integration/#list-namespace-rules).
        :param pulumi.Input[list] excluded_regions: An array of AWS regions to exclude from metrics collection.
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

            if account_id is None:
                raise TypeError("Missing required property 'account_id'")
            __props__['account_id'] = account_id
            __props__['account_specific_namespace_rules'] = account_specific_namespace_rules
            __props__['excluded_regions'] = excluded_regions
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

    @staticmethod
    def get(resource_name, id, opts=None, account_id=None, account_specific_namespace_rules=None, excluded_regions=None, external_id=None, filter_tags=None, host_tags=None, role_name=None):
        """
        Get an existing Integration resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] account_id: Your AWS Account ID without dashes.
        :param pulumi.Input[dict] account_specific_namespace_rules: Enables or disables metric collection for specific AWS namespaces for this AWS account only. A list of namespaces can be found at the [available namespace rules API endpoint](https://docs.datadoghq.com/api/v1/aws-integration/#list-namespace-rules).
        :param pulumi.Input[list] excluded_regions: An array of AWS regions to exclude from metrics collection.
        :param pulumi.Input[str] external_id: AWS External ID
        :param pulumi.Input[list] filter_tags: Array of EC2 tags (in the form `key:value`) defines a filter that Datadog use when collecting metrics from EC2. Wildcards, such as `?` (for single characters) and `*` (for multiple characters) can also be used.
        :param pulumi.Input[list] host_tags: Array of tags (in the form key:value) to add to all hosts and metrics reporting through this integration.
        :param pulumi.Input[str] role_name: Your Datadog role delegation name.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["account_id"] = account_id
        __props__["account_specific_namespace_rules"] = account_specific_namespace_rules
        __props__["excluded_regions"] = excluded_regions
        __props__["external_id"] = external_id
        __props__["filter_tags"] = filter_tags
        __props__["host_tags"] = host_tags
        __props__["role_name"] = role_name
        return Integration(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
