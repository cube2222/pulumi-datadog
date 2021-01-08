// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package config

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi/config"
)

// (Required unless validate is false) Datadog API key. This can also be set via the DD_API_KEY environment variable.
func GetApiKey(ctx *pulumi.Context) string {
	v, err := config.Try(ctx, "datadog:apiKey")
	if err == nil {
		return v
	}
	return getEnvOrDefault("", nil, "DATADOG_API_KEY").(string)
}

// The API Url. This can be also be set via the DD_HOST environment variable. Note that this URL must not end with the
// /api/ path. For example, https://api.datadoghq.com/ is a correct value, while https://api.datadoghq.com/api/ is not. And
// if you're working with "EU" version of Datadog, use https://api.datadoghq.eu/.
func GetApiUrl(ctx *pulumi.Context) string {
	v, err := config.Try(ctx, "datadog:apiUrl")
	if err == nil {
		return v
	}
	return getEnvOrDefault("", nil, "DATADOG_HOST").(string)
}

// (Required unless validate is false) Datadog APP key. This can also be set via the DD_APP_KEY environment variable.
func GetAppKey(ctx *pulumi.Context) string {
	v, err := config.Try(ctx, "datadog:appKey")
	if err == nil {
		return v
	}
	return getEnvOrDefault("", nil, "DATADOG_APP_KEY").(string)
}

// Enables validation of the provided API and APP keys during provider initialization. Default is true. When false, api_key
// and app_keywon't be checked.
func GetValidate(ctx *pulumi.Context) bool {
	return config.GetBool(ctx, "datadog:validate")
}
