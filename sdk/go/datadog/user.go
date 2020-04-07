// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package datadog

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Datadog user resource. This can be used to create and manage Datadog users.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/user.html.markdown.
type User struct {
	pulumi.CustomResourceState

	// Role description for user. Can be `st` (standard user), `adm` (admin user) or `ro` (read-only user).  Default is `st`.
	AccessRole pulumi.StringPtrOutput `pulumi:"accessRole"`
	// Whether the user is disabled
	Disabled pulumi.BoolPtrOutput `pulumi:"disabled"`
	// Email address for user
	Email pulumi.StringOutput `pulumi:"email"`
	// The user handle, must be a valid email.
	Handle pulumi.StringOutput `pulumi:"handle"`
	// (Optional) Whether the user is an administrator. **Warning**: the corresponding query parameter is ignored by the Datadog API, thus the argument would always trigger an execution plan.
	IsAdmin pulumi.BoolOutput `pulumi:"isAdmin"`
	// Name for user
	Name pulumi.StringOutput `pulumi:"name"`
	// Role description for user. **Warning**: the corresponding query parameter is ignored by the Datadog API, thus the argument would always trigger an execution plan.
	Role pulumi.StringPtrOutput `pulumi:"role"`
	// Returns true if Datadog user is verified
	Verified pulumi.BoolOutput `pulumi:"verified"`
}

// NewUser registers a new resource with the given unique name, arguments, and options.
func NewUser(ctx *pulumi.Context,
	name string, args *UserArgs, opts ...pulumi.ResourceOption) (*User, error) {
	if args == nil || args.Email == nil {
		return nil, errors.New("missing required argument 'Email'")
	}
	if args == nil || args.Handle == nil {
		return nil, errors.New("missing required argument 'Handle'")
	}
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil {
		args = &UserArgs{}
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
	// Role description for user. Can be `st` (standard user), `adm` (admin user) or `ro` (read-only user).  Default is `st`.
	AccessRole *string `pulumi:"accessRole"`
	// Whether the user is disabled
	Disabled *bool `pulumi:"disabled"`
	// Email address for user
	Email *string `pulumi:"email"`
	// The user handle, must be a valid email.
	Handle *string `pulumi:"handle"`
	// (Optional) Whether the user is an administrator. **Warning**: the corresponding query parameter is ignored by the Datadog API, thus the argument would always trigger an execution plan.
	IsAdmin *bool `pulumi:"isAdmin"`
	// Name for user
	Name *string `pulumi:"name"`
	// Role description for user. **Warning**: the corresponding query parameter is ignored by the Datadog API, thus the argument would always trigger an execution plan.
	Role *string `pulumi:"role"`
	// Returns true if Datadog user is verified
	Verified *bool `pulumi:"verified"`
}

type UserState struct {
	// Role description for user. Can be `st` (standard user), `adm` (admin user) or `ro` (read-only user).  Default is `st`.
	AccessRole pulumi.StringPtrInput
	// Whether the user is disabled
	Disabled pulumi.BoolPtrInput
	// Email address for user
	Email pulumi.StringPtrInput
	// The user handle, must be a valid email.
	Handle pulumi.StringPtrInput
	// (Optional) Whether the user is an administrator. **Warning**: the corresponding query parameter is ignored by the Datadog API, thus the argument would always trigger an execution plan.
	IsAdmin pulumi.BoolPtrInput
	// Name for user
	Name pulumi.StringPtrInput
	// Role description for user. **Warning**: the corresponding query parameter is ignored by the Datadog API, thus the argument would always trigger an execution plan.
	Role pulumi.StringPtrInput
	// Returns true if Datadog user is verified
	Verified pulumi.BoolPtrInput
}

func (UserState) ElementType() reflect.Type {
	return reflect.TypeOf((*userState)(nil)).Elem()
}

type userArgs struct {
	// Role description for user. Can be `st` (standard user), `adm` (admin user) or `ro` (read-only user).  Default is `st`.
	AccessRole *string `pulumi:"accessRole"`
	// Whether the user is disabled
	Disabled *bool `pulumi:"disabled"`
	// Email address for user
	Email string `pulumi:"email"`
	// The user handle, must be a valid email.
	Handle string `pulumi:"handle"`
	// (Optional) Whether the user is an administrator. **Warning**: the corresponding query parameter is ignored by the Datadog API, thus the argument would always trigger an execution plan.
	IsAdmin *bool `pulumi:"isAdmin"`
	// Name for user
	Name string `pulumi:"name"`
	// Role description for user. **Warning**: the corresponding query parameter is ignored by the Datadog API, thus the argument would always trigger an execution plan.
	Role *string `pulumi:"role"`
}

// The set of arguments for constructing a User resource.
type UserArgs struct {
	// Role description for user. Can be `st` (standard user), `adm` (admin user) or `ro` (read-only user).  Default is `st`.
	AccessRole pulumi.StringPtrInput
	// Whether the user is disabled
	Disabled pulumi.BoolPtrInput
	// Email address for user
	Email pulumi.StringInput
	// The user handle, must be a valid email.
	Handle pulumi.StringInput
	// (Optional) Whether the user is an administrator. **Warning**: the corresponding query parameter is ignored by the Datadog API, thus the argument would always trigger an execution plan.
	IsAdmin pulumi.BoolPtrInput
	// Name for user
	Name pulumi.StringInput
	// Role description for user. **Warning**: the corresponding query parameter is ignored by the Datadog API, thus the argument would always trigger an execution plan.
	Role pulumi.StringPtrInput
}

func (UserArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*userArgs)(nil)).Elem()
}
