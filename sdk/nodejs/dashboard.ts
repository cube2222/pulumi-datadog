// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides a Datadog dashboard resource. This can be used to create and manage Datadog dashboards.
 *
 * > **Note:** This resource uses the new [Dashboard API](https://docs.datadoghq.com/api/v1/dashboards/) which adds new features like better validation and support for the [Group widget](https://docs.datadoghq.com/graphing/widgets/group/). Additionally, this resource unifies `datadog..TimeBoard` and `datadog..ScreenBoard` resources to allow you to manage all of your dashboards using a single format.
 *
 *
 * ## Example Usage: Create a new Datadog dashboard - Ordered layout
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * const orderedDashboard = new datadog.Dashboard("orderedDashboard", {
 *     description: "Created using the Datadog provider in TF",
 *     isReadOnly: true,
 *     layoutType: "ordered",
 *     templateVariables: [
 *         {
 *             default: "aws",
 *             name: "var1",
 *             prefix: "host",
 *         },
 *         {
 *             default: "autoscaling",
 *             name: "var2",
 *             prefix: "serviceName",
 *         },
 *     ],
 *     templateVariablePresets: [{
 *         name: "preset1",
 *         templateVariables: [
 *             {
 *                 name: "var1",
 *                 value: "host.dc",
 *             },
 *             {
 *                 name: "var2",
 *                 value: "myService",
 *             },
 *         ],
 *     }],
 *     title: "Ordered Layout Dashboard",
 *     widgets: [
 *         {
 *             alertGraphDefinition: {
 *                 alertId: "895605",
 *                 time: {
 *                     live_span: "1h",
 *                 },
 *                 title: "Widget Title",
 *                 vizType: "timeseries",
 *             },
 *         },
 *         {
 *             alertValueDefinition: {
 *                 alertId: "895605",
 *                 precision: 3,
 *                 textAlign: "center",
 *                 title: "Widget Title",
 *                 unit: "b",
 *             },
 *         },
 *         {
 *             alertValueDefinition: {
 *                 alertId: "895605",
 *                 precision: 3,
 *                 textAlign: "center",
 *                 title: "Widget Title",
 *                 unit: "b",
 *             },
 *         },
 *         {
 *             changeDefinition: {
 *                 requests: [{
 *                     changeType: "absolute",
 *                     compareTo: "weekBefore",
 *                     increaseGood: true,
 *                     orderBy: "name",
 *                     orderDir: "desc",
 *                     q: "avg:system.load.1{env:staging} by {account}",
 *                     showPresent: true,
 *                 }],
 *                 time: {
 *                     live_span: "1h",
 *                 },
 *                 title: "Widget Title",
 *             },
 *         },
 *         {
 *             distributionDefinition: {
 *                 requests: [{
 *                     q: "avg:system.load.1{env:staging} by {account}",
 *                     style: {
 *                         palette: "warm",
 *                     },
 *                 }],
 *                 time: {
 *                     live_span: "1h",
 *                 },
 *                 title: "Widget Title",
 *             },
 *         },
 *         {
 *             checkStatusDefinition: {
 *                 check: "aws.ecs.agent_connected",
 *                 groupBies: [
 *                     "account",
 *                     "cluster",
 *                 ],
 *                 grouping: "cluster",
 *                 tags: [
 *                     "account:demo",
 *                     "cluster:awseb-ruthebdog-env-8-dn3m6u3gvk",
 *                 ],
 *                 time: {
 *                     live_span: "1h",
 *                 },
 *                 title: "Widget Title",
 *             },
 *         },
 *         {
 *             heatmapDefinition: {
 *                 requests: [{
 *                     q: "avg:system.load.1{env:staging} by {account}",
 *                     style: {
 *                         palette: "warm",
 *                     },
 *                 }],
 *                 time: {
 *                     live_span: "1h",
 *                 },
 *                 title: "Widget Title",
 *                 yaxis: {
 *                     includeZero: true,
 *                     max: "2",
 *                     min: "1",
 *                     scale: "sqrt",
 *                 },
 *             },
 *         },
 *         {
 *             hostmapDefinition: {
 *                 groups: [
 *                     "host",
 *                     "region",
 *                 ],
 *                 noGroupHosts: true,
 *                 noMetricHosts: true,
 *                 nodeType: "container",
 *                 request: {
 *                     fills: [{
 *                         q: "avg:system.load.1{*} by {host}",
 *                     }],
 *                     sizes: [{
 *                         q: "avg:memcache.uptime{*} by {host}",
 *                     }],
 *                 },
 *                 scopes: [
 *                     "region:us-east-1",
 *                     "aws_account:727006795293",
 *                 ],
 *                 style: {
 *                     fillMax: "20",
 *                     fillMin: "10",
 *                     palette: "yellowToGreen",
 *                     paletteFlip: true,
 *                 },
 *                 title: "Widget Title",
 *             },
 *         },
 *         {
 *             noteDefinition: {
 *                 backgroundColor: "pink",
 *                 content: "note text",
 *                 fontSize: "14",
 *                 showTick: true,
 *                 textAlign: "center",
 *                 tickEdge: "left",
 *                 tickPos: "50%",
 *             },
 *         },
 *         {
 *             queryValueDefinition: {
 *                 autoscale: true,
 *                 customUnit: "xx",
 *                 precision: 4,
 *                 requests: [{
 *                     aggregator: "sum",
 *                     conditionalFormats: [
 *                         {
 *                             comparator: "<",
 *                             palette: "whiteOnGreen",
 *                             value: 2,
 *                         },
 *                         {
 *                             comparator: ">",
 *                             palette: "whiteOnRed",
 *                             value: 2.2,
 *                         },
 *                     ],
 *                     q: "avg:system.load.1{env:staging} by {account}",
 *                 }],
 *                 textAlign: "right",
 *                 time: {
 *                     live_span: "1h",
 *                 },
 *                 title: "Widget Title",
 *             },
 *         },
 *         {
 *             queryTableDefinition: {
 *                 requests: [{
 *                     aggregator: "sum",
 *                     conditionalFormats: [
 *                         {
 *                             comparator: "<",
 *                             palette: "whiteOnGreen",
 *                             value: 2,
 *                         },
 *                         {
 *                             comparator: ">",
 *                             palette: "whiteOnRed",
 *                             value: 2.2,
 *                         },
 *                     ],
 *                     limit: 10,
 *                     q: "avg:system.load.1{env:staging} by {account}",
 *                 }],
 *                 time: {
 *                     live_span: "1h",
 *                 },
 *                 title: "Widget Title",
 *             },
 *         },
 *         {
 *             scatterplotDefinition: {
 *                 colorByGroups: [
 *                     "account",
 *                     "apm-role-group",
 *                 ],
 *                 request: {
 *                     xes: [{
 *                         aggregator: "max",
 *                         q: "avg:system.cpu.user{*} by {service, account}",
 *                     }],
 *                     ys: [{
 *                         aggregator: "min",
 *                         q: "avg:system.mem.used{*} by {service, account}",
 *                     }],
 *                 },
 *                 time: {
 *                     live_span: "1h",
 *                 },
 *                 title: "Widget Title",
 *                 xaxis: {
 *                     includeZero: true,
 *                     label: "x",
 *                     max: "2000",
 *                     min: "1",
 *                     scale: "pow",
 *                 },
 *                 yaxis: {
 *                     includeZero: false,
 *                     label: "y",
 *                     max: "2222",
 *                     min: "5",
 *                     scale: "log",
 *                 },
 *             },
 *         },
 *         {
 *             layout: {
 *                 height: 43,
 *                 width: 32,
 *                 x: 5,
 *                 y: 5,
 *             },
 *             servicemapDefinition: {
 *                 filters: [
 *                     "env:prod",
 *                     "datacenter:us1.prod.dog",
 *                 ],
 *                 service: "master-db",
 *                 title: "env: prod, datacenter:us1.prod.dog, service: master-db",
 *                 titleAlign: "left",
 *                 titleSize: "16",
 *             },
 *         },
 *         {
 *             timeseriesDefinition: {
 *                 events: [
 *                     {
 *                         q: "sources:test tags:1",
 *                     },
 *                     {
 *                         q: "sources:test tags:2",
 *                     },
 *                 ],
 *                 legendSize: "2",
 *                 markers: [
 *                     {
 *                         displayType: "error dashed",
 *                         label: " z=6 ",
 *                         value: "y = 4",
 *                     },
 *                     {
 *                         displayType: "ok solid",
 *                         label: " x=8 ",
 *                         value: "10 < y < 999",
 *                     },
 *                 ],
 *                 requests: [
 *                     {
 *                         displayType: "line",
 *                         metadatas: [{
 *                             aliasName: "Alpha",
 *                             expression: "avg:system.cpu.user{app:general} by {env}",
 *                         }],
 *                         q: "avg:system.cpu.user{app:general} by {env}",
 *                         style: {
 *                             lineType: "dashed",
 *                             lineWidth: "thin",
 *                             palette: "warm",
 *                         },
 *                     },
 *                     {
 *                         displayType: "area",
 *                         logQuery: {
 *                             compute: {
 *                                 aggregation: "avg",
 *                                 facet: "@duration",
 *                                 interval: 5000,
 *                             },
 *                             groupBies: [{
 *                                 facet: "host",
 *                                 limit: 10,
 *                                 sort: {
 *                                     aggregation: "avg",
 *                                     facet: "@duration",
 *                                     order: "desc",
 *                                 },
 *                             }],
 *                             index: "mcnulty",
 *                             search: {
 *                                 query: "status:info",
 *                             },
 *                         },
 *                     },
 *                     {
 *                         apmQuery: {
 *                             compute: {
 *                                 aggregation: "avg",
 *                                 facet: "@duration",
 *                                 interval: 5000,
 *                             },
 *                             groupBies: [{
 *                                 facet: "resourceName",
 *                                 limit: 50,
 *                                 sort: {
 *                                     aggregation: "avg",
 *                                     facet: "@string_query.interval",
 *                                     order: "desc",
 *                                 },
 *                             }],
 *                             index: "apm-search",
 *                             search: {
 *                                 query: "type:web",
 *                             },
 *                         },
 *                         displayType: "bars",
 *                     },
 *                     {
 *                         displayType: "area",
 *                         processQuery: {
 *                             filterBies: ["active"],
 *                             limit: 50,
 *                             metric: "process.stat.cpu.total_pct",
 *                             searchBy: "error",
 *                         },
 *                     },
 *                 ],
 *                 showLegend: true,
 *                 time: {
 *                     live_span: "1h",
 *                 },
 *                 title: "Widget Title",
 *                 yaxis: {
 *                     includeZero: false,
 *                     max: "100",
 *                     scale: "log",
 *                 },
 *             },
 *         },
 *         {
 *             toplistDefinition: {
 *                 requests: [{
 *                     conditionalFormats: [
 *                         {
 *                             comparator: "<",
 *                             palette: "whiteOnGreen",
 *                             value: 2,
 *                         },
 *                         {
 *                             comparator: ">",
 *                             palette: "whiteOnRed",
 *                             value: 2.2,
 *                         },
 *                     ],
 *                     q: "avg:system.cpu.user{app:general} by {env}",
 *                 }],
 *                 title: "Widget Title",
 *             },
 *         },
 *         {
 *             groupDefinition: {
 *                 layoutType: "ordered",
 *                 title: "Group Widget",
 *                 widgets: [
 *                     {
 *                         noteDefinition: {
 *                             backgroundColor: "pink",
 *                             content: "cluster note widget",
 *                             fontSize: "14",
 *                             showTick: true,
 *                             textAlign: "center",
 *                             tickEdge: "left",
 *                             tickPos: "50%",
 *                         },
 *                     },
 *                     {
 *                         alertGraphDefinition: {
 *                             alertId: "123",
 *                             time: {
 *                                 live_span: "1h",
 *                             },
 *                             title: "Alert Graph",
 *                             vizType: "toplist",
 *                         },
 *                     },
 *                 ],
 *             },
 *         },
 *         {
 *             serviceLevelObjectiveDefinition: {
 *                 showErrorBudget: true,
 *                 sloId: "56789",
 *                 timeWindows: [
 *                     "7d",
 *                     "previousWeek",
 *                 ],
 *                 title: "Widget Title",
 *                 viewMode: "overall",
 *                 viewType: "detail",
 *             },
 *         },
 *     ],
 * });
 * ```
 * ## Example Usage: Create a new Datadog dashboard - Free layout
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * const freeDashboard = new datadog.Dashboard("freeDashboard", {
 *     description: "Created using the Datadog provider in TF",
 *     isReadOnly: false,
 *     layoutType: "free",
 *     templateVariables: [
 *         {
 *             default: "aws",
 *             name: "var1",
 *             prefix: "host",
 *         },
 *         {
 *             default: "autoscaling",
 *             name: "var2",
 *             prefix: "serviceName",
 *         },
 *     ],
 *     templateVariablePresets: [{
 *         name: "preset1",
 *         templateVariables: [
 *             {
 *                 name: "var1",
 *                 value: "host.dc",
 *             },
 *             {
 *                 name: "var2",
 *                 value: "myService",
 *             },
 *         ],
 *     }],
 *     title: "Free Layout Dashboard",
 *     widgets: [
 *         {
 *             eventStreamDefinition: {
 *                 eventSize: "l",
 *                 query: "*",
 *                 time: {
 *                     live_span: "1h",
 *                 },
 *                 title: "Widget Title",
 *                 titleAlign: "left",
 *                 titleSize: "16",
 *             },
 *             layout: {
 *                 height: 43,
 *                 width: 32,
 *                 x: 5,
 *                 y: 5,
 *             },
 *         },
 *         {
 *             eventTimelineDefinition: {
 *                 query: "*",
 *                 time: {
 *                     live_span: "1h",
 *                 },
 *                 title: "Widget Title",
 *                 titleAlign: "left",
 *                 titleSize: "16",
 *             },
 *             layout: {
 *                 height: 9,
 *                 width: 65,
 *                 x: 42,
 *                 y: 73,
 *             },
 *         },
 *         {
 *             freeTextDefinition: {
 *                 color: "#d00",
 *                 fontSize: "88",
 *                 text: "free text content",
 *                 textAlign: "left",
 *             },
 *             layout: {
 *                 height: 20,
 *                 width: 30,
 *                 x: 42,
 *                 y: 5,
 *             },
 *         },
 *         {
 *             iframeDefinition: {
 *                 url: "http://google.com",
 *             },
 *             layout: {
 *                 height: 46,
 *                 width: 39,
 *                 x: 111,
 *                 y: 8,
 *             },
 *         },
 *         {
 *             imageDefinition: {
 *                 margin: "small",
 *                 sizing: "fit",
 *                 url: "https://images.pexels.com/photos/67636/rose-blue-flower-rose-blooms-67636.jpeg?auto=compress&cs=tinysrgb&h=350",
 *             },
 *             layout: {
 *                 height: 20,
 *                 width: 30,
 *                 x: 77,
 *                 y: 7,
 *             },
 *         },
 *         {
 *             layout: {
 *                 height: 36,
 *                 width: 32,
 *                 x: 5,
 *                 y: 51,
 *             },
 *             logStreamDefinition: {
 *                 columns: [
 *                     "coreHost",
 *                     "coreService",
 *                     "tagSource",
 *                 ],
 *                 logset: "19",
 *                 messageDisplay: "expanded-md",
 *                 query: "error",
 *                 showDateColumn: true,
 *                 showMessageColumn: true,
 *                 sort: {
 *                     column: "time",
 *                     order: "desc",
 *                 },
 *             },
 *         },
 *         {
 *             layout: {
 *                 height: 40,
 *                 width: 30,
 *                 x: 112,
 *                 y: 55,
 *             },
 *             manageStatusDefinition: {
 *                 colorPreference: "text",
 *                 displayFormat: "countsAndList",
 *                 hideZeroCounts: true,
 *                 query: "type:metric",
 *                 showLastTriggered: false,
 *                 sort: "status,asc",
 *                 summaryType: "monitors",
 *                 title: "Widget Title",
 *                 titleAlign: "left",
 *                 titleSize: "16",
 *             },
 *         },
 *         {
 *             layout: {
 *                 height: 38,
 *                 width: 67,
 *                 x: 40,
 *                 y: 28,
 *             },
 *             traceServiceDefinition: {
 *                 displayFormat: "threeColumn",
 *                 env: "datad0g.com",
 *                 service: "alerting-cassandra",
 *                 showBreakdown: true,
 *                 showDistribution: true,
 *                 showErrors: true,
 *                 showHits: true,
 *                 showLatency: false,
 *                 showResourceList: false,
 *                 sizeFormat: "large",
 *                 spanName: "cassandra.query",
 *                 time: {
 *                     live_span: "1h",
 *                 },
 *                 title: "alerting-cassandra #env:datad0g.com",
 *                 titleAlign: "center",
 *                 titleSize: "13",
 *             },
 *         },
 *     ],
 * });
 * ```
 */
export class Dashboard extends pulumi.CustomResource {
    /**
     * Get an existing Dashboard resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DashboardState, opts?: pulumi.CustomResourceOptions): Dashboard {
        return new Dashboard(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:index/dashboard:Dashboard';

    /**
     * Returns true if the given object is an instance of Dashboard.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Dashboard {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Dashboard.__pulumiType;
    }

    /**
     * The description of the dashboard.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Whether this dashboard is read-only.
     */
    public readonly isReadOnly!: pulumi.Output<boolean | undefined>;
    /**
     * The layout type of the dashboard, either 'free' or 'ordered'.
     */
    public readonly layoutType!: pulumi.Output<string>;
    /**
     * The list of handles of users to notify when changes are made to this dashboard.
     */
    public readonly notifyLists!: pulumi.Output<string[] | undefined>;
    /**
     * The list of selectable template variable presets for this dashboard.
     */
    public readonly templateVariablePresets!: pulumi.Output<outputs.DashboardTemplateVariablePreset[] | undefined>;
    /**
     * The list of template variables for this dashboard.
     */
    public readonly templateVariables!: pulumi.Output<outputs.DashboardTemplateVariable[] | undefined>;
    /**
     * The title of the dashboard.
     */
    public readonly title!: pulumi.Output<string>;
    /**
     * The URL of the dashboard.
     */
    public readonly url!: pulumi.Output<string>;
    /**
     * The list of widgets to display on the dashboard.
     */
    public readonly widgets!: pulumi.Output<outputs.DashboardWidget[]>;

    /**
     * Create a Dashboard resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DashboardArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DashboardArgs | DashboardState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as DashboardState | undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["isReadOnly"] = state ? state.isReadOnly : undefined;
            inputs["layoutType"] = state ? state.layoutType : undefined;
            inputs["notifyLists"] = state ? state.notifyLists : undefined;
            inputs["templateVariablePresets"] = state ? state.templateVariablePresets : undefined;
            inputs["templateVariables"] = state ? state.templateVariables : undefined;
            inputs["title"] = state ? state.title : undefined;
            inputs["url"] = state ? state.url : undefined;
            inputs["widgets"] = state ? state.widgets : undefined;
        } else {
            const args = argsOrState as DashboardArgs | undefined;
            if (!args || args.layoutType === undefined) {
                throw new Error("Missing required property 'layoutType'");
            }
            if (!args || args.title === undefined) {
                throw new Error("Missing required property 'title'");
            }
            if (!args || args.widgets === undefined) {
                throw new Error("Missing required property 'widgets'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["isReadOnly"] = args ? args.isReadOnly : undefined;
            inputs["layoutType"] = args ? args.layoutType : undefined;
            inputs["notifyLists"] = args ? args.notifyLists : undefined;
            inputs["templateVariablePresets"] = args ? args.templateVariablePresets : undefined;
            inputs["templateVariables"] = args ? args.templateVariables : undefined;
            inputs["title"] = args ? args.title : undefined;
            inputs["url"] = args ? args.url : undefined;
            inputs["widgets"] = args ? args.widgets : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Dashboard.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Dashboard resources.
 */
export interface DashboardState {
    /**
     * The description of the dashboard.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Whether this dashboard is read-only.
     */
    readonly isReadOnly?: pulumi.Input<boolean>;
    /**
     * The layout type of the dashboard, either 'free' or 'ordered'.
     */
    readonly layoutType?: pulumi.Input<string>;
    /**
     * The list of handles of users to notify when changes are made to this dashboard.
     */
    readonly notifyLists?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The list of selectable template variable presets for this dashboard.
     */
    readonly templateVariablePresets?: pulumi.Input<pulumi.Input<inputs.DashboardTemplateVariablePreset>[]>;
    /**
     * The list of template variables for this dashboard.
     */
    readonly templateVariables?: pulumi.Input<pulumi.Input<inputs.DashboardTemplateVariable>[]>;
    /**
     * The title of the dashboard.
     */
    readonly title?: pulumi.Input<string>;
    /**
     * The URL of the dashboard.
     */
    readonly url?: pulumi.Input<string>;
    /**
     * The list of widgets to display on the dashboard.
     */
    readonly widgets?: pulumi.Input<pulumi.Input<inputs.DashboardWidget>[]>;
}

/**
 * The set of arguments for constructing a Dashboard resource.
 */
export interface DashboardArgs {
    /**
     * The description of the dashboard.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Whether this dashboard is read-only.
     */
    readonly isReadOnly?: pulumi.Input<boolean>;
    /**
     * The layout type of the dashboard, either 'free' or 'ordered'.
     */
    readonly layoutType: pulumi.Input<string>;
    /**
     * The list of handles of users to notify when changes are made to this dashboard.
     */
    readonly notifyLists?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The list of selectable template variable presets for this dashboard.
     */
    readonly templateVariablePresets?: pulumi.Input<pulumi.Input<inputs.DashboardTemplateVariablePreset>[]>;
    /**
     * The list of template variables for this dashboard.
     */
    readonly templateVariables?: pulumi.Input<pulumi.Input<inputs.DashboardTemplateVariable>[]>;
    /**
     * The title of the dashboard.
     */
    readonly title: pulumi.Input<string>;
    /**
     * The URL of the dashboard.
     */
    readonly url?: pulumi.Input<string>;
    /**
     * The list of widgets to display on the dashboard.
     */
    readonly widgets: pulumi.Input<pulumi.Input<inputs.DashboardWidget>[]>;
}
