// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Datadog downtime resource. This can be used to create and manage Datadog downtimes.
//
// ## Example: downtime for a specific monitor
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-datadog/sdk/v2/go/datadog"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := datadog.NewDowntime(ctx, "foo", &datadog.DowntimeArgs{
// 			End:       pulumi.Int(1483365600),
// 			MonitorId: pulumi.Int(12345),
// 			Recurrence: &datadog.DowntimeRecurrenceArgs{
// 				Period: pulumi.Int(1),
// 				Type:   pulumi.String("days"),
// 			},
// 			Scopes: pulumi.StringArray{
// 				pulumi.String("*"),
// 			},
// 			Start: pulumi.Int(1483308000),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// ## Example: downtime for all monitors
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-datadog/sdk/v2/go/datadog"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := datadog.NewDowntime(ctx, "foo", &datadog.DowntimeArgs{
// 			End: pulumi.Int(1483365600),
// 			Recurrence: &datadog.DowntimeRecurrenceArgs{
// 				Period: pulumi.Int(1),
// 				Type:   pulumi.String("days"),
// 			},
// 			Scopes: pulumi.StringArray{
// 				pulumi.String("*"),
// 			},
// 			Start: pulumi.Int(1483308000),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// ## Import
//
// Downtimes can be imported using their numeric ID, e.g.
//
// ```sh
//  $ pulumi import datadog:index/downtime:Downtime bytes_received_localhost 2081
// ```
type Downtime struct {
	pulumi.CustomResourceState

	// When true indicates this downtime is being actively applied
	Active pulumi.BoolPtrOutput `pulumi:"active"`
	// When true indicates this downtime is not being applied
	Disabled pulumi.BoolPtrOutput `pulumi:"disabled"`
	// Optionally specify an end date when this downtime should expire
	End     pulumi.IntPtrOutput    `pulumi:"end"`
	EndDate pulumi.StringPtrOutput `pulumi:"endDate"`
	// An optional message to provide when creating the downtime, can include notification handles
	Message pulumi.StringPtrOutput `pulumi:"message"`
	// When specified, this downtime will only apply to this monitor
	MonitorId pulumi.IntPtrOutput `pulumi:"monitorId"`
	// A list of monitor tags (up to 25), i.e. tags that are applied directly to monitors to which the downtime applies
	MonitorTags pulumi.StringArrayOutput `pulumi:"monitorTags"`
	// Optional recurring schedule for this downtime
	Recurrence DowntimeRecurrencePtrOutput `pulumi:"recurrence"`
	// specify the group scope to which this downtime applies. For everything use '*'
	Scopes pulumi.StringArrayOutput `pulumi:"scopes"`
	// Specify when this downtime should start
	Start     pulumi.IntPtrOutput    `pulumi:"start"`
	StartDate pulumi.StringPtrOutput `pulumi:"startDate"`
	// The timezone for the downtime, default UTC
	Timezone pulumi.StringPtrOutput `pulumi:"timezone"`
}

// NewDowntime registers a new resource with the given unique name, arguments, and options.
func NewDowntime(ctx *pulumi.Context,
	name string, args *DowntimeArgs, opts ...pulumi.ResourceOption) (*Downtime, error) {
	if args == nil || args.Scopes == nil {
		return nil, errors.New("missing required argument 'Scopes'")
	}
	if args == nil {
		args = &DowntimeArgs{}
	}
	var resource Downtime
	err := ctx.RegisterResource("datadog:index/downtime:Downtime", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDowntime gets an existing Downtime resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDowntime(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DowntimeState, opts ...pulumi.ResourceOption) (*Downtime, error) {
	var resource Downtime
	err := ctx.ReadResource("datadog:index/downtime:Downtime", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Downtime resources.
type downtimeState struct {
	// When true indicates this downtime is being actively applied
	Active *bool `pulumi:"active"`
	// When true indicates this downtime is not being applied
	Disabled *bool `pulumi:"disabled"`
	// Optionally specify an end date when this downtime should expire
	End     *int    `pulumi:"end"`
	EndDate *string `pulumi:"endDate"`
	// An optional message to provide when creating the downtime, can include notification handles
	Message *string `pulumi:"message"`
	// When specified, this downtime will only apply to this monitor
	MonitorId *int `pulumi:"monitorId"`
	// A list of monitor tags (up to 25), i.e. tags that are applied directly to monitors to which the downtime applies
	MonitorTags []string `pulumi:"monitorTags"`
	// Optional recurring schedule for this downtime
	Recurrence *DowntimeRecurrence `pulumi:"recurrence"`
	// specify the group scope to which this downtime applies. For everything use '*'
	Scopes []string `pulumi:"scopes"`
	// Specify when this downtime should start
	Start     *int    `pulumi:"start"`
	StartDate *string `pulumi:"startDate"`
	// The timezone for the downtime, default UTC
	Timezone *string `pulumi:"timezone"`
}

type DowntimeState struct {
	// When true indicates this downtime is being actively applied
	Active pulumi.BoolPtrInput
	// When true indicates this downtime is not being applied
	Disabled pulumi.BoolPtrInput
	// Optionally specify an end date when this downtime should expire
	End     pulumi.IntPtrInput
	EndDate pulumi.StringPtrInput
	// An optional message to provide when creating the downtime, can include notification handles
	Message pulumi.StringPtrInput
	// When specified, this downtime will only apply to this monitor
	MonitorId pulumi.IntPtrInput
	// A list of monitor tags (up to 25), i.e. tags that are applied directly to monitors to which the downtime applies
	MonitorTags pulumi.StringArrayInput
	// Optional recurring schedule for this downtime
	Recurrence DowntimeRecurrencePtrInput
	// specify the group scope to which this downtime applies. For everything use '*'
	Scopes pulumi.StringArrayInput
	// Specify when this downtime should start
	Start     pulumi.IntPtrInput
	StartDate pulumi.StringPtrInput
	// The timezone for the downtime, default UTC
	Timezone pulumi.StringPtrInput
}

func (DowntimeState) ElementType() reflect.Type {
	return reflect.TypeOf((*downtimeState)(nil)).Elem()
}

type downtimeArgs struct {
	// When true indicates this downtime is being actively applied
	Active *bool `pulumi:"active"`
	// When true indicates this downtime is not being applied
	Disabled *bool `pulumi:"disabled"`
	// Optionally specify an end date when this downtime should expire
	End     *int    `pulumi:"end"`
	EndDate *string `pulumi:"endDate"`
	// An optional message to provide when creating the downtime, can include notification handles
	Message *string `pulumi:"message"`
	// When specified, this downtime will only apply to this monitor
	MonitorId *int `pulumi:"monitorId"`
	// A list of monitor tags (up to 25), i.e. tags that are applied directly to monitors to which the downtime applies
	MonitorTags []string `pulumi:"monitorTags"`
	// Optional recurring schedule for this downtime
	Recurrence *DowntimeRecurrence `pulumi:"recurrence"`
	// specify the group scope to which this downtime applies. For everything use '*'
	Scopes []string `pulumi:"scopes"`
	// Specify when this downtime should start
	Start     *int    `pulumi:"start"`
	StartDate *string `pulumi:"startDate"`
	// The timezone for the downtime, default UTC
	Timezone *string `pulumi:"timezone"`
}

// The set of arguments for constructing a Downtime resource.
type DowntimeArgs struct {
	// When true indicates this downtime is being actively applied
	Active pulumi.BoolPtrInput
	// When true indicates this downtime is not being applied
	Disabled pulumi.BoolPtrInput
	// Optionally specify an end date when this downtime should expire
	End     pulumi.IntPtrInput
	EndDate pulumi.StringPtrInput
	// An optional message to provide when creating the downtime, can include notification handles
	Message pulumi.StringPtrInput
	// When specified, this downtime will only apply to this monitor
	MonitorId pulumi.IntPtrInput
	// A list of monitor tags (up to 25), i.e. tags that are applied directly to monitors to which the downtime applies
	MonitorTags pulumi.StringArrayInput
	// Optional recurring schedule for this downtime
	Recurrence DowntimeRecurrencePtrInput
	// specify the group scope to which this downtime applies. For everything use '*'
	Scopes pulumi.StringArrayInput
	// Specify when this downtime should start
	Start     pulumi.IntPtrInput
	StartDate pulumi.StringPtrInput
	// The timezone for the downtime, default UTC
	Timezone pulumi.StringPtrInput
}

func (DowntimeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*downtimeArgs)(nil)).Elem()
}

type DowntimeInput interface {
	pulumi.Input

	ToDowntimeOutput() DowntimeOutput
	ToDowntimeOutputWithContext(ctx context.Context) DowntimeOutput
}

func (Downtime) ElementType() reflect.Type {
	return reflect.TypeOf((*Downtime)(nil)).Elem()
}

func (i Downtime) ToDowntimeOutput() DowntimeOutput {
	return i.ToDowntimeOutputWithContext(context.Background())
}

func (i Downtime) ToDowntimeOutputWithContext(ctx context.Context) DowntimeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DowntimeOutput)
}

type DowntimeOutput struct {
	*pulumi.OutputState
}

func (DowntimeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DowntimeOutput)(nil)).Elem()
}

func (o DowntimeOutput) ToDowntimeOutput() DowntimeOutput {
	return o
}

func (o DowntimeOutput) ToDowntimeOutputWithContext(ctx context.Context) DowntimeOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(DowntimeOutput{})
}
