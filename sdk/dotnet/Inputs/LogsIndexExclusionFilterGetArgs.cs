// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class LogsIndexExclusionFilterGetArgs : Pulumi.ResourceArgs
    {
        [Input("filters")]
        private InputList<Inputs.LogsIndexExclusionFilterFilterGetArgs>? _filters;
        public InputList<Inputs.LogsIndexExclusionFilterFilterGetArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.LogsIndexExclusionFilterFilterGetArgs>());
            set => _filters = value;
        }

        [Input("isEnabled")]
        public Input<bool>? IsEnabled { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        public LogsIndexExclusionFilterGetArgs()
        {
        }
    }
}
