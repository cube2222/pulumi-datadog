// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class LogsCustomPipelineProcessorPipelineProcessorAttributeRemapperArgs : Pulumi.ResourceArgs
    {
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
        /// Override the target element if already set.
        /// </summary>
        [Input("overrideOnConflict")]
        public Input<bool>? OverrideOnConflict { get; set; }

        /// <summary>
        /// Remove or preserve the remapped source element.
        /// </summary>
        [Input("preserveSource")]
        public Input<bool>? PreserveSource { get; set; }

        /// <summary>
        /// Defines where the sources are from (log `attribute` or `tag`). 
        /// </summary>
        [Input("sourceType", required: true)]
        public Input<string> SourceType { get; set; } = null!;

        [Input("sources", required: true)]
        private InputList<string>? _sources;

        /// <summary>
        /// List of source attributes.
        /// </summary>
        public InputList<string> Sources
        {
            get => _sources ?? (_sources = new InputList<string>());
            set => _sources = value;
        }

        /// <summary>
        /// Name of the parent attribute that contains all the extracted details from the sources.
        /// </summary>
        [Input("target", required: true)]
        public Input<string> Target { get; set; } = null!;

        /// <summary>
        /// Defines if the target is a log `attribute` or `tag`.
        /// </summary>
        [Input("targetType", required: true)]
        public Input<string> TargetType { get; set; } = null!;

        public LogsCustomPipelineProcessorPipelineProcessorAttributeRemapperArgs()
        {
        }
    }
}
