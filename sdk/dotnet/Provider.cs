// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog
{
    /// <summary>
    /// The provider type for the datadog package. By default, resources use package-wide configuration
    /// settings, however an explicit `Provider` instance may be created and passed during resource
    /// construction to achieve fine-grained programmatic control over provider settings. See the
    /// [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.
    /// </summary>
    [DatadogResourceType("pulumi:providers:datadog")]
    public partial class Provider : Pulumi.ProviderResource
    {
        /// <summary>
        /// Create a Provider resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Provider(string name, ProviderArgs? args = null, CustomResourceOptions? options = null)
            : base("datadog", name, args ?? new ProviderArgs(), MakeResourceOptions(options, ""))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
    }

    public sealed class ProviderArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Required unless validate is false) Datadog API key. This can also be set via the DD_API_KEY environment variable.
        /// </summary>
        [Input("apiKey")]
        public Input<string>? ApiKey { get; set; }

        /// <summary>
        /// The API Url. This can also be set via the DD_HOST environment variable. Note that this URL must not end with the /api/
        /// path. For example, https://api.datadoghq.com/ is a correct value, while https://api.datadoghq.com/api/ is not. And if
        /// you're working with "EU" version of Datadog, use https://api.datadoghq.eu/.
        /// </summary>
        [Input("apiUrl")]
        public Input<string>? ApiUrl { get; set; }

        /// <summary>
        /// (Required unless validate is false) Datadog APP key. This can also be set via the DD_APP_KEY environment variable.
        /// </summary>
        [Input("appKey")]
        public Input<string>? AppKey { get; set; }

        /// <summary>
        /// Enables validation of the provided API and APP keys during provider initialization. Default is true. When false, api_key
        /// and app_key won't be checked.
        /// </summary>
        [Input("validate", json: true)]
        public Input<bool>? Validate { get; set; }

        public ProviderArgs()
        {
            ApiKey = Utilities.GetEnv("DATADOG_API_KEY");
            ApiUrl = Utilities.GetEnv("DATADOG_HOST");
            AppKey = Utilities.GetEnv("DATADOG_APP_KEY");
        }
    }
}
