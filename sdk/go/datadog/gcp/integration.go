// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package gcp

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Datadog - Google Cloud Platform integration resource. This can be used to create and manage Datadog - Google Cloud Platform integration.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/integration_gcp.html.markdown.
type Integration struct {
	pulumi.CustomResourceState

	// Your email found in your JSON service account key.
	ClientEmail pulumi.StringOutput `pulumi:"clientEmail"`
	// Your ID found in your JSON service account key.
	ClientId pulumi.StringOutput `pulumi:"clientId"`
	// Limit the GCE instances that are pulled into Datadog by using tags. Only hosts that match one of the defined tags are imported into Datadog.
	HostFilters pulumi.StringPtrOutput `pulumi:"hostFilters"`
	// Your private key name found in your JSON service account key.
	PrivateKey pulumi.StringOutput `pulumi:"privateKey"`
	// Your private key ID found in your JSON service account key.
	PrivateKeyId pulumi.StringOutput `pulumi:"privateKeyId"`
	// Your Google Cloud project ID found in your JSON service account key.
	ProjectId pulumi.StringOutput `pulumi:"projectId"`
}

// NewIntegration registers a new resource with the given unique name, arguments, and options.
func NewIntegration(ctx *pulumi.Context,
	name string, args *IntegrationArgs, opts ...pulumi.ResourceOption) (*Integration, error) {
	if args == nil || args.ClientEmail == nil {
		return nil, errors.New("missing required argument 'ClientEmail'")
	}
	if args == nil || args.ClientId == nil {
		return nil, errors.New("missing required argument 'ClientId'")
	}
	if args == nil || args.PrivateKey == nil {
		return nil, errors.New("missing required argument 'PrivateKey'")
	}
	if args == nil || args.PrivateKeyId == nil {
		return nil, errors.New("missing required argument 'PrivateKeyId'")
	}
	if args == nil || args.ProjectId == nil {
		return nil, errors.New("missing required argument 'ProjectId'")
	}
	if args == nil {
		args = &IntegrationArgs{}
	}
	var resource Integration
	err := ctx.RegisterResource("datadog:gcp/integration:Integration", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIntegration gets an existing Integration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIntegration(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IntegrationState, opts ...pulumi.ResourceOption) (*Integration, error) {
	var resource Integration
	err := ctx.ReadResource("datadog:gcp/integration:Integration", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Integration resources.
type integrationState struct {
	// Your email found in your JSON service account key.
	ClientEmail *string `pulumi:"clientEmail"`
	// Your ID found in your JSON service account key.
	ClientId *string `pulumi:"clientId"`
	// Limit the GCE instances that are pulled into Datadog by using tags. Only hosts that match one of the defined tags are imported into Datadog.
	HostFilters *string `pulumi:"hostFilters"`
	// Your private key name found in your JSON service account key.
	PrivateKey *string `pulumi:"privateKey"`
	// Your private key ID found in your JSON service account key.
	PrivateKeyId *string `pulumi:"privateKeyId"`
	// Your Google Cloud project ID found in your JSON service account key.
	ProjectId *string `pulumi:"projectId"`
}

type IntegrationState struct {
	// Your email found in your JSON service account key.
	ClientEmail pulumi.StringPtrInput
	// Your ID found in your JSON service account key.
	ClientId pulumi.StringPtrInput
	// Limit the GCE instances that are pulled into Datadog by using tags. Only hosts that match one of the defined tags are imported into Datadog.
	HostFilters pulumi.StringPtrInput
	// Your private key name found in your JSON service account key.
	PrivateKey pulumi.StringPtrInput
	// Your private key ID found in your JSON service account key.
	PrivateKeyId pulumi.StringPtrInput
	// Your Google Cloud project ID found in your JSON service account key.
	ProjectId pulumi.StringPtrInput
}

func (IntegrationState) ElementType() reflect.Type {
	return reflect.TypeOf((*integrationState)(nil)).Elem()
}

type integrationArgs struct {
	// Your email found in your JSON service account key.
	ClientEmail string `pulumi:"clientEmail"`
	// Your ID found in your JSON service account key.
	ClientId string `pulumi:"clientId"`
	// Limit the GCE instances that are pulled into Datadog by using tags. Only hosts that match one of the defined tags are imported into Datadog.
	HostFilters *string `pulumi:"hostFilters"`
	// Your private key name found in your JSON service account key.
	PrivateKey string `pulumi:"privateKey"`
	// Your private key ID found in your JSON service account key.
	PrivateKeyId string `pulumi:"privateKeyId"`
	// Your Google Cloud project ID found in your JSON service account key.
	ProjectId string `pulumi:"projectId"`
}

// The set of arguments for constructing a Integration resource.
type IntegrationArgs struct {
	// Your email found in your JSON service account key.
	ClientEmail pulumi.StringInput
	// Your ID found in your JSON service account key.
	ClientId pulumi.StringInput
	// Limit the GCE instances that are pulled into Datadog by using tags. Only hosts that match one of the defined tags are imported into Datadog.
	HostFilters pulumi.StringPtrInput
	// Your private key name found in your JSON service account key.
	PrivateKey pulumi.StringInput
	// Your private key ID found in your JSON service account key.
	PrivateKeyId pulumi.StringInput
	// Your Google Cloud project ID found in your JSON service account key.
	ProjectId pulumi.StringInput
}

func (IntegrationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*integrationArgs)(nil)).Elem()
}

