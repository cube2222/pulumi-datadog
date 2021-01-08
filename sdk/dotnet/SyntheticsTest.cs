// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog
{
    /// <summary>
    /// Provides a Datadog synthetics test resource. This can be used to create and manage Datadog synthetics test.
    /// 
    /// ## Example Usage
    /// ### Synthetics API Test)
    /// 
    /// Create a new Datadog Synthetics API/HTTP test on https://www.example.org
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Datadog = Pulumi.Datadog;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var testApi = new Datadog.SyntheticsTest("testApi", new Datadog.SyntheticsTestArgs
    ///         {
    ///             Assertions = 
    ///             {
    ///                 
    ///                 {
    ///                     { "operator", "is" },
    ///                     { "target", "200" },
    ///                     { "type", "statusCode" },
    ///                 },
    ///             },
    ///             Locations = 
    ///             {
    ///                 "aws:eu-central-1",
    ///             },
    ///             Message = "Notify @pagerduty",
    ///             Name = "An API test on example.org",
    ///             OptionsList = new Datadog.Inputs.SyntheticsTestOptionsListArgs
    ///             {
    ///                 MonitorOptions = new Datadog.Inputs.SyntheticsTestOptionsListMonitorOptionsArgs
    ///                 {
    ///                     RenotifyInterval = 100,
    ///                 },
    ///                 Retry = new Datadog.Inputs.SyntheticsTestOptionsListRetryArgs
    ///                 {
    ///                     Count = 2,
    ///                     Interval = 300,
    ///                 },
    ///                 TickEvery = 900,
    ///             },
    ///             Request = new Datadog.Inputs.SyntheticsTestRequestArgs
    ///             {
    ///                 Method = "GET",
    ///                 Url = "https://www.example.org",
    ///             },
    ///             RequestHeaders = 
    ///             {
    ///                 { "Authentication", "Token: 1234566789" },
    ///                 { "Content-Type", "application/json" },
    ///             },
    ///             Status = "live",
    ///             Subtype = "http",
    ///             Tags = 
    ///             {
    ///                 "foo:bar",
    ///                 "foo",
    ///                 "env:test",
    ///             },
    ///             Type = "api",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Synthetics SSL Test)
    /// 
    /// Create a new Datadog Synthetics API/SSL test on example.org
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Datadog = Pulumi.Datadog;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var testSsl = new Datadog.SyntheticsTest("testSsl", new Datadog.SyntheticsTestArgs
    ///         {
    ///             Assertions = 
    ///             {
    ///                 
    ///                 {
    ///                     { "operator", "isInMoreThan" },
    ///                     { "target", 30 },
    ///                     { "type", "certificate" },
    ///                 },
    ///             },
    ///             Locations = 
    ///             {
    ///                 "aws:eu-central-1",
    ///             },
    ///             Message = "Notify @pagerduty",
    ///             Name = "An API test on example.org",
    ///             OptionsList = new Datadog.Inputs.SyntheticsTestOptionsListArgs
    ///             {
    ///                 AcceptSelfSigned = true,
    ///                 TickEvery = 900,
    ///             },
    ///             Request = new Datadog.Inputs.SyntheticsTestRequestArgs
    ///             {
    ///                 Host = "example.org",
    ///                 Port = 443,
    ///             },
    ///             Status = "live",
    ///             Subtype = "ssl",
    ///             Tags = 
    ///             {
    ///                 "foo:bar",
    ///                 "foo",
    ///                 "env:test",
    ///             },
    ///             Type = "api",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Synthetics TCP Test)
    /// 
    /// Create a new Datadog Synthetics API/TCP test on example.org
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Datadog = Pulumi.Datadog;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var testTcp = new Datadog.SyntheticsTest("testTcp", new Datadog.SyntheticsTestArgs
    ///         {
    ///             Assertions = 
    ///             {
    ///                 
    ///                 {
    ///                     { "operator", "lessThan" },
    ///                     { "target", 2000 },
    ///                     { "type", "responseTime" },
    ///                 },
    ///             },
    ///             Locations = 
    ///             {
    ///                 "aws:eu-central-1",
    ///             },
    ///             Message = "Notify @pagerduty",
    ///             Name = "An API test on example.org",
    ///             OptionsList = new Datadog.Inputs.SyntheticsTestOptionsListArgs
    ///             {
    ///                 TickEvery = 900,
    ///             },
    ///             Request = new Datadog.Inputs.SyntheticsTestRequestArgs
    ///             {
    ///                 Host = "example.org",
    ///                 Port = 443,
    ///             },
    ///             Status = "live",
    ///             Subtype = "tcp",
    ///             Tags = 
    ///             {
    ///                 "foo:bar",
    ///                 "foo",
    ///                 "env:test",
    ///             },
    ///             Type = "api",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Synthetics DNS Test)
    /// 
    /// Create a new Datadog Synthetics API/DNS test on example.org
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Datadog = Pulumi.Datadog;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var testDns = new Datadog.SyntheticsTest("testDns", new Datadog.SyntheticsTestArgs
    ///         {
    ///             Assertions = 
    ///             {
    ///                 
    ///                 {
    ///                     { "operator", "is" },
    ///                     { "property", "A" },
    ///                     { "target", "0.0.0.0" },
    ///                     { "type", "recordSome" },
    ///                 },
    ///             },
    ///             Locations = 
    ///             {
    ///                 "aws:eu-central-1",
    ///             },
    ///             Message = "Notify @pagerduty",
    ///             Name = "An API test on example.org",
    ///             OptionsList = new Datadog.Inputs.SyntheticsTestOptionsListArgs
    ///             {
    ///                 TickEvery = 900,
    ///             },
    ///             Request = new Datadog.Inputs.SyntheticsTestRequestArgs
    ///             {
    ///                 Host = "example.org",
    ///             },
    ///             Status = "live",
    ///             Subtype = "dns",
    ///             Tags = 
    ///             {
    ///                 "foo:bar",
    ///                 "foo",
    ///                 "env:test",
    ///             },
    ///             Type = "api",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Synthetics Browser Test)
    /// 
    /// Support for Synthetics Browser test steps is limited (see below)
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Text.Json;
    /// using Pulumi;
    /// using Datadog = Pulumi.Datadog;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         // Create a new Datadog Synthetics Browser test starting on https://www.example.org
    ///         var testBrowser = new Datadog.SyntheticsTest("testBrowser", new Datadog.SyntheticsTestArgs
    ///         {
    ///             Type = "browser",
    ///             Request = new Datadog.Inputs.SyntheticsTestRequestArgs
    ///             {
    ///                 Method = "GET",
    ///                 Url = "https://app.datadoghq.com",
    ///             },
    ///             DeviceIds = 
    ///             {
    ///                 "laptop_large",
    ///             },
    ///             Locations = 
    ///             {
    ///                 "aws:eu-central-1",
    ///             },
    ///             OptionsList = new Datadog.Inputs.SyntheticsTestOptionsListArgs
    ///             {
    ///                 TickEvery = 3600,
    ///             },
    ///             Name = "A Browser test on example.org",
    ///             Message = "Notify @qa",
    ///             Tags = {},
    ///             Status = "paused",
    ///             Steps = 
    ///             {
    ///                 new Datadog.Inputs.SyntheticsTestStepArgs
    ///                 {
    ///                     Name = "Check current url",
    ///                     Type = "assertCurrentUrl",
    ///                     Params = JsonSerializer.Serialize(new Dictionary&lt;string, object?&gt;
    ///                     {
    ///                         { "check", "contains" },
    ///                         { "value", "datadoghq" },
    ///                     }),
    ///                 },
    ///             },
    ///             BrowserVariables = 
    ///             {
    ///                 new Datadog.Inputs.SyntheticsTestBrowserVariableArgs
    ///                 {
    ///                     Type = "text",
    ///                     Name = "MY_PATTERN_VAR",
    ///                     Pattern = "{{numeric(3)}}",
    ///                     Example = "597",
    ///                 },
    ///                 new Datadog.Inputs.SyntheticsTestBrowserVariableArgs
    ///                 {
    ///                     Type = "email",
    ///                     Name = "MY_EMAIL_VAR",
    ///                     Pattern = "jd8-afe-ydv.{{ numeric(10) }}@synthetics.dtdg.co",
    ///                     Example = "jd8-afe-ydv.4546132139@synthetics.dtdg.co",
    ///                 },
    ///                 new Datadog.Inputs.SyntheticsTestBrowserVariableArgs
    ///                 {
    ///                     Type = "global",
    ///                     Name = "MY_GLOBAL_VAR",
    ///                     Id = "76636cd1-82e2-4aeb-9cfe-51366a8198a2",
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ## Synthetics Browser test
    /// 
    /// Support for Synthetics Browser test is limited when creating steps. Some steps types (like steps involving elements) cannot be created, but they can be imported.
    /// 
    /// ## Assertion format
    /// 
    /// The resource was changed to have assertions be a list of `assertion` blocks instead of single `assertions` array, to support the JSON path operations. We'll remove `assertions` support in the future: to migrate, rename your attribute to `assertion` and turn array elements into independent blocks. For example:
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Datadog = Pulumi.Datadog;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var testApi = new Datadog.SyntheticsTest("testApi", new Datadog.SyntheticsTestArgs
    ///         {
    ///             Assertions = 
    ///             {
    ///                 
    ///                 {
    ///                     { "operator", "is" },
    ///                     { "target", "200" },
    ///                     { "type", "statusCode" },
    ///                 },
    ///                 
    ///                 {
    ///                     { "operator", "lessThan" },
    ///                     { "target", "1000" },
    ///                     { "type", "responseTime" },
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// turns into:
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Datadog = Pulumi.Datadog;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var testApi = new Datadog.SyntheticsTest("testApi", new Datadog.SyntheticsTestArgs
    ///         {
    ///             Assertions = 
    ///             {
    ///                 
    ///                 {
    ///                     { "operator", "is" },
    ///                     { "target", "200" },
    ///                     { "type", "statusCode" },
    ///                 },
    ///                 
    ///                 {
    ///                     { "operator", "lessThan" },
    ///                     { "target", "1000" },
    ///                     { "type", "responseTime" },
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// Synthetics tests can be imported using their public string ID, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import datadog:index/syntheticsTest:SyntheticsTest fizz abc-123-xyz
    /// ```
    /// </summary>
    public partial class SyntheticsTest : Pulumi.CustomResource
    {
        /// <summary>
        /// List of assertions.
        /// </summary>
        [Output("assertions")]
        public Output<ImmutableArray<ImmutableDictionary<string, object>>> Assertions { get; private set; } = null!;

        /// <summary>
        /// Variables used for a browser test steps. Multiple `variable` blocks are allowed with the structure below.
        /// </summary>
        [Output("browserVariables")]
        public Output<ImmutableArray<Outputs.SyntheticsTestBrowserVariable>> BrowserVariables { get; private set; } = null!;

        /// <summary>
        /// Variables used for the test configuration. Multiple `config_variable` blocks are allowed with the structure below.
        /// </summary>
        [Output("configVariables")]
        public Output<ImmutableArray<Outputs.SyntheticsTestConfigVariable>> ConfigVariables { get; private set; } = null!;

        /// <summary>
        /// Array with the different device IDs used to run the test. Allowed enum values: `laptop_large`, `tablet`, `mobile_small`
        /// (only available for `browser` tests).
        /// </summary>
        [Output("deviceIds")]
        public Output<ImmutableArray<string>> DeviceIds { get; private set; } = null!;

        /// <summary>
        /// Array of locations used to run the test. Refer to [Datadog
        /// documentation](https://docs.datadoghq.com/synthetics/api_test/#request) for available locations (e.g.
        /// `aws:eu-central-1`).
        /// </summary>
        [Output("locations")]
        public Output<ImmutableArray<string>> Locations { get; private set; } = null!;

        /// <summary>
        /// A message to include with notifications for this synthetics test. Email notifications can be sent to specific users by
        /// using the same `@username` notation as events.
        /// </summary>
        [Output("message")]
        public Output<string?> Message { get; private set; } = null!;

        /// <summary>
        /// ID of the monitor associated with the Datadog synthetics test.
        /// </summary>
        [Output("monitorId")]
        public Output<int> MonitorId { get; private set; } = null!;

        /// <summary>
        /// Name of Datadog synthetics test.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("options")]
        public Output<Outputs.SyntheticsTestOptions?> Options { get; private set; } = null!;

        [Output("optionsList")]
        public Output<Outputs.SyntheticsTestOptionsList?> OptionsList { get; private set; } = null!;

        /// <summary>
        /// The synthetics test request. Required if `type = "api"` and `subtype = "http"`.
        /// </summary>
        [Output("request")]
        public Output<Outputs.SyntheticsTestRequest> Request { get; private set; } = null!;

        /// <summary>
        /// The HTTP basic authentication credentials. Exactly one nested block is allowed with the structure below.
        /// </summary>
        [Output("requestBasicauth")]
        public Output<Outputs.SyntheticsTestRequestBasicauth?> RequestBasicauth { get; private set; } = null!;

        /// <summary>
        /// Client certificate to use when performing the test request. Exactly one nested block is allowed with the structure
        /// below.
        /// </summary>
        [Output("requestClientCertificate")]
        public Output<Outputs.SyntheticsTestRequestClientCertificate?> RequestClientCertificate { get; private set; } = null!;

        /// <summary>
        /// Header name and value map.
        /// </summary>
        [Output("requestHeaders")]
        public Output<ImmutableDictionary<string, object>?> RequestHeaders { get; private set; } = null!;

        /// <summary>
        /// Query arguments name and value map.
        /// </summary>
        [Output("requestQuery")]
        public Output<ImmutableDictionary<string, object>?> RequestQuery { get; private set; } = null!;

        /// <summary>
        /// Define whether you want to start (`live`) or pause (`paused`) a Synthetic test. Allowed enum values: `live`, `paused`
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// Steps for browser tests.
        /// </summary>
        [Output("steps")]
        public Output<ImmutableArray<Outputs.SyntheticsTestStep>> Steps { get; private set; } = null!;

        /// <summary>
        /// When `type` is `api`, choose from `http`, `ssl`, `tcp` or `dns`. Defaults to `http`.
        /// </summary>
        [Output("subtype")]
        public Output<string?> Subtype { get; private set; } = null!;

        /// <summary>
        /// A list of tags to associate with your synthetics test. This can help you categorize and filter tests in the manage
        /// synthetics page of the UI. Default is an empty list (`[]`).
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        /// <summary>
        /// Synthetics test type (`api` or `browser`).
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Variables used for a browser test steps. Multiple `browser_variable` blocks are allowed with the structure below.
        /// </summary>
        [Output("variables")]
        public Output<ImmutableArray<Outputs.SyntheticsTestVariable>> Variables { get; private set; } = null!;


        /// <summary>
        /// Create a SyntheticsTest resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SyntheticsTest(string name, SyntheticsTestArgs args, CustomResourceOptions? options = null)
            : base("datadog:index/syntheticsTest:SyntheticsTest", name, args ?? new SyntheticsTestArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SyntheticsTest(string name, Input<string> id, SyntheticsTestState? state = null, CustomResourceOptions? options = null)
            : base("datadog:index/syntheticsTest:SyntheticsTest", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing SyntheticsTest resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SyntheticsTest Get(string name, Input<string> id, SyntheticsTestState? state = null, CustomResourceOptions? options = null)
        {
            return new SyntheticsTest(name, id, state, options);
        }
    }

    public sealed class SyntheticsTestArgs : Pulumi.ResourceArgs
    {
        [Input("assertions")]
        private InputList<ImmutableDictionary<string, object>>? _assertions;

        /// <summary>
        /// List of assertions.
        /// </summary>
        [Obsolete(@"Use assertion instead")]
        public InputList<ImmutableDictionary<string, object>> Assertions
        {
            get => _assertions ?? (_assertions = new InputList<ImmutableDictionary<string, object>>());
            set => _assertions = value;
        }

        [Input("browserVariables")]
        private InputList<Inputs.SyntheticsTestBrowserVariableArgs>? _browserVariables;

        /// <summary>
        /// Variables used for a browser test steps. Multiple `variable` blocks are allowed with the structure below.
        /// </summary>
        public InputList<Inputs.SyntheticsTestBrowserVariableArgs> BrowserVariables
        {
            get => _browserVariables ?? (_browserVariables = new InputList<Inputs.SyntheticsTestBrowserVariableArgs>());
            set => _browserVariables = value;
        }

        [Input("configVariables")]
        private InputList<Inputs.SyntheticsTestConfigVariableArgs>? _configVariables;

        /// <summary>
        /// Variables used for the test configuration. Multiple `config_variable` blocks are allowed with the structure below.
        /// </summary>
        public InputList<Inputs.SyntheticsTestConfigVariableArgs> ConfigVariables
        {
            get => _configVariables ?? (_configVariables = new InputList<Inputs.SyntheticsTestConfigVariableArgs>());
            set => _configVariables = value;
        }

        [Input("deviceIds")]
        private InputList<string>? _deviceIds;

        /// <summary>
        /// Array with the different device IDs used to run the test. Allowed enum values: `laptop_large`, `tablet`, `mobile_small`
        /// (only available for `browser` tests).
        /// </summary>
        public InputList<string> DeviceIds
        {
            get => _deviceIds ?? (_deviceIds = new InputList<string>());
            set => _deviceIds = value;
        }

        [Input("locations", required: true)]
        private InputList<string>? _locations;

        /// <summary>
        /// Array of locations used to run the test. Refer to [Datadog
        /// documentation](https://docs.datadoghq.com/synthetics/api_test/#request) for available locations (e.g.
        /// `aws:eu-central-1`).
        /// </summary>
        public InputList<string> Locations
        {
            get => _locations ?? (_locations = new InputList<string>());
            set => _locations = value;
        }

        /// <summary>
        /// A message to include with notifications for this synthetics test. Email notifications can be sent to specific users by
        /// using the same `@username` notation as events.
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// Name of Datadog synthetics test.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("options")]
        public Input<Inputs.SyntheticsTestOptionsArgs>? Options { get; set; }

        [Input("optionsList")]
        public Input<Inputs.SyntheticsTestOptionsListArgs>? OptionsList { get; set; }

        /// <summary>
        /// The synthetics test request. Required if `type = "api"` and `subtype = "http"`.
        /// </summary>
        [Input("request", required: true)]
        public Input<Inputs.SyntheticsTestRequestArgs> Request { get; set; } = null!;

        /// <summary>
        /// The HTTP basic authentication credentials. Exactly one nested block is allowed with the structure below.
        /// </summary>
        [Input("requestBasicauth")]
        public Input<Inputs.SyntheticsTestRequestBasicauthArgs>? RequestBasicauth { get; set; }

        /// <summary>
        /// Client certificate to use when performing the test request. Exactly one nested block is allowed with the structure
        /// below.
        /// </summary>
        [Input("requestClientCertificate")]
        public Input<Inputs.SyntheticsTestRequestClientCertificateArgs>? RequestClientCertificate { get; set; }

        [Input("requestHeaders")]
        private InputMap<object>? _requestHeaders;

        /// <summary>
        /// Header name and value map.
        /// </summary>
        public InputMap<object> RequestHeaders
        {
            get => _requestHeaders ?? (_requestHeaders = new InputMap<object>());
            set => _requestHeaders = value;
        }

        [Input("requestQuery")]
        private InputMap<object>? _requestQuery;

        /// <summary>
        /// Query arguments name and value map.
        /// </summary>
        public InputMap<object> RequestQuery
        {
            get => _requestQuery ?? (_requestQuery = new InputMap<object>());
            set => _requestQuery = value;
        }

        /// <summary>
        /// Define whether you want to start (`live`) or pause (`paused`) a Synthetic test. Allowed enum values: `live`, `paused`
        /// </summary>
        [Input("status", required: true)]
        public Input<string> Status { get; set; } = null!;

        [Input("steps")]
        private InputList<Inputs.SyntheticsTestStepArgs>? _steps;

        /// <summary>
        /// Steps for browser tests.
        /// </summary>
        public InputList<Inputs.SyntheticsTestStepArgs> Steps
        {
            get => _steps ?? (_steps = new InputList<Inputs.SyntheticsTestStepArgs>());
            set => _steps = value;
        }

        /// <summary>
        /// When `type` is `api`, choose from `http`, `ssl`, `tcp` or `dns`. Defaults to `http`.
        /// </summary>
        [Input("subtype")]
        public Input<string>? Subtype { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// A list of tags to associate with your synthetics test. This can help you categorize and filter tests in the manage
        /// synthetics page of the UI. Default is an empty list (`[]`).
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Synthetics test type (`api` or `browser`).
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        [Input("variables")]
        private InputList<Inputs.SyntheticsTestVariableArgs>? _variables;

        /// <summary>
        /// Variables used for a browser test steps. Multiple `browser_variable` blocks are allowed with the structure below.
        /// </summary>
        [Obsolete(@"This parameter is deprecated, please use `browser_variable`")]
        public InputList<Inputs.SyntheticsTestVariableArgs> Variables
        {
            get => _variables ?? (_variables = new InputList<Inputs.SyntheticsTestVariableArgs>());
            set => _variables = value;
        }

        public SyntheticsTestArgs()
        {
        }
    }

    public sealed class SyntheticsTestState : Pulumi.ResourceArgs
    {
        [Input("assertions")]
        private InputList<ImmutableDictionary<string, object>>? _assertions;

        /// <summary>
        /// List of assertions.
        /// </summary>
        [Obsolete(@"Use assertion instead")]
        public InputList<ImmutableDictionary<string, object>> Assertions
        {
            get => _assertions ?? (_assertions = new InputList<ImmutableDictionary<string, object>>());
            set => _assertions = value;
        }

        [Input("browserVariables")]
        private InputList<Inputs.SyntheticsTestBrowserVariableGetArgs>? _browserVariables;

        /// <summary>
        /// Variables used for a browser test steps. Multiple `variable` blocks are allowed with the structure below.
        /// </summary>
        public InputList<Inputs.SyntheticsTestBrowserVariableGetArgs> BrowserVariables
        {
            get => _browserVariables ?? (_browserVariables = new InputList<Inputs.SyntheticsTestBrowserVariableGetArgs>());
            set => _browserVariables = value;
        }

        [Input("configVariables")]
        private InputList<Inputs.SyntheticsTestConfigVariableGetArgs>? _configVariables;

        /// <summary>
        /// Variables used for the test configuration. Multiple `config_variable` blocks are allowed with the structure below.
        /// </summary>
        public InputList<Inputs.SyntheticsTestConfigVariableGetArgs> ConfigVariables
        {
            get => _configVariables ?? (_configVariables = new InputList<Inputs.SyntheticsTestConfigVariableGetArgs>());
            set => _configVariables = value;
        }

        [Input("deviceIds")]
        private InputList<string>? _deviceIds;

        /// <summary>
        /// Array with the different device IDs used to run the test. Allowed enum values: `laptop_large`, `tablet`, `mobile_small`
        /// (only available for `browser` tests).
        /// </summary>
        public InputList<string> DeviceIds
        {
            get => _deviceIds ?? (_deviceIds = new InputList<string>());
            set => _deviceIds = value;
        }

        [Input("locations")]
        private InputList<string>? _locations;

        /// <summary>
        /// Array of locations used to run the test. Refer to [Datadog
        /// documentation](https://docs.datadoghq.com/synthetics/api_test/#request) for available locations (e.g.
        /// `aws:eu-central-1`).
        /// </summary>
        public InputList<string> Locations
        {
            get => _locations ?? (_locations = new InputList<string>());
            set => _locations = value;
        }

        /// <summary>
        /// A message to include with notifications for this synthetics test. Email notifications can be sent to specific users by
        /// using the same `@username` notation as events.
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// ID of the monitor associated with the Datadog synthetics test.
        /// </summary>
        [Input("monitorId")]
        public Input<int>? MonitorId { get; set; }

        /// <summary>
        /// Name of Datadog synthetics test.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("options")]
        public Input<Inputs.SyntheticsTestOptionsGetArgs>? Options { get; set; }

        [Input("optionsList")]
        public Input<Inputs.SyntheticsTestOptionsListGetArgs>? OptionsList { get; set; }

        /// <summary>
        /// The synthetics test request. Required if `type = "api"` and `subtype = "http"`.
        /// </summary>
        [Input("request")]
        public Input<Inputs.SyntheticsTestRequestGetArgs>? Request { get; set; }

        /// <summary>
        /// The HTTP basic authentication credentials. Exactly one nested block is allowed with the structure below.
        /// </summary>
        [Input("requestBasicauth")]
        public Input<Inputs.SyntheticsTestRequestBasicauthGetArgs>? RequestBasicauth { get; set; }

        /// <summary>
        /// Client certificate to use when performing the test request. Exactly one nested block is allowed with the structure
        /// below.
        /// </summary>
        [Input("requestClientCertificate")]
        public Input<Inputs.SyntheticsTestRequestClientCertificateGetArgs>? RequestClientCertificate { get; set; }

        [Input("requestHeaders")]
        private InputMap<object>? _requestHeaders;

        /// <summary>
        /// Header name and value map.
        /// </summary>
        public InputMap<object> RequestHeaders
        {
            get => _requestHeaders ?? (_requestHeaders = new InputMap<object>());
            set => _requestHeaders = value;
        }

        [Input("requestQuery")]
        private InputMap<object>? _requestQuery;

        /// <summary>
        /// Query arguments name and value map.
        /// </summary>
        public InputMap<object> RequestQuery
        {
            get => _requestQuery ?? (_requestQuery = new InputMap<object>());
            set => _requestQuery = value;
        }

        /// <summary>
        /// Define whether you want to start (`live`) or pause (`paused`) a Synthetic test. Allowed enum values: `live`, `paused`
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("steps")]
        private InputList<Inputs.SyntheticsTestStepGetArgs>? _steps;

        /// <summary>
        /// Steps for browser tests.
        /// </summary>
        public InputList<Inputs.SyntheticsTestStepGetArgs> Steps
        {
            get => _steps ?? (_steps = new InputList<Inputs.SyntheticsTestStepGetArgs>());
            set => _steps = value;
        }

        /// <summary>
        /// When `type` is `api`, choose from `http`, `ssl`, `tcp` or `dns`. Defaults to `http`.
        /// </summary>
        [Input("subtype")]
        public Input<string>? Subtype { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// A list of tags to associate with your synthetics test. This can help you categorize and filter tests in the manage
        /// synthetics page of the UI. Default is an empty list (`[]`).
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Synthetics test type (`api` or `browser`).
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("variables")]
        private InputList<Inputs.SyntheticsTestVariableGetArgs>? _variables;

        /// <summary>
        /// Variables used for a browser test steps. Multiple `browser_variable` blocks are allowed with the structure below.
        /// </summary>
        [Obsolete(@"This parameter is deprecated, please use `browser_variable`")]
        public InputList<Inputs.SyntheticsTestVariableGetArgs> Variables
        {
            get => _variables ?? (_variables = new InputList<Inputs.SyntheticsTestVariableGetArgs>());
            set => _variables = value;
        }

        public SyntheticsTestState()
        {
        }
    }
}
