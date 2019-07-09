// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Datadog downtime resource. This can be used to create and manage Datadog downtimes.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/downtime.html.markdown.
type Downtime struct {
	s *pulumi.ResourceState
}

// NewDowntime registers a new resource with the given unique name, arguments, and options.
func NewDowntime(ctx *pulumi.Context,
	name string, args *DowntimeArgs, opts ...pulumi.ResourceOpt) (*Downtime, error) {
	if args == nil || args.Scopes == nil {
		return nil, errors.New("missing required argument 'Scopes'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["active"] = nil
		inputs["disabled"] = nil
		inputs["end"] = nil
		inputs["endDate"] = nil
		inputs["message"] = nil
		inputs["monitorId"] = nil
		inputs["monitorTags"] = nil
		inputs["recurrence"] = nil
		inputs["scopes"] = nil
		inputs["start"] = nil
		inputs["startDate"] = nil
		inputs["timezone"] = nil
	} else {
		inputs["active"] = args.Active
		inputs["disabled"] = args.Disabled
		inputs["end"] = args.End
		inputs["endDate"] = args.EndDate
		inputs["message"] = args.Message
		inputs["monitorId"] = args.MonitorId
		inputs["monitorTags"] = args.MonitorTags
		inputs["recurrence"] = args.Recurrence
		inputs["scopes"] = args.Scopes
		inputs["start"] = args.Start
		inputs["startDate"] = args.StartDate
		inputs["timezone"] = args.Timezone
	}
	s, err := ctx.RegisterResource("datadog:index/downtime:Downtime", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Downtime{s: s}, nil
}

// GetDowntime gets an existing Downtime resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDowntime(ctx *pulumi.Context,
	name string, id pulumi.ID, state *DowntimeState, opts ...pulumi.ResourceOpt) (*Downtime, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["active"] = state.Active
		inputs["disabled"] = state.Disabled
		inputs["end"] = state.End
		inputs["endDate"] = state.EndDate
		inputs["message"] = state.Message
		inputs["monitorId"] = state.MonitorId
		inputs["monitorTags"] = state.MonitorTags
		inputs["recurrence"] = state.Recurrence
		inputs["scopes"] = state.Scopes
		inputs["start"] = state.Start
		inputs["startDate"] = state.StartDate
		inputs["timezone"] = state.Timezone
	}
	s, err := ctx.ReadResource("datadog:index/downtime:Downtime", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Downtime{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Downtime) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Downtime) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// A flag indicating if the downtime is active now.
func (r *Downtime) Active() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["active"])
}

// A flag indicating if the downtime was disabled.
func (r *Downtime) Disabled() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["disabled"])
}

// POSIX timestamp to end the downtime.
func (r *Downtime) End() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["end"])
}

// String representing date and time to end the downtime in RFC3339 format.
func (r *Downtime) EndDate() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["endDate"])
}

// A message to include with notifications for this downtime.
func (r *Downtime) Message() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["message"])
}

// When specified, this downtime will only apply to this monitor
func (r *Downtime) MonitorId() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["monitorId"])
}

// A list of monitor tags to match. The resulting downtime applies to monitors that match **all** provided monitor tags. This option conflicts with `monitor_id` as it will match all monitors that match these tags.
func (r *Downtime) MonitorTags() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["monitorTags"])
}

// A dictionary to configure the downtime to be recurring.
func (r *Downtime) Recurrence() *pulumi.Output {
	return r.s.State["recurrence"]
}

// A list of items to apply the downtime to, e.g. host:X
func (r *Downtime) Scopes() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["scopes"])
}

// POSIX timestamp to start the downtime.
func (r *Downtime) Start() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["start"])
}

// String representing date and time to start the downtime in RFC3339 format.
func (r *Downtime) StartDate() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["startDate"])
}

// The timezone for the downtime, default UTC. It must be a valid IANA Time Zone.
func (r *Downtime) Timezone() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["timezone"])
}

// Input properties used for looking up and filtering Downtime resources.
type DowntimeState struct {
	// A flag indicating if the downtime is active now.
	Active interface{}
	// A flag indicating if the downtime was disabled.
	Disabled interface{}
	// POSIX timestamp to end the downtime.
	End interface{}
	// String representing date and time to end the downtime in RFC3339 format.
	EndDate interface{}
	// A message to include with notifications for this downtime.
	Message interface{}
	// When specified, this downtime will only apply to this monitor
	MonitorId interface{}
	// A list of monitor tags to match. The resulting downtime applies to monitors that match **all** provided monitor tags. This option conflicts with `monitor_id` as it will match all monitors that match these tags.
	MonitorTags interface{}
	// A dictionary to configure the downtime to be recurring.
	Recurrence interface{}
	// A list of items to apply the downtime to, e.g. host:X
	Scopes interface{}
	// POSIX timestamp to start the downtime.
	Start interface{}
	// String representing date and time to start the downtime in RFC3339 format.
	StartDate interface{}
	// The timezone for the downtime, default UTC. It must be a valid IANA Time Zone.
	Timezone interface{}
}

// The set of arguments for constructing a Downtime resource.
type DowntimeArgs struct {
	// A flag indicating if the downtime is active now.
	Active interface{}
	// A flag indicating if the downtime was disabled.
	Disabled interface{}
	// POSIX timestamp to end the downtime.
	End interface{}
	// String representing date and time to end the downtime in RFC3339 format.
	EndDate interface{}
	// A message to include with notifications for this downtime.
	Message interface{}
	// When specified, this downtime will only apply to this monitor
	MonitorId interface{}
	// A list of monitor tags to match. The resulting downtime applies to monitors that match **all** provided monitor tags. This option conflicts with `monitor_id` as it will match all monitors that match these tags.
	MonitorTags interface{}
	// A dictionary to configure the downtime to be recurring.
	Recurrence interface{}
	// A list of items to apply the downtime to, e.g. host:X
	Scopes interface{}
	// POSIX timestamp to start the downtime.
	Start interface{}
	// String representing date and time to start the downtime in RFC3339 format.
	StartDate interface{}
	// The timezone for the downtime, default UTC. It must be a valid IANA Time Zone.
	Timezone interface{}
}
