# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from . import _utilities, _tables

__all__ = [
    'GetDashboardListResult',
    'AwaitableGetDashboardListResult',
    'get_dashboard_list',
]

@pulumi.output_type
class GetDashboardListResult:
    """
    A collection of values returned by getDashboardList.
    """
    def __init__(__self__, id=None, name=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")


class AwaitableGetDashboardListResult(GetDashboardListResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDashboardListResult(
            id=self.id,
            name=self.name)


def get_dashboard_list(name: Optional[str] = None,
                       opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDashboardListResult:
    """
    Use this data source to retrieve information about an existing dashboard list, for use in other resources. In particular, it can be used in a dashboard to register it in the list.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_datadog as datadog

    test = datadog.get_dashboard_list(name="My super list")
    ```
    """
    __args__ = dict()
    __args__['name'] = name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('datadog:index/getDashboardList:getDashboardList', __args__, opts=opts, typ=GetDashboardListResult).value

    return AwaitableGetDashboardListResult(
        id=__ret__.id,
        name=__ret__.name)
