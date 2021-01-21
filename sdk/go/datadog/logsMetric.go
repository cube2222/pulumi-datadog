// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Resource for interacting with the logsMetric API
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
// 		_, err := datadog.NewLogsMetric(ctx, "testingLogsMetric", &datadog.LogsMetricArgs{
// 			Compute: &datadog.LogsMetricComputeArgs{
// 				AggregationType: pulumi.String("distribution"),
// 				Path:            pulumi.String("@duration"),
// 			},
// 			Filter: &datadog.LogsMetricFilterArgs{
// 				Query: pulumi.String("service:test"),
// 			},
// 			GroupBies: datadog.LogsMetricGroupByArray{
// 				&datadog.LogsMetricGroupByArgs{
// 					Path:    pulumi.String("@status"),
// 					TagName: pulumi.String("status"),
// 				},
// 			},
// 			Name: pulumi.String("testing.logs.metric"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ## Schema
//
// ### Required
//
// - **compute** (Block List, Min: 1, Max: 1) The compute rule to compute the log-based metric. This field can't be updated after creation. (see below for nested schema)
// - **filter** (Block List, Min: 1, Max: 1) The log-based metric filter. Logs matching this filter will be aggregated in this metric. (see below for nested schema)
// - **name** (String, Required) The name of the log-based metric. This field can't be updated after creation.
//
// ### Optional
//
// - **group_by** (Block List) The rules for the group by. (see below for nested schema)
// - **id** (String, Optional) The ID of this resource.
//
// <a id="nestedblock--compute"></a>
// ### Nested Schema for `compute`
//
// Required:
//
// - **aggregation_type** (String, Required) The type of aggregation to use. This field can't be updated after creation.
//
// Optional:
//
// - **path** (String, Optional) The path to the value the log-based metric will aggregate on (only used if the aggregation type is a "distribution"). This field can't be updated after creation.
//
// <a id="nestedblock--filter"></a>
// ### Nested Schema for `filter`
//
// Required:
//
// - **query** (String, Required) The search query - following the log search syntax.
//
// <a id="nestedblock--group_by"></a>
// ### Nested Schema for `groupBy`
//
// Required:
//
// - **path** (String, Required) The path to the value the log-based metric will be aggregated over.
// - **tag_name** (String, Required) Name of the tag that gets created.
//
// ## Import
//
// Import is supported using the following syntax
//
// ```sh
//  $ pulumi import datadog:index/logsMetric:LogsMetric testing_logs_metric testing.logs.metric
// ```
type LogsMetric struct {
	pulumi.CustomResourceState

	// The compute rule to compute the log-based metric. This field can't be updated after creation.
	Compute LogsMetricComputeOutput `pulumi:"compute"`
	// The log-based metric filter. Logs matching this filter will be aggregated in this metric.
	Filter LogsMetricFilterOutput `pulumi:"filter"`
	// The rules for the group by.
	GroupBies LogsMetricGroupByArrayOutput `pulumi:"groupBies"`
	// The name of the log-based metric. This field can't be updated after creation.
	Name pulumi.StringOutput `pulumi:"name"`
}

// NewLogsMetric registers a new resource with the given unique name, arguments, and options.
func NewLogsMetric(ctx *pulumi.Context,
	name string, args *LogsMetricArgs, opts ...pulumi.ResourceOption) (*LogsMetric, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Compute == nil {
		return nil, errors.New("invalid value for required argument 'Compute'")
	}
	if args.Filter == nil {
		return nil, errors.New("invalid value for required argument 'Filter'")
	}
	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	var resource LogsMetric
	err := ctx.RegisterResource("datadog:index/logsMetric:LogsMetric", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLogsMetric gets an existing LogsMetric resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLogsMetric(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LogsMetricState, opts ...pulumi.ResourceOption) (*LogsMetric, error) {
	var resource LogsMetric
	err := ctx.ReadResource("datadog:index/logsMetric:LogsMetric", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LogsMetric resources.
type logsMetricState struct {
	// The compute rule to compute the log-based metric. This field can't be updated after creation.
	Compute *LogsMetricCompute `pulumi:"compute"`
	// The log-based metric filter. Logs matching this filter will be aggregated in this metric.
	Filter *LogsMetricFilter `pulumi:"filter"`
	// The rules for the group by.
	GroupBies []LogsMetricGroupBy `pulumi:"groupBies"`
	// The name of the log-based metric. This field can't be updated after creation.
	Name *string `pulumi:"name"`
}

type LogsMetricState struct {
	// The compute rule to compute the log-based metric. This field can't be updated after creation.
	Compute LogsMetricComputePtrInput
	// The log-based metric filter. Logs matching this filter will be aggregated in this metric.
	Filter LogsMetricFilterPtrInput
	// The rules for the group by.
	GroupBies LogsMetricGroupByArrayInput
	// The name of the log-based metric. This field can't be updated after creation.
	Name pulumi.StringPtrInput
}

func (LogsMetricState) ElementType() reflect.Type {
	return reflect.TypeOf((*logsMetricState)(nil)).Elem()
}

type logsMetricArgs struct {
	// The compute rule to compute the log-based metric. This field can't be updated after creation.
	Compute LogsMetricCompute `pulumi:"compute"`
	// The log-based metric filter. Logs matching this filter will be aggregated in this metric.
	Filter LogsMetricFilter `pulumi:"filter"`
	// The rules for the group by.
	GroupBies []LogsMetricGroupBy `pulumi:"groupBies"`
	// The name of the log-based metric. This field can't be updated after creation.
	Name string `pulumi:"name"`
}

// The set of arguments for constructing a LogsMetric resource.
type LogsMetricArgs struct {
	// The compute rule to compute the log-based metric. This field can't be updated after creation.
	Compute LogsMetricComputeInput
	// The log-based metric filter. Logs matching this filter will be aggregated in this metric.
	Filter LogsMetricFilterInput
	// The rules for the group by.
	GroupBies LogsMetricGroupByArrayInput
	// The name of the log-based metric. This field can't be updated after creation.
	Name pulumi.StringInput
}

func (LogsMetricArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*logsMetricArgs)(nil)).Elem()
}

type LogsMetricInput interface {
	pulumi.Input

	ToLogsMetricOutput() LogsMetricOutput
	ToLogsMetricOutputWithContext(ctx context.Context) LogsMetricOutput
}

func (LogsMetric) ElementType() reflect.Type {
	return reflect.TypeOf((*LogsMetric)(nil)).Elem()
}

func (i LogsMetric) ToLogsMetricOutput() LogsMetricOutput {
	return i.ToLogsMetricOutputWithContext(context.Background())
}

func (i LogsMetric) ToLogsMetricOutputWithContext(ctx context.Context) LogsMetricOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LogsMetricOutput)
}

type LogsMetricOutput struct {
	*pulumi.OutputState
}

func (LogsMetricOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LogsMetricOutput)(nil)).Elem()
}

func (o LogsMetricOutput) ToLogsMetricOutput() LogsMetricOutput {
	return o
}

func (o LogsMetricOutput) ToLogsMetricOutputWithContext(ctx context.Context) LogsMetricOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(LogsMetricOutput{})
}
