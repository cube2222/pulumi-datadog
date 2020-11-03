// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package pagerduty

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type IntegrationService struct {
	ServiceKey  string `pulumi:"serviceKey"`
	ServiceName string `pulumi:"serviceName"`
}

// IntegrationServiceInput is an input type that accepts IntegrationServiceArgs and IntegrationServiceOutput values.
// You can construct a concrete instance of `IntegrationServiceInput` via:
//
//          IntegrationServiceArgs{...}
type IntegrationServiceInput interface {
	pulumi.Input

	ToIntegrationServiceOutput() IntegrationServiceOutput
	ToIntegrationServiceOutputWithContext(context.Context) IntegrationServiceOutput
}

type IntegrationServiceArgs struct {
	ServiceKey  pulumi.StringInput `pulumi:"serviceKey"`
	ServiceName pulumi.StringInput `pulumi:"serviceName"`
}

func (IntegrationServiceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*IntegrationService)(nil)).Elem()
}

func (i IntegrationServiceArgs) ToIntegrationServiceOutput() IntegrationServiceOutput {
	return i.ToIntegrationServiceOutputWithContext(context.Background())
}

func (i IntegrationServiceArgs) ToIntegrationServiceOutputWithContext(ctx context.Context) IntegrationServiceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IntegrationServiceOutput)
}

// IntegrationServiceArrayInput is an input type that accepts IntegrationServiceArray and IntegrationServiceArrayOutput values.
// You can construct a concrete instance of `IntegrationServiceArrayInput` via:
//
//          IntegrationServiceArray{ IntegrationServiceArgs{...} }
type IntegrationServiceArrayInput interface {
	pulumi.Input

	ToIntegrationServiceArrayOutput() IntegrationServiceArrayOutput
	ToIntegrationServiceArrayOutputWithContext(context.Context) IntegrationServiceArrayOutput
}

type IntegrationServiceArray []IntegrationServiceInput

func (IntegrationServiceArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]IntegrationService)(nil)).Elem()
}

func (i IntegrationServiceArray) ToIntegrationServiceArrayOutput() IntegrationServiceArrayOutput {
	return i.ToIntegrationServiceArrayOutputWithContext(context.Background())
}

func (i IntegrationServiceArray) ToIntegrationServiceArrayOutputWithContext(ctx context.Context) IntegrationServiceArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IntegrationServiceArrayOutput)
}

type IntegrationServiceOutput struct{ *pulumi.OutputState }

func (IntegrationServiceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*IntegrationService)(nil)).Elem()
}

func (o IntegrationServiceOutput) ToIntegrationServiceOutput() IntegrationServiceOutput {
	return o
}

func (o IntegrationServiceOutput) ToIntegrationServiceOutputWithContext(ctx context.Context) IntegrationServiceOutput {
	return o
}

func (o IntegrationServiceOutput) ServiceKey() pulumi.StringOutput {
	return o.ApplyT(func(v IntegrationService) string { return v.ServiceKey }).(pulumi.StringOutput)
}

func (o IntegrationServiceOutput) ServiceName() pulumi.StringOutput {
	return o.ApplyT(func(v IntegrationService) string { return v.ServiceName }).(pulumi.StringOutput)
}

type IntegrationServiceArrayOutput struct{ *pulumi.OutputState }

func (IntegrationServiceArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]IntegrationService)(nil)).Elem()
}

func (o IntegrationServiceArrayOutput) ToIntegrationServiceArrayOutput() IntegrationServiceArrayOutput {
	return o
}

func (o IntegrationServiceArrayOutput) ToIntegrationServiceArrayOutputWithContext(ctx context.Context) IntegrationServiceArrayOutput {
	return o
}

func (o IntegrationServiceArrayOutput) Index(i pulumi.IntInput) IntegrationServiceOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) IntegrationService {
		return vs[0].([]IntegrationService)[vs[1].(int)]
	}).(IntegrationServiceOutput)
}

func init() {
	pulumi.RegisterOutputType(IntegrationServiceOutput{})
	pulumi.RegisterOutputType(IntegrationServiceArrayOutput{})
}
