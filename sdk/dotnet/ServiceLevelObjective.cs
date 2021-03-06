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
    /// Provides a Datadog service level objective resource. This can be used to create and manage Datadog service level objectives.
    /// 
    /// ## Example Usage
    /// ### Metric-Based SLO
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Datadog = Pulumi.Datadog;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         // Create a new Datadog service level objective
    ///         var foo = new Datadog.ServiceLevelObjective("foo", new Datadog.ServiceLevelObjectiveArgs
    ///         {
    ///             Description = "My custom metric SLO",
    ///             Name = "Example Metric SLO",
    ///             Query = new Datadog.Inputs.ServiceLevelObjectiveQueryArgs
    ///             {
    ///                 Denominator = "sum:my.custom.count.metric{*}.as_count()",
    ///                 Numerator = "sum:my.custom.count.metric{type:good_events}.as_count()",
    ///             },
    ///             Tags = 
    ///             {
    ///                 "foo:bar",
    ///                 "baz",
    ///             },
    ///             Thresholds = 
    ///             {
    ///                 new Datadog.Inputs.ServiceLevelObjectiveThresholdArgs
    ///                 {
    ///                     Target = 99.9,
    ///                     TargetDisplay = "99.900",
    ///                     Timeframe = "7d",
    ///                     Warning = 99.99,
    ///                     WarningDisplay = "99.990",
    ///                 },
    ///                 new Datadog.Inputs.ServiceLevelObjectiveThresholdArgs
    ///                 {
    ///                     Target = 99.9,
    ///                     TargetDisplay = "99.900",
    ///                     Timeframe = "30d",
    ///                     Warning = 99.99,
    ///                     WarningDisplay = "99.990",
    ///                 },
    ///             },
    ///             Type = "metric",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Monitor-Based SLO
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Datadog = Pulumi.Datadog;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         // Create a new Datadog service level objective
    ///         var bar = new Datadog.ServiceLevelObjective("bar", new Datadog.ServiceLevelObjectiveArgs
    ///         {
    ///             Description = "My custom monitor SLO",
    ///             MonitorIds = 
    ///             {
    ///                 1,
    ///                 2,
    ///                 3,
    ///             },
    ///             Name = "Example Monitor SLO",
    ///             Tags = 
    ///             {
    ///                 "foo:bar",
    ///                 "baz",
    ///             },
    ///             Thresholds = 
    ///             {
    ///                 new Datadog.Inputs.ServiceLevelObjectiveThresholdArgs
    ///                 {
    ///                     Target = 99.9,
    ///                     Timeframe = "7d",
    ///                     Warning = 99.99,
    ///                 },
    ///                 new Datadog.Inputs.ServiceLevelObjectiveThresholdArgs
    ///                 {
    ///                     Target = 99.9,
    ///                     Timeframe = "30d",
    ///                     Warning = 99.99,
    ///                 },
    ///             },
    ///             Type = "monitor",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// Service Level Objectives can be imported using their string ID, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import datadog:index/serviceLevelObjective:ServiceLevelObjective baz 12345678901234567890123456789012
    /// ```
    /// </summary>
    [DatadogResourceType("datadog:index/serviceLevelObjective:ServiceLevelObjective")]
    public partial class ServiceLevelObjective : Pulumi.CustomResource
    {
        /// <summary>
        /// A description of this service level objective.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// A boolean indicating whether this monitor can be deleted even if it’s referenced by other resources (e.g. dashboards).
        /// -   `thresholds`: (Required) - A list of thresholds and targets that define the service level objectives from the provided SLIs.
        /// </summary>
        [Output("forceDelete")]
        public Output<bool?> ForceDelete { get; private set; } = null!;

        /// <summary>
        /// A static set of groups to filter monitor-based SLOs
        /// </summary>
        [Output("groups")]
        public Output<ImmutableArray<string>> Groups { get; private set; } = null!;

        /// <summary>
        /// A static set of monitor IDs to use as part of the SLO
        /// </summary>
        [Output("monitorIds")]
        public Output<ImmutableArray<int>> MonitorIds { get; private set; } = null!;

        /// <summary>
        /// Name of Datadog service level objective
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The metric query of good / total events
        /// </summary>
        [Output("query")]
        public Output<Outputs.ServiceLevelObjectiveQuery?> Query { get; private set; } = null!;

        /// <summary>
        /// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        /// <summary>
        /// A list of thresholds and targets that define the service level objectives from the provided SLIs.
        /// </summary>
        [Output("thresholds")]
        public Output<ImmutableArray<Outputs.ServiceLevelObjectiveThreshold>> Thresholds { get; private set; } = null!;

        /// <summary>
        /// The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be
        /// found in the Datadog API [documentation
        /// page](https://docs.datadoghq.com/api/v1/service-level-objectives/#create-a-slo-object). Available options to choose from
        /// are: `metric` and `monitor`.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Whether or not to validate the SLO.
        /// </summary>
        [Output("validate")]
        public Output<bool?> Validate { get; private set; } = null!;


        /// <summary>
        /// Create a ServiceLevelObjective resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ServiceLevelObjective(string name, ServiceLevelObjectiveArgs args, CustomResourceOptions? options = null)
            : base("datadog:index/serviceLevelObjective:ServiceLevelObjective", name, args ?? new ServiceLevelObjectiveArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ServiceLevelObjective(string name, Input<string> id, ServiceLevelObjectiveState? state = null, CustomResourceOptions? options = null)
            : base("datadog:index/serviceLevelObjective:ServiceLevelObjective", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ServiceLevelObjective resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ServiceLevelObjective Get(string name, Input<string> id, ServiceLevelObjectiveState? state = null, CustomResourceOptions? options = null)
        {
            return new ServiceLevelObjective(name, id, state, options);
        }
    }

    public sealed class ServiceLevelObjectiveArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A description of this service level objective.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// A boolean indicating whether this monitor can be deleted even if it’s referenced by other resources (e.g. dashboards).
        /// -   `thresholds`: (Required) - A list of thresholds and targets that define the service level objectives from the provided SLIs.
        /// </summary>
        [Input("forceDelete")]
        public Input<bool>? ForceDelete { get; set; }

        [Input("groups")]
        private InputList<string>? _groups;

        /// <summary>
        /// A static set of groups to filter monitor-based SLOs
        /// </summary>
        public InputList<string> Groups
        {
            get => _groups ?? (_groups = new InputList<string>());
            set => _groups = value;
        }

        [Input("monitorIds")]
        private InputList<int>? _monitorIds;

        /// <summary>
        /// A static set of monitor IDs to use as part of the SLO
        /// </summary>
        public InputList<int> MonitorIds
        {
            get => _monitorIds ?? (_monitorIds = new InputList<int>());
            set => _monitorIds = value;
        }

        /// <summary>
        /// Name of Datadog service level objective
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The metric query of good / total events
        /// </summary>
        [Input("query")]
        public Input<Inputs.ServiceLevelObjectiveQueryArgs>? Query { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("thresholds", required: true)]
        private InputList<Inputs.ServiceLevelObjectiveThresholdArgs>? _thresholds;

        /// <summary>
        /// A list of thresholds and targets that define the service level objectives from the provided SLIs.
        /// </summary>
        public InputList<Inputs.ServiceLevelObjectiveThresholdArgs> Thresholds
        {
            get => _thresholds ?? (_thresholds = new InputList<Inputs.ServiceLevelObjectiveThresholdArgs>());
            set => _thresholds = value;
        }

        /// <summary>
        /// The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be
        /// found in the Datadog API [documentation
        /// page](https://docs.datadoghq.com/api/v1/service-level-objectives/#create-a-slo-object). Available options to choose from
        /// are: `metric` and `monitor`.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// Whether or not to validate the SLO.
        /// </summary>
        [Input("validate")]
        public Input<bool>? Validate { get; set; }

        public ServiceLevelObjectiveArgs()
        {
        }
    }

    public sealed class ServiceLevelObjectiveState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A description of this service level objective.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// A boolean indicating whether this monitor can be deleted even if it’s referenced by other resources (e.g. dashboards).
        /// -   `thresholds`: (Required) - A list of thresholds and targets that define the service level objectives from the provided SLIs.
        /// </summary>
        [Input("forceDelete")]
        public Input<bool>? ForceDelete { get; set; }

        [Input("groups")]
        private InputList<string>? _groups;

        /// <summary>
        /// A static set of groups to filter monitor-based SLOs
        /// </summary>
        public InputList<string> Groups
        {
            get => _groups ?? (_groups = new InputList<string>());
            set => _groups = value;
        }

        [Input("monitorIds")]
        private InputList<int>? _monitorIds;

        /// <summary>
        /// A static set of monitor IDs to use as part of the SLO
        /// </summary>
        public InputList<int> MonitorIds
        {
            get => _monitorIds ?? (_monitorIds = new InputList<int>());
            set => _monitorIds = value;
        }

        /// <summary>
        /// Name of Datadog service level objective
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The metric query of good / total events
        /// </summary>
        [Input("query")]
        public Input<Inputs.ServiceLevelObjectiveQueryGetArgs>? Query { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// A list of tags to associate with your service level objective. This can help you categorize and filter service level objectives in the service level objectives page of the UI. Note: it's not currently possible to filter by these tags when querying via the API
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("thresholds")]
        private InputList<Inputs.ServiceLevelObjectiveThresholdGetArgs>? _thresholds;

        /// <summary>
        /// A list of thresholds and targets that define the service level objectives from the provided SLIs.
        /// </summary>
        public InputList<Inputs.ServiceLevelObjectiveThresholdGetArgs> Thresholds
        {
            get => _thresholds ?? (_thresholds = new InputList<Inputs.ServiceLevelObjectiveThresholdGetArgs>());
            set => _thresholds = value;
        }

        /// <summary>
        /// The type of the service level objective. The mapping from these types to the types found in the Datadog Web UI can be
        /// found in the Datadog API [documentation
        /// page](https://docs.datadoghq.com/api/v1/service-level-objectives/#create-a-slo-object). Available options to choose from
        /// are: `metric` and `monitor`.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// Whether or not to validate the SLO.
        /// </summary>
        [Input("validate")]
        public Input<bool>? Validate { get; set; }

        public ServiceLevelObjectiveState()
        {
        }
    }
}
