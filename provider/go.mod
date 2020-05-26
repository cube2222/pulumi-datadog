module github.com/pulumi/pulumi-datadog/provider/v2

go 1.14

require (
	github.com/hashicorp/terraform-plugin-sdk v1.7.0
	github.com/pulumi/pulumi-terraform-bridge/v2 v2.3.3
	github.com/pulumi/pulumi/pkg/v2 v2.2.2-0.20200522013710-a83df2061170 // indirect
	github.com/pulumi/pulumi/sdk/v2 v2.2.2-0.20200522013710-a83df2061170
	github.com/terraform-providers/terraform-provider-datadog v1.9.1-0.20200210163259-e1f6b31c5a1d
)

replace (
	github.com/Azure/go-autorest => github.com/Azure/go-autorest v12.4.3+incompatible
	github.com/hashicorp/vault => github.com/hashicorp/vault v1.2.0
)
