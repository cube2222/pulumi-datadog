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

__all__ = ['LogsArchive']


class LogsArchive(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 azure: Optional[pulumi.Input[pulumi.InputType['LogsArchiveAzureArgs']]] = None,
                 gcs: Optional[pulumi.Input[pulumi.InputType['LogsArchiveGcsArgs']]] = None,
                 include_tags: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 query: Optional[pulumi.Input[str]] = None,
                 rehydration_tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 s3: Optional[pulumi.Input[pulumi.InputType['LogsArchiveS3Args']]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Provides a Datadog [Logs Archive API](https://docs.datadoghq.com/api/v2/logs-archives/) resource, which is used to create and manage Datadog logs archives.

        ## Example Usage

        Create a Datadog logs archive:

        ```python
        import pulumi
        import pulumi_datadog as datadog

        my_s3_archive = datadog.LogsArchive("myS3Archive",
            name="my s3 archive",
            query="service:myservice",
            s3=datadog.LogsArchiveS3Args(
                account_id="001234567888",
                bucket="my-bucket",
                path="/path/foo",
                role_name="my-role-name",
            ))
        ```

        ## Import

        Logs archives can be imported using their public string ID, e.g.

        ```sh
         $ pulumi import datadog:index/logsArchive:LogsArchive my_s3_archive 1Aabc2_dfQPLnXy3HlfK4hi
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

            __props__['azure'] = azure
            __props__['gcs'] = gcs
            __props__['include_tags'] = include_tags
            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__['name'] = name
            if query is None and not opts.urn:
                raise TypeError("Missing required property 'query'")
            __props__['query'] = query
            __props__['rehydration_tags'] = rehydration_tags
            __props__['s3'] = s3
        super(LogsArchive, __self__).__init__(
            'datadog:index/logsArchive:LogsArchive',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            azure: Optional[pulumi.Input[pulumi.InputType['LogsArchiveAzureArgs']]] = None,
            gcs: Optional[pulumi.Input[pulumi.InputType['LogsArchiveGcsArgs']]] = None,
            include_tags: Optional[pulumi.Input[bool]] = None,
            name: Optional[pulumi.Input[str]] = None,
            query: Optional[pulumi.Input[str]] = None,
            rehydration_tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            s3: Optional[pulumi.Input[pulumi.InputType['LogsArchiveS3Args']]] = None) -> 'LogsArchive':
        """
        Get an existing LogsArchive resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["azure"] = azure
        __props__["gcs"] = gcs
        __props__["include_tags"] = include_tags
        __props__["name"] = name
        __props__["query"] = query
        __props__["rehydration_tags"] = rehydration_tags
        __props__["s3"] = s3
        return LogsArchive(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def azure(self) -> pulumi.Output[Optional['outputs.LogsArchiveAzure']]:
        return pulumi.get(self, "azure")

    @property
    @pulumi.getter
    def gcs(self) -> pulumi.Output[Optional['outputs.LogsArchiveGcs']]:
        return pulumi.get(self, "gcs")

    @property
    @pulumi.getter(name="includeTags")
    def include_tags(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "include_tags")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def query(self) -> pulumi.Output[str]:
        return pulumi.get(self, "query")

    @property
    @pulumi.getter(name="rehydrationTags")
    def rehydration_tags(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "rehydration_tags")

    @property
    @pulumi.getter
    def s3(self) -> pulumi.Output[Optional['outputs.LogsArchiveS3']]:
        return pulumi.get(self, "s3")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

