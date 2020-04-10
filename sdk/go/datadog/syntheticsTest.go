// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

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
