// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Azure
{
    /// <summary>
    /// Provides a Datadog - Microsoft Azure integration resource. This can be used to create and manage the integrations.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Datadog = Pulumi.Datadog;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         // Create a new Datadog - Microsoft Azure integration
    ///         var sandbox = new Datadog.Azure.Integration("sandbox", new Datadog.Azure.IntegrationArgs
    ///         {
    ///             ClientId = "&lt;azure_client_id&gt;",
    ///             ClientSecret = "&lt;azure_client_secret_key&gt;",
    ///             HostFilters = "examplefilter:true,example:true",
    ///             TenantName = "&lt;azure_tenant_name&gt;",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class Integration : Pulumi.CustomResource
    {
        [Output("clientId")]
        public Output<string> ClientId { get; private set; } = null!;

        [Output("clientSecret")]
        public Output<string> ClientSecret { get; private set; } = null!;

        [Output("hostFilters")]
        public Output<string?> HostFilters { get; private set; } = null!;

        [Output("tenantName")]
        public Output<string> TenantName { get; private set; } = null!;


        /// <summary>
        /// Create a Integration resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Integration(string name, IntegrationArgs args, CustomResourceOptions? options = null)
            : base("datadog:azure/integration:Integration", name, args ?? new IntegrationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Integration(string name, Input<string> id, IntegrationState? state = null, CustomResourceOptions? options = null)
            : base("datadog:azure/integration:Integration", name, state, MakeResourceOptions(options, id))
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
        [Input("clientId", required: true)]
        public Input<string> ClientId { get; set; } = null!;

        [Input("clientSecret", required: true)]
        public Input<string> ClientSecret { get; set; } = null!;

        [Input("hostFilters")]
        public Input<string>? HostFilters { get; set; }

        [Input("tenantName", required: true)]
        public Input<string> TenantName { get; set; } = null!;

        public IntegrationArgs()
        {
        }
    }

    public sealed class IntegrationState : Pulumi.ResourceArgs
    {
        [Input("clientId")]
        public Input<string>? ClientId { get; set; }

        [Input("clientSecret")]
        public Input<string>? ClientSecret { get; set; }

        [Input("hostFilters")]
        public Input<string>? HostFilters { get; set; }

        [Input("tenantName")]
        public Input<string>? TenantName { get; set; }

        public IntegrationState()
        {
        }
    }
}
