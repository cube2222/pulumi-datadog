// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Datadog role resource. This can be used to create and manage Datadog roles.
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
// 		bar, err := datadog.GetPermissions(ctx, nil, nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = datadog.NewRole(ctx, "foo", &datadog.RoleArgs{
// 			Name: pulumi.String("foo"),
// 			Permissions: datadog.RolePermissionArray{
// 				&datadog.RolePermissionArgs{
// 					Id: pulumi.String(bar.Permissions.MonitorsDowntime),
// 				},
// 				&datadog.RolePermissionArgs{
// 					Id: pulumi.String(bar.Permissions.MonitorsWrite),
// 				},
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
// Roles can be imported using their ID, e.g.
//
// ```sh
//  $ pulumi import datadog:index/role:Role example_role 000000-0000-0000-0000-000000000000
// ```
type Role struct {
	pulumi.CustomResourceState

	// Name of the role.
	Name pulumi.StringOutput `pulumi:"name"`
	// Set of objects containing the permission ID and the name of the permissions granted to this role.
	Permissions RolePermissionArrayOutput `pulumi:"permissions"`
	// Number of users that have this role.
	UserCount pulumi.IntOutput `pulumi:"userCount"`
}

// NewRole registers a new resource with the given unique name, arguments, and options.
func NewRole(ctx *pulumi.Context,
	name string, args *RoleArgs, opts ...pulumi.ResourceOption) (*Role, error) {
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil {
		args = &RoleArgs{}
	}
	var resource Role
	err := ctx.RegisterResource("datadog:index/role:Role", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRole gets an existing Role resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRole(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RoleState, opts ...pulumi.ResourceOption) (*Role, error) {
	var resource Role
	err := ctx.ReadResource("datadog:index/role:Role", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Role resources.
type roleState struct {
	// Name of the role.
	Name *string `pulumi:"name"`
	// Set of objects containing the permission ID and the name of the permissions granted to this role.
	Permissions []RolePermission `pulumi:"permissions"`
	// Number of users that have this role.
	UserCount *int `pulumi:"userCount"`
}

type RoleState struct {
	// Name of the role.
	Name pulumi.StringPtrInput
	// Set of objects containing the permission ID and the name of the permissions granted to this role.
	Permissions RolePermissionArrayInput
	// Number of users that have this role.
	UserCount pulumi.IntPtrInput
}

func (RoleState) ElementType() reflect.Type {
	return reflect.TypeOf((*roleState)(nil)).Elem()
}

type roleArgs struct {
	// Name of the role.
	Name string `pulumi:"name"`
	// Set of objects containing the permission ID and the name of the permissions granted to this role.
	Permissions []RolePermission `pulumi:"permissions"`
}

// The set of arguments for constructing a Role resource.
type RoleArgs struct {
	// Name of the role.
	Name pulumi.StringInput
	// Set of objects containing the permission ID and the name of the permissions granted to this role.
	Permissions RolePermissionArrayInput
}

func (RoleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*roleArgs)(nil)).Elem()
}

type RoleInput interface {
	pulumi.Input

	ToRoleOutput() RoleOutput
	ToRoleOutputWithContext(ctx context.Context) RoleOutput
}

func (Role) ElementType() reflect.Type {
	return reflect.TypeOf((*Role)(nil)).Elem()
}

func (i Role) ToRoleOutput() RoleOutput {
	return i.ToRoleOutputWithContext(context.Background())
}

func (i Role) ToRoleOutputWithContext(ctx context.Context) RoleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RoleOutput)
}

type RoleOutput struct {
	*pulumi.OutputState
}

func (RoleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RoleOutput)(nil)).Elem()
}

func (o RoleOutput) ToRoleOutput() RoleOutput {
	return o
}

func (o RoleOutput) ToRoleOutputWithContext(ctx context.Context) RoleOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(RoleOutput{})
}