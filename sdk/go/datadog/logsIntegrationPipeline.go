// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Datadog [Logs Pipeline API](https://docs.datadoghq.com/api/v1/logs-pipelines/) resource to manage the [integrations](https://docs.datadoghq.com/logs/log_collection/?tab=tcpussite).
//
// Integration pipelines are the pipelines that are automatically installed for your organization when sending the logs with specific sources. You don't need to maintain or update these types of pipelines. Keeping them as resources, however, allows you to manage the order of your pipelines by referencing them in your LogsPipelineOrder resource. If you don't need the `pipelineOrder` feature, this resource declaration can be omitted.
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
// 		_, err := datadog.NewLogsIntegrationPipeline(ctx, "python", &datadog.LogsIntegrationPipelineArgs{
// 			IsEnabled: pulumi.Bool(true),
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
// ```sh
//  $ pulumi import datadog:index/logsIntegrationPipeline:LogsIntegrationPipeline name> <pipelineID>`
// ```
type LogsIntegrationPipeline struct {
	pulumi.CustomResourceState

	// Boolean value to enable your pipeline.
	IsEnabled pulumi.BoolPtrOutput `pulumi:"isEnabled"`
}

// NewLogsIntegrationPipeline registers a new resource with the given unique name, arguments, and options.
func NewLogsIntegrationPipeline(ctx *pulumi.Context,
	name string, args *LogsIntegrationPipelineArgs, opts ...pulumi.ResourceOption) (*LogsIntegrationPipeline, error) {
	if args == nil {
		args = &LogsIntegrationPipelineArgs{}
	}

	var resource LogsIntegrationPipeline
	err := ctx.RegisterResource("datadog:index/logsIntegrationPipeline:LogsIntegrationPipeline", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLogsIntegrationPipeline gets an existing LogsIntegrationPipeline resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLogsIntegrationPipeline(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LogsIntegrationPipelineState, opts ...pulumi.ResourceOption) (*LogsIntegrationPipeline, error) {
	var resource LogsIntegrationPipeline
	err := ctx.ReadResource("datadog:index/logsIntegrationPipeline:LogsIntegrationPipeline", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LogsIntegrationPipeline resources.
type logsIntegrationPipelineState struct {
	// Boolean value to enable your pipeline.
	IsEnabled *bool `pulumi:"isEnabled"`
}

type LogsIntegrationPipelineState struct {
	// Boolean value to enable your pipeline.
	IsEnabled pulumi.BoolPtrInput
}

func (LogsIntegrationPipelineState) ElementType() reflect.Type {
	return reflect.TypeOf((*logsIntegrationPipelineState)(nil)).Elem()
}

type logsIntegrationPipelineArgs struct {
	// Boolean value to enable your pipeline.
	IsEnabled *bool `pulumi:"isEnabled"`
}

// The set of arguments for constructing a LogsIntegrationPipeline resource.
type LogsIntegrationPipelineArgs struct {
	// Boolean value to enable your pipeline.
	IsEnabled pulumi.BoolPtrInput
}

func (LogsIntegrationPipelineArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*logsIntegrationPipelineArgs)(nil)).Elem()
}

type LogsIntegrationPipelineInput interface {
	pulumi.Input

	ToLogsIntegrationPipelineOutput() LogsIntegrationPipelineOutput
	ToLogsIntegrationPipelineOutputWithContext(ctx context.Context) LogsIntegrationPipelineOutput
}

func (LogsIntegrationPipeline) ElementType() reflect.Type {
	return reflect.TypeOf((*LogsIntegrationPipeline)(nil)).Elem()
}

func (i LogsIntegrationPipeline) ToLogsIntegrationPipelineOutput() LogsIntegrationPipelineOutput {
	return i.ToLogsIntegrationPipelineOutputWithContext(context.Background())
}

func (i LogsIntegrationPipeline) ToLogsIntegrationPipelineOutputWithContext(ctx context.Context) LogsIntegrationPipelineOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LogsIntegrationPipelineOutput)
}

type LogsIntegrationPipelineOutput struct {
	*pulumi.OutputState
}

func (LogsIntegrationPipelineOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LogsIntegrationPipelineOutput)(nil)).Elem()
}

func (o LogsIntegrationPipelineOutput) ToLogsIntegrationPipelineOutput() LogsIntegrationPipelineOutput {
	return o
}

func (o LogsIntegrationPipelineOutput) ToLogsIntegrationPipelineOutputWithContext(ctx context.Context) LogsIntegrationPipelineOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(LogsIntegrationPipelineOutput{})
}
