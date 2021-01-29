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
    /// Provides a Datadog synthetics global variable resource. This can be used to create and manage Datadog synthetics global variables.
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
    ///         var testVariable = new Datadog.SyntheticsGlobalVariable("testVariable", new Datadog.SyntheticsGlobalVariableArgs
    ///         {
    ///             Description = "Description of the variable",
    ///             Name = "EXAMPLE_VARIABLE",
    ///             Tags = 
    ///             {
    ///                 "foo:bar",
    ///                 "env:test",
    ///             },
    ///             Value = "variable-value",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// Synthetics global variables can be imported using their string ID, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import datadog:index/syntheticsGlobalVariable:SyntheticsGlobalVariable fizz abcde123-fghi-456-jkl-mnopqrstuv
    /// ```
    /// </summary>
    [DatadogResourceType("datadog:index/syntheticsGlobalVariable:SyntheticsGlobalVariable")]
    public partial class SyntheticsGlobalVariable : Pulumi.CustomResource
    {
        /// <summary>
        /// Description of the global variable.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Synthetics global variable name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Id of the Synthetics test to use for a variable from test.
        /// </summary>
        [Output("parseTestId")]
        public Output<string?> ParseTestId { get; private set; } = null!;

        /// <summary>
        /// ID of the Synthetics test to use a source of the global variable value.
        /// </summary>
        [Output("parseTestOptions")]
        public Output<Outputs.SyntheticsGlobalVariableParseTestOptions?> ParseTestOptions { get; private set; } = null!;

        /// <summary>
        /// Sets the variable as secure. Defaults to `false`.
        /// </summary>
        [Output("secure")]
        public Output<bool?> Secure { get; private set; } = null!;

        /// <summary>
        /// A list of tags to associate with your synthetics global variable.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        /// <summary>
        /// The value of the global variable.
        /// </summary>
        [Output("value")]
        public Output<string> Value { get; private set; } = null!;


        /// <summary>
        /// Create a SyntheticsGlobalVariable resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SyntheticsGlobalVariable(string name, SyntheticsGlobalVariableArgs args, CustomResourceOptions? options = null)
            : base("datadog:index/syntheticsGlobalVariable:SyntheticsGlobalVariable", name, args ?? new SyntheticsGlobalVariableArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SyntheticsGlobalVariable(string name, Input<string> id, SyntheticsGlobalVariableState? state = null, CustomResourceOptions? options = null)
            : base("datadog:index/syntheticsGlobalVariable:SyntheticsGlobalVariable", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SyntheticsGlobalVariable resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SyntheticsGlobalVariable Get(string name, Input<string> id, SyntheticsGlobalVariableState? state = null, CustomResourceOptions? options = null)
        {
            return new SyntheticsGlobalVariable(name, id, state, options);
        }
    }

    public sealed class SyntheticsGlobalVariableArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the global variable.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Synthetics global variable name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Id of the Synthetics test to use for a variable from test.
        /// </summary>
        [Input("parseTestId")]
        public Input<string>? ParseTestId { get; set; }

        /// <summary>
        /// ID of the Synthetics test to use a source of the global variable value.
        /// </summary>
        [Input("parseTestOptions")]
        public Input<Inputs.SyntheticsGlobalVariableParseTestOptionsArgs>? ParseTestOptions { get; set; }

        /// <summary>
        /// Sets the variable as secure. Defaults to `false`.
        /// </summary>
        [Input("secure")]
        public Input<bool>? Secure { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// A list of tags to associate with your synthetics global variable.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The value of the global variable.
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public SyntheticsGlobalVariableArgs()
        {
        }
    }

    public sealed class SyntheticsGlobalVariableState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the global variable.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Synthetics global variable name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Id of the Synthetics test to use for a variable from test.
        /// </summary>
        [Input("parseTestId")]
        public Input<string>? ParseTestId { get; set; }

        /// <summary>
        /// ID of the Synthetics test to use a source of the global variable value.
        /// </summary>
        [Input("parseTestOptions")]
        public Input<Inputs.SyntheticsGlobalVariableParseTestOptionsGetArgs>? ParseTestOptions { get; set; }

        /// <summary>
        /// Sets the variable as secure. Defaults to `false`.
        /// </summary>
        [Input("secure")]
        public Input<bool>? Secure { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// A list of tags to associate with your synthetics global variable.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The value of the global variable.
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public SyntheticsGlobalVariableState()
        {
        }
    }
}
