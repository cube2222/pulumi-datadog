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
    /// Provides a Datadog dashboard_list resource. This can be used to create and manage Datadog Dashboard Lists and the individual dashboards within them.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/dashboard_list.markdown.
    /// </summary>
    public partial class DashboardList : Pulumi.CustomResource
    {
        /// <summary>
        /// An individual dashboard object to add to this Dashboard List. If present, must contain the following:
        /// </summary>
        [Output("dashItems")]
        public Output<ImmutableArray<Outputs.DashboardListDashItems>> DashItems { get; private set; } = null!;

        /// <summary>
        /// The name of this Dashbaord List.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;


        /// <summary>
        /// Create a DashboardList resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DashboardList(string name, DashboardListArgs args, CustomResourceOptions? options = null)
            : base("datadog:index/dashboardList:DashboardList", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private DashboardList(string name, Input<string> id, DashboardListState? state = null, CustomResourceOptions? options = null)
            : base("datadog:index/dashboardList:DashboardList", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DashboardList resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DashboardList Get(string name, Input<string> id, DashboardListState? state = null, CustomResourceOptions? options = null)
        {
            return new DashboardList(name, id, state, options);
        }
    }

    public sealed class DashboardListArgs : Pulumi.ResourceArgs
    {
        [Input("dashItems")]
        private InputList<Inputs.DashboardListDashItemsArgs>? _dashItems;

        /// <summary>
        /// An individual dashboard object to add to this Dashboard List. If present, must contain the following:
        /// </summary>
        public InputList<Inputs.DashboardListDashItemsArgs> DashItems
        {
            get => _dashItems ?? (_dashItems = new InputList<Inputs.DashboardListDashItemsArgs>());
            set => _dashItems = value;
        }

        /// <summary>
        /// The name of this Dashbaord List.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public DashboardListArgs()
        {
        }
    }

    public sealed class DashboardListState : Pulumi.ResourceArgs
    {
        [Input("dashItems")]
        private InputList<Inputs.DashboardListDashItemsGetArgs>? _dashItems;

        /// <summary>
        /// An individual dashboard object to add to this Dashboard List. If present, must contain the following:
        /// </summary>
        public InputList<Inputs.DashboardListDashItemsGetArgs> DashItems
        {
            get => _dashItems ?? (_dashItems = new InputList<Inputs.DashboardListDashItemsGetArgs>());
            set => _dashItems = value;
        }

        /// <summary>
        /// The name of this Dashbaord List.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public DashboardListState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class DashboardListDashItemsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of this dashboard.
        /// </summary>
        [Input("dashId", required: true)]
        public Input<string> DashId { get; set; } = null!;

        /// <summary>
        /// The type of this dashboard. Available options are: `custom_timeboard`, `custom_screenboard`, `integration_screenboard`, `integration_timeboard`, and `host_timeboard`
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public DashboardListDashItemsArgs()
        {
        }
    }

    public sealed class DashboardListDashItemsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of this dashboard.
        /// </summary>
        [Input("dashId", required: true)]
        public Input<string> DashId { get; set; } = null!;

        /// <summary>
        /// The type of this dashboard. Available options are: `custom_timeboard`, `custom_screenboard`, `integration_screenboard`, `integration_timeboard`, and `host_timeboard`
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public DashboardListDashItemsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class DashboardListDashItems
    {
        /// <summary>
        /// The ID of this dashboard.
        /// </summary>
        public readonly string DashId;
        /// <summary>
        /// The type of this dashboard. Available options are: `custom_timeboard`, `custom_screenboard`, `integration_screenboard`, `integration_timeboard`, and `host_timeboard`
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private DashboardListDashItems(
            string dashId,
            string type)
        {
            DashId = dashId;
            Type = type;
        }
    }
    }
}
