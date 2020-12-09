// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./integration";
export * from "./integrationLambdaArn";
export * from "./integrationLogCollection";

// Import resources to register:
import { Integration } from "./integration";
import { IntegrationLambdaArn } from "./integrationLambdaArn";
import { IntegrationLogCollection } from "./integrationLogCollection";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "datadog:aws/integration:Integration":
                return new Integration(name, <any>undefined, { urn })
            case "datadog:aws/integrationLambdaArn:IntegrationLambdaArn":
                return new IntegrationLambdaArn(name, <any>undefined, { urn })
            case "datadog:aws/integrationLogCollection:IntegrationLogCollection":
                return new IntegrationLogCollection(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("datadog", "aws/integration", _module)
pulumi.runtime.registerResourceModule("datadog", "aws/integrationLambdaArn", _module)
pulumi.runtime.registerResourceModule("datadog", "aws/integrationLogCollection", _module)
