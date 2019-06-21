# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from . import utilities, tables

class User(pulumi.CustomResource):
    access_role: pulumi.Output[str]
    """
    Role description for user. Can be `st` (standard user), `adm` (admin user) or `ro` (read-only user).  Default is `st`.
    """
    disabled: pulumi.Output[bool]
    """
    Whether the user is disabled
    """
    email: pulumi.Output[str]
    """
    Email address for user
    """
    handle: pulumi.Output[str]
    """
    The user handle, must be a valid email.
    """
    is_admin: pulumi.Output[bool]
    """
    (Optional) Whether the user is an administrator. **Warning**: the corresponding query parameter is ignored by the Datadog API, thus the argument would always trigger an execution plan.
    """
    name: pulumi.Output[str]
    """
    Name for user
    """
    role: pulumi.Output[str]
    """
    Role description for user. **Warning**: the corresponding query parameter is ignored by the Datadog API, thus the argument would always trigger an execution plan.
    """
    verified: pulumi.Output[bool]
    """
    Returns true if Datadog user is verified
    """
    def __init__(__self__, resource_name, opts=None, access_role=None, disabled=None, email=None, handle=None, is_admin=None, name=None, role=None, __name__=None, __opts__=None):
        """
        Provides a Datadog user resource. This can be used to create and manage Datadog users.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] access_role: Role description for user. Can be `st` (standard user), `adm` (admin user) or `ro` (read-only user).  Default is `st`.
        :param pulumi.Input[bool] disabled: Whether the user is disabled
        :param pulumi.Input[str] email: Email address for user
        :param pulumi.Input[str] handle: The user handle, must be a valid email.
        :param pulumi.Input[bool] is_admin: (Optional) Whether the user is an administrator. **Warning**: the corresponding query parameter is ignored by the Datadog API, thus the argument would always trigger an execution plan.
        :param pulumi.Input[str] name: Name for user
        :param pulumi.Input[str] role: Role description for user. **Warning**: the corresponding query parameter is ignored by the Datadog API, thus the argument would always trigger an execution plan.
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

        __props__['access_role'] = access_role

        __props__['disabled'] = disabled

        if email is None:
            raise TypeError("Missing required property 'email'")
        __props__['email'] = email

        if handle is None:
            raise TypeError("Missing required property 'handle'")
        __props__['handle'] = handle

        __props__['is_admin'] = is_admin

        if name is None:
            raise TypeError("Missing required property 'name'")
        __props__['name'] = name

        __props__['role'] = role

        __props__['verified'] = None

        super(User, __self__).__init__(
            'index:index/user:User',
            resource_name,
            __props__,
            opts)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

