// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Datadog dashboard resource. This can be used to create and manage Datadog dashboards.
//
// > **Note:** This resource uses the new [Dashboard API](https://docs.datadoghq.com/api/v1/dashboards/) which adds new features like better validation and support for the [Group widget](https://docs.datadoghq.com/graphing/widgets/group/). Additionally, this resource unifies `.TimeBoard` and `.ScreenBoard` resources to allow you to manage all of your dashboards using a single format.
type Dashboard struct {
	pulumi.CustomResourceState

	// The description of the dashboard.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Whether this dashboard is read-only.
	IsReadOnly pulumi.BoolPtrOutput `pulumi:"isReadOnly"`
	// The layout type of the dashboard, either 'free' or 'ordered'.
	LayoutType pulumi.StringOutput `pulumi:"layoutType"`
	// The list of handles of users to notify when changes are made to this dashboard.
	NotifyLists pulumi.StringArrayOutput `pulumi:"notifyLists"`
	// The list of selectable template variable presets for this dashboard.
	TemplateVariablePresets DashboardTemplateVariablePresetArrayOutput `pulumi:"templateVariablePresets"`
	// The list of template variables for this dashboard.
	TemplateVariables DashboardTemplateVariableArrayOutput `pulumi:"templateVariables"`
	// The title of the dashboard.
	Title pulumi.StringOutput `pulumi:"title"`
	// The list of widgets to display on the dashboard.
	Widgets DashboardWidgetArrayOutput `pulumi:"widgets"`
}

// NewDashboard registers a new resource with the given unique name, arguments, and options.
func NewDashboard(ctx *pulumi.Context,
	name string, args *DashboardArgs, opts ...pulumi.ResourceOption) (*Dashboard, error) {
	if args == nil || args.LayoutType == nil {
		return nil, errors.New("missing required argument 'LayoutType'")
	}
	if args == nil || args.Title == nil {
		return nil, errors.New("missing required argument 'Title'")
	}
	if args == nil || args.Widgets == nil {
		return nil, errors.New("missing required argument 'Widgets'")
	}
	if args == nil {
		args = &DashboardArgs{}
	}
	var resource Dashboard
	err := ctx.RegisterResource("datadog:index/dashboard:Dashboard", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDashboard gets an existing Dashboard resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDashboard(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DashboardState, opts ...pulumi.ResourceOption) (*Dashboard, error) {
	var resource Dashboard
	err := ctx.ReadResource("datadog:index/dashboard:Dashboard", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Dashboard resources.
type dashboardState struct {
	// The description of the dashboard.
	Description *string `pulumi:"description"`
	// Whether this dashboard is read-only.
	IsReadOnly *bool `pulumi:"isReadOnly"`
	// The layout type of the dashboard, either 'free' or 'ordered'.
	LayoutType *string `pulumi:"layoutType"`
	// The list of handles of users to notify when changes are made to this dashboard.
	NotifyLists []string `pulumi:"notifyLists"`
	// The list of selectable template variable presets for this dashboard.
	TemplateVariablePresets []DashboardTemplateVariablePreset `pulumi:"templateVariablePresets"`
	// The list of template variables for this dashboard.
	TemplateVariables []DashboardTemplateVariable `pulumi:"templateVariables"`
	// The title of the dashboard.
	Title *string `pulumi:"title"`
	// The list of widgets to display on the dashboard.
	Widgets []DashboardWidget `pulumi:"widgets"`
}

type DashboardState struct {
	// The description of the dashboard.
	Description pulumi.StringPtrInput
	// Whether this dashboard is read-only.
	IsReadOnly pulumi.BoolPtrInput
	// The layout type of the dashboard, either 'free' or 'ordered'.
	LayoutType pulumi.StringPtrInput
	// The list of handles of users to notify when changes are made to this dashboard.
	NotifyLists pulumi.StringArrayInput
	// The list of selectable template variable presets for this dashboard.
	TemplateVariablePresets DashboardTemplateVariablePresetArrayInput
	// The list of template variables for this dashboard.
	TemplateVariables DashboardTemplateVariableArrayInput
	// The title of the dashboard.
	Title pulumi.StringPtrInput
	// The list of widgets to display on the dashboard.
	Widgets DashboardWidgetArrayInput
}

func (DashboardState) ElementType() reflect.Type {
	return reflect.TypeOf((*dashboardState)(nil)).Elem()
}

type dashboardArgs struct {
	// The description of the dashboard.
	Description *string `pulumi:"description"`
	// Whether this dashboard is read-only.
	IsReadOnly *bool `pulumi:"isReadOnly"`
	// The layout type of the dashboard, either 'free' or 'ordered'.
	LayoutType string `pulumi:"layoutType"`
	// The list of handles of users to notify when changes are made to this dashboard.
	NotifyLists []string `pulumi:"notifyLists"`
	// The list of selectable template variable presets for this dashboard.
	TemplateVariablePresets []DashboardTemplateVariablePreset `pulumi:"templateVariablePresets"`
	// The list of template variables for this dashboard.
	TemplateVariables []DashboardTemplateVariable `pulumi:"templateVariables"`
	// The title of the dashboard.
	Title string `pulumi:"title"`
	// The list of widgets to display on the dashboard.
	Widgets []DashboardWidget `pulumi:"widgets"`
}

// The set of arguments for constructing a Dashboard resource.
type DashboardArgs struct {
	// The description of the dashboard.
	Description pulumi.StringPtrInput
	// Whether this dashboard is read-only.
	IsReadOnly pulumi.BoolPtrInput
	// The layout type of the dashboard, either 'free' or 'ordered'.
	LayoutType pulumi.StringInput
	// The list of handles of users to notify when changes are made to this dashboard.
	NotifyLists pulumi.StringArrayInput
	// The list of selectable template variable presets for this dashboard.
	TemplateVariablePresets DashboardTemplateVariablePresetArrayInput
	// The list of template variables for this dashboard.
	TemplateVariables DashboardTemplateVariableArrayInput
	// The title of the dashboard.
	Title pulumi.StringInput
	// The list of widgets to display on the dashboard.
	Widgets DashboardWidgetArrayInput
}

func (DashboardArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dashboardArgs)(nil)).Elem()
}
