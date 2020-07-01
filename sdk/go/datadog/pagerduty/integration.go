// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package pagerduty

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Datadog - PagerDuty resource. This can be used to create and manage Datadog - PagerDuty integration.
//
// ## Example Usage
// ### Services as Individual Resources
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-datadog/sdk/v2/go/datadog/pagerduty"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := pagerduty.NewIntegration(ctx, "pd", &pagerduty.IntegrationArgs{
// 			ApiToken:           pulumi.String("38457822378273432587234242874"),
// 			IndividualServices: pulumi.Bool(true),
// 			Schedules: pulumi.StringArray{
// 				pulumi.String("https://ddog.pagerduty.com/schedules/X123VF"),
// 				pulumi.String("https://ddog.pagerduty.com/schedules/X321XX"),
// 			},
// 			Subdomain: pulumi.String("ddog"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = pagerduty.NewServiceObject(ctx, "testingFoo", &pagerduty.ServiceObjectArgs{
// 			ServiceKey:  pulumi.String("9876543210123456789"),
// 			ServiceName: pulumi.String("testing_foo"),
// 		}, pulumi.DependsOn([]pulumi.Resource{
// 			"datadog_integration_pagerduty.pd",
// 		}))
// 		if err != nil {
// 			return err
// 		}
// 		_, err = pagerduty.NewServiceObject(ctx, "testingBar", &pagerduty.ServiceObjectArgs{
// 			ServiceKey:  pulumi.String("54321098765432109876"),
// 			ServiceName: pulumi.String("testing_bar"),
// 		}, pulumi.DependsOn([]pulumi.Resource{
// 			"datadog_integration_pagerduty.pd",
// 		}))
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type Integration struct {
	pulumi.CustomResourceState

	// Your PagerDuty API token.
	ApiToken pulumi.StringPtrOutput `pulumi:"apiToken"`
	// Boolean to specify whether or not individual service objects specified by `pagerduty.ServiceObject` resource are to be used. Mutually exclusive with `services` key.
	IndividualServices pulumi.BoolPtrOutput `pulumi:"individualServices"`
	// Array of your schedule URLs.
	Schedules pulumi.StringArrayOutput `pulumi:"schedules"`
	// Array of PagerDuty service objects. **Deprecated** The `services` list is now deprecated in favour of `pagerduty.ServiceObject` resource. Note that `individualServices` must be set to `true` to ignore the `service` attribute and use individual services properly.
	//
	// Deprecated: set "individual_services" to true and use datadog_pagerduty_integration_service_object
	Services IntegrationServiceArrayOutput `pulumi:"services"`
	// Your PagerDuty account’s personalized subdomain name.
	Subdomain pulumi.StringOutput `pulumi:"subdomain"`
}

// NewIntegration registers a new resource with the given unique name, arguments, and options.
func NewIntegration(ctx *pulumi.Context,
	name string, args *IntegrationArgs, opts ...pulumi.ResourceOption) (*Integration, error) {
	if args == nil || args.Subdomain == nil {
		return nil, errors.New("missing required argument 'Subdomain'")
	}
	if args == nil {
		args = &IntegrationArgs{}
	}
	var resource Integration
	err := ctx.RegisterResource("datadog:pagerduty/integration:Integration", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIntegration gets an existing Integration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIntegration(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IntegrationState, opts ...pulumi.ResourceOption) (*Integration, error) {
	var resource Integration
	err := ctx.ReadResource("datadog:pagerduty/integration:Integration", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Integration resources.
type integrationState struct {
	// Your PagerDuty API token.
	ApiToken *string `pulumi:"apiToken"`
	// Boolean to specify whether or not individual service objects specified by `pagerduty.ServiceObject` resource are to be used. Mutually exclusive with `services` key.
	IndividualServices *bool `pulumi:"individualServices"`
	// Array of your schedule URLs.
	Schedules []string `pulumi:"schedules"`
	// Array of PagerDuty service objects. **Deprecated** The `services` list is now deprecated in favour of `pagerduty.ServiceObject` resource. Note that `individualServices` must be set to `true` to ignore the `service` attribute and use individual services properly.
	//
	// Deprecated: set "individual_services" to true and use datadog_pagerduty_integration_service_object
	Services []IntegrationService `pulumi:"services"`
	// Your PagerDuty account’s personalized subdomain name.
	Subdomain *string `pulumi:"subdomain"`
}

type IntegrationState struct {
	// Your PagerDuty API token.
	ApiToken pulumi.StringPtrInput
	// Boolean to specify whether or not individual service objects specified by `pagerduty.ServiceObject` resource are to be used. Mutually exclusive with `services` key.
	IndividualServices pulumi.BoolPtrInput
	// Array of your schedule URLs.
	Schedules pulumi.StringArrayInput
	// Array of PagerDuty service objects. **Deprecated** The `services` list is now deprecated in favour of `pagerduty.ServiceObject` resource. Note that `individualServices` must be set to `true` to ignore the `service` attribute and use individual services properly.
	//
	// Deprecated: set "individual_services" to true and use datadog_pagerduty_integration_service_object
	Services IntegrationServiceArrayInput
	// Your PagerDuty account’s personalized subdomain name.
	Subdomain pulumi.StringPtrInput
}

func (IntegrationState) ElementType() reflect.Type {
	return reflect.TypeOf((*integrationState)(nil)).Elem()
}

type integrationArgs struct {
	// Your PagerDuty API token.
	ApiToken *string `pulumi:"apiToken"`
	// Boolean to specify whether or not individual service objects specified by `pagerduty.ServiceObject` resource are to be used. Mutually exclusive with `services` key.
	IndividualServices *bool `pulumi:"individualServices"`
	// Array of your schedule URLs.
	Schedules []string `pulumi:"schedules"`
	// Array of PagerDuty service objects. **Deprecated** The `services` list is now deprecated in favour of `pagerduty.ServiceObject` resource. Note that `individualServices` must be set to `true` to ignore the `service` attribute and use individual services properly.
	//
	// Deprecated: set "individual_services" to true and use datadog_pagerduty_integration_service_object
	Services []IntegrationService `pulumi:"services"`
	// Your PagerDuty account’s personalized subdomain name.
	Subdomain string `pulumi:"subdomain"`
}

// The set of arguments for constructing a Integration resource.
type IntegrationArgs struct {
	// Your PagerDuty API token.
	ApiToken pulumi.StringPtrInput
	// Boolean to specify whether or not individual service objects specified by `pagerduty.ServiceObject` resource are to be used. Mutually exclusive with `services` key.
	IndividualServices pulumi.BoolPtrInput
	// Array of your schedule URLs.
	Schedules pulumi.StringArrayInput
	// Array of PagerDuty service objects. **Deprecated** The `services` list is now deprecated in favour of `pagerduty.ServiceObject` resource. Note that `individualServices` must be set to `true` to ignore the `service` attribute and use individual services properly.
	//
	// Deprecated: set "individual_services" to true and use datadog_pagerduty_integration_service_object
	Services IntegrationServiceArrayInput
	// Your PagerDuty account’s personalized subdomain name.
	Subdomain pulumi.StringInput
}

func (IntegrationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*integrationArgs)(nil)).Elem()
}
