// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package aws

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/pulumi/pulumi-datadog/sdk/v2/go/datadog"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "datadog:aws/integration:Integration":
		r, err = NewIntegration(ctx, name, nil, pulumi.URN_(urn))
	case "datadog:aws/integrationLambdaArn:IntegrationLambdaArn":
		r, err = NewIntegrationLambdaArn(ctx, name, nil, pulumi.URN_(urn))
	case "datadog:aws/integrationLogCollection:IntegrationLogCollection":
		r, err = NewIntegrationLogCollection(ctx, name, nil, pulumi.URN_(urn))
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	return
}

func init() {
	version, err := datadog.PkgVersion()
	if err != nil {
		fmt.Println("failed to determine package version. defaulting to v1: %v", err)
	}
	pulumi.RegisterResourceModule(
		"datadog",
		"aws/integration",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"datadog",
		"aws/integrationLambdaArn",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"datadog",
		"aws/integrationLogCollection",
		&module{version},
	)
}
