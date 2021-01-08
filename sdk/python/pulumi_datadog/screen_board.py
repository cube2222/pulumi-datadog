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

__all__ = ['ScreenBoard']


class ScreenBoard(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 height: Optional[pulumi.Input[str]] = None,
                 read_only: Optional[pulumi.Input[bool]] = None,
                 shared: Optional[pulumi.Input[bool]] = None,
                 template_variables: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ScreenBoardTemplateVariableArgs']]]]] = None,
                 title: Optional[pulumi.Input[str]] = None,
                 widgets: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ScreenBoardWidgetArgs']]]]] = None,
                 width: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Provides a Datadog screenboard resource. This can be used to create and manage Datadog screenboards.

        > **Note:** This resource is outdated. Use the new `Dashboard` resource instead.

        ## Example Usage

        ```python
        import pulumi
        import json
        import pulumi_datadog as datadog

        # Create a new Datadog screenboard
        acceptance_test = datadog.ScreenBoard("acceptanceTest",
            title="Test Screenboard",
            read_only=True,
            template_variables=[
                datadog.ScreenBoardTemplateVariableArgs(
                    name="varname 1",
                    prefix="pod_name",
                    default="*",
                ),
                datadog.ScreenBoardTemplateVariableArgs(
                    name="varname 2",
                    prefix="service_name",
                    default="autoscaling",
                ),
            ],
            widgets=[
                datadog.ScreenBoardWidgetArgs(
                    type="free_text",
                    x=5,
                    y=5,
                    text="test text",
                    text_align="right",
                    font_size="36",
                    color="#ffc0cb",
                ),
                datadog.ScreenBoardWidgetArgs(
                    type="timeseries",
                    x=25,
                    y=5,
                    title="graph title terraform",
                    title_size=16,
                    title_align="right",
                    legend=True,
                    legend_size="16",
                    time={
                        "live_span": "1d",
                    },
                    tile_deves=[datadog.ScreenBoardWidgetTileDefArgs(
                        viz="timeseries",
                        requests=[
                            datadog.ScreenBoardWidgetTileDefRequestArgs(
                                q="avg:system.cpu.user{*}",
                                type="line",
                                style={
                                    "palette": "purple",
                                    "type": "dashed",
                                    "width": "thin",
                                },
                                metadata_json=json.dumps({
                                    "avg:system.cpu.user{*}": {
                                        "alias": "CPU Usage",
                                    },
                                }),
                            ),
                            datadog.ScreenBoardWidgetTileDefRequestArgs(
                                log_query=datadog.ScreenBoardWidgetTileDefRequestLogQueryArgs(
                                    index="mcnulty",
                                    compute=datadog.ScreenBoardWidgetTileDefRequestLogQueryComputeArgs(
                                        aggregation="avg",
                                        facet="@duration",
                                        interval="5000",
                                    ),
                                    search=datadog.ScreenBoardWidgetTileDefRequestLogQuerySearchArgs(
                                        query="status:info",
                                    ),
                                    group_bies=[datadog.ScreenBoardWidgetTileDefRequestLogQueryGroupByArgs(
                                        facet="host",
                                        limit=10,
                                        sort=datadog.ScreenBoardWidgetTileDefRequestLogQueryGroupBySortArgs(
                                            aggregation="avg",
                                            order="desc",
                                            facet="@duration",
                                        ),
                                    )],
                                ),
                                type="area",
                            ),
                            datadog.ScreenBoardWidgetTileDefRequestArgs(
                                apm_query=datadog.ScreenBoardWidgetTileDefRequestApmQueryArgs(
                                    index="apm-search",
                                    compute=datadog.ScreenBoardWidgetTileDefRequestApmQueryComputeArgs(
                                        aggregation="avg",
                                        facet="@duration",
                                        interval="5000",
                                    ),
                                    search=datadog.ScreenBoardWidgetTileDefRequestApmQuerySearchArgs(
                                        query="type:web",
                                    ),
                                    group_bies=[datadog.ScreenBoardWidgetTileDefRequestApmQueryGroupByArgs(
                                        facet="resource_name",
                                        limit=50,
                                        sort=datadog.ScreenBoardWidgetTileDefRequestApmQueryGroupBySortArgs(
                                            aggregation="avg",
                                            order="desc",
                                            facet="@string_query.interval",
                                        ),
                                    )],
                                ),
                                type="bars",
                            ),
                            datadog.ScreenBoardWidgetTileDefRequestArgs(
                                process_query=datadog.ScreenBoardWidgetTileDefRequestProcessQueryArgs(
                                    metric="process.stat.cpu.total_pct",
                                    search_by="error",
                                    filter_bies=["active"],
                                    limit=50,
                                ),
                                type="area",
                            ),
                        ],
                        markers=[datadog.ScreenBoardWidgetTileDefMarkerArgs(
                            label="test marker",
                            type="error dashed",
                            value="y < 6",
                        )],
                        events=[datadog.ScreenBoardWidgetTileDefEventArgs(
                            q="test event",
                        )],
                    )],
                ),
                datadog.ScreenBoardWidgetArgs(
                    type="query_value",
                    x=45,
                    y=25,
                    title="query value title terraform",
                    title_size=20,
                    title_align="center",
                    legend=True,
                    legend_size="16",
                    tile_deves=[datadog.ScreenBoardWidgetTileDefArgs(
                        viz="query_value",
                        requests=[datadog.ScreenBoardWidgetTileDefRequestArgs(
                            q="avg:system.cpu.user{*}",
                            type="line",
                            style={
                                "palette": "purple",
                                "type": "dashed",
                                "width": "thin",
                            },
                            conditional_formats=[
                                datadog.ScreenBoardWidgetTileDefRequestConditionalFormatArgs(
                                    comparator=">",
                                    value="1",
                                    palette="white_on_red",
                                ),
                                datadog.ScreenBoardWidgetTileDefRequestConditionalFormatArgs(
                                    comparator=">=",
                                    value="2",
                                    palette="white_on_yellow",
                                ),
                            ],
                            aggregator="max",
                        )],
                        custom_unit="%",
                        autoscale=False,
                        precision="6",
                        text_align="right",
                    )],
                ),
                datadog.ScreenBoardWidgetArgs(
                    type="toplist",
                    x=65,
                    y=5,
                    title="toplist title terraform",
                    legend=True,
                    legend_size="auto",
                    time={
                        "live_span": "1d",
                    },
                    tile_deves=[datadog.ScreenBoardWidgetTileDefArgs(
                        viz="toplist",
                        requests=[datadog.ScreenBoardWidgetTileDefRequestArgs(
                            q="top(avg:system.load.1{*} by {host}, 10, 'mean', 'desc')",
                            style={
                                "palette": "purple",
                                "type": "dashed",
                                "width": "thin",
                            },
                            conditional_formats=[datadog.ScreenBoardWidgetTileDefRequestConditionalFormatArgs(
                                comparator=">",
                                value="4",
                                palette="white_on_green",
                            )],
                        )],
                    )],
                ),
                datadog.ScreenBoardWidgetArgs(
                    type="change",
                    x=85,
                    y=5,
                    title="change title terraform",
                    tile_deves=[datadog.ScreenBoardWidgetTileDefArgs(
                        viz="change",
                        requests=[datadog.ScreenBoardWidgetTileDefRequestArgs(
                            q="min:system.load.1{*} by {host}",
                            compare_to="week_before",
                            change_type="relative",
                            order_by="present",
                            order_dir="asc",
                            extra_col="",
                            increase_good=False,
                        )],
                    )],
                ),
                datadog.ScreenBoardWidgetArgs(
                    type="event_timeline",
                    x=105,
                    y=5,
                    title="event_timeline title terraform",
                    query="status:error",
                    time={
                        "live_span": "1d",
                    },
                ),
                datadog.ScreenBoardWidgetArgs(
                    type="event_stream",
                    x=115,
                    y=5,
                    title="event_stream title terraform",
                    query="*",
                    event_size="l",
                    time={
                        "live_span": "4h",
                    },
                ),
                datadog.ScreenBoardWidgetArgs(
                    type="image",
                    x=145,
                    y=5,
                    title="image title terraform",
                    sizing="fit",
                    margin="large",
                    url="https://datadog-prod.imgix.net/img/dd_logo_70x75.png",
                ),
                datadog.ScreenBoardWidgetArgs(
                    type="note",
                    x=165,
                    y=5,
                    bgcolor="pink",
                    text_align="right",
                    font_size="36",
                    tick=True,
                    tick_edge="bottom",
                    tick_pos="50%",
                    html="<b>test note</b>",
                ),
                datadog.ScreenBoardWidgetArgs(
                    type="alert_graph",
                    x=185,
                    y=5,
                    title="alert graph title terraform",
                    alert_id=123456,
                    viz_type="toplist",
                    time={
                        "live_span": "15m",
                    },
                ),
                datadog.ScreenBoardWidgetArgs(
                    type="alert_value",
                    x=205,
                    y=5,
                    title="alert value title terraform",
                    alert_id=123456,
                    text_size="fill_height",
                    text_align="right",
                    precision="*",
                    unit="b",
                ),
                datadog.ScreenBoardWidgetArgs(
                    type="iframe",
                    x=225,
                    y=5,
                    url="https://www.datadoghq.org",
                ),
                datadog.ScreenBoardWidgetArgs(
                    type="check_status",
                    x=245,
                    y=5,
                    title="test title",
                    title_align="left",
                    grouping="check",
                    check="aws.ecs.agent_connected",
                    tags=["*"],
                    group="cluster:test",
                    time={
                        "live_span": "30m",
                    },
                ),
                datadog.ScreenBoardWidgetArgs(
                    type="trace_service",
                    x=265,
                    y=5,
                    env="testEnv",
                    service_service="",
                    service_name="",
                    size_version="large",
                    layout_version="three_column",
                    must_show_hits=True,
                    must_show_errors=True,
                    must_show_latency=True,
                    must_show_breakdown=True,
                    must_show_distribution=True,
                    must_show_resource_list=True,
                    time={
                        "live_span": "30m",
                    },
                ),
                datadog.ScreenBoardWidgetArgs(
                    type="hostmap",
                    x=285,
                    y=5,
                    query="avg:system.load.1{*} by {host}",
                    tile_deves=[datadog.ScreenBoardWidgetTileDefArgs(
                        viz="hostmap",
                        node_type="container",
                        scopes=["datacenter:test"],
                        groups=["pod_name"],
                        no_group_hosts=False,
                        no_metric_hosts=False,
                        requests=[datadog.ScreenBoardWidgetTileDefRequestArgs(
                            q="max:process.stat.container.io.wbps{datacenter:test} by {host}",
                            type="fill",
                        )],
                        style={
                            "palette": "hostmap_blues",
                            "palette_flip": True,
                            "fill_min": 20,
                            "fill_max": 300,
                        },
                    )],
                ),
                datadog.ScreenBoardWidgetArgs(
                    type="manage_status",
                    x=305,
                    y=5,
                    summary_type="monitors",
                    display_format="countsAndList",
                    color_preference="background",
                    hide_zero_counts=True,
                    show_last_triggered=False,
                    manage_status_show_title=False,
                    manage_status_title_text="test title",
                    manage_status_title_size="20",
                    manage_status_title_align="right",
                    params={
                        "sort": "status,asc",
                        "text": "status:alert",
                    },
                ),
                datadog.ScreenBoardWidgetArgs(
                    type="log_stream",
                    x=325,
                    y=5,
                    query="source:kubernetes",
                    columns="[\"column1\",\"column2\",\"column3\"]",
                    logset="1234",
                    time={
                        "live_span": "1h",
                    },
                ),
                datadog.ScreenBoardWidgetArgs(
                    type="process",
                    x=365,
                    y=5,
                    tile_deves=[datadog.ScreenBoardWidgetTileDefArgs(
                        viz="process",
                        requests=[datadog.ScreenBoardWidgetTileDefRequestArgs(
                            query_type="process",
                            metric="process.stat.cpu.total_pct",
                            text_filter="",
                            tag_filters=[],
                            limit=200,
                            style={
                                "palette": "dog_classic_area",
                            },
                        )],
                    )],
                ),
            ])
        ```

        ## Import

        screenboards can be imported using their numeric ID, e.g.

        ```sh
         $ pulumi import datadog:index/screenBoard:ScreenBoard my_service_screenboard 2081
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] height: Height of the screenboard
        :param pulumi.Input[bool] read_only: The read-only status of the screenboard. Default is `false`.
        :param pulumi.Input[bool] shared: Whether the screenboard is shared or not
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ScreenBoardTemplateVariableArgs']]]] template_variables: A list of template variables for using Dashboard templating.
        :param pulumi.Input[str] title: Name of the screenboard
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ScreenBoardWidgetArgs']]]] widgets: A list of widget definitions.
        :param pulumi.Input[str] width: Width of the screenboard
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

            __props__['height'] = height
            __props__['read_only'] = read_only
            __props__['shared'] = shared
            __props__['template_variables'] = template_variables
            if title is None and not opts.urn:
                raise TypeError("Missing required property 'title'")
            __props__['title'] = title
            if widgets is None and not opts.urn:
                raise TypeError("Missing required property 'widgets'")
            __props__['widgets'] = widgets
            __props__['width'] = width
        super(ScreenBoard, __self__).__init__(
            'datadog:index/screenBoard:ScreenBoard',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            height: Optional[pulumi.Input[str]] = None,
            read_only: Optional[pulumi.Input[bool]] = None,
            shared: Optional[pulumi.Input[bool]] = None,
            template_variables: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ScreenBoardTemplateVariableArgs']]]]] = None,
            title: Optional[pulumi.Input[str]] = None,
            widgets: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ScreenBoardWidgetArgs']]]]] = None,
            width: Optional[pulumi.Input[str]] = None) -> 'ScreenBoard':
        """
        Get an existing ScreenBoard resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] height: Height of the screenboard
        :param pulumi.Input[bool] read_only: The read-only status of the screenboard. Default is `false`.
        :param pulumi.Input[bool] shared: Whether the screenboard is shared or not
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ScreenBoardTemplateVariableArgs']]]] template_variables: A list of template variables for using Dashboard templating.
        :param pulumi.Input[str] title: Name of the screenboard
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ScreenBoardWidgetArgs']]]] widgets: A list of widget definitions.
        :param pulumi.Input[str] width: Width of the screenboard
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["height"] = height
        __props__["read_only"] = read_only
        __props__["shared"] = shared
        __props__["template_variables"] = template_variables
        __props__["title"] = title
        __props__["widgets"] = widgets
        __props__["width"] = width
        return ScreenBoard(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def height(self) -> pulumi.Output[Optional[str]]:
        """
        Height of the screenboard
        """
        return pulumi.get(self, "height")

    @property
    @pulumi.getter(name="readOnly")
    def read_only(self) -> pulumi.Output[Optional[bool]]:
        """
        The read-only status of the screenboard. Default is `false`.
        """
        return pulumi.get(self, "read_only")

    @property
    @pulumi.getter
    def shared(self) -> pulumi.Output[Optional[bool]]:
        """
        Whether the screenboard is shared or not
        """
        return pulumi.get(self, "shared")

    @property
    @pulumi.getter(name="templateVariables")
    def template_variables(self) -> pulumi.Output[Optional[Sequence['outputs.ScreenBoardTemplateVariable']]]:
        """
        A list of template variables for using Dashboard templating.
        """
        return pulumi.get(self, "template_variables")

    @property
    @pulumi.getter
    def title(self) -> pulumi.Output[str]:
        """
        Name of the screenboard
        """
        return pulumi.get(self, "title")

    @property
    @pulumi.getter
    def widgets(self) -> pulumi.Output[Sequence['outputs.ScreenBoardWidget']]:
        """
        A list of widget definitions.
        """
        return pulumi.get(self, "widgets")

    @property
    @pulumi.getter
    def width(self) -> pulumi.Output[Optional[str]]:
        """
        Width of the screenboard
        """
        return pulumi.get(self, "width")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

