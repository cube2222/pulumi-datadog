// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Datadog service level objective resource. This can be used to create and manage Datadog service level objectives.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/service_level_objective.html.markdown.
type ServiceLevelObjective struct {
	s *pulumi.ResourceState
}

// NewServiceLevelObjective registers a new resource with the given unique name, arguments, and options.
func NewServiceLevelObjective(ctx *pulumi.Context,
	name string, args *ServiceLevelObjectiveArgs, opts ...pulumi.ResourceOpt) (*ServiceLevelObjective, error) {
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.Thresholds == nil {
		return nil, errors.New("missing required argument 'Thresholds'")
	}
	if args == nil || args.Type == nil {
		return nil, errors.New("missing required argument 'Type'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["description"] = nil
		inputs["groups"] = nil
		inputs["monitorIds"] = nil
		inputs["monitorSearch"] = nil
		inputs["name"] = nil
		inputs["query"] = nil
		inputs["tags"] = nil
		inputs["thresholds"] = nil
		inputs["type"] = nil
	} else {
		inputs["description"] = args.Description
		inputs["groups"] = args.Groups
		inputs["monitorIds"] = args.MonitorIds
		inputs["monitorSearch"] = args.MonitorSearch
		inputs["name"] = args.Name
		inputs["query"] = args.Query
		inputs["tags"] = args.Tags
		inputs["thresholds"] = args.Thresholds
		inputs["type"] = args.Type
	}
	s, err := ctx.RegisterResource("datadog:index/serviceLevelObjective:ServiceLevelObjective", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ServiceLevelObjective{s: s}, nil
}

// GetServiceLevelObjective gets an existing ServiceLevelObjective resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServiceLevelObjective(ctx *pulumi.Context,
	name string, id pulumi.ID, state *ServiceLevelObjectiveState, opts ...pulumi.ResourceOpt) (*ServiceLevelObjective, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["description"] = state.Description
		inputs["groups"] = state.Groups
		inputs["monitorIds"] = state.MonitorIds
		inputs["monitorSearch"] = state.MonitorSearch
		inputs["name"] = state.Name
		inputs["query"] = state.Query
		inputs["tags"] = state.Tags
		inputs["thresholds"] = state.Thresholds
		inputs["type"] = state.Type
	}
	s, err := ctx.ReadResource("datadog:index/serviceLevelObjective:ServiceLevelObjective", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ServiceLevelObjective{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *ServiceLevelObjective) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *ServiceLevelObjective) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// A description of this service level objective.
func (r *ServiceLevelObjective) Description() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["description"])
}

// A custom set of groups from the monitor(s) for which to use as the SLI instead of all the groups.
func (r *ServiceLevelObjective) Groups() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["groups"])
}

// A list of numeric monitor IDs for which to use as SLIs. Their tags will be auto-imported into `monitorTags` field in the API resource. At least 1 of `monitorIds` or `monitorSearch` must be provided.
func (r *ServiceLevelObjective) MonitorIds() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["monitorIds"])
}

// The monitor query search used on the monitor search API to add monitorIds by searching. Their tags will be auto-imported into `monitorTags` field in the API resource. At least 1 of `monitorIds` or `monitorSearch` must be provided.
func (r *ServiceLevelObjective) MonitorSearch() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["monitorSearch"])
}

// Name of Datadog service level objective
func (r *ServiceLevelObjective) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The metric query configuration to use for the SLI. This is a dictionary and requires both the `numerator` and `denominator` fields which should be `count` metrics using the `sum` aggregator.
func (r *ServiceLevelObjective) Query() *pulumi.Output {
	return r.s.State["query"]
}

// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
func (r *ServiceLevelObjective) Tags() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["tags"])
}

// - A list of thresholds and targets that define the service level objectives from the provided SLIs.
func (r *ServiceLevelObjective) Thresholds() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["thresholds"])
}

// The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/?lang=python#create-a-service-level-objective) page. Available options to choose from are:
// * `metric`
// * `monitor`
func (r *ServiceLevelObjective) Type() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["type"])
}

// Input properties used for looking up and filtering ServiceLevelObjective resources.
type ServiceLevelObjectiveState struct {
	// A description of this service level objective.
	Description interface{}
	// A custom set of groups from the monitor(s) for which to use as the SLI instead of all the groups.
	Groups interface{}
	// A list of numeric monitor IDs for which to use as SLIs. Their tags will be auto-imported into `monitorTags` field in the API resource. At least 1 of `monitorIds` or `monitorSearch` must be provided.
	MonitorIds interface{}
	// The monitor query search used on the monitor search API to add monitorIds by searching. Their tags will be auto-imported into `monitorTags` field in the API resource. At least 1 of `monitorIds` or `monitorSearch` must be provided.
	MonitorSearch interface{}
	// Name of Datadog service level objective
	Name interface{}
	// The metric query configuration to use for the SLI. This is a dictionary and requires both the `numerator` and `denominator` fields which should be `count` metrics using the `sum` aggregator.
	Query interface{}
	// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	Tags interface{}
	// - A list of thresholds and targets that define the service level objectives from the provided SLIs.
	Thresholds interface{}
	// The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/?lang=python#create-a-service-level-objective) page. Available options to choose from are:
	// * `metric`
	// * `monitor`
	Type interface{}
}

// The set of arguments for constructing a ServiceLevelObjective resource.
type ServiceLevelObjectiveArgs struct {
	// A description of this service level objective.
	Description interface{}
	// A custom set of groups from the monitor(s) for which to use as the SLI instead of all the groups.
	Groups interface{}
	// A list of numeric monitor IDs for which to use as SLIs. Their tags will be auto-imported into `monitorTags` field in the API resource. At least 1 of `monitorIds` or `monitorSearch` must be provided.
	MonitorIds interface{}
	// The monitor query search used on the monitor search API to add monitorIds by searching. Their tags will be auto-imported into `monitorTags` field in the API resource. At least 1 of `monitorIds` or `monitorSearch` must be provided.
	MonitorSearch interface{}
	// Name of Datadog service level objective
	Name interface{}
	// The metric query configuration to use for the SLI. This is a dictionary and requires both the `numerator` and `denominator` fields which should be `count` metrics using the `sum` aggregator.
	Query interface{}
	// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
	Tags interface{}
	// - A list of thresholds and targets that define the service level objectives from the provided SLIs.
	Thresholds interface{}
	// The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/?lang=python#create-a-service-level-objective) page. Available options to choose from are:
	// * `metric`
	// * `monitor`
	Type interface{}
}