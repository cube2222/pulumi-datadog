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
    public sealed class LogsArchiveGcs
    {
        /// <summary>
        /// Name of your gcs bucket.
        /// </summary>
        public readonly string Bucket;
        /// <summary>
        /// Your client email.
        /// </summary>
        public readonly string ClientEmail;
        /// <summary>
        /// The path where the archive will be stored.
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// Your project id.
        /// </summary>
        public readonly string ProjectId;

        [OutputConstructor]
        private LogsArchiveGcs(
            string bucket,

            string clientEmail,

            string path,

            string projectId)
        {
            Bucket = bucket;
            ClientEmail = clientEmail;
            Path = path;
            ProjectId = projectId;
        }
    }
}
