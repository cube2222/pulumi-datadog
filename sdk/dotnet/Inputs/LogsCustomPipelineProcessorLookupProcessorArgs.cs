// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class LogsCustomPipelineProcessorLookupProcessorArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Default lookup value to use if there is no entry in the lookup table for the value of the source attribute.
        /// </summary>
        [Input("defaultLookup")]
        public Input<string>? DefaultLookup { get; set; }

        /// <summary>
        /// If the processor is enabled or not.
        /// </summary>
        [Input("isEnabled")]
        public Input<bool>? IsEnabled { get; set; }

        [Input("lookupTables", required: true)]
        private InputList<string>? _lookupTables;

        /// <summary>
        /// List of entries of the lookup table using `"key,value"` format.
        /// </summary>
        public InputList<string> LookupTables
        {
            get => _lookupTables ?? (_lookupTables = new InputList<string>());
            set => _lookupTables = value;
        }

        /// <summary>
        /// Name of the processor
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Name of the source attribute used to do the lookup.
        /// </summary>
        [Input("source", required: true)]
        public Input<string> Source { get; set; } = null!;

        /// <summary>
        /// Name of the parent attribute that contains all the extracted details from the sources.
        /// </summary>
        [Input("target", required: true)]
        public Input<string> Target { get; set; } = null!;

        public LogsCustomPipelineProcessorLookupProcessorArgs()
        {
        }
    }
}