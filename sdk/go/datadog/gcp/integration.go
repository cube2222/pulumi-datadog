// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package gcp

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Datadog - Google Cloud Platform integration resource. This can be used to create and manage Datadog - Google Cloud Platform integration.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/integration_gcp.html.markdown.
type Integration struct {
	s *pulumi.ResourceState
}

// NewIntegration registers a new resource with the given unique name, arguments, and options.
func NewIntegration(ctx *pulumi.Context,
	name string, args *IntegrationArgs, opts ...pulumi.ResourceOpt) (*Integration, error) {
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
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["clientEmail"] = nil
		inputs["clientId"] = nil
		inputs["hostFilters"] = nil
		inputs["privateKey"] = nil
		inputs["privateKeyId"] = nil
		inputs["projectId"] = nil
	} else {
		inputs["clientEmail"] = args.ClientEmail
		inputs["clientId"] = args.ClientId
		inputs["hostFilters"] = args.HostFilters
		inputs["privateKey"] = args.PrivateKey
		inputs["privateKeyId"] = args.PrivateKeyId
		inputs["projectId"] = args.ProjectId
	}
	s, err := ctx.RegisterResource("datadog:gcp/integration:Integration", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Integration{s: s}, nil
}

// GetIntegration gets an existing Integration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIntegration(ctx *pulumi.Context,
	name string, id pulumi.ID, state *IntegrationState, opts ...pulumi.ResourceOpt) (*Integration, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["clientEmail"] = state.ClientEmail
		inputs["clientId"] = state.ClientId
		inputs["hostFilters"] = state.HostFilters
		inputs["privateKey"] = state.PrivateKey
		inputs["privateKeyId"] = state.PrivateKeyId
		inputs["projectId"] = state.ProjectId
	}
	s, err := ctx.ReadResource("datadog:gcp/integration:Integration", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Integration{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Integration) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Integration) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// Your email found in your JSON service account key.
func (r *Integration) ClientEmail() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["clientEmail"])
}

// Your ID found in your JSON service account key.
func (r *Integration) ClientId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["clientId"])
}

// Limit the GCE instances that are pulled into Datadog by using tags. Only hosts that match one of the defined tags are imported into Datadog.
func (r *Integration) HostFilters() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["hostFilters"])
}

// Your private key name found in your JSON service account key.
func (r *Integration) PrivateKey() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["privateKey"])
}

// Your private key ID found in your JSON service account key.
func (r *Integration) PrivateKeyId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["privateKeyId"])
}

// Your Google Cloud project ID found in your JSON service account key.
func (r *Integration) ProjectId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["projectId"])
}

// Input properties used for looking up and filtering Integration resources.
type IntegrationState struct {
	// Your email found in your JSON service account key.
	ClientEmail interface{}
	// Your ID found in your JSON service account key.
	ClientId interface{}
	// Limit the GCE instances that are pulled into Datadog by using tags. Only hosts that match one of the defined tags are imported into Datadog.
	HostFilters interface{}
	// Your private key name found in your JSON service account key.
	PrivateKey interface{}
	// Your private key ID found in your JSON service account key.
	PrivateKeyId interface{}
	// Your Google Cloud project ID found in your JSON service account key.
	ProjectId interface{}
}

// The set of arguments for constructing a Integration resource.
type IntegrationArgs struct {
	// Your email found in your JSON service account key.
	ClientEmail interface{}
	// Your ID found in your JSON service account key.
	ClientId interface{}
	// Limit the GCE instances that are pulled into Datadog by using tags. Only hosts that match one of the defined tags are imported into Datadog.
	HostFilters interface{}
	// Your private key name found in your JSON service account key.
	PrivateKey interface{}
	// Your private key ID found in your JSON service account key.
	PrivateKeyId interface{}
	// Your Google Cloud project ID found in your JSON service account key.
	ProjectId interface{}
}
