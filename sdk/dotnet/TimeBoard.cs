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
    /// ## Import
    /// 
    /// Timeboards can be imported using their numeric ID, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import datadog:index/timeBoard:TimeBoard my_service_timeboard 2081
    /// ```
    /// </summary>
    public partial class TimeBoard : Pulumi.CustomResource
    {
        /// <summary>
        /// A description of the dashboard's content.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// A list of graph definitions.
        /// </summary>
        [Output("graphs")]
        public Output<ImmutableArray<Outputs.TimeBoardGraph>> Graphs { get; private set; } = null!;

        [Output("readOnly")]
        public Output<bool?> ReadOnly { get; private set; } = null!;

        /// <summary>
        /// A list of template variables for using Dashboard templating.
        /// </summary>
        [Output("templateVariables")]
        public Output<ImmutableArray<Outputs.TimeBoardTemplateVariable>> TemplateVariables { get; private set; } = null!;

        /// <summary>
        /// The name of the dashboard.
        /// </summary>
        [Output("title")]
        public Output<string> Title { get; private set; } = null!;


        /// <summary>
        /// Create a TimeBoard resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TimeBoard(string name, TimeBoardArgs args, CustomResourceOptions? options = null)
            : base("datadog:index/timeBoard:TimeBoard", name, args ?? new TimeBoardArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TimeBoard(string name, Input<string> id, TimeBoardState? state = null, CustomResourceOptions? options = null)
            : base("datadog:index/timeBoard:TimeBoard", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing TimeBoard resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TimeBoard Get(string name, Input<string> id, TimeBoardState? state = null, CustomResourceOptions? options = null)
        {
            return new TimeBoard(name, id, state, options);
        }
    }

    public sealed class TimeBoardArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A description of the dashboard's content.
        /// </summary>
        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        [Input("graphs", required: true)]
        private InputList<Inputs.TimeBoardGraphArgs>? _graphs;

        /// <summary>
        /// A list of graph definitions.
        /// </summary>
        public InputList<Inputs.TimeBoardGraphArgs> Graphs
        {
            get => _graphs ?? (_graphs = new InputList<Inputs.TimeBoardGraphArgs>());
            set => _graphs = value;
        }

        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        [Input("templateVariables")]
        private InputList<Inputs.TimeBoardTemplateVariableArgs>? _templateVariables;

        /// <summary>
        /// A list of template variables for using Dashboard templating.
        /// </summary>
        public InputList<Inputs.TimeBoardTemplateVariableArgs> TemplateVariables
        {
            get => _templateVariables ?? (_templateVariables = new InputList<Inputs.TimeBoardTemplateVariableArgs>());
            set => _templateVariables = value;
        }

        /// <summary>
        /// The name of the dashboard.
        /// </summary>
        [Input("title", required: true)]
        public Input<string> Title { get; set; } = null!;

        public TimeBoardArgs()
        {
        }
    }

    public sealed class TimeBoardState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A description of the dashboard's content.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("graphs")]
        private InputList<Inputs.TimeBoardGraphGetArgs>? _graphs;

        /// <summary>
        /// A list of graph definitions.
        /// </summary>
        public InputList<Inputs.TimeBoardGraphGetArgs> Graphs
        {
            get => _graphs ?? (_graphs = new InputList<Inputs.TimeBoardGraphGetArgs>());
            set => _graphs = value;
        }

        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        [Input("templateVariables")]
        private InputList<Inputs.TimeBoardTemplateVariableGetArgs>? _templateVariables;

        /// <summary>
        /// A list of template variables for using Dashboard templating.
        /// </summary>
        public InputList<Inputs.TimeBoardTemplateVariableGetArgs> TemplateVariables
        {
            get => _templateVariables ?? (_templateVariables = new InputList<Inputs.TimeBoardTemplateVariableGetArgs>());
            set => _templateVariables = value;
        }

        /// <summary>
        /// The name of the dashboard.
        /// </summary>
        [Input("title")]
        public Input<string>? Title { get; set; }

        public TimeBoardState()
        {
        }
    }
}
