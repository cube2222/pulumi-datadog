# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from . import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = ['Dashboard']


class Dashboard(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 is_read_only: Optional[pulumi.Input[bool]] = None,
                 layout_type: Optional[pulumi.Input[str]] = None,
                 notify_lists: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
                 template_variable_presets: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['DashboardTemplateVariablePresetArgs']]]]] = None,
                 template_variables: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['DashboardTemplateVariableArgs']]]]] = None,
                 title: Optional[pulumi.Input[str]] = None,
                 url: Optional[pulumi.Input[str]] = None,
                 widgets: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['DashboardWidgetArgs']]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Provides a Datadog dashboard resource. This can be used to create and manage Datadog dashboards.

        > **Note:** This resource uses the new [Dashboard API](https://docs.datadoghq.com/api/v1/dashboards/) which adds new features like better validation and support for the [Group widget](https://docs.datadoghq.com/graphing/widgets/group/). Additionally, this resource unifies `TimeBoard` and `ScreenBoard` resources to allow you to manage all of your dashboards using a single format.

        ## Example Usage
        ### Create A New Datadog Dashboard - Ordered Layout

        ```python
        import pulumi
        import pulumi_datadog as datadog

        ordered_dashboard = datadog.Dashboard("orderedDashboard",
            description="Created using the Datadog provider in TF",
            is_read_only=True,
            layout_type="ordered",
            template_variables=[
                datadog.DashboardTemplateVariableArgs(
                    default="aws",
                    name="var_1",
                    prefix="host",
                ),
                datadog.DashboardTemplateVariableArgs(
                    default="autoscaling",
                    name="var_2",
                    prefix="service_name",
                ),
            ],
            template_variable_presets=[datadog.DashboardTemplateVariablePresetArgs(
                name="preset_1",
                template_variables=[
                    {
                        "name": "var_1",
                        "value": "host.dc",
                    },
                    {
                        "name": "var_2",
                        "value": "my_service",
                    },
                ],
            )],
            title="Ordered Layout Dashboard",
            widgets=[
                datadog.DashboardWidgetArgs(
                    alert_graph_definition=datadog.DashboardWidgetAlertGraphDefinitionArgs(
                        alert_id="895605",
                        time=datadog.DashboardWidgetAlertGraphDefinitionTimeArgs(
                            live_span="1h",
                        ),
                        title="Widget Title",
                        viz_type="timeseries",
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    alert_value_definition=datadog.DashboardWidgetAlertValueDefinitionArgs(
                        alert_id="895605",
                        precision=3,
                        text_align="center",
                        title="Widget Title",
                        unit="b",
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    alert_value_definition=datadog.DashboardWidgetAlertValueDefinitionArgs(
                        alert_id="895605",
                        precision=3,
                        text_align="center",
                        title="Widget Title",
                        unit="b",
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    change_definition=datadog.DashboardWidgetChangeDefinitionArgs(
                        request=[{
                            "changeType": "absolute",
                            "compareTo": "week_before",
                            "increaseGood": True,
                            "orderBy": "name",
                            "orderDir": "desc",
                            "q": "avg:system.load.1{env:staging} by {account}",
                            "showPresent": True,
                        }],
                        time=datadog.DashboardWidgetChangeDefinitionTimeArgs(
                            live_span="1h",
                        ),
                        title="Widget Title",
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    distribution_definition=datadog.DashboardWidgetDistributionDefinitionArgs(
                        request=[{
                            "q": "avg:system.load.1{env:staging} by {account}",
                            "style": {
                                "palette": "warm",
                            },
                        }],
                        time=datadog.DashboardWidgetDistributionDefinitionTimeArgs(
                            live_span="1h",
                        ),
                        title="Widget Title",
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    check_status_definition=datadog.DashboardWidgetCheckStatusDefinitionArgs(
                        check="aws.ecs.agent_connected",
                        group_by=[
                            "account",
                            "cluster",
                        ],
                        grouping="cluster",
                        tags=[
                            "account:demo",
                            "cluster:awseb-ruthebdog-env-8-dn3m6u3gvk",
                        ],
                        time=datadog.DashboardWidgetCheckStatusDefinitionTimeArgs(
                            live_span="1h",
                        ),
                        title="Widget Title",
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    heatmap_definition=datadog.DashboardWidgetHeatmapDefinitionArgs(
                        request=[{
                            "q": "avg:system.load.1{env:staging} by {account}",
                            "style": {
                                "palette": "warm",
                            },
                        }],
                        time=datadog.DashboardWidgetHeatmapDefinitionTimeArgs(
                            live_span="1h",
                        ),
                        title="Widget Title",
                        yaxis=datadog.DashboardWidgetHeatmapDefinitionYaxisArgs(
                            include_zero=True,
                            max="2",
                            min="1",
                            scale="sqrt",
                        ),
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    hostmap_definition=datadog.DashboardWidgetHostmapDefinitionArgs(
                        group=[
                            "host",
                            "region",
                        ],
                        no_group_hosts=True,
                        no_metric_hosts=True,
                        node_type="container",
                        request=datadog.DashboardWidgetHostmapDefinitionRequestArgs(
                            fill=[{
                                "q": "avg:system.load.1{*} by {host}",
                            }],
                            size=[{
                                "q": "avg:memcache.uptime{*} by {host}",
                            }],
                        ),
                        scope=[
                            "region:us-east-1",
                            "aws_account:727006795293",
                        ],
                        style=datadog.DashboardWidgetHostmapDefinitionStyleArgs(
                            fill_max="20",
                            fill_min="10",
                            palette="yellow_to_green",
                            palette_flip=True,
                        ),
                        title="Widget Title",
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    note_definition=datadog.DashboardWidgetNoteDefinitionArgs(
                        background_color="pink",
                        content="note text",
                        font_size="14",
                        show_tick=True,
                        text_align="center",
                        tick_edge="left",
                        tick_pos="50%",
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    query_value_definition=datadog.DashboardWidgetQueryValueDefinitionArgs(
                        autoscale=True,
                        custom_unit="xx",
                        precision=4,
                        request=[{
                            "aggregator": "sum",
                            "conditionalFormats": [
                                {
                                    "comparator": "<",
                                    "palette": "white_on_green",
                                    "value": "2",
                                },
                                {
                                    "comparator": ">",
                                    "palette": "white_on_red",
                                    "value": "2.2",
                                },
                            ],
                            "q": "avg:system.load.1{env:staging} by {account}",
                        }],
                        text_align="right",
                        time=datadog.DashboardWidgetQueryValueDefinitionTimeArgs(
                            live_span="1h",
                        ),
                        title="Widget Title",
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    query_table_definition=datadog.DashboardWidgetQueryTableDefinitionArgs(
                        request=[{
                            "aggregator": "sum",
                            "conditionalFormats": [
                                {
                                    "comparator": "<",
                                    "palette": "white_on_green",
                                    "value": "2",
                                },
                                {
                                    "comparator": ">",
                                    "palette": "white_on_red",
                                    "value": "2.2",
                                },
                            ],
                            "limit": "10",
                            "q": "avg:system.load.1{env:staging} by {account}",
                        }],
                        time=datadog.DashboardWidgetQueryTableDefinitionTimeArgs(
                            live_span="1h",
                        ),
                        title="Widget Title",
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    scatterplot_definition=datadog.DashboardWidgetScatterplotDefinitionArgs(
                        color_by_groups=[
                            "account",
                            "apm-role-group",
                        ],
                        request=datadog.DashboardWidgetScatterplotDefinitionRequestArgs(
                            x=[{
                                "aggregator": "max",
                                "q": "avg:system.cpu.user{*} by {service, account}",
                            }],
                            y=[{
                                "aggregator": "min",
                                "q": "avg:system.mem.used{*} by {service, account}",
                            }],
                        ),
                        time=datadog.DashboardWidgetScatterplotDefinitionTimeArgs(
                            live_span="1h",
                        ),
                        title="Widget Title",
                        xaxis=datadog.DashboardWidgetScatterplotDefinitionXaxisArgs(
                            include_zero=True,
                            label="x",
                            max="2000",
                            min="1",
                            scale="pow",
                        ),
                        yaxis=datadog.DashboardWidgetScatterplotDefinitionYaxisArgs(
                            include_zero=False,
                            label="y",
                            max="2222",
                            min="5",
                            scale="log",
                        ),
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    layout=datadog.DashboardWidgetLayoutArgs(
                        height=43,
                        width=32,
                        x=5,
                        y=5,
                    ),
                    servicemap_definition=datadog.DashboardWidgetServicemapDefinitionArgs(
                        filters=[
                            "env:prod",
                            "datacenter:us1.prod.dog",
                        ],
                        service="master-db",
                        title="env: prod, datacenter:us1.prod.dog, service: master-db",
                        title_align="left",
                        title_size="16",
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    timeseries_definition=datadog.DashboardWidgetTimeseriesDefinitionArgs(
                        event=[
                            {
                                "q": "sources:test tags:1",
                            },
                            {
                                "q": "sources:test tags:2",
                            },
                        ],
                        legend_size="2",
                        marker=[
                            {
                                "displayType": "error dashed",
                                "label": " z=6 ",
                                "value": "y = 4",
                            },
                            {
                                "displayType": "ok solid",
                                "label": " x=8 ",
                                "value": "10 < y < 999",
                            },
                        ],
                        request=[
                            {
                                "displayType": "line",
                                "metadata": [{
                                    "aliasName": "Alpha",
                                    "expression": "avg:system.cpu.user{app:general} by {env}",
                                }],
                                "q": "avg:system.cpu.user{app:general} by {env}",
                                "style": {
                                    "lineType": "dashed",
                                    "lineWidth": "thin",
                                    "palette": "warm",
                                },
                            },
                            {
                                "displayType": "area",
                                "logQuery": {
                                    "compute": {
                                        "aggregation": "avg",
                                        "facet": "@duration",
                                        "interval": 5000,
                                    },
                                    "groupBy": [{
                                        "facet": "host",
                                        "limit": 10,
                                        "sort": {
                                            "aggregation": "avg",
                                            "facet": "@duration",
                                            "order": "desc",
                                        },
                                    }],
                                    "index": "mcnulty",
                                    "search": {
                                        "query": "status:info",
                                    },
                                },
                            },
                            {
                                "apmQuery": {
                                    "compute": {
                                        "aggregation": "avg",
                                        "facet": "@duration",
                                        "interval": 5000,
                                    },
                                    "groupBy": [{
                                        "facet": "resource_name",
                                        "limit": 50,
                                        "sort": {
                                            "aggregation": "avg",
                                            "facet": "@string_query.interval",
                                            "order": "desc",
                                        },
                                    }],
                                    "index": "apm-search",
                                    "search": {
                                        "query": "type:web",
                                    },
                                },
                                "displayType": "bars",
                            },
                            {
                                "displayType": "area",
                                "processQuery": {
                                    "filterBy": ["active"],
                                    "limit": 50,
                                    "metric": "process.stat.cpu.total_pct",
                                    "searchBy": "error",
                                },
                            },
                        ],
                        show_legend=True,
                        time=datadog.DashboardWidgetTimeseriesDefinitionTimeArgs(
                            live_span="1h",
                        ),
                        title="Widget Title",
                        yaxis=datadog.DashboardWidgetTimeseriesDefinitionYaxisArgs(
                            include_zero=False,
                            max="100",
                            scale="log",
                        ),
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    toplist_definition=datadog.DashboardWidgetToplistDefinitionArgs(
                        request=[{
                            "conditionalFormats": [
                                {
                                    "comparator": "<",
                                    "palette": "white_on_green",
                                    "value": "2",
                                },
                                {
                                    "comparator": ">",
                                    "palette": "white_on_red",
                                    "value": "2.2",
                                },
                            ],
                            "q": "avg:system.cpu.user{app:general} by {env}",
                        }],
                        title="Widget Title",
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    group_definition=datadog.DashboardWidgetGroupDefinitionArgs(
                        layout_type="ordered",
                        title="Group Widget",
                        widget=[
                            {
                                "noteDefinition": {
                                    "backgroundColor": "pink",
                                    "content": "cluster note widget",
                                    "fontSize": "14",
                                    "showTick": True,
                                    "textAlign": "center",
                                    "tickEdge": "left",
                                    "tickPos": "50%",
                                },
                            },
                            {
                                "alertGraphDefinition": {
                                    "alertId": "123",
                                    "time": {
                                        "liveSpan": "1h",
                                    },
                                    "title": "Alert Graph",
                                    "vizType": "toplist",
                                },
                            },
                        ],
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    service_level_objective_definition=datadog.DashboardWidgetServiceLevelObjectiveDefinitionArgs(
                        show_error_budget=True,
                        slo_id="56789",
                        time_windows=[
                            "7d",
                            "previous_week",
                        ],
                        title="Widget Title",
                        view_mode="overall",
                        view_type="detail",
                    ),
                ),
            ])
        ```
        ### Create A New Datadog Dashboard - Free Layout

        ```python
        import pulumi
        import pulumi_datadog as datadog

        free_dashboard = datadog.Dashboard("freeDashboard",
            description="Created using the Datadog provider in TF",
            is_read_only=False,
            layout_type="free",
            template_variables=[
                datadog.DashboardTemplateVariableArgs(
                    default="aws",
                    name="var_1",
                    prefix="host",
                ),
                datadog.DashboardTemplateVariableArgs(
                    default="autoscaling",
                    name="var_2",
                    prefix="service_name",
                ),
            ],
            template_variable_presets=[datadog.DashboardTemplateVariablePresetArgs(
                name="preset_1",
                template_variables=[
                    {
                        "name": "var_1",
                        "value": "host.dc",
                    },
                    {
                        "name": "var_2",
                        "value": "my_service",
                    },
                ],
            )],
            title="Free Layout Dashboard",
            widgets=[
                datadog.DashboardWidgetArgs(
                    event_stream_definition=datadog.DashboardWidgetEventStreamDefinitionArgs(
                        event_size="l",
                        query="*",
                        time=datadog.DashboardWidgetEventStreamDefinitionTimeArgs(
                            live_span="1h",
                        ),
                        title="Widget Title",
                        title_align="left",
                        title_size="16",
                    ),
                    layout=datadog.DashboardWidgetLayoutArgs(
                        height=43,
                        width=32,
                        x=5,
                        y=5,
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    event_timeline_definition=datadog.DashboardWidgetEventTimelineDefinitionArgs(
                        query="*",
                        time=datadog.DashboardWidgetEventTimelineDefinitionTimeArgs(
                            live_span="1h",
                        ),
                        title="Widget Title",
                        title_align="left",
                        title_size="16",
                    ),
                    layout=datadog.DashboardWidgetLayoutArgs(
                        height=9,
                        width=65,
                        x=42,
                        y=73,
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    free_text_definition=datadog.DashboardWidgetFreeTextDefinitionArgs(
                        color="#d00",
                        font_size="88",
                        text="free text content",
                        text_align="left",
                    ),
                    layout=datadog.DashboardWidgetLayoutArgs(
                        height=20,
                        width=30,
                        x=42,
                        y=5,
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    iframe_definition=datadog.DashboardWidgetIframeDefinitionArgs(
                        url="http://google.com",
                    ),
                    layout=datadog.DashboardWidgetLayoutArgs(
                        height=46,
                        width=39,
                        x=111,
                        y=8,
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    image_definition=datadog.DashboardWidgetImageDefinitionArgs(
                        margin="small",
                        sizing="fit",
                        url="https://images.pexels.com/photos/67636/rose-blue-flower-rose-blooms-67636.jpeg?auto=compress&cs=tinysrgb&h=350",
                    ),
                    layout=datadog.DashboardWidgetLayoutArgs(
                        height=20,
                        width=30,
                        x=77,
                        y=7,
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    layout=datadog.DashboardWidgetLayoutArgs(
                        height=36,
                        width=32,
                        x=5,
                        y=51,
                    ),
                    log_stream_definition=datadog.DashboardWidgetLogStreamDefinitionArgs(
                        columns=[
                            "core_host",
                            "core_service",
                            "tag_source",
                        ],
                        logset="19",
                        message_display="expanded-md",
                        query="error",
                        show_date_column=True,
                        show_message_column=True,
                        sort=datadog.DashboardWidgetLogStreamDefinitionSortArgs(
                            column="time",
                            order="desc",
                        ),
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    layout=datadog.DashboardWidgetLayoutArgs(
                        height=40,
                        width=30,
                        x=112,
                        y=55,
                    ),
                    manage_status_definition=datadog.DashboardWidgetManageStatusDefinitionArgs(
                        color_preference="text",
                        display_format="countsAndList",
                        hide_zero_counts=True,
                        query="type:metric",
                        show_last_triggered=False,
                        sort="status,asc",
                        summary_type="monitors",
                        title="Widget Title",
                        title_align="left",
                        title_size="16",
                    ),
                ),
                datadog.DashboardWidgetArgs(
                    layout=datadog.DashboardWidgetLayoutArgs(
                        height=38,
                        width=67,
                        x=40,
                        y=28,
                    ),
                    trace_service_definition=datadog.DashboardWidgetTraceServiceDefinitionArgs(
                        display_format="three_column",
                        env="datad0g.com",
                        service="alerting-cassandra",
                        show_breakdown=True,
                        show_distribution=True,
                        show_errors=True,
                        show_hits=True,
                        show_latency=False,
                        show_resource_list=False,
                        size_format="large",
                        span_name="cassandra.query",
                        time=datadog.DashboardWidgetTraceServiceDefinitionTimeArgs(
                            live_span="1h",
                        ),
                        title="alerting-cassandra #env:datad0g.com",
                        title_align="center",
                        title_size="13",
                    ),
                ),
            ])
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Description of the dashboard.
        :param pulumi.Input[bool] is_read_only: Whether this dashboard is read-only. If `true`, only the author and admins can make changes to it.
        :param pulumi.Input[str] layout_type: Layout type of the dashboard. Available values are: `ordered` (previous timeboard) or `free` (previous screenboard layout).
               <br>**Note: This value cannot be changed. Converting a dashboard from `free` <> `ordered` requires destroying and re-creating the dashboard.** Instead of using `ForceNew`, this is a manual action as many underlying widget configs need to be updated to work for the updated layout, otherwise the new dashboard won't be created properly.
        :param pulumi.Input[List[pulumi.Input[str]]] notify_lists: List of handles of users to notify when changes are made to this dashboard.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['DashboardTemplateVariablePresetArgs']]]] template_variable_presets: The list of selectable template variable presets for this dashboard.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['DashboardTemplateVariableArgs']]]] template_variables: The list of template variables for this dashboard.
        :param pulumi.Input[str] title: Title of the dashboard.
        :param pulumi.Input[str] url: Read only field - The URL of the dashboard.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['DashboardWidgetArgs']]]] widgets: Nested block describing a widget. The structure of this block is described below. Multiple `widget` blocks are allowed within a `Dashboard` resource.
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
            __props__['is_read_only'] = is_read_only
            if layout_type is None:
                raise TypeError("Missing required property 'layout_type'")
            __props__['layout_type'] = layout_type
            __props__['notify_lists'] = notify_lists
            __props__['template_variable_presets'] = template_variable_presets
            __props__['template_variables'] = template_variables
            if title is None:
                raise TypeError("Missing required property 'title'")
            __props__['title'] = title
            __props__['url'] = url
            if widgets is None:
                raise TypeError("Missing required property 'widgets'")
            __props__['widgets'] = widgets
        super(Dashboard, __self__).__init__(
            'datadog:index/dashboard:Dashboard',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            is_read_only: Optional[pulumi.Input[bool]] = None,
            layout_type: Optional[pulumi.Input[str]] = None,
            notify_lists: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
            template_variable_presets: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['DashboardTemplateVariablePresetArgs']]]]] = None,
            template_variables: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['DashboardTemplateVariableArgs']]]]] = None,
            title: Optional[pulumi.Input[str]] = None,
            url: Optional[pulumi.Input[str]] = None,
            widgets: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['DashboardWidgetArgs']]]]] = None) -> 'Dashboard':
        """
        Get an existing Dashboard resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Description of the dashboard.
        :param pulumi.Input[bool] is_read_only: Whether this dashboard is read-only. If `true`, only the author and admins can make changes to it.
        :param pulumi.Input[str] layout_type: Layout type of the dashboard. Available values are: `ordered` (previous timeboard) or `free` (previous screenboard layout).
               <br>**Note: This value cannot be changed. Converting a dashboard from `free` <> `ordered` requires destroying and re-creating the dashboard.** Instead of using `ForceNew`, this is a manual action as many underlying widget configs need to be updated to work for the updated layout, otherwise the new dashboard won't be created properly.
        :param pulumi.Input[List[pulumi.Input[str]]] notify_lists: List of handles of users to notify when changes are made to this dashboard.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['DashboardTemplateVariablePresetArgs']]]] template_variable_presets: The list of selectable template variable presets for this dashboard.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['DashboardTemplateVariableArgs']]]] template_variables: The list of template variables for this dashboard.
        :param pulumi.Input[str] title: Title of the dashboard.
        :param pulumi.Input[str] url: Read only field - The URL of the dashboard.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['DashboardWidgetArgs']]]] widgets: Nested block describing a widget. The structure of this block is described below. Multiple `widget` blocks are allowed within a `Dashboard` resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["description"] = description
        __props__["is_read_only"] = is_read_only
        __props__["layout_type"] = layout_type
        __props__["notify_lists"] = notify_lists
        __props__["template_variable_presets"] = template_variable_presets
        __props__["template_variables"] = template_variables
        __props__["title"] = title
        __props__["url"] = url
        __props__["widgets"] = widgets
        return Dashboard(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Description of the dashboard.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="isReadOnly")
    def is_read_only(self) -> pulumi.Output[Optional[bool]]:
        """
        Whether this dashboard is read-only. If `true`, only the author and admins can make changes to it.
        """
        return pulumi.get(self, "is_read_only")

    @property
    @pulumi.getter(name="layoutType")
    def layout_type(self) -> pulumi.Output[str]:
        """
        Layout type of the dashboard. Available values are: `ordered` (previous timeboard) or `free` (previous screenboard layout).
        <br>**Note: This value cannot be changed. Converting a dashboard from `free` <> `ordered` requires destroying and re-creating the dashboard.** Instead of using `ForceNew`, this is a manual action as many underlying widget configs need to be updated to work for the updated layout, otherwise the new dashboard won't be created properly.
        """
        return pulumi.get(self, "layout_type")

    @property
    @pulumi.getter(name="notifyLists")
    def notify_lists(self) -> pulumi.Output[Optional[List[str]]]:
        """
        List of handles of users to notify when changes are made to this dashboard.
        """
        return pulumi.get(self, "notify_lists")

    @property
    @pulumi.getter(name="templateVariablePresets")
    def template_variable_presets(self) -> pulumi.Output[Optional[List['outputs.DashboardTemplateVariablePreset']]]:
        """
        The list of selectable template variable presets for this dashboard.
        """
        return pulumi.get(self, "template_variable_presets")

    @property
    @pulumi.getter(name="templateVariables")
    def template_variables(self) -> pulumi.Output[Optional[List['outputs.DashboardTemplateVariable']]]:
        """
        The list of template variables for this dashboard.
        """
        return pulumi.get(self, "template_variables")

    @property
    @pulumi.getter
    def title(self) -> pulumi.Output[str]:
        """
        Title of the dashboard.
        """
        return pulumi.get(self, "title")

    @property
    @pulumi.getter
    def url(self) -> pulumi.Output[str]:
        """
        Read only field - The URL of the dashboard.
        """
        return pulumi.get(self, "url")

    @property
    @pulumi.getter
    def widgets(self) -> pulumi.Output[List['outputs.DashboardWidget']]:
        """
        Nested block describing a widget. The structure of this block is described below. Multiple `widget` blocks are allowed within a `Dashboard` resource.
        """
        return pulumi.get(self, "widgets")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

