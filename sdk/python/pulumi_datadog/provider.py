# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from . import _utilities, _tables

__all__ = ['Provider']


class Provider(pulumi.ProviderResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 api_key: Optional[pulumi.Input[str]] = None,
                 api_url: Optional[pulumi.Input[str]] = None,
                 app_key: Optional[pulumi.Input[str]] = None,
                 validate: Optional[pulumi.Input[bool]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        The provider type for the datadog package. By default, resources use package-wide configuration
        settings, however an explicit `Provider` instance may be created and passed during resource
        construction to achieve fine-grained programmatic control over provider settings. See the
        [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] api_key: (Required unless validate is false) Datadog API key. This can also be set via the DD_API_KEY environment variable.
        :param pulumi.Input[str] api_url: The API Url. This can also be set via the DD_HOST environment variable. Note that this URL must not end with the /api/
               path. For example, https://api.datadoghq.com/ is a correct value, while https://api.datadoghq.com/api/ is not. And if
               you're working with "EU" version of Datadog, use https://api.datadoghq.eu/.
        :param pulumi.Input[str] app_key: (Required unless validate is false) Datadog APP key. This can also be set via the DD_APP_KEY environment variable.
        :param pulumi.Input[bool] validate: Enables validation of the provided API and APP keys during provider initialization. Default is true. When false, api_key
               and app_key won't be checked.
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

            if api_key is None:
                api_key = _utilities.get_env('DATADOG_API_KEY')
            __props__['api_key'] = api_key
            if api_url is None:
                api_url = _utilities.get_env('DATADOG_HOST')
            __props__['api_url'] = api_url
            if app_key is None:
                app_key = _utilities.get_env('DATADOG_APP_KEY')
            __props__['app_key'] = app_key
            __props__['validate'] = pulumi.Output.from_input(validate).apply(pulumi.runtime.to_json) if validate is not None else None
        super(Provider, __self__).__init__(
            'datadog',
            resource_name,
            __props__,
            opts)

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

