// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Datadog service level objective resource. This can be used to create and manage Datadog service level objectives.
type ServiceLevelObjective struct {
	pulumi.CustomResourceState

	// A description of this service level objective.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// A custom set of groups from the monitor(s) for which to use as the SLI instead of all the groups.
	Groups pulumi.StringArrayOutput `pulumi:"groups"`
	// A list of numeric monitor IDs for which to use as SLIs. Their tags will be auto-imported into `monitorTags` field in the API resource.
	MonitorIds pulumi.IntArrayOutput `pulumi:"monitorIds"`
	// Name of Datadog service level objective
	Name pulumi.StringOutput `pulumi:"name"`
	// The metric query configuration to use for the SLI. This is a dictionary and requires both the `numerator` and `denominator` fields which should be `count` metrics using the `sum` aggregator.
	Query ServiceLevelObjectiveQueryPtrOutput `pulumi:"query"`
	// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	Tags pulumi.StringArrayOutput `pulumi:"tags"`
	// - A list of thresholds and targets that define the service level objectives from the provided SLIs.
	Thresholds ServiceLevelObjectiveThresholdArrayOutput `pulumi:"thresholds"`
	// The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/v1/service-level-objectives/#create-a-slo-object) page. Available options to choose from are:
	// * `metric`
	// * `monitor`
	Type pulumi.StringOutput `pulumi:"type"`
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
	// A description of this service level objective.
	Description *string `pulumi:"description"`
	// A custom set of groups from the monitor(s) for which to use as the SLI instead of all the groups.
	Groups []string `pulumi:"groups"`
	// A list of numeric monitor IDs for which to use as SLIs. Their tags will be auto-imported into `monitorTags` field in the API resource.
	MonitorIds []int `pulumi:"monitorIds"`
	// Name of Datadog service level objective
	Name *string `pulumi:"name"`
	// The metric query configuration to use for the SLI. This is a dictionary and requires both the `numerator` and `denominator` fields which should be `count` metrics using the `sum` aggregator.
	Query *ServiceLevelObjectiveQuery `pulumi:"query"`
	// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	Tags []string `pulumi:"tags"`
	// - A list of thresholds and targets that define the service level objectives from the provided SLIs.
	Thresholds []ServiceLevelObjectiveThreshold `pulumi:"thresholds"`
	// The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/v1/service-level-objectives/#create-a-slo-object) page. Available options to choose from are:
	// * `metric`
	// * `monitor`
	Type *string `pulumi:"type"`
}

type ServiceLevelObjectiveState struct {
	// A description of this service level objective.
	Description pulumi.StringPtrInput
	// A custom set of groups from the monitor(s) for which to use as the SLI instead of all the groups.
	Groups pulumi.StringArrayInput
	// A list of numeric monitor IDs for which to use as SLIs. Their tags will be auto-imported into `monitorTags` field in the API resource.
	MonitorIds pulumi.IntArrayInput
	// Name of Datadog service level objective
	Name pulumi.StringPtrInput
	// The metric query configuration to use for the SLI. This is a dictionary and requires both the `numerator` and `denominator` fields which should be `count` metrics using the `sum` aggregator.
	Query ServiceLevelObjectiveQueryPtrInput
	// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	Tags pulumi.StringArrayInput
	// - A list of thresholds and targets that define the service level objectives from the provided SLIs.
	Thresholds ServiceLevelObjectiveThresholdArrayInput
	// The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/v1/service-level-objectives/#create-a-slo-object) page. Available options to choose from are:
	// * `metric`
	// * `monitor`
	Type pulumi.StringPtrInput
}

func (ServiceLevelObjectiveState) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceLevelObjectiveState)(nil)).Elem()
}

type serviceLevelObjectiveArgs struct {
	// A description of this service level objective.
	Description *string `pulumi:"description"`
	// A custom set of groups from the monitor(s) for which to use as the SLI instead of all the groups.
	Groups []string `pulumi:"groups"`
	// A list of numeric monitor IDs for which to use as SLIs. Their tags will be auto-imported into `monitorTags` field in the API resource.
	MonitorIds []int `pulumi:"monitorIds"`
	// Name of Datadog service level objective
	Name string `pulumi:"name"`
	// The metric query configuration to use for the SLI. This is a dictionary and requires both the `numerator` and `denominator` fields which should be `count` metrics using the `sum` aggregator.
	Query *ServiceLevelObjectiveQuery `pulumi:"query"`
	// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	Tags []string `pulumi:"tags"`
	// - A list of thresholds and targets that define the service level objectives from the provided SLIs.
	Thresholds []ServiceLevelObjectiveThreshold `pulumi:"thresholds"`
	// The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/v1/service-level-objectives/#create-a-slo-object) page. Available options to choose from are:
	// * `metric`
	// * `monitor`
	Type string `pulumi:"type"`
}

// The set of arguments for constructing a ServiceLevelObjective resource.
type ServiceLevelObjectiveArgs struct {
	// A description of this service level objective.
	Description pulumi.StringPtrInput
	// A custom set of groups from the monitor(s) for which to use as the SLI instead of all the groups.
	Groups pulumi.StringArrayInput
	// A list of numeric monitor IDs for which to use as SLIs. Their tags will be auto-imported into `monitorTags` field in the API resource.
	MonitorIds pulumi.IntArrayInput
	// Name of Datadog service level objective
	Name pulumi.StringInput
	// The metric query configuration to use for the SLI. This is a dictionary and requires both the `numerator` and `denominator` fields which should be `count` metrics using the `sum` aggregator.
	Query ServiceLevelObjectiveQueryPtrInput
	// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	Tags pulumi.StringArrayInput
	// - A list of thresholds and targets that define the service level objectives from the provided SLIs.
	Thresholds ServiceLevelObjectiveThresholdArrayInput
	// The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/v1/service-level-objectives/#create-a-slo-object) page. Available options to choose from are:
	// * `metric`
	// * `monitor`
	Type pulumi.StringInput
}

func (ServiceLevelObjectiveArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceLevelObjectiveArgs)(nil)).Elem()
}
