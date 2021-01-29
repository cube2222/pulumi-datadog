// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package aws

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Datadog - Amazon Web Services integration Lambda ARN resource. This can be used to create and manage the log collection Lambdas for an account.
//
// Update operations are currently not supported with datadog API so any change forces a new resource.
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
// 		_, err := aws.NewIntegrationLambdaArn(ctx, "mainCollector", &aws.IntegrationLambdaArnArgs{
// 			AccountId: pulumi.String("1234567890"),
// 			LambdaArn: pulumi.String("arn:aws:lambda:us-east-1:1234567890:function:datadog-forwarder-Forwarder"),
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
// Amazon Web Services Lambda ARN integrations can be imported using their `account_id` and `lambda_arn` separated with a space (` `).
//
// ```sh
//  $ pulumi import datadog:aws/integrationLambdaArn:IntegrationLambdaArn test "1234567890 arn:aws:lambda:us-east-1:1234567890:function:datadog-forwarder-Forwarder"
// ```
type IntegrationLambdaArn struct {
	pulumi.CustomResourceState

	// Your AWS Account ID without dashes.
	AccountId pulumi.StringOutput `pulumi:"accountId"`
	// The ARN of the Datadog forwarder Lambda.
	LambdaArn pulumi.StringOutput `pulumi:"lambdaArn"`
}

// NewIntegrationLambdaArn registers a new resource with the given unique name, arguments, and options.
func NewIntegrationLambdaArn(ctx *pulumi.Context,
	name string, args *IntegrationLambdaArnArgs, opts ...pulumi.ResourceOption) (*IntegrationLambdaArn, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AccountId == nil {
		return nil, errors.New("invalid value for required argument 'AccountId'")
	}
	if args.LambdaArn == nil {
		return nil, errors.New("invalid value for required argument 'LambdaArn'")
	}
	var resource IntegrationLambdaArn
	err := ctx.RegisterResource("datadog:aws/integrationLambdaArn:IntegrationLambdaArn", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIntegrationLambdaArn gets an existing IntegrationLambdaArn resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIntegrationLambdaArn(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IntegrationLambdaArnState, opts ...pulumi.ResourceOption) (*IntegrationLambdaArn, error) {
	var resource IntegrationLambdaArn
	err := ctx.ReadResource("datadog:aws/integrationLambdaArn:IntegrationLambdaArn", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IntegrationLambdaArn resources.
type integrationLambdaArnState struct {
	// Your AWS Account ID without dashes.
	AccountId *string `pulumi:"accountId"`
	// The ARN of the Datadog forwarder Lambda.
	LambdaArn *string `pulumi:"lambdaArn"`
}

type IntegrationLambdaArnState struct {
	// Your AWS Account ID without dashes.
	AccountId pulumi.StringPtrInput
	// The ARN of the Datadog forwarder Lambda.
	LambdaArn pulumi.StringPtrInput
}

func (IntegrationLambdaArnState) ElementType() reflect.Type {
	return reflect.TypeOf((*integrationLambdaArnState)(nil)).Elem()
}

type integrationLambdaArnArgs struct {
	// Your AWS Account ID without dashes.
	AccountId string `pulumi:"accountId"`
	// The ARN of the Datadog forwarder Lambda.
	LambdaArn string `pulumi:"lambdaArn"`
}

// The set of arguments for constructing a IntegrationLambdaArn resource.
type IntegrationLambdaArnArgs struct {
	// Your AWS Account ID without dashes.
	AccountId pulumi.StringInput
	// The ARN of the Datadog forwarder Lambda.
	LambdaArn pulumi.StringInput
}

func (IntegrationLambdaArnArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*integrationLambdaArnArgs)(nil)).Elem()
}

type IntegrationLambdaArnInput interface {
	pulumi.Input

	ToIntegrationLambdaArnOutput() IntegrationLambdaArnOutput
	ToIntegrationLambdaArnOutputWithContext(ctx context.Context) IntegrationLambdaArnOutput
}

func (*IntegrationLambdaArn) ElementType() reflect.Type {
	return reflect.TypeOf((*IntegrationLambdaArn)(nil))
}

func (i *IntegrationLambdaArn) ToIntegrationLambdaArnOutput() IntegrationLambdaArnOutput {
	return i.ToIntegrationLambdaArnOutputWithContext(context.Background())
}

func (i *IntegrationLambdaArn) ToIntegrationLambdaArnOutputWithContext(ctx context.Context) IntegrationLambdaArnOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IntegrationLambdaArnOutput)
}

type IntegrationLambdaArnOutput struct {
	*pulumi.OutputState
}

func (IntegrationLambdaArnOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*IntegrationLambdaArn)(nil))
}

func (o IntegrationLambdaArnOutput) ToIntegrationLambdaArnOutput() IntegrationLambdaArnOutput {
	return o
}

func (o IntegrationLambdaArnOutput) ToIntegrationLambdaArnOutputWithContext(ctx context.Context) IntegrationLambdaArnOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(IntegrationLambdaArnOutput{})
}
