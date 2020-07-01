// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
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
type LogsArchive struct {
	pulumi.CustomResourceState

	// Definition of an azure archive.
	Azure LogsArchiveAzurePtrOutput `pulumi:"azure"`
	// Definition of an gcs archive.
	Gcs LogsArchiveGcsPtrOutput `pulumi:"gcs"`
	// Your archive name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The archive query/filter. Logs matching this query are included in the archive.
	Query pulumi.StringOutput `pulumi:"query"`
	// Definition of an s3 archive.
	S3 LogsArchiveS3PtrOutput `pulumi:"s3"`
}

// NewLogsArchive registers a new resource with the given unique name, arguments, and options.
func NewLogsArchive(ctx *pulumi.Context,
	name string, args *LogsArchiveArgs, opts ...pulumi.ResourceOption) (*LogsArchive, error) {
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.Query == nil {
		return nil, errors.New("missing required argument 'Query'")
	}
	if args == nil {
		args = &LogsArchiveArgs{}
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
	// Definition of an azure archive.
	Azure *LogsArchiveAzure `pulumi:"azure"`
	// Definition of an gcs archive.
	Gcs *LogsArchiveGcs `pulumi:"gcs"`
	// Your archive name.
	Name *string `pulumi:"name"`
	// The archive query/filter. Logs matching this query are included in the archive.
	Query *string `pulumi:"query"`
	// Definition of an s3 archive.
	S3 *LogsArchiveS3 `pulumi:"s3"`
}

type LogsArchiveState struct {
	// Definition of an azure archive.
	Azure LogsArchiveAzurePtrInput
	// Definition of an gcs archive.
	Gcs LogsArchiveGcsPtrInput
	// Your archive name.
	Name pulumi.StringPtrInput
	// The archive query/filter. Logs matching this query are included in the archive.
	Query pulumi.StringPtrInput
	// Definition of an s3 archive.
	S3 LogsArchiveS3PtrInput
}

func (LogsArchiveState) ElementType() reflect.Type {
	return reflect.TypeOf((*logsArchiveState)(nil)).Elem()
}

type logsArchiveArgs struct {
	// Definition of an azure archive.
	Azure *LogsArchiveAzure `pulumi:"azure"`
	// Definition of an gcs archive.
	Gcs *LogsArchiveGcs `pulumi:"gcs"`
	// Your archive name.
	Name string `pulumi:"name"`
	// The archive query/filter. Logs matching this query are included in the archive.
	Query string `pulumi:"query"`
	// Definition of an s3 archive.
	S3 *LogsArchiveS3 `pulumi:"s3"`
}

// The set of arguments for constructing a LogsArchive resource.
type LogsArchiveArgs struct {
	// Definition of an azure archive.
	Azure LogsArchiveAzurePtrInput
	// Definition of an gcs archive.
	Gcs LogsArchiveGcsPtrInput
	// Your archive name.
	Name pulumi.StringInput
	// The archive query/filter. Logs matching this query are included in the archive.
	Query pulumi.StringInput
	// Definition of an s3 archive.
	S3 LogsArchiveS3PtrInput
}

func (LogsArchiveArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*logsArchiveArgs)(nil)).Elem()
}
