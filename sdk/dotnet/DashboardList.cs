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
    /// ## Example Usage
    /// 
    /// Create a new Dashboard list with two dashboards
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Datadog = Pulumi.Datadog;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var time = new Datadog.Dashboard("time", new Datadog.DashboardArgs
    ///         {
    ///             Description = "Created using the Datadog provider in TF",
    ///             IsReadOnly = true,
    ///             LayoutType = "ordered",
    ///             Title = "TF Test Layout Dashboard",
    ///             Widgets = 
    ///             {
    ///                 new Datadog.Inputs.DashboardWidgetArgs
    ///                 {
    ///                     AlertGraphDefinition = new Datadog.Inputs.DashboardWidgetAlertGraphDefinitionArgs
    ///                     {
    ///                         AlertId = "1234",
    ///                         Time = new Datadog.Inputs.DashboardWidgetAlertGraphDefinitionTimeArgs
    ///                         {
    ///                             LiveSpan = "1h",
    ///                         },
    ///                         Title = "Widget Title",
    ///                         VizType = "timeseries",
    ///                     },
    ///                 },
    ///             },
    ///         });
    ///         var screen = new Datadog.Dashboard("screen", new Datadog.DashboardArgs
    ///         {
    ///             Description = "Created using the Datadog provider in TF",
    ///             IsReadOnly = false,
    ///             LayoutType = "free",
    ///             Title = "TF Test Free Layout Dashboard",
    ///             Widgets = 
    ///             {
    ///                 new Datadog.Inputs.DashboardWidgetArgs
    ///                 {
    ///                     EventStreamDefinition = new Datadog.Inputs.DashboardWidgetEventStreamDefinitionArgs
    ///                     {
    ///                         EventSize = "l",
    ///                         Query = "*",
    ///                         Time = new Datadog.Inputs.DashboardWidgetEventStreamDefinitionTimeArgs
    ///                         {
    ///                             LiveSpan = "1h",
    ///                         },
    ///                         Title = "Widget Title",
    ///                         TitleAlign = "left",
    ///                         TitleSize = "16",
    ///                     },
    ///                     Layout = new Datadog.Inputs.DashboardWidgetLayoutArgs
    ///                     {
    ///                         Height = 43,
    ///                         Width = 32,
    ///                         X = 5,
    ///                         Y = 5,
    ///                     },
    ///                 },
    ///             },
    ///         });
    ///         var newList = new Datadog.DashboardList("newList", new Datadog.DashboardListArgs
    ///         {
    ///             DashItems = 
    ///             {
    ///                 new Datadog.Inputs.DashboardListDashItemArgs
    ///                 {
    ///                     DashId = time.Id,
    ///                     Type = "custom_timeboard",
    ///                 },
    ///                 new Datadog.Inputs.DashboardListDashItemArgs
    ///                 {
    ///                     DashId = screen.Id,
    ///                     Type = "custom_screenboard",
    ///                 },
    ///             },
    ///             Name = "TF Created List",
    ///         }, new CustomResourceOptions
    ///         {
    ///             DependsOn = 
    ///             {
    ///                 "datadog_dashboard.screen",
    ///                 "datadog_dashboard.time",
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class DashboardList : Pulumi.CustomResource
    {
        /// <summary>
        /// An individual dashboard object to add to this Dashboard List. If present, must contain the following:
        /// </summary>
        [Output("dashItems")]
        public Output<ImmutableArray<Outputs.DashboardListDashItem>> DashItems { get; private set; } = null!;

        /// <summary>
        /// The name of this Dashboard List.
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
            : base("datadog:index/dashboardList:DashboardList", name, args ?? new DashboardListArgs(), MakeResourceOptions(options, ""))
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
        private InputList<Inputs.DashboardListDashItemArgs>? _dashItems;

        /// <summary>
        /// An individual dashboard object to add to this Dashboard List. If present, must contain the following:
        /// </summary>
        public InputList<Inputs.DashboardListDashItemArgs> DashItems
        {
            get => _dashItems ?? (_dashItems = new InputList<Inputs.DashboardListDashItemArgs>());
            set => _dashItems = value;
        }

        /// <summary>
        /// The name of this Dashboard List.
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
        private InputList<Inputs.DashboardListDashItemGetArgs>? _dashItems;

        /// <summary>
        /// An individual dashboard object to add to this Dashboard List. If present, must contain the following:
        /// </summary>
        public InputList<Inputs.DashboardListDashItemGetArgs> DashItems
        {
            get => _dashItems ?? (_dashItems = new InputList<Inputs.DashboardListDashItemGetArgs>());
            set => _dashItems = value;
        }

        /// <summary>
        /// The name of this Dashboard List.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public DashboardListState()
        {
        }
    }
}
