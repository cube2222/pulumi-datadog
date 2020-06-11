// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class ServiceLevelObjectiveThresholdGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// the objective's target `[0,100]`
        /// </summary>
        [Input("target", required: true)]
        public Input<double> Target { get; set; } = null!;

        /// <summary>
        /// the string version to specify additional digits in the case of `99` but want 3 digits like `99.000` to display.
        /// </summary>
        [Input("targetDisplay")]
        public Input<string>? TargetDisplay { get; set; }

        /// <summary>
        /// the time frame for the objective. The mapping from these types to the types found in the Datadog Web UI can be found in the Datadog API [documentation](https://docs.datadoghq.com/api/v1/service-level-objectives/#create-a-slo-object) page. Available options to choose from are:
        /// * `7d`
        /// * `30d`
        /// * `90d`
        /// </summary>
        [Input("timeframe", required: true)]
        public Input<string> Timeframe { get; set; } = null!;

        /// <summary>
        /// the objective's warning value `[0,100]`. This must be `&gt; target` value.
        /// </summary>
        [Input("warning")]
        public Input<double>? Warning { get; set; }

        /// <summary>
        /// the string version to specify additional digits in the case of `99` but want 3 digits like `99.000` to display.
        /// </summary>
        [Input("warningDisplay")]
        public Input<string>? WarningDisplay { get; set; }

        public ServiceLevelObjectiveThresholdGetArgs()
        {
        }
    }
}
