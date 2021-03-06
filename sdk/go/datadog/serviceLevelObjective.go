// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"context"
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
// 	"github.com/pulumi/pulumi-datadog/sdk/v2/go/datadog/"
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
//
// ## Import
//
// Service Level Objectives can be imported using their string ID, e.g.
//
// ```sh
//  $ pulumi import datadog:index/serviceLevelObjective:ServiceLevelObjective baz 12345678901234567890123456789012
// ```
type ServiceLevelObjective struct {
	pulumi.CustomResourceState

	// A description of this service level objective.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// A boolean indicating whether this monitor can be deleted even if it’s referenced by other resources (e.g. dashboards).
	// -   `thresholds`: (Required) - A list of thresholds and targets that define the service level objectives from the provided SLIs.
	ForceDelete pulumi.BoolPtrOutput `pulumi:"forceDelete"`
	// A static set of groups to filter monitor-based SLOs
	Groups pulumi.StringArrayOutput `pulumi:"groups"`
	// A static set of monitor IDs to use as part of the SLO
	MonitorIds pulumi.IntArrayOutput `pulumi:"monitorIds"`
	// Name of Datadog service level objective
	Name pulumi.StringOutput `pulumi:"name"`
	// The metric query of good / total events
	Query ServiceLevelObjectiveQueryPtrOutput `pulumi:"query"`
	// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	Tags pulumi.StringArrayOutput `pulumi:"tags"`
	// A list of thresholds and targets that define the service level objectives from the provided SLIs.
	Thresholds ServiceLevelObjectiveThresholdArrayOutput `pulumi:"thresholds"`
	// The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be
	// found in the Datadog API [documentation
	// page](https://docs.datadoghq.com/api/v1/service-level-objectives/#create-a-slo-object). Available options to choose from
	// are: `metric` and `monitor`.
	Type pulumi.StringOutput `pulumi:"type"`
	// Whether or not to validate the SLO.
	Validate pulumi.BoolPtrOutput `pulumi:"validate"`
}

// NewServiceLevelObjective registers a new resource with the given unique name, arguments, and options.
func NewServiceLevelObjective(ctx *pulumi.Context,
	name string, args *ServiceLevelObjectiveArgs, opts ...pulumi.ResourceOption) (*ServiceLevelObjective, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.Thresholds == nil {
		return nil, errors.New("invalid value for required argument 'Thresholds'")
	}
	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
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
	// A description of this service level objective.
	Description *string `pulumi:"description"`
	// A boolean indicating whether this monitor can be deleted even if it’s referenced by other resources (e.g. dashboards).
	// -   `thresholds`: (Required) - A list of thresholds and targets that define the service level objectives from the provided SLIs.
	ForceDelete *bool `pulumi:"forceDelete"`
	// A static set of groups to filter monitor-based SLOs
	Groups []string `pulumi:"groups"`
	// A static set of monitor IDs to use as part of the SLO
	MonitorIds []int `pulumi:"monitorIds"`
	// Name of Datadog service level objective
	Name *string `pulumi:"name"`
	// The metric query of good / total events
	Query *ServiceLevelObjectiveQuery `pulumi:"query"`
	// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	Tags []string `pulumi:"tags"`
	// A list of thresholds and targets that define the service level objectives from the provided SLIs.
	Thresholds []ServiceLevelObjectiveThreshold `pulumi:"thresholds"`
	// The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be
	// found in the Datadog API [documentation
	// page](https://docs.datadoghq.com/api/v1/service-level-objectives/#create-a-slo-object). Available options to choose from
	// are: `metric` and `monitor`.
	Type *string `pulumi:"type"`
	// Whether or not to validate the SLO.
	Validate *bool `pulumi:"validate"`
}

type ServiceLevelObjectiveState struct {
	// A description of this service level objective.
	Description pulumi.StringPtrInput
	// A boolean indicating whether this monitor can be deleted even if it’s referenced by other resources (e.g. dashboards).
	// -   `thresholds`: (Required) - A list of thresholds and targets that define the service level objectives from the provided SLIs.
	ForceDelete pulumi.BoolPtrInput
	// A static set of groups to filter monitor-based SLOs
	Groups pulumi.StringArrayInput
	// A static set of monitor IDs to use as part of the SLO
	MonitorIds pulumi.IntArrayInput
	// Name of Datadog service level objective
	Name pulumi.StringPtrInput
	// The metric query of good / total events
	Query ServiceLevelObjectiveQueryPtrInput
	// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	Tags pulumi.StringArrayInput
	// A list of thresholds and targets that define the service level objectives from the provided SLIs.
	Thresholds ServiceLevelObjectiveThresholdArrayInput
	// The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be
	// found in the Datadog API [documentation
	// page](https://docs.datadoghq.com/api/v1/service-level-objectives/#create-a-slo-object). Available options to choose from
	// are: `metric` and `monitor`.
	Type pulumi.StringPtrInput
	// Whether or not to validate the SLO.
	Validate pulumi.BoolPtrInput
}

func (ServiceLevelObjectiveState) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceLevelObjectiveState)(nil)).Elem()
}

type serviceLevelObjectiveArgs struct {
	// A description of this service level objective.
	Description *string `pulumi:"description"`
	// A boolean indicating whether this monitor can be deleted even if it’s referenced by other resources (e.g. dashboards).
	// -   `thresholds`: (Required) - A list of thresholds and targets that define the service level objectives from the provided SLIs.
	ForceDelete *bool `pulumi:"forceDelete"`
	// A static set of groups to filter monitor-based SLOs
	Groups []string `pulumi:"groups"`
	// A static set of monitor IDs to use as part of the SLO
	MonitorIds []int `pulumi:"monitorIds"`
	// Name of Datadog service level objective
	Name string `pulumi:"name"`
	// The metric query of good / total events
	Query *ServiceLevelObjectiveQuery `pulumi:"query"`
	// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	Tags []string `pulumi:"tags"`
	// A list of thresholds and targets that define the service level objectives from the provided SLIs.
	Thresholds []ServiceLevelObjectiveThreshold `pulumi:"thresholds"`
	// The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be
	// found in the Datadog API [documentation
	// page](https://docs.datadoghq.com/api/v1/service-level-objectives/#create-a-slo-object). Available options to choose from
	// are: `metric` and `monitor`.
	Type string `pulumi:"type"`
	// Whether or not to validate the SLO.
	Validate *bool `pulumi:"validate"`
}

// The set of arguments for constructing a ServiceLevelObjective resource.
type ServiceLevelObjectiveArgs struct {
	// A description of this service level objective.
	Description pulumi.StringPtrInput
	// A boolean indicating whether this monitor can be deleted even if it’s referenced by other resources (e.g. dashboards).
	// -   `thresholds`: (Required) - A list of thresholds and targets that define the service level objectives from the provided SLIs.
	ForceDelete pulumi.BoolPtrInput
	// A static set of groups to filter monitor-based SLOs
	Groups pulumi.StringArrayInput
	// A static set of monitor IDs to use as part of the SLO
	MonitorIds pulumi.IntArrayInput
	// Name of Datadog service level objective
	Name pulumi.StringInput
	// The metric query of good / total events
	Query ServiceLevelObjectiveQueryPtrInput
	// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	Tags pulumi.StringArrayInput
	// A list of thresholds and targets that define the service level objectives from the provided SLIs.
	Thresholds ServiceLevelObjectiveThresholdArrayInput
	// The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be
	// found in the Datadog API [documentation
	// page](https://docs.datadoghq.com/api/v1/service-level-objectives/#create-a-slo-object). Available options to choose from
	// are: `metric` and `monitor`.
	Type pulumi.StringInput
	// Whether or not to validate the SLO.
	Validate pulumi.BoolPtrInput
}

func (ServiceLevelObjectiveArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceLevelObjectiveArgs)(nil)).Elem()
}

type ServiceLevelObjectiveInput interface {
	pulumi.Input

	ToServiceLevelObjectiveOutput() ServiceLevelObjectiveOutput
	ToServiceLevelObjectiveOutputWithContext(ctx context.Context) ServiceLevelObjectiveOutput
}

func (*ServiceLevelObjective) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceLevelObjective)(nil))
}

func (i *ServiceLevelObjective) ToServiceLevelObjectiveOutput() ServiceLevelObjectiveOutput {
	return i.ToServiceLevelObjectiveOutputWithContext(context.Background())
}

func (i *ServiceLevelObjective) ToServiceLevelObjectiveOutputWithContext(ctx context.Context) ServiceLevelObjectiveOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceLevelObjectiveOutput)
}

type ServiceLevelObjectiveOutput struct {
	*pulumi.OutputState
}

func (ServiceLevelObjectiveOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceLevelObjective)(nil))
}

func (o ServiceLevelObjectiveOutput) ToServiceLevelObjectiveOutput() ServiceLevelObjectiveOutput {
	return o
}

func (o ServiceLevelObjectiveOutput) ToServiceLevelObjectiveOutputWithContext(ctx context.Context) ServiceLevelObjectiveOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ServiceLevelObjectiveOutput{})
}
