// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The provider type for the datadog package. By default, resources use package-wide configuration
// settings, however an explicit `Provider` instance may be created and passed during resource
// construction to achieve fine-grained programmatic control over provider settings. See the
// [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.
type Provider struct {
	pulumi.ProviderResourceState
}

// NewProvider registers a new resource with the given unique name, arguments, and options.
func NewProvider(ctx *pulumi.Context,
	name string, args *ProviderArgs, opts ...pulumi.ResourceOption) (*Provider, error) {
	if args == nil {
		args = &ProviderArgs{}
	}

	if args.ApiKey == nil {
		args.ApiKey = pulumi.StringPtr(getEnvOrDefault("", nil, "DATADOG_API_KEY").(string))
	}
	if args.ApiUrl == nil {
		args.ApiUrl = pulumi.StringPtr(getEnvOrDefault("", nil, "DATADOG_HOST").(string))
	}
	if args.AppKey == nil {
		args.AppKey = pulumi.StringPtr(getEnvOrDefault("", nil, "DATADOG_APP_KEY").(string))
	}
	var resource Provider
	err := ctx.RegisterResource("pulumi:providers:datadog", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

type providerArgs struct {
	// (Required unless validate is false) Datadog API key. This can also be set via the DD_API_KEY environment variable.
	ApiKey *string `pulumi:"apiKey"`
	// The API Url. This can be also be set via the DD_HOST environment variable. Note that this URL must not end with the
	// /api/ path. For example, https://api.datadoghq.com/ is a correct value, while https://api.datadoghq.com/api/ is not. And
	// if you're working with "EU" version of Datadog, use https://api.datadoghq.eu/.
	ApiUrl *string `pulumi:"apiUrl"`
	// (Required unless validate is false) Datadog APP key. This can also be set via the DD_APP_KEY environment variable.
	AppKey *string `pulumi:"appKey"`
	// Enables validation of the provided API and APP keys during provider initialization. Default is true. When false, api_key
	// and app_keywon't be checked.
	Validate *bool `pulumi:"validate"`
}

// The set of arguments for constructing a Provider resource.
type ProviderArgs struct {
	// (Required unless validate is false) Datadog API key. This can also be set via the DD_API_KEY environment variable.
	ApiKey pulumi.StringPtrInput
	// The API Url. This can be also be set via the DD_HOST environment variable. Note that this URL must not end with the
	// /api/ path. For example, https://api.datadoghq.com/ is a correct value, while https://api.datadoghq.com/api/ is not. And
	// if you're working with "EU" version of Datadog, use https://api.datadoghq.eu/.
	ApiUrl pulumi.StringPtrInput
	// (Required unless validate is false) Datadog APP key. This can also be set via the DD_APP_KEY environment variable.
	AppKey pulumi.StringPtrInput
	// Enables validation of the provided API and APP keys during provider initialization. Default is true. When false, api_key
	// and app_keywon't be checked.
	Validate pulumi.BoolPtrInput
}

func (ProviderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*providerArgs)(nil)).Elem()
}

type ProviderInput interface {
	pulumi.Input

	ToProviderOutput() ProviderOutput
	ToProviderOutputWithContext(ctx context.Context) ProviderOutput
}

func (Provider) ElementType() reflect.Type {
	return reflect.TypeOf((*Provider)(nil)).Elem()
}

func (i Provider) ToProviderOutput() ProviderOutput {
	return i.ToProviderOutputWithContext(context.Background())
}

func (i Provider) ToProviderOutputWithContext(ctx context.Context) ProviderOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProviderOutput)
}

type ProviderOutput struct {
	*pulumi.OutputState
}

func (ProviderOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ProviderOutput)(nil)).Elem()
}

func (o ProviderOutput) ToProviderOutput() ProviderOutput {
	return o
}

func (o ProviderOutput) ToProviderOutputWithContext(ctx context.Context) ProviderOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ProviderOutput{})
}
