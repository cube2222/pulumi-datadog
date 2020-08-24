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
    public sealed class DashboardTemplateVariablePresetTemplateVariable
    {
        /// <summary>
        /// The variable name. Can be referenced as $name in `graph` `request` `q` query strings.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Value for the comparator.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private DashboardTemplateVariablePresetTemplateVariable(
            string name,

            string value)
        {
            Name = name;
            Value = value;
        }
    }
}
