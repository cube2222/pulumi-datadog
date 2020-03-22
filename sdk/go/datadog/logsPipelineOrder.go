// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package datadog

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Datadog [Logs Pipeline API](https://docs.datadoghq.com/api/?lang=python#logs-pipelines) resource, which is used to manage Datadog log pipelines order.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/logs_pipeline_order.html.markdown.
type LogsPipelineOrder struct {
	pulumi.CustomResourceState

	// The name attribute in the resource `.LogsPipelineOrder` needs to be unique. It's recommended to use the same value as the resource `NAME`. 
	// No related field is available in  [Logs Pipeline API](https://docs.datadoghq.com/api/?lang=python#get-pipeline-order).
	Name pulumi.StringOutput `pulumi:"name"`
	// The pipeline IDs list. The order of pipeline IDs in this attribute defines the overall pipeline order for logs.
	Pipelines pulumi.StringArrayOutput `pulumi:"pipelines"`
}

// NewLogsPipelineOrder registers a new resource with the given unique name, arguments, and options.
func NewLogsPipelineOrder(ctx *pulumi.Context,
	name string, args *LogsPipelineOrderArgs, opts ...pulumi.ResourceOption) (*LogsPipelineOrder, error) {
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.Pipelines == nil {
		return nil, errors.New("missing required argument 'Pipelines'")
	}
	if args == nil {
		args = &LogsPipelineOrderArgs{}
	}
	var resource LogsPipelineOrder
	err := ctx.RegisterResource("datadog:index/logsPipelineOrder:LogsPipelineOrder", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLogsPipelineOrder gets an existing LogsPipelineOrder resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLogsPipelineOrder(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LogsPipelineOrderState, opts ...pulumi.ResourceOption) (*LogsPipelineOrder, error) {
	var resource LogsPipelineOrder
	err := ctx.ReadResource("datadog:index/logsPipelineOrder:LogsPipelineOrder", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LogsPipelineOrder resources.
type logsPipelineOrderState struct {
	// The name attribute in the resource `.LogsPipelineOrder` needs to be unique. It's recommended to use the same value as the resource `NAME`. 
	// No related field is available in  [Logs Pipeline API](https://docs.datadoghq.com/api/?lang=python#get-pipeline-order).
	Name *string `pulumi:"name"`
	// The pipeline IDs list. The order of pipeline IDs in this attribute defines the overall pipeline order for logs.
	Pipelines []string `pulumi:"pipelines"`
}

type LogsPipelineOrderState struct {
	// The name attribute in the resource `.LogsPipelineOrder` needs to be unique. It's recommended to use the same value as the resource `NAME`. 
	// No related field is available in  [Logs Pipeline API](https://docs.datadoghq.com/api/?lang=python#get-pipeline-order).
	Name pulumi.StringPtrInput
	// The pipeline IDs list. The order of pipeline IDs in this attribute defines the overall pipeline order for logs.
	Pipelines pulumi.StringArrayInput
}

func (LogsPipelineOrderState) ElementType() reflect.Type {
	return reflect.TypeOf((*logsPipelineOrderState)(nil)).Elem()
}

type logsPipelineOrderArgs struct {
	// The name attribute in the resource `.LogsPipelineOrder` needs to be unique. It's recommended to use the same value as the resource `NAME`. 
	// No related field is available in  [Logs Pipeline API](https://docs.datadoghq.com/api/?lang=python#get-pipeline-order).
	Name string `pulumi:"name"`
	// The pipeline IDs list. The order of pipeline IDs in this attribute defines the overall pipeline order for logs.
	Pipelines []string `pulumi:"pipelines"`
}

// The set of arguments for constructing a LogsPipelineOrder resource.
type LogsPipelineOrderArgs struct {
	// The name attribute in the resource `.LogsPipelineOrder` needs to be unique. It's recommended to use the same value as the resource `NAME`. 
	// No related field is available in  [Logs Pipeline API](https://docs.datadoghq.com/api/?lang=python#get-pipeline-order).
	Name pulumi.StringInput
	// The pipeline IDs list. The order of pipeline IDs in this attribute defines the overall pipeline order for logs.
	Pipelines pulumi.StringArrayInput
}

func (LogsPipelineOrderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*logsPipelineOrderArgs)(nil)).Elem()
}

