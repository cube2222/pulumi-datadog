# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables

__all__ = ['Integration']


class Integration(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 client_email: Optional[pulumi.Input[str]] = None,
                 client_id: Optional[pulumi.Input[str]] = None,
                 host_filters: Optional[pulumi.Input[str]] = None,
                 private_key: Optional[pulumi.Input[str]] = None,
                 private_key_id: Optional[pulumi.Input[str]] = None,
                 project_id: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Provides a Datadog - Google Cloud Platform integration resource. This can be used to create and manage Datadog - Google Cloud Platform integration.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_datadog as datadog

        # Create a new Datadog - Google Cloud Platform integration
        awesome_gcp_project_integration = datadog.gcp.Integration("awesomeGcpProjectIntegration",
            client_email="awesome-service-account@awesome-project-id.iam.gserviceaccount.com",
            client_id="123456789012345678901",
            host_filters="foo:bar,buzz:lightyear",
            private_key=\"\"\"-----BEGIN PRIVATE KEY-----
        ...
        -----END PRIVATE KEY-----

        \"\"\",
            private_key_id="1234567890123456789012345678901234567890",
            project_id="awesome-project-id")
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

            if client_email is None:
                raise TypeError("Missing required property 'client_email'")
            __props__['client_email'] = client_email
            if client_id is None:
                raise TypeError("Missing required property 'client_id'")
            __props__['client_id'] = client_id
            __props__['host_filters'] = host_filters
            if private_key is None:
                raise TypeError("Missing required property 'private_key'")
            __props__['private_key'] = private_key
            if private_key_id is None:
                raise TypeError("Missing required property 'private_key_id'")
            __props__['private_key_id'] = private_key_id
            if project_id is None:
                raise TypeError("Missing required property 'project_id'")
            __props__['project_id'] = project_id
        super(Integration, __self__).__init__(
            'datadog:gcp/integration:Integration',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            client_email: Optional[pulumi.Input[str]] = None,
            client_id: Optional[pulumi.Input[str]] = None,
            host_filters: Optional[pulumi.Input[str]] = None,
            private_key: Optional[pulumi.Input[str]] = None,
            private_key_id: Optional[pulumi.Input[str]] = None,
            project_id: Optional[pulumi.Input[str]] = None) -> 'Integration':
        """
        Get an existing Integration resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["client_email"] = client_email
        __props__["client_id"] = client_id
        __props__["host_filters"] = host_filters
        __props__["private_key"] = private_key
        __props__["private_key_id"] = private_key_id
        __props__["project_id"] = project_id
        return Integration(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="clientEmail")
    def client_email(self) -> pulumi.Output[str]:
        return pulumi.get(self, "client_email")

    @property
    @pulumi.getter(name="clientId")
    def client_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "client_id")

    @property
    @pulumi.getter(name="hostFilters")
    def host_filters(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "host_filters")

    @property
    @pulumi.getter(name="privateKey")
    def private_key(self) -> pulumi.Output[str]:
        return pulumi.get(self, "private_key")

    @property
    @pulumi.getter(name="privateKeyId")
    def private_key_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "private_key_id")

    @property
    @pulumi.getter(name="projectId")
    def project_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "project_id")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

