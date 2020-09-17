# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables

__all__ = ['Integration']


class Integration(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 account_id: Optional[pulumi.Input[str]] = None,
                 account_specific_namespace_rules: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 excluded_regions: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
                 filter_tags: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
                 host_tags: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
                 role_name: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
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
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            account_id: Optional[pulumi.Input[str]] = None,
            account_specific_namespace_rules: Optional[pulumi.Input[Mapping[str, Any]]] = None,
            excluded_regions: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
            external_id: Optional[pulumi.Input[str]] = None,
            filter_tags: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
            host_tags: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
            role_name: Optional[pulumi.Input[str]] = None) -> 'Integration':
        """
        Get an existing Integration resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
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

    @property
    @pulumi.getter(name="accountId")
    def account_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "account_id")

    @property
    @pulumi.getter(name="accountSpecificNamespaceRules")
    def account_specific_namespace_rules(self) -> pulumi.Output[Optional[Mapping[str, Any]]]:
        return pulumi.get(self, "account_specific_namespace_rules")

    @property
    @pulumi.getter(name="excludedRegions")
    def excluded_regions(self) -> pulumi.Output[Optional[List[str]]]:
        return pulumi.get(self, "excluded_regions")

    @property
    @pulumi.getter(name="externalId")
    def external_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "external_id")

    @property
    @pulumi.getter(name="filterTags")
    def filter_tags(self) -> pulumi.Output[Optional[List[str]]]:
        return pulumi.get(self, "filter_tags")

    @property
    @pulumi.getter(name="hostTags")
    def host_tags(self) -> pulumi.Output[Optional[List[str]]]:
        return pulumi.get(self, "host_tags")

    @property
    @pulumi.getter(name="roleName")
    def role_name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "role_name")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

