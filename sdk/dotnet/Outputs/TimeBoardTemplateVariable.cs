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
    public sealed class TimeBoardTemplateVariable
    {
        /// <summary>
        /// The default tag. Default: "\*" (match all).
        /// </summary>
        public readonly string? Default;
        /// <summary>
        /// The variable name. Can be referenced as \$name in `graph` `request` `q` query strings.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The tag group. Default: no tag group.
        /// </summary>
        public readonly string? Prefix;

        [OutputConstructor]
        private TimeBoardTemplateVariable(
            string? @default,

            string name,

            string? prefix)
        {
            Default = @default;
            Name = name;
            Prefix = prefix;
        }
    }
}
