// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Datadog user resource. This can be used to create and manage Datadog users.
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
// 		roRole, err := datadog.LookupRole(ctx, &datadog.LookupRoleArgs{
// 			Filter: "Datadog Read Only Role",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = datadog.NewUser(ctx, "foo", &datadog.UserArgs{
// 			Email: pulumi.String("new@example.com"),
// 			Roles: pulumi.StringArray{
// 				pulumi.String(roRole.Id),
// 			},
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
// users can be imported using their ID, e.g.
//
// ```sh
//  $ pulumi import datadog:index/user:User example_user 6f1b44c0-30b2-11eb-86bc-279f7c1ebaa4
// ```
type User struct {
	pulumi.CustomResourceState

	AccessRole pulumi.StringPtrOutput `pulumi:"accessRole"`
	Disabled   pulumi.BoolPtrOutput   `pulumi:"disabled"`
	Email      pulumi.StringOutput    `pulumi:"email"`
	// Deprecated: This parameter is deprecated and will be removed from the next Major version
	Handle pulumi.StringPtrOutput `pulumi:"handle"`
	// Deprecated: This parameter is replaced by `roles` and will be removed from the next Major version
	IsAdmin pulumi.BoolOutput      `pulumi:"isAdmin"`
	Name    pulumi.StringPtrOutput `pulumi:"name"`
	// Deprecated: This parameter was removed from the API and has no effect
	Role     pulumi.StringPtrOutput   `pulumi:"role"`
	Roles    pulumi.StringArrayOutput `pulumi:"roles"`
	Verified pulumi.BoolOutput        `pulumi:"verified"`
}

// NewUser registers a new resource with the given unique name, arguments, and options.
func NewUser(ctx *pulumi.Context,
	name string, args *UserArgs, opts ...pulumi.ResourceOption) (*User, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Email == nil {
		return nil, errors.New("invalid value for required argument 'Email'")
	}
	var resource User
	err := ctx.RegisterResource("datadog:index/user:User", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetUser gets an existing User resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetUser(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *UserState, opts ...pulumi.ResourceOption) (*User, error) {
	var resource User
	err := ctx.ReadResource("datadog:index/user:User", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering User resources.
type userState struct {
	AccessRole *string `pulumi:"accessRole"`
	Disabled   *bool   `pulumi:"disabled"`
	Email      *string `pulumi:"email"`
	// Deprecated: This parameter is deprecated and will be removed from the next Major version
	Handle *string `pulumi:"handle"`
	// Deprecated: This parameter is replaced by `roles` and will be removed from the next Major version
	IsAdmin *bool   `pulumi:"isAdmin"`
	Name    *string `pulumi:"name"`
	// Deprecated: This parameter was removed from the API and has no effect
	Role     *string  `pulumi:"role"`
	Roles    []string `pulumi:"roles"`
	Verified *bool    `pulumi:"verified"`
}

type UserState struct {
	AccessRole pulumi.StringPtrInput
	Disabled   pulumi.BoolPtrInput
	Email      pulumi.StringPtrInput
	// Deprecated: This parameter is deprecated and will be removed from the next Major version
	Handle pulumi.StringPtrInput
	// Deprecated: This parameter is replaced by `roles` and will be removed from the next Major version
	IsAdmin pulumi.BoolPtrInput
	Name    pulumi.StringPtrInput
	// Deprecated: This parameter was removed from the API and has no effect
	Role     pulumi.StringPtrInput
	Roles    pulumi.StringArrayInput
	Verified pulumi.BoolPtrInput
}

func (UserState) ElementType() reflect.Type {
	return reflect.TypeOf((*userState)(nil)).Elem()
}

type userArgs struct {
	AccessRole *string `pulumi:"accessRole"`
	Disabled   *bool   `pulumi:"disabled"`
	Email      string  `pulumi:"email"`
	// Deprecated: This parameter is deprecated and will be removed from the next Major version
	Handle *string `pulumi:"handle"`
	// Deprecated: This parameter is replaced by `roles` and will be removed from the next Major version
	IsAdmin *bool   `pulumi:"isAdmin"`
	Name    *string `pulumi:"name"`
	// Deprecated: This parameter was removed from the API and has no effect
	Role  *string  `pulumi:"role"`
	Roles []string `pulumi:"roles"`
}

// The set of arguments for constructing a User resource.
type UserArgs struct {
	AccessRole pulumi.StringPtrInput
	Disabled   pulumi.BoolPtrInput
	Email      pulumi.StringInput
	// Deprecated: This parameter is deprecated and will be removed from the next Major version
	Handle pulumi.StringPtrInput
	// Deprecated: This parameter is replaced by `roles` and will be removed from the next Major version
	IsAdmin pulumi.BoolPtrInput
	Name    pulumi.StringPtrInput
	// Deprecated: This parameter was removed from the API and has no effect
	Role  pulumi.StringPtrInput
	Roles pulumi.StringArrayInput
}

func (UserArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*userArgs)(nil)).Elem()
}

type UserInput interface {
	pulumi.Input

	ToUserOutput() UserOutput
	ToUserOutputWithContext(ctx context.Context) UserOutput
}

func (User) ElementType() reflect.Type {
	return reflect.TypeOf((*User)(nil)).Elem()
}

func (i User) ToUserOutput() UserOutput {
	return i.ToUserOutputWithContext(context.Background())
}

func (i User) ToUserOutputWithContext(ctx context.Context) UserOutput {
	return pulumi.ToOutputWithContext(ctx, i).(UserOutput)
}

type UserOutput struct {
	*pulumi.OutputState
}

func (UserOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*UserOutput)(nil)).Elem()
}

func (o UserOutput) ToUserOutput() UserOutput {
	return o
}

func (o UserOutput) ToUserOutputWithContext(ctx context.Context) UserOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(UserOutput{})
}
