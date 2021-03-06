// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package aws

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Datadog - Amazon Web Services integration resource. This can be used to create and manage Datadog - Amazon Web Services integration.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-datadog/sdk/v2/go/datadog/aws"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := aws.NewIntegration(ctx, "sandbox", &aws.IntegrationArgs{
// 			AccountId: pulumi.String("1234567890"),
// 			AccountSpecificNamespaceRules: pulumi.BoolMap{
// 				"auto_scaling": pulumi.Bool(false),
// 				"opsworks":     pulumi.Bool(false),
// 			},
// 			ExcludedRegions: pulumi.StringArray{
// 				pulumi.String("us-east-1"),
// 				pulumi.String("us-west-2"),
// 			},
// 			FilterTags: pulumi.StringArray{
// 				pulumi.String("key:value"),
// 			},
// 			HostTags: pulumi.StringArray{
// 				pulumi.String("key:value"),
// 				pulumi.String("key2:value2"),
// 			},
// 			RoleName: pulumi.String("DatadogAWSIntegrationRole"),
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
// Amazon Web Services integrations can be imported using their `account ID` and `role name` separated with a colon (`:`), while the `external_id` should be passed by setting an environment variable called `EXTERNAL_ID`
//
// ```sh
//  $ pulumi import datadog:aws/integration:Integration EXTERNAL_ID=${external_id} datadog_integration_aws.test ${account_id}:${role_name}
// ```
type Integration struct {
	pulumi.CustomResourceState

	// Your AWS Account ID without dashes.
	AccountId pulumi.StringOutput `pulumi:"accountId"`
	// Enables or disables metric collection for specific AWS namespaces for this AWS account only. A list of namespaces can be
	// found at the [available namespace rules API
	// endpoint](https://docs.datadoghq.com/api/v1/aws-integration/#list-namespace-rules).
	AccountSpecificNamespaceRules pulumi.MapOutput `pulumi:"accountSpecificNamespaceRules"`
	// An array of AWS regions to exclude from metrics collection.
	ExcludedRegions pulumi.StringArrayOutput `pulumi:"excludedRegions"`
	// AWS External ID. **NOTE** This provider will not be able to detect changes made to the `external_id` field from outside
	// Terraform.
	ExternalId pulumi.StringOutput `pulumi:"externalId"`
	// Array of EC2 tags (in the form key:value) defines a filter that Datadog use when collecting metrics from EC2. Wildcards,
	// such as `?` (for single characters) and `*` (for multiple characters) can also be used. Only hosts that match one of the
	// defined tags will be imported into Datadog. The rest will be ignored. Host matching a given tag can also be excluded by
	// adding `!` before the tag. e.x. `env:production,instance-type:c1.*,!region:us-east-1`.
	FilterTags pulumi.StringArrayOutput `pulumi:"filterTags"`
	// Array of tags (in the form key:value) to add to all hosts and metrics reporting through this integration.
	HostTags pulumi.StringArrayOutput `pulumi:"hostTags"`
	// Your Datadog role delegation name.
	RoleName pulumi.StringOutput `pulumi:"roleName"`
}

// NewIntegration registers a new resource with the given unique name, arguments, and options.
func NewIntegration(ctx *pulumi.Context,
	name string, args *IntegrationArgs, opts ...pulumi.ResourceOption) (*Integration, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AccountId == nil {
		return nil, errors.New("invalid value for required argument 'AccountId'")
	}
	if args.RoleName == nil {
		return nil, errors.New("invalid value for required argument 'RoleName'")
	}
	var resource Integration
	err := ctx.RegisterResource("datadog:aws/integration:Integration", name, args, &resource, opts...)
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
	err := ctx.ReadResource("datadog:aws/integration:Integration", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Integration resources.
type integrationState struct {
	// Your AWS Account ID without dashes.
	AccountId *string `pulumi:"accountId"`
	// Enables or disables metric collection for specific AWS namespaces for this AWS account only. A list of namespaces can be
	// found at the [available namespace rules API
	// endpoint](https://docs.datadoghq.com/api/v1/aws-integration/#list-namespace-rules).
	AccountSpecificNamespaceRules map[string]interface{} `pulumi:"accountSpecificNamespaceRules"`
	// An array of AWS regions to exclude from metrics collection.
	ExcludedRegions []string `pulumi:"excludedRegions"`
	// AWS External ID. **NOTE** This provider will not be able to detect changes made to the `external_id` field from outside
	// Terraform.
	ExternalId *string `pulumi:"externalId"`
	// Array of EC2 tags (in the form key:value) defines a filter that Datadog use when collecting metrics from EC2. Wildcards,
	// such as `?` (for single characters) and `*` (for multiple characters) can also be used. Only hosts that match one of the
	// defined tags will be imported into Datadog. The rest will be ignored. Host matching a given tag can also be excluded by
	// adding `!` before the tag. e.x. `env:production,instance-type:c1.*,!region:us-east-1`.
	FilterTags []string `pulumi:"filterTags"`
	// Array of tags (in the form key:value) to add to all hosts and metrics reporting through this integration.
	HostTags []string `pulumi:"hostTags"`
	// Your Datadog role delegation name.
	RoleName *string `pulumi:"roleName"`
}

type IntegrationState struct {
	// Your AWS Account ID without dashes.
	AccountId pulumi.StringPtrInput
	// Enables or disables metric collection for specific AWS namespaces for this AWS account only. A list of namespaces can be
	// found at the [available namespace rules API
	// endpoint](https://docs.datadoghq.com/api/v1/aws-integration/#list-namespace-rules).
	AccountSpecificNamespaceRules pulumi.MapInput
	// An array of AWS regions to exclude from metrics collection.
	ExcludedRegions pulumi.StringArrayInput
	// AWS External ID. **NOTE** This provider will not be able to detect changes made to the `external_id` field from outside
	// Terraform.
	ExternalId pulumi.StringPtrInput
	// Array of EC2 tags (in the form key:value) defines a filter that Datadog use when collecting metrics from EC2. Wildcards,
	// such as `?` (for single characters) and `*` (for multiple characters) can also be used. Only hosts that match one of the
	// defined tags will be imported into Datadog. The rest will be ignored. Host matching a given tag can also be excluded by
	// adding `!` before the tag. e.x. `env:production,instance-type:c1.*,!region:us-east-1`.
	FilterTags pulumi.StringArrayInput
	// Array of tags (in the form key:value) to add to all hosts and metrics reporting through this integration.
	HostTags pulumi.StringArrayInput
	// Your Datadog role delegation name.
	RoleName pulumi.StringPtrInput
}

func (IntegrationState) ElementType() reflect.Type {
	return reflect.TypeOf((*integrationState)(nil)).Elem()
}

type integrationArgs struct {
	// Your AWS Account ID without dashes.
	AccountId string `pulumi:"accountId"`
	// Enables or disables metric collection for specific AWS namespaces for this AWS account only. A list of namespaces can be
	// found at the [available namespace rules API
	// endpoint](https://docs.datadoghq.com/api/v1/aws-integration/#list-namespace-rules).
	AccountSpecificNamespaceRules map[string]interface{} `pulumi:"accountSpecificNamespaceRules"`
	// An array of AWS regions to exclude from metrics collection.
	ExcludedRegions []string `pulumi:"excludedRegions"`
	// Array of EC2 tags (in the form key:value) defines a filter that Datadog use when collecting metrics from EC2. Wildcards,
	// such as `?` (for single characters) and `*` (for multiple characters) can also be used. Only hosts that match one of the
	// defined tags will be imported into Datadog. The rest will be ignored. Host matching a given tag can also be excluded by
	// adding `!` before the tag. e.x. `env:production,instance-type:c1.*,!region:us-east-1`.
	FilterTags []string `pulumi:"filterTags"`
	// Array of tags (in the form key:value) to add to all hosts and metrics reporting through this integration.
	HostTags []string `pulumi:"hostTags"`
	// Your Datadog role delegation name.
	RoleName string `pulumi:"roleName"`
}

// The set of arguments for constructing a Integration resource.
type IntegrationArgs struct {
	// Your AWS Account ID without dashes.
	AccountId pulumi.StringInput
	// Enables or disables metric collection for specific AWS namespaces for this AWS account only. A list of namespaces can be
	// found at the [available namespace rules API
	// endpoint](https://docs.datadoghq.com/api/v1/aws-integration/#list-namespace-rules).
	AccountSpecificNamespaceRules pulumi.MapInput
	// An array of AWS regions to exclude from metrics collection.
	ExcludedRegions pulumi.StringArrayInput
	// Array of EC2 tags (in the form key:value) defines a filter that Datadog use when collecting metrics from EC2. Wildcards,
	// such as `?` (for single characters) and `*` (for multiple characters) can also be used. Only hosts that match one of the
	// defined tags will be imported into Datadog. The rest will be ignored. Host matching a given tag can also be excluded by
	// adding `!` before the tag. e.x. `env:production,instance-type:c1.*,!region:us-east-1`.
	FilterTags pulumi.StringArrayInput
	// Array of tags (in the form key:value) to add to all hosts and metrics reporting through this integration.
	HostTags pulumi.StringArrayInput
	// Your Datadog role delegation name.
	RoleName pulumi.StringInput
}

func (IntegrationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*integrationArgs)(nil)).Elem()
}

type IntegrationInput interface {
	pulumi.Input

	ToIntegrationOutput() IntegrationOutput
	ToIntegrationOutputWithContext(ctx context.Context) IntegrationOutput
}

func (*Integration) ElementType() reflect.Type {
	return reflect.TypeOf((*Integration)(nil))
}

func (i *Integration) ToIntegrationOutput() IntegrationOutput {
	return i.ToIntegrationOutputWithContext(context.Background())
}

func (i *Integration) ToIntegrationOutputWithContext(ctx context.Context) IntegrationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IntegrationOutput)
}

type IntegrationOutput struct {
	*pulumi.OutputState
}

func (IntegrationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Integration)(nil))
}

func (o IntegrationOutput) ToIntegrationOutput() IntegrationOutput {
	return o
}

func (o IntegrationOutput) ToIntegrationOutputWithContext(ctx context.Context) IntegrationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(IntegrationOutput{})
}
