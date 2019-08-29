# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables

class ServiceLevelObjective(pulumi.CustomResource):
    description: pulumi.Output[str]
    """
    A description of this service level objective.
    """
    groups: pulumi.Output[list]
    """
    A custom set of groups from the monitor(s) for which to use as the SLI instead of all the groups.
    """
    monitor_ids: pulumi.Output[list]
    """
    A list of numeric monitor IDs for which to use as SLIs. Their tags will be auto-imported into `monitor_tags` field in the API resource. At least 1 of `monitor_ids` or `monitor_search` must be provided.
    """
    monitor_search: pulumi.Output[str]
    """
    The monitor query search used on the monitor search API to add monitor_ids by searching. Their tags will be auto-imported into `monitor_tags` field in the API resource. At least 1 of `monitor_ids` or `monitor_search` must be provided.
    """
    name: pulumi.Output[str]
    """
    Name of Datadog service level objective
    """
    query: pulumi.Output[dict]
    """
    The metric query configuration to use for the SLI. This is a dictionary and requires both the `numerator` and `denominator` fields which should be `count` metrics using the `sum` aggregator.
    
      * `denominator` (`str`) - the sum of the `total` events
        * Example Usage:
        * `monitor` type SLOs:
      * `numerator` (`str`) - the sum of all the `good` events
    """
    tags: pulumi.Output[list]
    """
    A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
    """
    thresholds: pulumi.Output[list]
    """
    - A list of thresholds and targets that define the service level objectives from the provided SLIs.
    
      * `target` (`float`) - the objective's target `[0,100]`
      * `targetDisplay` (`str`) - the string version to specify additional digits in the case of `99` but want 3 digits like `99.000` to display.
      * `timeframe` (`str`) - the time frame for the objective. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/?lang=python#create-a-service-level-objective) page. Available options to choose from are:
        * `7d`
        * `30d`
        * `90d`
      * `warning` (`float`) - the objective's warning value `[0,100]`. This must be `> target` value.
      * `warningDisplay` (`str`) - the string version to specify additional digits in the case of `99` but want 3 digits like `99.000` to display.
    """
    type: pulumi.Output[str]
    """
    The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/?lang=python#create-a-service-level-objective) page. Available options to choose from are:
    * `metric`
    * `monitor`
    """
    def __init__(__self__, resource_name, opts=None, description=None, groups=None, monitor_ids=None, monitor_search=None, name=None, query=None, tags=None, thresholds=None, type=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides a Datadog service level objective resource. This can be used to create and manage Datadog service level objectives.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: A description of this service level objective.
        :param pulumi.Input[list] groups: A custom set of groups from the monitor(s) for which to use as the SLI instead of all the groups.
        :param pulumi.Input[list] monitor_ids: A list of numeric monitor IDs for which to use as SLIs. Their tags will be auto-imported into `monitor_tags` field in the API resource. At least 1 of `monitor_ids` or `monitor_search` must be provided.
        :param pulumi.Input[str] monitor_search: The monitor query search used on the monitor search API to add monitor_ids by searching. Their tags will be auto-imported into `monitor_tags` field in the API resource. At least 1 of `monitor_ids` or `monitor_search` must be provided.
        :param pulumi.Input[str] name: Name of Datadog service level objective
        :param pulumi.Input[dict] query: The metric query configuration to use for the SLI. This is a dictionary and requires both the `numerator` and `denominator` fields which should be `count` metrics using the `sum` aggregator.
        :param pulumi.Input[list] tags: A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
        :param pulumi.Input[list] thresholds: - A list of thresholds and targets that define the service level objectives from the provided SLIs.
        :param pulumi.Input[str] type: The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/?lang=python#create-a-service-level-objective) page. Available options to choose from are:
               * `metric`
               * `monitor`
        
        The **query** object supports the following:
        
          * `denominator` (`pulumi.Input[str]`) - the sum of the `total` events
            * Example Usage:
            * `monitor` type SLOs:
          * `numerator` (`pulumi.Input[str]`) - the sum of all the `good` events
        
        The **thresholds** object supports the following:
        
          * `target` (`pulumi.Input[float]`) - the objective's target `[0,100]`
          * `targetDisplay` (`pulumi.Input[str]`) - the string version to specify additional digits in the case of `99` but want 3 digits like `99.000` to display.
          * `timeframe` (`pulumi.Input[str]`) - the time frame for the objective. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/?lang=python#create-a-service-level-objective) page. Available options to choose from are:
            * `7d`
            * `30d`
            * `90d`
          * `warning` (`pulumi.Input[float]`) - the objective's warning value `[0,100]`. This must be `> target` value.
          * `warningDisplay` (`pulumi.Input[str]`) - the string version to specify additional digits in the case of `99` but want 3 digits like `99.000` to display.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/service_level_objective.html.markdown.
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

            __props__['description'] = description
            __props__['groups'] = groups
            __props__['monitor_ids'] = monitor_ids
            __props__['monitor_search'] = monitor_search
            if name is None:
                raise TypeError("Missing required property 'name'")
            __props__['name'] = name
            __props__['query'] = query
            __props__['tags'] = tags
            if thresholds is None:
                raise TypeError("Missing required property 'thresholds'")
            __props__['thresholds'] = thresholds
            if type is None:
                raise TypeError("Missing required property 'type'")
            __props__['type'] = type
        super(ServiceLevelObjective, __self__).__init__(
            'datadog:index/serviceLevelObjective:ServiceLevelObjective',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, description=None, groups=None, monitor_ids=None, monitor_search=None, name=None, query=None, tags=None, thresholds=None, type=None):
        """
        Get an existing ServiceLevelObjective resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: A description of this service level objective.
        :param pulumi.Input[list] groups: A custom set of groups from the monitor(s) for which to use as the SLI instead of all the groups.
        :param pulumi.Input[list] monitor_ids: A list of numeric monitor IDs for which to use as SLIs. Their tags will be auto-imported into `monitor_tags` field in the API resource. At least 1 of `monitor_ids` or `monitor_search` must be provided.
        :param pulumi.Input[str] monitor_search: The monitor query search used on the monitor search API to add monitor_ids by searching. Their tags will be auto-imported into `monitor_tags` field in the API resource. At least 1 of `monitor_ids` or `monitor_search` must be provided.
        :param pulumi.Input[str] name: Name of Datadog service level objective
        :param pulumi.Input[dict] query: The metric query configuration to use for the SLI. This is a dictionary and requires both the `numerator` and `denominator` fields which should be `count` metrics using the `sum` aggregator.
        :param pulumi.Input[list] tags: A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
        :param pulumi.Input[list] thresholds: - A list of thresholds and targets that define the service level objectives from the provided SLIs.
        :param pulumi.Input[str] type: The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/?lang=python#create-a-service-level-objective) page. Available options to choose from are:
               * `metric`
               * `monitor`
        
        The **query** object supports the following:
        
          * `denominator` (`pulumi.Input[str]`) - the sum of the `total` events
            * Example Usage:
            * `monitor` type SLOs:
          * `numerator` (`pulumi.Input[str]`) - the sum of all the `good` events
        
        The **thresholds** object supports the following:
        
          * `target` (`pulumi.Input[float]`) - the objective's target `[0,100]`
          * `targetDisplay` (`pulumi.Input[str]`) - the string version to specify additional digits in the case of `99` but want 3 digits like `99.000` to display.
          * `timeframe` (`pulumi.Input[str]`) - the time frame for the objective. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/?lang=python#create-a-service-level-objective) page. Available options to choose from are:
            * `7d`
            * `30d`
            * `90d`
          * `warning` (`pulumi.Input[float]`) - the objective's warning value `[0,100]`. This must be `> target` value.
          * `warningDisplay` (`pulumi.Input[str]`) - the string version to specify additional digits in the case of `99` but want 3 digits like `99.000` to display.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/service_level_objective.html.markdown.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["description"] = description
        __props__["groups"] = groups
        __props__["monitor_ids"] = monitor_ids
        __props__["monitor_search"] = monitor_search
        __props__["name"] = name
        __props__["query"] = query
        __props__["tags"] = tags
        __props__["thresholds"] = thresholds
        __props__["type"] = type
        return ServiceLevelObjective(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

