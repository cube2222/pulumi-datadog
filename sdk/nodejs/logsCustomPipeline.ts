// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides a Datadog [Logs Pipeline API](https://docs.datadoghq.com/api/?lang=python#logs-pipelines) resource, which is used to create and manage Datadog logs custom pipelines.
 * 
 * 
 * ## Example Usage
 * 
 * Create a Datadog logs pipeline:
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 * 
 * const samplePipeline = new datadog.LogsCustomPipeline("samplePipeline", {
 *     filters: [{
 *         query: "source:foo",
 *     }],
 *     isEnabled: true,
 *     name: "sample pipeline",
 *     processors: [
 *         {
 *             arithmeticProcessor: {
 *                 expression: "(time1 - time2)*1000",
 *                 isEnabled: true,
 *                 isReplaceMissing: true,
 *                 name: "sample arithmetic processor",
 *                 target: "myArithmetic",
 *             },
 *         },
 *         {
 *             attributeRemapper: {
 *                 isEnabled: true,
 *                 name: "sample attribute processor",
 *                 overrideOnConflict: false,
 *                 preserveSource: true,
 *                 sourceType: "tag",
 *                 sources: ["db.instance"],
 *                 target: "db",
 *                 targetType: "tag",
 *             },
 *         },
 *         {
 *             categoryProcessor: {
 *                 categories: [
 *                     {
 *                         filters: [{
 *                             query: "@severity: \".\"",
 *                         }],
 *                         name: "debug",
 *                     },
 *                     {
 *                         filters: [{
 *                             query: "@severity: \"-\"",
 *                         }],
 *                         name: "verbose",
 *                     },
 *                 ],
 *                 isEnabled: true,
 *                 name: "sample category processor",
 *                 target: "foo.severity",
 *             },
 *         },
 *         {
 *             dateRemapper: {
 *                 isEnabled: true,
 *                 name: "sample date remapper",
 *                 sources: [
 *                     "_timestamp",
 *                     "publishedDate",
 *                 ],
 *             },
 *         },
 *         {
 *             messageRemapper: {
 *                 isEnabled: true,
 *                 name: "sample message remapper",
 *                 sources: ["msg"],
 *             },
 *         },
 *         {
 *             statusRemapper: {
 *                 isEnabled: true,
 *                 name: "sample status remapper",
 *                 sources: [
 *                     "info",
 *                     "trace",
 *                 ],
 *             },
 *         },
 *         {
 *             traceIdRemapper: {
 *                 isEnabled: true,
 *                 name: "sample trace id remapper",
 *                 sources: ["dd.trace_id"],
 *             },
 *         },
 *         {
 *             serviceRemapper: {
 *                 isEnabled: true,
 *                 name: "sample service remapper",
 *                 sources: ["service"],
 *             },
 *         },
 *         {
 *             grokParser: {
 *                 grok: {
 *                     matchRules: "Rule %%{word:my_word2} %%{number:my_float2}",
 *                     supportRules: "",
 *                 },
 *                 isEnabled: true,
 *                 name: "sample grok parser",
 *                 source: "message",
 *             },
 *         },
 *         {
 *             pipeline: {
 *                 filters: [{
 *                     query: "source:foo",
 *                 }],
 *                 isEnabled: true,
 *                 name: "nested pipeline",
 *                 processors: [{
 *                     urlParser: {
 *                         name: "sample url parser",
 *                         normalizeEndingSlashes: true,
 *                         sources: [
 *                             "url",
 *                             "extra",
 *                         ],
 *                         target: "httpUrl",
 *                     },
 *                 }],
 *             },
 *         },
 *         {
 *             userAgentParser: {
 *                 isEnabled: true,
 *                 isEncoded: false,
 *                 name: "sample user agent parser",
 *                 sources: [
 *                     "user",
 *                     "agent",
 *                 ],
 *                 target: "httpAgent",
 *             },
 *         },
 *     ],
 * });
 * ```
 * 
 * ## Important Notes
 * 
 * Each `datadog..LogsCustomPipeline` resource defines a complete pipeline. The order of the pipelines is maintained in
 * a different resource datadog_logs_pipeline_order.
 * When creating a new pipeline, you need to **explicitly** add this pipeline to the `datadog..LogsPipelineOrder` 
 * resource to track the pipeline. Similarly, when a pipeline needs to be destroyed, remove its references from the 
 * `datadog..LogsPipelineOrder` resource.
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-datadog/blob/master/website/docs/r/logs_custom_pipeline.html.markdown.
 */
export class LogsCustomPipeline extends pulumi.CustomResource {
    /**
     * Get an existing LogsCustomPipeline resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: LogsCustomPipelineState, opts?: pulumi.CustomResourceOptions): LogsCustomPipeline {
        return new LogsCustomPipeline(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'datadog:index/logsCustomPipeline:LogsCustomPipeline';

    /**
     * Returns true if the given object is an instance of LogsCustomPipeline.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LogsCustomPipeline {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LogsCustomPipeline.__pulumiType;
    }

    /**
     * Defines the nested pipeline filter. Only logs that match the filter criteria are processed by this pipeline.
     */
    public readonly filters!: pulumi.Output<outputs.LogsCustomPipelineFilter[]>;
    /**
     * If the processor is enabled or not.
     */
    public readonly isEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * Name of the processor
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Processors. Nested pipeline can't take any other nested pipeline as its processor.
     */
    public readonly processors!: pulumi.Output<outputs.LogsCustomPipelineProcessor[] | undefined>;

    /**
     * Create a LogsCustomPipeline resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LogsCustomPipelineArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: LogsCustomPipelineArgs | LogsCustomPipelineState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as LogsCustomPipelineState | undefined;
            inputs["filters"] = state ? state.filters : undefined;
            inputs["isEnabled"] = state ? state.isEnabled : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["processors"] = state ? state.processors : undefined;
        } else {
            const args = argsOrState as LogsCustomPipelineArgs | undefined;
            if (!args || args.filters === undefined) {
                throw new Error("Missing required property 'filters'");
            }
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            inputs["filters"] = args ? args.filters : undefined;
            inputs["isEnabled"] = args ? args.isEnabled : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["processors"] = args ? args.processors : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(LogsCustomPipeline.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering LogsCustomPipeline resources.
 */
export interface LogsCustomPipelineState {
    /**
     * Defines the nested pipeline filter. Only logs that match the filter criteria are processed by this pipeline.
     */
    readonly filters?: pulumi.Input<pulumi.Input<inputs.LogsCustomPipelineFilter>[]>;
    /**
     * If the processor is enabled or not.
     */
    readonly isEnabled?: pulumi.Input<boolean>;
    /**
     * Name of the processor
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Processors. Nested pipeline can't take any other nested pipeline as its processor.
     */
    readonly processors?: pulumi.Input<pulumi.Input<inputs.LogsCustomPipelineProcessor>[]>;
}

/**
 * The set of arguments for constructing a LogsCustomPipeline resource.
 */
export interface LogsCustomPipelineArgs {
    /**
     * Defines the nested pipeline filter. Only logs that match the filter criteria are processed by this pipeline.
     */
    readonly filters: pulumi.Input<pulumi.Input<inputs.LogsCustomPipelineFilter>[]>;
    /**
     * If the processor is enabled or not.
     */
    readonly isEnabled?: pulumi.Input<boolean>;
    /**
     * Name of the processor
     */
    readonly name: pulumi.Input<string>;
    /**
     * Processors. Nested pipeline can't take any other nested pipeline as its processor.
     */
    readonly processors?: pulumi.Input<pulumi.Input<inputs.LogsCustomPipelineProcessor>[]>;
}