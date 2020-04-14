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
    public sealed class DashboardListDashItem
    {
        /// <summary>
        /// The ID of this dashboard.
        /// </summary>
        public readonly string DashId;
        /// <summary>
        /// The type of this dashboard. Available options are: `custom_timeboard`, `custom_screenboard`, `integration_screenboard`, `integration_timeboard`, and `host_timeboard`
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private DashboardListDashItem(
            string dashId,

            string type)
        {
            DashId = dashId;
            Type = type;
        }
    }
}
