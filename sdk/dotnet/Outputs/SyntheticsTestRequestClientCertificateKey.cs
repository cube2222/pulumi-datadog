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
    public sealed class SyntheticsTestRequestClientCertificateKey
    {
        public readonly string Content;
        public readonly string? Filename;

        [OutputConstructor]
        private SyntheticsTestRequestClientCertificateKey(
            string content,

            string? filename)
        {
            Content = content;
            Filename = filename;
        }
    }
}
