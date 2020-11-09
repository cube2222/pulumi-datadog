// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Datadog synthetics global variable resource. This can be used to create and manage Datadog synthetics global variables.
//
// ## Example Usage
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
// 		_, err := datadog.NewSyntheticsGlobalVariable(ctx, "testApi", &datadog.SyntheticsGlobalVariableArgs{
// 			Description: pulumi.String("Description of the variable"),
// 			Name:        pulumi.String("EXAMPLE_VARIABLE"),
// 			Tags: pulumi.StringArray{
// 				pulumi.String("foo:bar"),
// 				pulumi.String("env:test"),
// 			},
// 			Value: pulumi.String("variable-value"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ## Secure global variables
//
// Secure global variables are not supported for now.
type SyntheticsGlobalVariable struct {
	pulumi.CustomResourceState

	Description pulumi.StringPtrOutput   `pulumi:"description"`
	Name        pulumi.StringOutput      `pulumi:"name"`
	Tags        pulumi.StringArrayOutput `pulumi:"tags"`
	Value       pulumi.StringOutput      `pulumi:"value"`
}

// NewSyntheticsGlobalVariable registers a new resource with the given unique name, arguments, and options.
func NewSyntheticsGlobalVariable(ctx *pulumi.Context,
	name string, args *SyntheticsGlobalVariableArgs, opts ...pulumi.ResourceOption) (*SyntheticsGlobalVariable, error) {
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.Value == nil {
		return nil, errors.New("missing required argument 'Value'")
	}
	if args == nil {
		args = &SyntheticsGlobalVariableArgs{}
	}
	var resource SyntheticsGlobalVariable
	err := ctx.RegisterResource("datadog:index/syntheticsGlobalVariable:SyntheticsGlobalVariable", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSyntheticsGlobalVariable gets an existing SyntheticsGlobalVariable resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSyntheticsGlobalVariable(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SyntheticsGlobalVariableState, opts ...pulumi.ResourceOption) (*SyntheticsGlobalVariable, error) {
	var resource SyntheticsGlobalVariable
	err := ctx.ReadResource("datadog:index/syntheticsGlobalVariable:SyntheticsGlobalVariable", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SyntheticsGlobalVariable resources.
type syntheticsGlobalVariableState struct {
	Description *string  `pulumi:"description"`
	Name        *string  `pulumi:"name"`
	Tags        []string `pulumi:"tags"`
	Value       *string  `pulumi:"value"`
}

type SyntheticsGlobalVariableState struct {
	Description pulumi.StringPtrInput
	Name        pulumi.StringPtrInput
	Tags        pulumi.StringArrayInput
	Value       pulumi.StringPtrInput
}

func (SyntheticsGlobalVariableState) ElementType() reflect.Type {
	return reflect.TypeOf((*syntheticsGlobalVariableState)(nil)).Elem()
}

type syntheticsGlobalVariableArgs struct {
	Description *string  `pulumi:"description"`
	Name        string   `pulumi:"name"`
	Tags        []string `pulumi:"tags"`
	Value       string   `pulumi:"value"`
}

// The set of arguments for constructing a SyntheticsGlobalVariable resource.
type SyntheticsGlobalVariableArgs struct {
	Description pulumi.StringPtrInput
	Name        pulumi.StringInput
	Tags        pulumi.StringArrayInput
	Value       pulumi.StringInput
}

func (SyntheticsGlobalVariableArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*syntheticsGlobalVariableArgs)(nil)).Elem()
}