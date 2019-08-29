# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

__config__ = pulumi.Config('datadog')

api_key = __config__.get('apiKey') or utilities.get_env('DATADOG_API_KEY')

api_url = __config__.get('apiUrl') or utilities.get_env('DATADOG_HOST')

app_key = __config__.get('appKey') or utilities.get_env('DATADOG_APP_KEY')

