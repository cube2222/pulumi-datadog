// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class LogsCustomPipelineProcessorPipelineProcessorCategoryProcessorArgs : Pulumi.ResourceArgs
    {
        [Input("categories", required: true)]
        private InputList<Inputs.LogsCustomPipelineProcessorPipelineProcessorCategoryProcessorCategoryArgs>? _categories;

        /// <summary>
        /// List of filters to match or exclude a log with their corresponding name to assign a custom value to the log.
        /// </summary>
        public InputList<Inputs.LogsCustomPipelineProcessorPipelineProcessorCategoryProcessorCategoryArgs> Categories
        {
            get => _categories ?? (_categories = new InputList<Inputs.LogsCustomPipelineProcessorPipelineProcessorCategoryProcessorCategoryArgs>());
            set => _categories = value;
        }

        /// <summary>
        /// If the processor is enabled or not.
        /// </summary>
        [Input("isEnabled")]
        public Input<bool>? IsEnabled { get; set; }

        /// <summary>
        /// Name of the processor
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Name of the parent attribute that contains all the extracted details from the sources.
        /// </summary>
        [Input("target", required: true)]
        public Input<string> Target { get; set; } = null!;

        public LogsCustomPipelineProcessorPipelineProcessorCategoryProcessorArgs()
        {
        }
    }
}
