// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Aws
{
    /// <summary>
    /// Provides a Datadog - Amazon Web Services integration resource. This can be used to create and manage Datadog - Amazon Web Services integration.
    /// 
    /// Update operations are currently not supported with datadog API so any change forces a new resource.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/integration_aws.html.markdown.
    /// </summary>
    public partial class Integration : Pulumi.CustomResource
    {
        /// <summary>
        /// Your AWS Account ID without dashes.
        /// </summary>
        [Output("accountId")]
        public Output<string> AccountId { get; private set; } = null!;

        /// <summary>
        /// Enables or disables metric collection for specific AWS namespaces for this AWS account only. A list of namespaces can be found at the [available namespace rules API endpoint](https://api.datadoghq.com/api/v1/integration/aws/available_namespace_rules).
        /// </summary>
        [Output("accountSpecificNamespaceRules")]
        public Output<ImmutableDictionary<string, object>?> AccountSpecificNamespaceRules { get; private set; } = null!;

        /// <summary>
        /// AWS External ID
        /// </summary>
        [Output("externalId")]
        public Output<string> ExternalId { get; private set; } = null!;

        /// <summary>
        /// Array of EC2 tags (in the form `key:value`) defines a filter that Datadog use when collecting metrics from EC2. Wildcards, such as `?` (for single characters) and `*` (for multiple characters) can also be used.
        /// </summary>
        [Output("filterTags")]
        public Output<ImmutableArray<string>> FilterTags { get; private set; } = null!;

        /// <summary>
        /// Array of tags (in the form key:value) to add to all hosts and metrics reporting through this integration.
        /// </summary>
        [Output("hostTags")]
        public Output<ImmutableArray<string>> HostTags { get; private set; } = null!;

        /// <summary>
        /// Your Datadog role delegation name.
        /// </summary>
        [Output("roleName")]
        public Output<string> RoleName { get; private set; } = null!;


        /// <summary>
        /// Create a Integration resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Integration(string name, IntegrationArgs args, CustomResourceOptions? options = null)
            : base("datadog:aws/integration:Integration", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Integration(string name, Input<string> id, IntegrationState? state = null, CustomResourceOptions? options = null)
            : base("datadog:aws/integration:Integration", name, state, MakeResourceOptions(options, id))
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
        /// <summary>
        /// Get an existing Integration resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Integration Get(string name, Input<string> id, IntegrationState? state = null, CustomResourceOptions? options = null)
        {
            return new Integration(name, id, state, options);
        }
    }

    public sealed class IntegrationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Your AWS Account ID without dashes.
        /// </summary>
        [Input("accountId", required: true)]
        public Input<string> AccountId { get; set; } = null!;

        [Input("accountSpecificNamespaceRules")]
        private InputMap<object>? _accountSpecificNamespaceRules;

        /// <summary>
        /// Enables or disables metric collection for specific AWS namespaces for this AWS account only. A list of namespaces can be found at the [available namespace rules API endpoint](https://api.datadoghq.com/api/v1/integration/aws/available_namespace_rules).
        /// </summary>
        public InputMap<object> AccountSpecificNamespaceRules
        {
            get => _accountSpecificNamespaceRules ?? (_accountSpecificNamespaceRules = new InputMap<object>());
            set => _accountSpecificNamespaceRules = value;
        }

        [Input("filterTags")]
        private InputList<string>? _filterTags;

        /// <summary>
        /// Array of EC2 tags (in the form `key:value`) defines a filter that Datadog use when collecting metrics from EC2. Wildcards, such as `?` (for single characters) and `*` (for multiple characters) can also be used.
        /// </summary>
        public InputList<string> FilterTags
        {
            get => _filterTags ?? (_filterTags = new InputList<string>());
            set => _filterTags = value;
        }

        [Input("hostTags")]
        private InputList<string>? _hostTags;

        /// <summary>
        /// Array of tags (in the form key:value) to add to all hosts and metrics reporting through this integration.
        /// </summary>
        public InputList<string> HostTags
        {
            get => _hostTags ?? (_hostTags = new InputList<string>());
            set => _hostTags = value;
        }

        /// <summary>
        /// Your Datadog role delegation name.
        /// </summary>
        [Input("roleName", required: true)]
        public Input<string> RoleName { get; set; } = null!;

        public IntegrationArgs()
        {
        }
    }

    public sealed class IntegrationState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Your AWS Account ID without dashes.
        /// </summary>
        [Input("accountId")]
        public Input<string>? AccountId { get; set; }

        [Input("accountSpecificNamespaceRules")]
        private InputMap<object>? _accountSpecificNamespaceRules;

        /// <summary>
        /// Enables or disables metric collection for specific AWS namespaces for this AWS account only. A list of namespaces can be found at the [available namespace rules API endpoint](https://api.datadoghq.com/api/v1/integration/aws/available_namespace_rules).
        /// </summary>
        public InputMap<object> AccountSpecificNamespaceRules
        {
            get => _accountSpecificNamespaceRules ?? (_accountSpecificNamespaceRules = new InputMap<object>());
            set => _accountSpecificNamespaceRules = value;
        }

        /// <summary>
        /// AWS External ID
        /// </summary>
        [Input("externalId")]
        public Input<string>? ExternalId { get; set; }

        [Input("filterTags")]
        private InputList<string>? _filterTags;

        /// <summary>
        /// Array of EC2 tags (in the form `key:value`) defines a filter that Datadog use when collecting metrics from EC2. Wildcards, such as `?` (for single characters) and `*` (for multiple characters) can also be used.
        /// </summary>
        public InputList<string> FilterTags
        {
            get => _filterTags ?? (_filterTags = new InputList<string>());
            set => _filterTags = value;
        }

        [Input("hostTags")]
        private InputList<string>? _hostTags;

        /// <summary>
        /// Array of tags (in the form key:value) to add to all hosts and metrics reporting through this integration.
        /// </summary>
        public InputList<string> HostTags
        {
            get => _hostTags ?? (_hostTags = new InputList<string>());
            set => _hostTags = value;
        }

        /// <summary>
        /// Your Datadog role delegation name.
        /// </summary>
        [Input("roleName")]
        public Input<string>? RoleName { get; set; }

        public IntegrationState()
        {
        }
    }
}
