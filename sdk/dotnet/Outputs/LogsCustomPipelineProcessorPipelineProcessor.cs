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
    public sealed class LogsCustomPipelineProcessorPipelineProcessor
    {
        public readonly Outputs.LogsCustomPipelineProcessorPipelineProcessorArithmeticProcessor? ArithmeticProcessor;
        public readonly Outputs.LogsCustomPipelineProcessorPipelineProcessorAttributeRemapper? AttributeRemapper;
        public readonly Outputs.LogsCustomPipelineProcessorPipelineProcessorCategoryProcessor? CategoryProcessor;
        public readonly Outputs.LogsCustomPipelineProcessorPipelineProcessorDateRemapper? DateRemapper;
        public readonly Outputs.LogsCustomPipelineProcessorPipelineProcessorGeoIpParser? GeoIpParser;
        public readonly Outputs.LogsCustomPipelineProcessorPipelineProcessorGrokParser? GrokParser;
        public readonly Outputs.LogsCustomPipelineProcessorPipelineProcessorMessageRemapper? MessageRemapper;
        public readonly Outputs.LogsCustomPipelineProcessorPipelineProcessorServiceRemapper? ServiceRemapper;
        public readonly Outputs.LogsCustomPipelineProcessorPipelineProcessorStatusRemapper? StatusRemapper;
        public readonly Outputs.LogsCustomPipelineProcessorPipelineProcessorStringBuilderProcessor? StringBuilderProcessor;
        public readonly Outputs.LogsCustomPipelineProcessorPipelineProcessorTraceIdRemapper? TraceIdRemapper;
        public readonly Outputs.LogsCustomPipelineProcessorPipelineProcessorUrlParser? UrlParser;
        public readonly Outputs.LogsCustomPipelineProcessorPipelineProcessorUserAgentParser? UserAgentParser;

        [OutputConstructor]
        private LogsCustomPipelineProcessorPipelineProcessor(
            Outputs.LogsCustomPipelineProcessorPipelineProcessorArithmeticProcessor? arithmeticProcessor,

            Outputs.LogsCustomPipelineProcessorPipelineProcessorAttributeRemapper? attributeRemapper,

            Outputs.LogsCustomPipelineProcessorPipelineProcessorCategoryProcessor? categoryProcessor,

            Outputs.LogsCustomPipelineProcessorPipelineProcessorDateRemapper? dateRemapper,

            Outputs.LogsCustomPipelineProcessorPipelineProcessorGeoIpParser? geoIpParser,

            Outputs.LogsCustomPipelineProcessorPipelineProcessorGrokParser? grokParser,

            Outputs.LogsCustomPipelineProcessorPipelineProcessorMessageRemapper? messageRemapper,

            Outputs.LogsCustomPipelineProcessorPipelineProcessorServiceRemapper? serviceRemapper,

            Outputs.LogsCustomPipelineProcessorPipelineProcessorStatusRemapper? statusRemapper,

            Outputs.LogsCustomPipelineProcessorPipelineProcessorStringBuilderProcessor? stringBuilderProcessor,

            Outputs.LogsCustomPipelineProcessorPipelineProcessorTraceIdRemapper? traceIdRemapper,

            Outputs.LogsCustomPipelineProcessorPipelineProcessorUrlParser? urlParser,

            Outputs.LogsCustomPipelineProcessorPipelineProcessorUserAgentParser? userAgentParser)
        {
            ArithmeticProcessor = arithmeticProcessor;
            AttributeRemapper = attributeRemapper;
            CategoryProcessor = categoryProcessor;
            DateRemapper = dateRemapper;
            GeoIpParser = geoIpParser;
            GrokParser = grokParser;
            MessageRemapper = messageRemapper;
            ServiceRemapper = serviceRemapper;
            StatusRemapper = statusRemapper;
            StringBuilderProcessor = stringBuilderProcessor;
            TraceIdRemapper = traceIdRemapper;
            UrlParser = urlParser;
            UserAgentParser = userAgentParser;
        }
    }
}
