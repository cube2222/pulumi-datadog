// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package pagerduty

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/integration_pagerduty.html.markdown.
type Integration struct {
	s *pulumi.ResourceState
}

// NewIntegration registers a new resource with the given unique name, arguments, and options.
func NewIntegration(ctx *pulumi.Context,
	name string, args *IntegrationArgs, opts ...pulumi.ResourceOpt) (*Integration, error) {
	if args == nil || args.Subdomain == nil {
		return nil, errors.New("missing required argument 'Subdomain'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["apiToken"] = nil
		inputs["individualServices"] = nil
		inputs["schedules"] = nil
		inputs["services"] = nil
		inputs["subdomain"] = nil
	} else {
		inputs["apiToken"] = args.ApiToken
		inputs["individualServices"] = args.IndividualServices
		inputs["schedules"] = args.Schedules
		inputs["services"] = args.Services
		inputs["subdomain"] = args.Subdomain
	}
	s, err := ctx.RegisterResource("datadog:pagerduty/integration:Integration", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Integration{s: s}, nil
}

// GetIntegration gets an existing Integration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIntegration(ctx *pulumi.Context,
	name string, id pulumi.ID, state *IntegrationState, opts ...pulumi.ResourceOpt) (*Integration, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["apiToken"] = state.ApiToken
		inputs["individualServices"] = state.IndividualServices
		inputs["schedules"] = state.Schedules
		inputs["services"] = state.Services
		inputs["subdomain"] = state.Subdomain
	}
	s, err := ctx.ReadResource("datadog:pagerduty/integration:Integration", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Integration{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Integration) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Integration) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// Your PagerDuty API token.
func (r *Integration) ApiToken() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["apiToken"])
}

// Boolean to specify whether or not individual service objects specified by [datadog_integration_pagerduty_service_object](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty_service_object.html) resource are to be used. Mutually exclusive with `services` key.
func (r *Integration) IndividualServices() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["individualServices"])
}

// Array of your schedule URLs.
func (r *Integration) Schedules() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["schedules"])
}

// Array of PagerDuty service objects. **Deprecated** The `services` list is now deprecated in favour of [datadog_integration_pagerduty_service_object](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty_service_object.html) resource. Note that `individual_services` must be set to `true` to ignore the `service` attribute and use individual services properly.
func (r *Integration) Services() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["services"])
}

// Your PagerDuty account’s personalized subdomain name.
func (r *Integration) Subdomain() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["subdomain"])
}

// Input properties used for looking up and filtering Integration resources.
type IntegrationState struct {
	// Your PagerDuty API token.
	ApiToken interface{}
	// Boolean to specify whether or not individual service objects specified by [datadog_integration_pagerduty_service_object](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty_service_object.html) resource are to be used. Mutually exclusive with `services` key.
	IndividualServices interface{}
	// Array of your schedule URLs.
	Schedules interface{}
	// Array of PagerDuty service objects. **Deprecated** The `services` list is now deprecated in favour of [datadog_integration_pagerduty_service_object](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty_service_object.html) resource. Note that `individual_services` must be set to `true` to ignore the `service` attribute and use individual services properly.
	Services interface{}
	// Your PagerDuty account’s personalized subdomain name.
	Subdomain interface{}
}

// The set of arguments for constructing a Integration resource.
type IntegrationArgs struct {
	// Your PagerDuty API token.
	ApiToken interface{}
	// Boolean to specify whether or not individual service objects specified by [datadog_integration_pagerduty_service_object](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty_service_object.html) resource are to be used. Mutually exclusive with `services` key.
	IndividualServices interface{}
	// Array of your schedule URLs.
	Schedules interface{}
	// Array of PagerDuty service objects. **Deprecated** The `services` list is now deprecated in favour of [datadog_integration_pagerduty_service_object](https://www.terraform.io/docs/providers/datadog/r/integration_pagerduty_service_object.html) resource. Note that `individual_services` must be set to `true` to ignore the `service` attribute and use individual services properly.
	Services interface{}
	// Your PagerDuty account’s personalized subdomain name.
	Subdomain interface{}
}
