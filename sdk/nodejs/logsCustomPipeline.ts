// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * Provides a Datadog [Logs Pipeline API](https://docs.datadoghq.com/api/v1/logs-pipelines/) resource, which is used to create and manage Datadog logs custom pipelines.
 *
 * ## Example Usage
 *
 * Create a Datadog logs pipeline:
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as datadog from "@pulumi/datadog";
 *
 * const samplePipeline = new datadog.LogsCustomPipeline("sample_pipeline", {
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
 *                 target: "my_arithmetic",
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
 *                 targetFormat: "string",
 *                 targetType: "attribute",
 *             },
 *         },
 *         {
 *             categoryProcessor: {
 *                 categories: [
 *                     {
 *                         filter: {
 *                             query: "@severity: \".\"",
 *                         },
 *                         name: "debug",
 *                     },
 *                     {
 *                         filter: {
 *                             query: "@severity: \"-\"",
 *                         },
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
 *                     "published_date",
 *                 ],
 *             },
 *         },
 *         {
 *             geoIpParser: {
 *                 isEnabled: true,
 *                 name: "sample geo ip parser",
 *                 sources: ["network.client.ip"],
 *                 target: "network.client.geoip",
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
 *                 samples: ["sample log 1"],
 *                 source: "message",
 *             },
 *         },
 *         {
 *             lookupProcessor: {
 *                 defaultLookup: "unknown service",
 *                 isEnabled: true,
 *                 lookupTables: ["1,my service"],
 *                 name: "sample lookup processor",
 *                 source: "service_id",
 *                 target: "service_name",
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
 *                         target: "http_url",
 *                     },
 *                 }],
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
 *             stringBuilderProcessor: {
 *                 isEnabled: true,
 *                 isReplaceMissing: false,
 *                 name: "sample string builder processor",
 *                 target: "user_activity",
 *                 template: "%%{user.name} logged in at %%{timestamp}",
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
 *             userAgentParser: {
 *                 isEnabled: true,
 *                 isEncoded: false,
 *                 name: "sample user agent parser",
 *                 sources: [
 *                     "user",
 *                     "agent",
 *                 ],
 *                 target: "http_agent",
 *             },
 *         },
 *     ],
 * });
 * ```
 * ## Important Notes
 *
 * Each `datadog.LogsCustomPipeline` resource defines a complete pipeline. The order of the pipelines is maintained in a different resource datadog_logs_pipeline_order. When creating a new pipeline, you need to **explicitly** add this pipeline to the `datadog.LogsPipelineOrder` resource to track the pipeline. Similarly, when a pipeline needs to be destroyed, remove its references from the `datadog.LogsPipelineOrder` resource.
 *
 * ## Import
 *
 * ```sh
 *  $ pulumi import datadog:index/logsCustomPipeline:LogsCustomPipeline For the previously created custom pipelines, you can include them in Terraform with the `import` operation. Currently, Terraform requires you to explicitly create resources that match the existing pipelines to import them. Use `<resource.name> <pipelineID>` for each existing pipeline.
 * ```
 */
export class LogsCustomPipeline extends pulumi.CustomResource {
    /**
     * Get an existing LogsCustomPipeline resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
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

    public readonly filters!: pulumi.Output<outputs.LogsCustomPipelineFilter[]>;
    public readonly isEnabled!: pulumi.Output<boolean | undefined>;
    public readonly name!: pulumi.Output<string>;
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
            if ((!args || args.filters === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'filters'");
            }
            if ((!args || args.name === undefined) && !(opts && opts.urn)) {
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
    readonly filters?: pulumi.Input<pulumi.Input<inputs.LogsCustomPipelineFilter>[]>;
    readonly isEnabled?: pulumi.Input<boolean>;
    readonly name?: pulumi.Input<string>;
    readonly processors?: pulumi.Input<pulumi.Input<inputs.LogsCustomPipelineProcessor>[]>;
}

/**
 * The set of arguments for constructing a LogsCustomPipeline resource.
 */
export interface LogsCustomPipelineArgs {
    readonly filters: pulumi.Input<pulumi.Input<inputs.LogsCustomPipelineFilter>[]>;
    readonly isEnabled?: pulumi.Input<boolean>;
    readonly name: pulumi.Input<string>;
    readonly processors?: pulumi.Input<pulumi.Input<inputs.LogsCustomPipelineProcessor>[]>;
}
