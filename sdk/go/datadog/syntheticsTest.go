// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Datadog synthetics test resource. This can be used to create and manage Datadog synthetics test.
//
// ## Example Usage
// ### Synthetics API Test)
//
// Create a new Datadog Synthetics API/HTTP test on https://www.example.org
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
// 		_, err := datadog.NewSyntheticsTest(ctx, "testApi", &datadog.SyntheticsTestArgs{
// 			Assertions: pulumi.StringMapArray{
// 				pulumi.StringMap{
// 					"operator": pulumi.String("is"),
// 					"target":   pulumi.String("200"),
// 					"type":     pulumi.String("statusCode"),
// 				},
// 			},
// 			Locations: pulumi.StringArray{
// 				pulumi.String("aws:eu-central-1"),
// 			},
// 			Message: pulumi.String("Notify @pagerduty"),
// 			Name:    pulumi.String("An API test on example.org"),
// 			Options: &datadog.SyntheticsTestOptionsArgs{
// 				Tick_every: pulumi.Float64(900),
// 			},
// 			Request: &datadog.SyntheticsTestRequestArgs{
// 				Method: pulumi.String("GET"),
// 				Url:    pulumi.String("https://www.example.org"),
// 			},
// 			RequestHeaders: pulumi.StringMap{
// 				"Authentication": pulumi.String("Token: 1234566789"),
// 				"Content-Type":   pulumi.String("application/json"),
// 			},
// 			Status:  pulumi.String("live"),
// 			Subtype: pulumi.String("http"),
// 			Tags: pulumi.StringArray{
// 				pulumi.String("foo:bar"),
// 				pulumi.String("foo"),
// 				pulumi.String("env:test"),
// 			},
// 			Type: pulumi.String("api"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ### Synthetics SSL Test)
//
// Create a new Datadog Synthetics API/SSL test on example.org
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
// 		_, err := datadog.NewSyntheticsTest(ctx, "testSsl", &datadog.SyntheticsTestArgs{
// 			Assertions: pulumi.MapArray{
// 				pulumi.Map{
// 					"operator": pulumi.String("isInMoreThan"),
// 					"target":   pulumi.Float64(30),
// 					"type":     pulumi.String("certificate"),
// 				},
// 			},
// 			Locations: pulumi.StringArray{
// 				pulumi.String("aws:eu-central-1"),
// 			},
// 			Message: pulumi.String("Notify @pagerduty"),
// 			Name:    pulumi.String("An API test on example.org"),
// 			Options: &datadog.SyntheticsTestOptionsArgs{
// 				Accept_self_signed: pulumi.Bool(true),
// 				Tick_every:         pulumi.Float64(900),
// 			},
// 			Request: &datadog.SyntheticsTestRequestArgs{
// 				Host: pulumi.String("example.org"),
// 				Port: pulumi.Int(443),
// 			},
// 			Status:  pulumi.String("live"),
// 			Subtype: pulumi.String("ssl"),
// 			Tags: pulumi.StringArray{
// 				pulumi.String("foo:bar"),
// 				pulumi.String("foo"),
// 				pulumi.String("env:test"),
// 			},
// 			Type: pulumi.String("api"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ### Synthetics Browser Test)
//
// Support for Synthetics Browser test is limited (see below)
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
// 		_, err := datadog.NewSyntheticsTest(ctx, "testBrowser", &datadog.SyntheticsTestArgs{
// 			DeviceIds: pulumi.StringArray{
// 				pulumi.String("laptop_large"),
// 			},
// 			Locations: pulumi.StringArray{
// 				pulumi.String("aws:eu-central-1"),
// 			},
// 			Message: pulumi.String("Notify @qa"),
// 			Name:    pulumi.String("A Browser test on example.org"),
// 			Options: &datadog.SyntheticsTestOptionsArgs{
// 				Tick_every: pulumi.Float64(3600),
// 			},
// 			Request: &datadog.SyntheticsTestRequestArgs{
// 				Method: pulumi.String("GET"),
// 				Url:    pulumi.String("https://app.datadoghq.com"),
// 			},
// 			Status: pulumi.String("paused"),
// 			Tags:   []interface{}{},
// 			Type:   pulumi.String("browser"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ## Synthetics Browser test
//
// Support for Synthetics Browser test is limited to creating shallow Synthetics Browser test (cf. example usage below)
//
// You cannot create/edit/delete steps or assertions via this provider unless you use [Datadog WebUI](https://app.datadoghq.com/synthetics/list) in conjunction with the provider.
//
// We are considering adding support for Synthetics Browser test steps and assertions in the future but can't share any release date on that matter.
type SyntheticsTest struct {
	pulumi.CustomResourceState

	Assertions     pulumi.MapArrayOutput          `pulumi:"assertions"`
	DeviceIds      pulumi.StringArrayOutput       `pulumi:"deviceIds"`
	Locations      pulumi.StringArrayOutput       `pulumi:"locations"`
	Message        pulumi.StringPtrOutput         `pulumi:"message"`
	MonitorId      pulumi.IntOutput               `pulumi:"monitorId"`
	Name           pulumi.StringOutput            `pulumi:"name"`
	Options        SyntheticsTestOptionsPtrOutput `pulumi:"options"`
	Request        SyntheticsTestRequestOutput    `pulumi:"request"`
	RequestHeaders pulumi.MapOutput               `pulumi:"requestHeaders"`
	Status         pulumi.StringOutput            `pulumi:"status"`
	Subtype        pulumi.StringPtrOutput         `pulumi:"subtype"`
	Tags           pulumi.StringArrayOutput       `pulumi:"tags"`
	Type           pulumi.StringOutput            `pulumi:"type"`
}

// NewSyntheticsTest registers a new resource with the given unique name, arguments, and options.
func NewSyntheticsTest(ctx *pulumi.Context,
	name string, args *SyntheticsTestArgs, opts ...pulumi.ResourceOption) (*SyntheticsTest, error) {
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
	if args == nil {
		args = &SyntheticsTestArgs{}
	}
	var resource SyntheticsTest
	err := ctx.RegisterResource("datadog:index/syntheticsTest:SyntheticsTest", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSyntheticsTest gets an existing SyntheticsTest resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSyntheticsTest(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SyntheticsTestState, opts ...pulumi.ResourceOption) (*SyntheticsTest, error) {
	var resource SyntheticsTest
	err := ctx.ReadResource("datadog:index/syntheticsTest:SyntheticsTest", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SyntheticsTest resources.
type syntheticsTestState struct {
	Assertions     []map[string]interface{} `pulumi:"assertions"`
	DeviceIds      []string                 `pulumi:"deviceIds"`
	Locations      []string                 `pulumi:"locations"`
	Message        *string                  `pulumi:"message"`
	MonitorId      *int                     `pulumi:"monitorId"`
	Name           *string                  `pulumi:"name"`
	Options        *SyntheticsTestOptions   `pulumi:"options"`
	Request        *SyntheticsTestRequest   `pulumi:"request"`
	RequestHeaders map[string]interface{}   `pulumi:"requestHeaders"`
	Status         *string                  `pulumi:"status"`
	Subtype        *string                  `pulumi:"subtype"`
	Tags           []string                 `pulumi:"tags"`
	Type           *string                  `pulumi:"type"`
}

type SyntheticsTestState struct {
	Assertions     pulumi.MapArrayInput
	DeviceIds      pulumi.StringArrayInput
	Locations      pulumi.StringArrayInput
	Message        pulumi.StringPtrInput
	MonitorId      pulumi.IntPtrInput
	Name           pulumi.StringPtrInput
	Options        SyntheticsTestOptionsPtrInput
	Request        SyntheticsTestRequestPtrInput
	RequestHeaders pulumi.MapInput
	Status         pulumi.StringPtrInput
	Subtype        pulumi.StringPtrInput
	Tags           pulumi.StringArrayInput
	Type           pulumi.StringPtrInput
}

func (SyntheticsTestState) ElementType() reflect.Type {
	return reflect.TypeOf((*syntheticsTestState)(nil)).Elem()
}

type syntheticsTestArgs struct {
	Assertions     []map[string]interface{} `pulumi:"assertions"`
	DeviceIds      []string                 `pulumi:"deviceIds"`
	Locations      []string                 `pulumi:"locations"`
	Message        *string                  `pulumi:"message"`
	Name           string                   `pulumi:"name"`
	Options        *SyntheticsTestOptions   `pulumi:"options"`
	Request        SyntheticsTestRequest    `pulumi:"request"`
	RequestHeaders map[string]interface{}   `pulumi:"requestHeaders"`
	Status         string                   `pulumi:"status"`
	Subtype        *string                  `pulumi:"subtype"`
	Tags           []string                 `pulumi:"tags"`
	Type           string                   `pulumi:"type"`
}

// The set of arguments for constructing a SyntheticsTest resource.
type SyntheticsTestArgs struct {
	Assertions     pulumi.MapArrayInput
	DeviceIds      pulumi.StringArrayInput
	Locations      pulumi.StringArrayInput
	Message        pulumi.StringPtrInput
	Name           pulumi.StringInput
	Options        SyntheticsTestOptionsPtrInput
	Request        SyntheticsTestRequestInput
	RequestHeaders pulumi.MapInput
	Status         pulumi.StringInput
	Subtype        pulumi.StringPtrInput
	Tags           pulumi.StringArrayInput
	Type           pulumi.StringInput
}

func (SyntheticsTestArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*syntheticsTestArgs)(nil)).Elem()
}
