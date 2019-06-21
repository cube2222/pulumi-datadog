// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

type SyntheticsTest struct {
	s *pulumi.ResourceState
}

// NewSyntheticsTest registers a new resource with the given unique name, arguments, and options.
func NewSyntheticsTest(ctx *pulumi.Context,
	name string, args *SyntheticsTestArgs, opts ...pulumi.ResourceOpt) (*SyntheticsTest, error) {
	if args == nil || args.Locations == nil {
		return nil, errors.New("missing required argument 'Locations'")
	}
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.Request == nil {
		return nil, errors.New("missing required argument 'Request'")
	}
	if args == nil || args.Status == nil {
		return nil, errors.New("missing required argument 'Status'")
	}
	if args == nil || args.Tags == nil {
		return nil, errors.New("missing required argument 'Tags'")
	}
	if args == nil || args.Type == nil {
		return nil, errors.New("missing required argument 'Type'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["assertions"] = nil
		inputs["deviceIds"] = nil
		inputs["locations"] = nil
		inputs["message"] = nil
		inputs["name"] = nil
		inputs["options"] = nil
		inputs["request"] = nil
		inputs["requestHeaders"] = nil
		inputs["status"] = nil
		inputs["tags"] = nil
		inputs["type"] = nil
	} else {
		inputs["assertions"] = args.Assertions
		inputs["deviceIds"] = args.DeviceIds
		inputs["locations"] = args.Locations
		inputs["message"] = args.Message
		inputs["name"] = args.Name
		inputs["options"] = args.Options
		inputs["request"] = args.Request
		inputs["requestHeaders"] = args.RequestHeaders
		inputs["status"] = args.Status
		inputs["tags"] = args.Tags
		inputs["type"] = args.Type
	}
	s, err := ctx.RegisterResource("datadog:index/syntheticsTest:SyntheticsTest", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &SyntheticsTest{s: s}, nil
}

// GetSyntheticsTest gets an existing SyntheticsTest resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSyntheticsTest(ctx *pulumi.Context,
	name string, id pulumi.ID, state *SyntheticsTestState, opts ...pulumi.ResourceOpt) (*SyntheticsTest, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["assertions"] = state.Assertions
		inputs["deviceIds"] = state.DeviceIds
		inputs["locations"] = state.Locations
		inputs["message"] = state.Message
		inputs["name"] = state.Name
		inputs["options"] = state.Options
		inputs["request"] = state.Request
		inputs["requestHeaders"] = state.RequestHeaders
		inputs["status"] = state.Status
		inputs["tags"] = state.Tags
		inputs["type"] = state.Type
	}
	s, err := ctx.ReadResource("datadog:index/syntheticsTest:SyntheticsTest", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &SyntheticsTest{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *SyntheticsTest) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *SyntheticsTest) ID() *pulumi.IDOutput {
	return r.s.ID()
}

func (r *SyntheticsTest) Assertions() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["assertions"])
}

func (r *SyntheticsTest) DeviceIds() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["deviceIds"])
}

func (r *SyntheticsTest) Locations() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["locations"])
}

func (r *SyntheticsTest) Message() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["message"])
}

func (r *SyntheticsTest) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

func (r *SyntheticsTest) Options() *pulumi.Output {
	return r.s.State["options"]
}

func (r *SyntheticsTest) Request() *pulumi.Output {
	return r.s.State["request"]
}

func (r *SyntheticsTest) RequestHeaders() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["requestHeaders"])
}

func (r *SyntheticsTest) Status() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["status"])
}

func (r *SyntheticsTest) Tags() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["tags"])
}

func (r *SyntheticsTest) Type() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["type"])
}

// Input properties used for looking up and filtering SyntheticsTest resources.
type SyntheticsTestState struct {
	Assertions interface{}
	DeviceIds interface{}
	Locations interface{}
	Message interface{}
	Name interface{}
	Options interface{}
	Request interface{}
	RequestHeaders interface{}
	Status interface{}
	Tags interface{}
	Type interface{}
}

// The set of arguments for constructing a SyntheticsTest resource.
type SyntheticsTestArgs struct {
	Assertions interface{}
	DeviceIds interface{}
	Locations interface{}
	Message interface{}
	Name interface{}
	Options interface{}
	Request interface{}
	RequestHeaders interface{}
	Status interface{}
	Tags interface{}
	Type interface{}
}