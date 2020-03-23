// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package datadog

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Datadog screenboard resource. This can be used to create and manage Datadog screenboards.
//
// > **Note:** This resource is outdated. Use the new `.Dashboard` resource instead.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/screenboard.html.markdown.
type ScreenBoard struct {
	pulumi.CustomResourceState

	// Height of the screenboard
	Height pulumi.StringPtrOutput `pulumi:"height"`
	ReadOnly pulumi.BoolPtrOutput `pulumi:"readOnly"`
	// Whether the screenboard is shared or not
	Shared pulumi.BoolPtrOutput `pulumi:"shared"`
	// A list of template variables for using Dashboard templating.
	TemplateVariables ScreenBoardTemplateVariableArrayOutput `pulumi:"templateVariables"`
	// Name of the screenboard
	Title pulumi.StringOutput `pulumi:"title"`
	// A list of widget definitions.
	Widgets ScreenBoardWidgetArrayOutput `pulumi:"widgets"`
	// Width of the screenboard
	Width pulumi.StringPtrOutput `pulumi:"width"`
}

// NewScreenBoard registers a new resource with the given unique name, arguments, and options.
func NewScreenBoard(ctx *pulumi.Context,
	name string, args *ScreenBoardArgs, opts ...pulumi.ResourceOption) (*ScreenBoard, error) {
	if args == nil || args.Title == nil {
		return nil, errors.New("missing required argument 'Title'")
	}
	if args == nil || args.Widgets == nil {
		return nil, errors.New("missing required argument 'Widgets'")
	}
	if args == nil {
		args = &ScreenBoardArgs{}
	}
	var resource ScreenBoard
	err := ctx.RegisterResource("datadog:index/screenBoard:ScreenBoard", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetScreenBoard gets an existing ScreenBoard resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetScreenBoard(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ScreenBoardState, opts ...pulumi.ResourceOption) (*ScreenBoard, error) {
	var resource ScreenBoard
	err := ctx.ReadResource("datadog:index/screenBoard:ScreenBoard", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ScreenBoard resources.
type screenBoardState struct {
	// Height of the screenboard
	Height *string `pulumi:"height"`
	ReadOnly *bool `pulumi:"readOnly"`
	// Whether the screenboard is shared or not
	Shared *bool `pulumi:"shared"`
	// A list of template variables for using Dashboard templating.
	TemplateVariables []ScreenBoardTemplateVariable `pulumi:"templateVariables"`
	// Name of the screenboard
	Title *string `pulumi:"title"`
	// A list of widget definitions.
	Widgets []ScreenBoardWidget `pulumi:"widgets"`
	// Width of the screenboard
	Width *string `pulumi:"width"`
}

type ScreenBoardState struct {
	// Height of the screenboard
	Height pulumi.StringPtrInput
	ReadOnly pulumi.BoolPtrInput
	// Whether the screenboard is shared or not
	Shared pulumi.BoolPtrInput
	// A list of template variables for using Dashboard templating.
	TemplateVariables ScreenBoardTemplateVariableArrayInput
	// Name of the screenboard
	Title pulumi.StringPtrInput
	// A list of widget definitions.
	Widgets ScreenBoardWidgetArrayInput
	// Width of the screenboard
	Width pulumi.StringPtrInput
}

func (ScreenBoardState) ElementType() reflect.Type {
	return reflect.TypeOf((*screenBoardState)(nil)).Elem()
}

type screenBoardArgs struct {
	// Height of the screenboard
	Height *string `pulumi:"height"`
	ReadOnly *bool `pulumi:"readOnly"`
	// Whether the screenboard is shared or not
	Shared *bool `pulumi:"shared"`
	// A list of template variables for using Dashboard templating.
	TemplateVariables []ScreenBoardTemplateVariable `pulumi:"templateVariables"`
	// Name of the screenboard
	Title string `pulumi:"title"`
	// A list of widget definitions.
	Widgets []ScreenBoardWidget `pulumi:"widgets"`
	// Width of the screenboard
	Width *string `pulumi:"width"`
}

// The set of arguments for constructing a ScreenBoard resource.
type ScreenBoardArgs struct {
	// Height of the screenboard
	Height pulumi.StringPtrInput
	ReadOnly pulumi.BoolPtrInput
	// Whether the screenboard is shared or not
	Shared pulumi.BoolPtrInput
	// A list of template variables for using Dashboard templating.
	TemplateVariables ScreenBoardTemplateVariableArrayInput
	// Name of the screenboard
	Title pulumi.StringInput
	// A list of widget definitions.
	Widgets ScreenBoardWidgetArrayInput
	// Width of the screenboard
	Width pulumi.StringPtrInput
}

func (ScreenBoardArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*screenBoardArgs)(nil)).Elem()
}

