// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package datadog

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Datadog [Logs Index API](https://docs.datadoghq.com/api/?lang=python#logs-indexes) resource. This can be used to manage the order of Datadog logs indexes.
//
//
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/logs_index_order.html.markdown.
type LogsIndexOrder struct {
	pulumi.CustomResourceState

	// The index resource list. Logs are tested against the query filter of each index one by one following the order of the list.
	Indexes pulumi.StringArrayOutput `pulumi:"indexes"`
	// The unique name of the index order resource.
	Name pulumi.StringOutput `pulumi:"name"`
}

// NewLogsIndexOrder registers a new resource with the given unique name, arguments, and options.
func NewLogsIndexOrder(ctx *pulumi.Context,
	name string, args *LogsIndexOrderArgs, opts ...pulumi.ResourceOption) (*LogsIndexOrder, error) {
	if args == nil || args.Indexes == nil {
		return nil, errors.New("missing required argument 'Indexes'")
	}
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil {
		args = &LogsIndexOrderArgs{}
	}
	var resource LogsIndexOrder
	err := ctx.RegisterResource("datadog:index/logsIndexOrder:LogsIndexOrder", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLogsIndexOrder gets an existing LogsIndexOrder resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLogsIndexOrder(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LogsIndexOrderState, opts ...pulumi.ResourceOption) (*LogsIndexOrder, error) {
	var resource LogsIndexOrder
	err := ctx.ReadResource("datadog:index/logsIndexOrder:LogsIndexOrder", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LogsIndexOrder resources.
type logsIndexOrderState struct {
	// The index resource list. Logs are tested against the query filter of each index one by one following the order of the list.
	Indexes []string `pulumi:"indexes"`
	// The unique name of the index order resource.
	Name *string `pulumi:"name"`
}

type LogsIndexOrderState struct {
	// The index resource list. Logs are tested against the query filter of each index one by one following the order of the list.
	Indexes pulumi.StringArrayInput
	// The unique name of the index order resource.
	Name pulumi.StringPtrInput
}

func (LogsIndexOrderState) ElementType() reflect.Type {
	return reflect.TypeOf((*logsIndexOrderState)(nil)).Elem()
}

type logsIndexOrderArgs struct {
	// The index resource list. Logs are tested against the query filter of each index one by one following the order of the list.
	Indexes []string `pulumi:"indexes"`
	// The unique name of the index order resource.
	Name string `pulumi:"name"`
}

// The set of arguments for constructing a LogsIndexOrder resource.
type LogsIndexOrderArgs struct {
	// The index resource list. Logs are tested against the query filter of each index one by one following the order of the list.
	Indexes pulumi.StringArrayInput
	// The unique name of the index order resource.
	Name pulumi.StringInput
}

func (LogsIndexOrderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*logsIndexOrderArgs)(nil)).Elem()
}
