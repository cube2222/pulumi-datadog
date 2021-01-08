// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Outputs
{

    [OutputType]
    public sealed class SyntheticsTestBrowserVariable
    {
        public readonly string? Example;
        public readonly string? Id;
        public readonly string Name;
        public readonly string? Pattern;
        public readonly string Type;

        [OutputConstructor]
        private SyntheticsTestBrowserVariable(
            string? example,

            string? id,

            string name,

            string? pattern,

            string type)
        {
            Example = example;
            Id = id;
            Name = name;
            Pattern = pattern;
            Type = type;
        }
    }
}
