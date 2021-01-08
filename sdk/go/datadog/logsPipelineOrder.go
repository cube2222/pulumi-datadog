// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Datadog [Logs Pipeline API](https://docs.datadoghq.com/api/v1/logs-pipelines/) resource, which is used to manage Datadog log pipelines order.
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
// 		_, err := datadog.NewLogsPipelineOrder(ctx, "samplePipelineOrder", &datadog.LogsPipelineOrderArgs{
// 			Name: pulumi.String("sample_pipeline_order"),
// 			Pipelines: pulumi.StringArray{
// 				pulumi.Any(datadog_logs_custom_pipeline.Sample_pipeline.Id),
// 				pulumi.Any(datadog_logs_integration_pipeline.Python.Id),
// 			},
// 		}, pulumi.DependsOn([]pulumi.Resource{
// 			"datadog_logs_custom_pipeline.sample_pipeline",
// 			"datadog_logs_integration_pipeline.python",
// 		}))
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
// There must be at most one `datadog_logs_pipeline_order` resource. Pipeline order creation is not supported from logs config API. You can import the `datadog_logs_pipeline_order` or create a pipeline order (which is actually doing the update operation).
//
// ```sh
//  $ pulumi import datadog:index/logsPipelineOrder:LogsPipelineOrder name> <name>
// ```
type LogsPipelineOrder struct {
	pulumi.CustomResourceState

	// The name attribute in the resource `datadog_logs_pipeline_order` needs to be unique. It's recommended to use the same
	// value as the resource name. No related field is available in [Logs Pipeline
	// API](https://docs.datadoghq.com/api/v1/logs-pipelines/#get-pipeline-order).
	Name pulumi.StringOutput `pulumi:"name"`
	// The pipeline IDs list. The order of pipeline IDs in this attribute defines the overall pipeline order for logs.
	Pipelines pulumi.StringArrayOutput `pulumi:"pipelines"`
}

// NewLogsPipelineOrder registers a new resource with the given unique name, arguments, and options.
func NewLogsPipelineOrder(ctx *pulumi.Context,
	name string, args *LogsPipelineOrderArgs, opts ...pulumi.ResourceOption) (*LogsPipelineOrder, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.Pipelines == nil {
		return nil, errors.New("invalid value for required argument 'Pipelines'")
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
	// The name attribute in the resource `datadog_logs_pipeline_order` needs to be unique. It's recommended to use the same
	// value as the resource name. No related field is available in [Logs Pipeline
	// API](https://docs.datadoghq.com/api/v1/logs-pipelines/#get-pipeline-order).
	Name *string `pulumi:"name"`
	// The pipeline IDs list. The order of pipeline IDs in this attribute defines the overall pipeline order for logs.
	Pipelines []string `pulumi:"pipelines"`
}

type LogsPipelineOrderState struct {
	// The name attribute in the resource `datadog_logs_pipeline_order` needs to be unique. It's recommended to use the same
	// value as the resource name. No related field is available in [Logs Pipeline
	// API](https://docs.datadoghq.com/api/v1/logs-pipelines/#get-pipeline-order).
	Name pulumi.StringPtrInput
	// The pipeline IDs list. The order of pipeline IDs in this attribute defines the overall pipeline order for logs.
	Pipelines pulumi.StringArrayInput
}

func (LogsPipelineOrderState) ElementType() reflect.Type {
	return reflect.TypeOf((*logsPipelineOrderState)(nil)).Elem()
}

type logsPipelineOrderArgs struct {
	// The name attribute in the resource `datadog_logs_pipeline_order` needs to be unique. It's recommended to use the same
	// value as the resource name. No related field is available in [Logs Pipeline
	// API](https://docs.datadoghq.com/api/v1/logs-pipelines/#get-pipeline-order).
	Name string `pulumi:"name"`
	// The pipeline IDs list. The order of pipeline IDs in this attribute defines the overall pipeline order for logs.
	Pipelines []string `pulumi:"pipelines"`
}

// The set of arguments for constructing a LogsPipelineOrder resource.
type LogsPipelineOrderArgs struct {
	// The name attribute in the resource `datadog_logs_pipeline_order` needs to be unique. It's recommended to use the same
	// value as the resource name. No related field is available in [Logs Pipeline
	// API](https://docs.datadoghq.com/api/v1/logs-pipelines/#get-pipeline-order).
	Name pulumi.StringInput
	// The pipeline IDs list. The order of pipeline IDs in this attribute defines the overall pipeline order for logs.
	Pipelines pulumi.StringArrayInput
}

func (LogsPipelineOrderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*logsPipelineOrderArgs)(nil)).Elem()
}

type LogsPipelineOrderInput interface {
	pulumi.Input

	ToLogsPipelineOrderOutput() LogsPipelineOrderOutput
	ToLogsPipelineOrderOutputWithContext(ctx context.Context) LogsPipelineOrderOutput
}

func (LogsPipelineOrder) ElementType() reflect.Type {
	return reflect.TypeOf((*LogsPipelineOrder)(nil)).Elem()
}

func (i LogsPipelineOrder) ToLogsPipelineOrderOutput() LogsPipelineOrderOutput {
	return i.ToLogsPipelineOrderOutputWithContext(context.Background())
}

func (i LogsPipelineOrder) ToLogsPipelineOrderOutputWithContext(ctx context.Context) LogsPipelineOrderOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LogsPipelineOrderOutput)
}

type LogsPipelineOrderOutput struct {
	*pulumi.OutputState
}

func (LogsPipelineOrderOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LogsPipelineOrderOutput)(nil)).Elem()
}

func (o LogsPipelineOrderOutput) ToLogsPipelineOrderOutput() LogsPipelineOrderOutput {
	return o
}

func (o LogsPipelineOrderOutput) ToLogsPipelineOrderOutputWithContext(ctx context.Context) LogsPipelineOrderOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(LogsPipelineOrderOutput{})
}
