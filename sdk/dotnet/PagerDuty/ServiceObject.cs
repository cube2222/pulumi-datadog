// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.PagerDuty
{
    /// <summary>
    /// Provides access to individual Service Objects of Datadog - PagerDuty integrations. Note that the Datadog - PagerDuty integration must be activated in the Datadog UI in order for this resource to be usable.
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
    ///         var testingFoo = new Datadog.PagerDuty.ServiceObject("testingFoo", new Datadog.PagerDuty.ServiceObjectArgs
    ///         {
    ///             ServiceKey = "9876543210123456789",
    ///             ServiceName = "testing_foo",
    ///         });
    ///         var testingBar = new Datadog.PagerDuty.ServiceObject("testingBar", new Datadog.PagerDuty.ServiceObjectArgs
    ///         {
    ///             ServiceKey = "54321098765432109876",
    ///             ServiceName = "testing_bar",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class ServiceObject : Pulumi.CustomResource
    {
        /// <summary>
        /// Your Service name associated service key in PagerDuty. Note: Since the Datadog API never returns service keys, it is impossible to detect drifts.
        /// </summary>
        [Output("serviceKey")]
        public Output<string> ServiceKey { get; private set; } = null!;

        /// <summary>
        /// Your Service name in PagerDuty.
        /// </summary>
        [Output("serviceName")]
        public Output<string> ServiceName { get; private set; } = null!;


        /// <summary>
        /// Create a ServiceObject resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ServiceObject(string name, ServiceObjectArgs args, CustomResourceOptions? options = null)
            : base("datadog:pagerduty/serviceObject:ServiceObject", name, args ?? new ServiceObjectArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ServiceObject(string name, Input<string> id, ServiceObjectState? state = null, CustomResourceOptions? options = null)
            : base("datadog:pagerduty/serviceObject:ServiceObject", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ServiceObject resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ServiceObject Get(string name, Input<string> id, ServiceObjectState? state = null, CustomResourceOptions? options = null)
        {
            return new ServiceObject(name, id, state, options);
        }
    }

    public sealed class ServiceObjectArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Your Service name associated service key in PagerDuty. Note: Since the Datadog API never returns service keys, it is impossible to detect drifts.
        /// </summary>
        [Input("serviceKey", required: true)]
        public Input<string> ServiceKey { get; set; } = null!;

        /// <summary>
        /// Your Service name in PagerDuty.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        public ServiceObjectArgs()
        {
        }
    }

    public sealed class ServiceObjectState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Your Service name associated service key in PagerDuty. Note: Since the Datadog API never returns service keys, it is impossible to detect drifts.
        /// </summary>
        [Input("serviceKey")]
        public Input<string>? ServiceKey { get; set; }

        /// <summary>
        /// Your Service name in PagerDuty.
        /// </summary>
        [Input("serviceName")]
        public Input<string>? ServiceName { get; set; }

        public ServiceObjectState()
        {
        }
    }
}
