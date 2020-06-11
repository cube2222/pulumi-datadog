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
    public sealed class LogsCustomPipelineProcessor
    {
        public readonly Outputs.LogsCustomPipelineProcessorArithmeticProcessor? ArithmeticProcessor;
        public readonly Outputs.LogsCustomPipelineProcessorAttributeRemapper? AttributeRemapper;
        public readonly Outputs.LogsCustomPipelineProcessorCategoryProcessor? CategoryProcessor;
        public readonly Outputs.LogsCustomPipelineProcessorDateRemapper? DateRemapper;
        public readonly Outputs.LogsCustomPipelineProcessorGeoIpParser? GeoIpParser;
        public readonly Outputs.LogsCustomPipelineProcessorGrokParser? GrokParser;
        public readonly Outputs.LogsCustomPipelineProcessorLookupProcessor? LookupProcessor;
        public readonly Outputs.LogsCustomPipelineProcessorMessageRemapper? MessageRemapper;
        public readonly Outputs.LogsCustomPipelineProcessorPipeline? Pipeline;
        public readonly Outputs.LogsCustomPipelineProcessorServiceRemapper? ServiceRemapper;
        public readonly Outputs.LogsCustomPipelineProcessorStatusRemapper? StatusRemapper;
        public readonly Outputs.LogsCustomPipelineProcessorStringBuilderProcessor? StringBuilderProcessor;
        public readonly Outputs.LogsCustomPipelineProcessorTraceIdRemapper? TraceIdRemapper;
        public readonly Outputs.LogsCustomPipelineProcessorUrlParser? UrlParser;
        public readonly Outputs.LogsCustomPipelineProcessorUserAgentParser? UserAgentParser;

        [OutputConstructor]
        private LogsCustomPipelineProcessor(
            Outputs.LogsCustomPipelineProcessorArithmeticProcessor? arithmeticProcessor,

            Outputs.LogsCustomPipelineProcessorAttributeRemapper? attributeRemapper,

            Outputs.LogsCustomPipelineProcessorCategoryProcessor? categoryProcessor,

            Outputs.LogsCustomPipelineProcessorDateRemapper? dateRemapper,

            Outputs.LogsCustomPipelineProcessorGeoIpParser? geoIpParser,

            Outputs.LogsCustomPipelineProcessorGrokParser? grokParser,

            Outputs.LogsCustomPipelineProcessorLookupProcessor? lookupProcessor,

            Outputs.LogsCustomPipelineProcessorMessageRemapper? messageRemapper,

            Outputs.LogsCustomPipelineProcessorPipeline? pipeline,

            Outputs.LogsCustomPipelineProcessorServiceRemapper? serviceRemapper,

            Outputs.LogsCustomPipelineProcessorStatusRemapper? statusRemapper,

            Outputs.LogsCustomPipelineProcessorStringBuilderProcessor? stringBuilderProcessor,

            Outputs.LogsCustomPipelineProcessorTraceIdRemapper? traceIdRemapper,

            Outputs.LogsCustomPipelineProcessorUrlParser? urlParser,

            Outputs.LogsCustomPipelineProcessorUserAgentParser? userAgentParser)
        {
            ArithmeticProcessor = arithmeticProcessor;
            AttributeRemapper = attributeRemapper;
            CategoryProcessor = categoryProcessor;
            DateRemapper = dateRemapper;
            GeoIpParser = geoIpParser;
            GrokParser = grokParser;
            LookupProcessor = lookupProcessor;
            MessageRemapper = messageRemapper;
            Pipeline = pipeline;
            ServiceRemapper = serviceRemapper;
            StatusRemapper = statusRemapper;
            StringBuilderProcessor = stringBuilderProcessor;
            TraceIdRemapper = traceIdRemapper;
            UrlParser = urlParser;
            UserAgentParser = userAgentParser;
        }
    }
}
