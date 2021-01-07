# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from . import _utilities, _tables

__all__ = ['SyntheticsPrivateLocation']


class SyntheticsPrivateLocation(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Provides a Datadog synthetics private location resource. This can be used to create and manage Datadog synthetics private locations.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_datadog as datadog

        private_location = datadog.SyntheticsPrivateLocation("privateLocation",
            description="Description of the private location",
            name="First private location",
            tags=[
                "foo:bar",
                "env:test",
            ])
        ```

        ## Import

        Synthetics private locations can be imported using their string ID, e.g.

        ```sh
         $ pulumi import datadog:index/syntheticsPrivateLocation:SyntheticsPrivateLocation bar pl:private-location-name-abcdef123456
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Description of the private location.
        :param pulumi.Input[str] name: Synthetics private location name.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] tags: A list of tags to associate with your synthetics private location.
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
            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__['name'] = name
            __props__['tags'] = tags
            __props__['config'] = None
        super(SyntheticsPrivateLocation, __self__).__init__(
            'datadog:index/syntheticsPrivateLocation:SyntheticsPrivateLocation',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            config: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None) -> 'SyntheticsPrivateLocation':
        """
        Get an existing SyntheticsPrivateLocation resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] config: Configuration skeleton for the private location. See installation instructions of the private location on how to use
               this configuration.
        :param pulumi.Input[str] description: Description of the private location.
        :param pulumi.Input[str] name: Synthetics private location name.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] tags: A list of tags to associate with your synthetics private location.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["config"] = config
        __props__["description"] = description
        __props__["name"] = name
        __props__["tags"] = tags
        return SyntheticsPrivateLocation(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def config(self) -> pulumi.Output[str]:
        """
        Configuration skeleton for the private location. See installation instructions of the private location on how to use
        this configuration.
        """
        return pulumi.get(self, "config")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Description of the private location.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Synthetics private location name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        A list of tags to associate with your synthetics private location.
        """
        return pulumi.get(self, "tags")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

