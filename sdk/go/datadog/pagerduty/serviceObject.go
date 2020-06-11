// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package pagerduty

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides access to individual Service Objects of Datadog - PagerDuty integrations. Note that the Datadog - PagerDuty integration must be activated (either manually in the Datadog UI or by using `pagerduty.Integration`) in order for this resource to be usable.
type ServiceObject struct {
	pulumi.CustomResourceState

	// Your Service name associated service key in PagerDuty. Note: Since the Datadog API never returns service keys, it is impossible to detect drifts.
	ServiceKey pulumi.StringOutput `pulumi:"serviceKey"`
	// Your Service name in PagerDuty.
	ServiceName pulumi.StringOutput `pulumi:"serviceName"`
}

// NewServiceObject registers a new resource with the given unique name, arguments, and options.
func NewServiceObject(ctx *pulumi.Context,
	name string, args *ServiceObjectArgs, opts ...pulumi.ResourceOption) (*ServiceObject, error) {
	if args == nil || args.ServiceKey == nil {
		return nil, errors.New("missing required argument 'ServiceKey'")
	}
	if args == nil || args.ServiceName == nil {
		return nil, errors.New("missing required argument 'ServiceName'")
	}
	if args == nil {
		args = &ServiceObjectArgs{}
	}
	var resource ServiceObject
	err := ctx.RegisterResource("datadog:pagerduty/serviceObject:ServiceObject", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServiceObject gets an existing ServiceObject resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServiceObject(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServiceObjectState, opts ...pulumi.ResourceOption) (*ServiceObject, error) {
	var resource ServiceObject
	err := ctx.ReadResource("datadog:pagerduty/serviceObject:ServiceObject", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServiceObject resources.
type serviceObjectState struct {
	// Your Service name associated service key in PagerDuty. Note: Since the Datadog API never returns service keys, it is impossible to detect drifts.
	ServiceKey *string `pulumi:"serviceKey"`
	// Your Service name in PagerDuty.
	ServiceName *string `pulumi:"serviceName"`
}

type ServiceObjectState struct {
	// Your Service name associated service key in PagerDuty. Note: Since the Datadog API never returns service keys, it is impossible to detect drifts.
	ServiceKey pulumi.StringPtrInput
	// Your Service name in PagerDuty.
	ServiceName pulumi.StringPtrInput
}

func (ServiceObjectState) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceObjectState)(nil)).Elem()
}

type serviceObjectArgs struct {
	// Your Service name associated service key in PagerDuty. Note: Since the Datadog API never returns service keys, it is impossible to detect drifts.
	ServiceKey string `pulumi:"serviceKey"`
	// Your Service name in PagerDuty.
	ServiceName string `pulumi:"serviceName"`
}

// The set of arguments for constructing a ServiceObject resource.
type ServiceObjectArgs struct {
	// Your Service name associated service key in PagerDuty. Note: Since the Datadog API never returns service keys, it is impossible to detect drifts.
	ServiceKey pulumi.StringInput
	// Your Service name in PagerDuty.
	ServiceName pulumi.StringInput
}

func (ServiceObjectArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceObjectArgs)(nil)).Elem()
}
