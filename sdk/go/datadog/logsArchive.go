// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Datadog [Logs Archive API](https://docs.datadoghq.com/api/v2/logs-archives/) resource, which is used to create and manage Datadog logs archives.
//
// ## Example Usage
//
// Create a Datadog logs archive:
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
// 		_, err := datadog.NewLogsArchive(ctx, "myS3Archive", &datadog.LogsArchiveArgs{
// 			Name:  pulumi.String("my s3 archive"),
// 			Query: pulumi.String("service:myservice"),
// 			S3: &datadog.LogsArchiveS3Args{
// 				Account_id: pulumi.String("001234567888"),
// 				Bucket:     pulumi.String("my-bucket"),
// 				Path:       pulumi.String("/path/foo"),
// 				Role_name:  pulumi.String("my-role-name"),
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
// Logs archives can be imported using their public string ID, e.g.
//
// ```sh
//  $ pulumi import datadog:index/logsArchive:LogsArchive my_s3_archive 1Aabc2_dfQPLnXy3HlfK4hi
// ```
type LogsArchive struct {
	pulumi.CustomResourceState

	Azure           LogsArchiveAzurePtrOutput `pulumi:"azure"`
	Gcs             LogsArchiveGcsPtrOutput   `pulumi:"gcs"`
	IncludeTags     pulumi.BoolPtrOutput      `pulumi:"includeTags"`
	Name            pulumi.StringOutput       `pulumi:"name"`
	Query           pulumi.StringOutput       `pulumi:"query"`
	RehydrationTags pulumi.StringArrayOutput  `pulumi:"rehydrationTags"`
	S3              LogsArchiveS3PtrOutput    `pulumi:"s3"`
}

// NewLogsArchive registers a new resource with the given unique name, arguments, and options.
func NewLogsArchive(ctx *pulumi.Context,
	name string, args *LogsArchiveArgs, opts ...pulumi.ResourceOption) (*LogsArchive, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.Query == nil {
		return nil, errors.New("invalid value for required argument 'Query'")
	}
	var resource LogsArchive
	err := ctx.RegisterResource("datadog:index/logsArchive:LogsArchive", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLogsArchive gets an existing LogsArchive resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLogsArchive(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LogsArchiveState, opts ...pulumi.ResourceOption) (*LogsArchive, error) {
	var resource LogsArchive
	err := ctx.ReadResource("datadog:index/logsArchive:LogsArchive", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LogsArchive resources.
type logsArchiveState struct {
	Azure           *LogsArchiveAzure `pulumi:"azure"`
	Gcs             *LogsArchiveGcs   `pulumi:"gcs"`
	IncludeTags     *bool             `pulumi:"includeTags"`
	Name            *string           `pulumi:"name"`
	Query           *string           `pulumi:"query"`
	RehydrationTags []string          `pulumi:"rehydrationTags"`
	S3              *LogsArchiveS3    `pulumi:"s3"`
}

type LogsArchiveState struct {
	Azure           LogsArchiveAzurePtrInput
	Gcs             LogsArchiveGcsPtrInput
	IncludeTags     pulumi.BoolPtrInput
	Name            pulumi.StringPtrInput
	Query           pulumi.StringPtrInput
	RehydrationTags pulumi.StringArrayInput
	S3              LogsArchiveS3PtrInput
}

func (LogsArchiveState) ElementType() reflect.Type {
	return reflect.TypeOf((*logsArchiveState)(nil)).Elem()
}

type logsArchiveArgs struct {
	Azure           *LogsArchiveAzure `pulumi:"azure"`
	Gcs             *LogsArchiveGcs   `pulumi:"gcs"`
	IncludeTags     *bool             `pulumi:"includeTags"`
	Name            string            `pulumi:"name"`
	Query           string            `pulumi:"query"`
	RehydrationTags []string          `pulumi:"rehydrationTags"`
	S3              *LogsArchiveS3    `pulumi:"s3"`
}

// The set of arguments for constructing a LogsArchive resource.
type LogsArchiveArgs struct {
	Azure           LogsArchiveAzurePtrInput
	Gcs             LogsArchiveGcsPtrInput
	IncludeTags     pulumi.BoolPtrInput
	Name            pulumi.StringInput
	Query           pulumi.StringInput
	RehydrationTags pulumi.StringArrayInput
	S3              LogsArchiveS3PtrInput
}

func (LogsArchiveArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*logsArchiveArgs)(nil)).Elem()
}

type LogsArchiveInput interface {
	pulumi.Input

	ToLogsArchiveOutput() LogsArchiveOutput
	ToLogsArchiveOutputWithContext(ctx context.Context) LogsArchiveOutput
}

func (LogsArchive) ElementType() reflect.Type {
	return reflect.TypeOf((*LogsArchive)(nil)).Elem()
}

func (i LogsArchive) ToLogsArchiveOutput() LogsArchiveOutput {
	return i.ToLogsArchiveOutputWithContext(context.Background())
}

func (i LogsArchive) ToLogsArchiveOutputWithContext(ctx context.Context) LogsArchiveOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LogsArchiveOutput)
}

type LogsArchiveOutput struct {
	*pulumi.OutputState
}

func (LogsArchiveOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LogsArchiveOutput)(nil)).Elem()
}

func (o LogsArchiveOutput) ToLogsArchiveOutput() LogsArchiveOutput {
	return o
}

func (o LogsArchiveOutput) ToLogsArchiveOutputWithContext(ctx context.Context) LogsArchiveOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(LogsArchiveOutput{})
}
