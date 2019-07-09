# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class Integration(pulumi.CustomResource):
    client_email: pulumi.Output[str]
    """
    Your email found in your JSON service account key.
    """
    client_id: pulumi.Output[str]
    """
    Your ID found in your JSON service account key.
    """
    host_filters: pulumi.Output[str]
    """
    Limit the GCE instances that are pulled into Datadog by using tags. Only hosts that match one of the defined tags are imported into Datadog.
    """
    private_key: pulumi.Output[str]
    """
    Your private key name found in your JSON service account key.
    """
    private_key_id: pulumi.Output[str]
    """
    Your private key ID found in your JSON service account key.
    """
    project_id: pulumi.Output[str]
    """
    Your Google Cloud project ID found in your JSON service account key.
    """
    def __init__(__self__, resource_name, opts=None, client_email=None, client_id=None, host_filters=None, private_key=None, private_key_id=None, project_id=None, __name__=None, __opts__=None):
        """
        Provides a Datadog - Google Cloud Platform integration resource. This can be used to create and manage Datadog - Google Cloud Platform integration.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] client_email: Your email found in your JSON service account key.
        :param pulumi.Input[str] client_id: Your ID found in your JSON service account key.
        :param pulumi.Input[str] host_filters: Limit the GCE instances that are pulled into Datadog by using tags. Only hosts that match one of the defined tags are imported into Datadog.
        :param pulumi.Input[str] private_key: Your private key name found in your JSON service account key.
        :param pulumi.Input[str] private_key_id: Your private key ID found in your JSON service account key.
        :param pulumi.Input[str] project_id: Your Google Cloud project ID found in your JSON service account key.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/integration_gcp.html.markdown.
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


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

