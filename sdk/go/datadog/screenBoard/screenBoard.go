// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package screenBoard

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Datadog screenboard resource. This can be used to create and manage Datadog screenboards.
type ScreenBoard struct {
	s *pulumi.ResourceState
}

// NewScreenBoard registers a new resource with the given unique name, arguments, and options.
func NewScreenBoard(ctx *pulumi.Context,
	name string, args *ScreenBoardArgs, opts ...pulumi.ResourceOpt) (*ScreenBoard, error) {
	if args == nil || args.Title == nil {
		return nil, errors.New("missing required argument 'Title'")
	}
	if args == nil || args.Widgets == nil {
		return nil, errors.New("missing required argument 'Widgets'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["height"] = nil
		inputs["readOnly"] = nil
		inputs["shared"] = nil
		inputs["templateVariables"] = nil
		inputs["title"] = nil
		inputs["widgets"] = nil
		inputs["width"] = nil
	} else {
		inputs["height"] = args.Height
		inputs["readOnly"] = args.ReadOnly
		inputs["shared"] = args.Shared
		inputs["templateVariables"] = args.TemplateVariables
		inputs["title"] = args.Title
		inputs["widgets"] = args.Widgets
		inputs["width"] = args.Width
	}
	s, err := ctx.RegisterResource("datadog:screenBoard:ScreenBoard", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ScreenBoard{s: s}, nil
}

// GetScreenBoard gets an existing ScreenBoard resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetScreenBoard(ctx *pulumi.Context,
	name string, id pulumi.ID, state *ScreenBoardState, opts ...pulumi.ResourceOpt) (*ScreenBoard, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["height"] = state.Height
		inputs["readOnly"] = state.ReadOnly
		inputs["shared"] = state.Shared
		inputs["templateVariables"] = state.TemplateVariables
		inputs["title"] = state.Title
		inputs["widgets"] = state.Widgets
		inputs["width"] = state.Width
	}
	s, err := ctx.ReadResource("datadog:screenBoard:ScreenBoard", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ScreenBoard{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *ScreenBoard) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *ScreenBoard) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// Height of the screenboard
func (r *ScreenBoard) Height() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["height"])
}

func (r *ScreenBoard) ReadOnly() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["readOnly"])
}

// Whether the screenboard is shared or not
func (r *ScreenBoard) Shared() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["shared"])
}

// A list of template variables for using Dashboard templating.
func (r *ScreenBoard) TemplateVariables() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["templateVariables"])
}

// Name of the screenboard
func (r *ScreenBoard) Title() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["title"])
}

// A list of widget definitions.
func (r *ScreenBoard) Widgets() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["widgets"])
}

// Width of the screenboard
func (r *ScreenBoard) Width() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["width"])
}

// Input properties used for looking up and filtering ScreenBoard resources.
type ScreenBoardState struct {
	// Height of the screenboard
	Height interface{}
	ReadOnly interface{}
	// Whether the screenboard is shared or not
	Shared interface{}
	// A list of template variables for using Dashboard templating.
	TemplateVariables interface{}
	// Name of the screenboard
	Title interface{}
	// A list of widget definitions.
	Widgets interface{}
	// Width of the screenboard
	Width interface{}
}

// The set of arguments for constructing a ScreenBoard resource.
type ScreenBoardArgs struct {
	// Height of the screenboard
	Height interface{}
	ReadOnly interface{}
	// Whether the screenboard is shared or not
	Shared interface{}
	// A list of template variables for using Dashboard templating.
	TemplateVariables interface{}
	// Name of the screenboard
	Title interface{}
	// A list of widget definitions.
	Widgets interface{}
	// Width of the screenboard
	Width interface{}
}
