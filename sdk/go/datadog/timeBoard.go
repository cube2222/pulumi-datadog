// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Datadog timeboard resource. This can be used to create and manage Datadog timeboards.
type TimeBoard struct {
	s *pulumi.ResourceState
}

// NewTimeBoard registers a new resource with the given unique name, arguments, and options.
func NewTimeBoard(ctx *pulumi.Context,
	name string, args *TimeBoardArgs, opts ...pulumi.ResourceOpt) (*TimeBoard, error) {
	if args == nil || args.Description == nil {
		return nil, errors.New("missing required argument 'Description'")
	}
	if args == nil || args.Graphs == nil {
		return nil, errors.New("missing required argument 'Graphs'")
	}
	if args == nil || args.Title == nil {
		return nil, errors.New("missing required argument 'Title'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["description"] = nil
		inputs["graphs"] = nil
		inputs["readOnly"] = nil
		inputs["templateVariables"] = nil
		inputs["title"] = nil
	} else {
		inputs["description"] = args.Description
		inputs["graphs"] = args.Graphs
		inputs["readOnly"] = args.ReadOnly
		inputs["templateVariables"] = args.TemplateVariables
		inputs["title"] = args.Title
	}
	s, err := ctx.RegisterResource("datadog:index/timeBoard:TimeBoard", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &TimeBoard{s: s}, nil
}

// GetTimeBoard gets an existing TimeBoard resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTimeBoard(ctx *pulumi.Context,
	name string, id pulumi.ID, state *TimeBoardState, opts ...pulumi.ResourceOpt) (*TimeBoard, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["description"] = state.Description
		inputs["graphs"] = state.Graphs
		inputs["readOnly"] = state.ReadOnly
		inputs["templateVariables"] = state.TemplateVariables
		inputs["title"] = state.Title
	}
	s, err := ctx.ReadResource("datadog:index/timeBoard:TimeBoard", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &TimeBoard{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *TimeBoard) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *TimeBoard) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// A description of the dashboard's content.
func (r *TimeBoard) Description() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["description"])
}

// Nested block describing a graph definition. The structure of this block is described below. Multiple graph blocks are allowed within a datadog_timeboard resource.
func (r *TimeBoard) Graphs() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["graphs"])
}

// The read-only status of the timeboard. Default is false.
func (r *TimeBoard) ReadOnly() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["readOnly"])
}

// Nested block describing a template variable. The structure of this block is described below. Multiple template_variable blocks are allowed within a datadog_timeboard resource.
func (r *TimeBoard) TemplateVariables() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["templateVariables"])
}

// The name of the dashboard.
func (r *TimeBoard) Title() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["title"])
}

// Input properties used for looking up and filtering TimeBoard resources.
type TimeBoardState struct {
	// A description of the dashboard's content.
	Description interface{}
	// Nested block describing a graph definition. The structure of this block is described below. Multiple graph blocks are allowed within a datadog_timeboard resource.
	Graphs interface{}
	// The read-only status of the timeboard. Default is false.
	ReadOnly interface{}
	// Nested block describing a template variable. The structure of this block is described below. Multiple template_variable blocks are allowed within a datadog_timeboard resource.
	TemplateVariables interface{}
	// The name of the dashboard.
	Title interface{}
}

// The set of arguments for constructing a TimeBoard resource.
type TimeBoardArgs struct {
	// A description of the dashboard's content.
	Description interface{}
	// Nested block describing a graph definition. The structure of this block is described below. Multiple graph blocks are allowed within a datadog_timeboard resource.
	Graphs interface{}
	// The read-only status of the timeboard. Default is false.
	ReadOnly interface{}
	// Nested block describing a template variable. The structure of this block is described below. Multiple template_variable blocks are allowed within a datadog_timeboard resource.
	TemplateVariables interface{}
	// The name of the dashboard.
	Title interface{}
}
