// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Datadog service level objective resource. This can be used to create and manage Datadog service level objectives.
//
// ## Example Usage
// ### Metric-Based SLO
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
// 		_, err := datadog.NewServiceLevelObjective(ctx, "foo", &datadog.ServiceLevelObjectiveArgs{
// 			Description: pulumi.String("My custom metric SLO"),
// 			Name:        pulumi.String("Example Metric SLO"),
// 			Query: &datadog.ServiceLevelObjectiveQueryArgs{
// 				Denominator: pulumi.String("sum:my.custom.count.metric{*}.as_count()"),
// 				Numerator:   pulumi.String("sum:my.custom.count.metric{type:good_events}.as_count()"),
// 			},
// 			Tags: pulumi.StringArray{
// 				pulumi.String("foo:bar"),
// 				pulumi.String("baz"),
// 			},
// 			Thresholds: datadog.ServiceLevelObjectiveThresholdArray{
// 				&datadog.ServiceLevelObjectiveThresholdArgs{
// 					Target:         pulumi.Float64(99.9),
// 					TargetDisplay:  pulumi.String("99.900"),
// 					Timeframe:      pulumi.String("7d"),
// 					Warning:        pulumi.Float64(99.99),
// 					WarningDisplay: pulumi.String("99.990"),
// 				},
// 				&datadog.ServiceLevelObjectiveThresholdArgs{
// 					Target:         pulumi.Float64(99.9),
// 					TargetDisplay:  pulumi.String("99.900"),
// 					Timeframe:      pulumi.String("30d"),
// 					Warning:        pulumi.Float64(99.99),
// 					WarningDisplay: pulumi.String("99.990"),
// 				},
// 			},
// 			Type: pulumi.String("metric"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type ServiceLevelObjective struct {
	pulumi.CustomResourceState

	Description pulumi.StringPtrOutput `pulumi:"description"`
	// A static set of groups to filter monitor-based SLOs
	Groups pulumi.StringArrayOutput `pulumi:"groups"`
	// A static set of monitor IDs to use as part of the SLO
	MonitorIds pulumi.IntArrayOutput `pulumi:"monitorIds"`
	Name       pulumi.StringOutput   `pulumi:"name"`
	// The metric query of good / total events
	Query ServiceLevelObjectiveQueryPtrOutput `pulumi:"query"`
	// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	// - `thresholds`: (Required) - A list of thresholds and targets that define the service level objectives from the provided SLIs.
	Tags       pulumi.StringArrayOutput                  `pulumi:"tags"`
	Thresholds ServiceLevelObjectiveThresholdArrayOutput `pulumi:"thresholds"`
	Type       pulumi.StringOutput                       `pulumi:"type"`
	Validate   pulumi.BoolPtrOutput                      `pulumi:"validate"`
}

// NewServiceLevelObjective registers a new resource with the given unique name, arguments, and options.
func NewServiceLevelObjective(ctx *pulumi.Context,
	name string, args *ServiceLevelObjectiveArgs, opts ...pulumi.ResourceOption) (*ServiceLevelObjective, error) {
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.Thresholds == nil {
		return nil, errors.New("missing required argument 'Thresholds'")
	}
	if args == nil || args.Type == nil {
		return nil, errors.New("missing required argument 'Type'")
	}
	if args == nil {
		args = &ServiceLevelObjectiveArgs{}
	}
	var resource ServiceLevelObjective
	err := ctx.RegisterResource("datadog:index/serviceLevelObjective:ServiceLevelObjective", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServiceLevelObjective gets an existing ServiceLevelObjective resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServiceLevelObjective(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServiceLevelObjectiveState, opts ...pulumi.ResourceOption) (*ServiceLevelObjective, error) {
	var resource ServiceLevelObjective
	err := ctx.ReadResource("datadog:index/serviceLevelObjective:ServiceLevelObjective", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServiceLevelObjective resources.
type serviceLevelObjectiveState struct {
	Description *string `pulumi:"description"`
	// A static set of groups to filter monitor-based SLOs
	Groups []string `pulumi:"groups"`
	// A static set of monitor IDs to use as part of the SLO
	MonitorIds []int   `pulumi:"monitorIds"`
	Name       *string `pulumi:"name"`
	// The metric query of good / total events
	Query *ServiceLevelObjectiveQuery `pulumi:"query"`
	// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	// - `thresholds`: (Required) - A list of thresholds and targets that define the service level objectives from the provided SLIs.
	Tags       []string                         `pulumi:"tags"`
	Thresholds []ServiceLevelObjectiveThreshold `pulumi:"thresholds"`
	Type       *string                          `pulumi:"type"`
	Validate   *bool                            `pulumi:"validate"`
}

type ServiceLevelObjectiveState struct {
	Description pulumi.StringPtrInput
	// A static set of groups to filter monitor-based SLOs
	Groups pulumi.StringArrayInput
	// A static set of monitor IDs to use as part of the SLO
	MonitorIds pulumi.IntArrayInput
	Name       pulumi.StringPtrInput
	// The metric query of good / total events
	Query ServiceLevelObjectiveQueryPtrInput
	// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	// - `thresholds`: (Required) - A list of thresholds and targets that define the service level objectives from the provided SLIs.
	Tags       pulumi.StringArrayInput
	Thresholds ServiceLevelObjectiveThresholdArrayInput
	Type       pulumi.StringPtrInput
	Validate   pulumi.BoolPtrInput
}

func (ServiceLevelObjectiveState) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceLevelObjectiveState)(nil)).Elem()
}

type serviceLevelObjectiveArgs struct {
	Description *string `pulumi:"description"`
	// A static set of groups to filter monitor-based SLOs
	Groups []string `pulumi:"groups"`
	// A static set of monitor IDs to use as part of the SLO
	MonitorIds []int  `pulumi:"monitorIds"`
	Name       string `pulumi:"name"`
	// The metric query of good / total events
	Query *ServiceLevelObjectiveQuery `pulumi:"query"`
	// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	// - `thresholds`: (Required) - A list of thresholds and targets that define the service level objectives from the provided SLIs.
	Tags       []string                         `pulumi:"tags"`
	Thresholds []ServiceLevelObjectiveThreshold `pulumi:"thresholds"`
	Type       string                           `pulumi:"type"`
	Validate   *bool                            `pulumi:"validate"`
}

// The set of arguments for constructing a ServiceLevelObjective resource.
type ServiceLevelObjectiveArgs struct {
	Description pulumi.StringPtrInput
	// A static set of groups to filter monitor-based SLOs
	Groups pulumi.StringArrayInput
	// A static set of monitor IDs to use as part of the SLO
	MonitorIds pulumi.IntArrayInput
	Name       pulumi.StringInput
	// The metric query of good / total events
	Query ServiceLevelObjectiveQueryPtrInput
	// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	// - `thresholds`: (Required) - A list of thresholds and targets that define the service level objectives from the provided SLIs.
	Tags       pulumi.StringArrayInput
	Thresholds ServiceLevelObjectiveThresholdArrayInput
	Type       pulumi.StringInput
	Validate   pulumi.BoolPtrInput
}

func (ServiceLevelObjectiveArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceLevelObjectiveArgs)(nil)).Elem()
}
