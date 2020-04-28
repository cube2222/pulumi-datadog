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
    public sealed class ScreenBoardWidgetTileDefRequestApmQuery
    {
        public readonly Outputs.ScreenBoardWidgetTileDefRequestApmQueryCompute Compute;
        public readonly ImmutableArray<Outputs.ScreenBoardWidgetTileDefRequestApmQueryGroupBy> GroupBies;
        public readonly string Index;
        public readonly Outputs.ScreenBoardWidgetTileDefRequestApmQuerySearch? Search;

        [OutputConstructor]
        private ScreenBoardWidgetTileDefRequestApmQuery(
            Outputs.ScreenBoardWidgetTileDefRequestApmQueryCompute compute,

            ImmutableArray<Outputs.ScreenBoardWidgetTileDefRequestApmQueryGroupBy> groupBies,

            string index,

            Outputs.ScreenBoardWidgetTileDefRequestApmQuerySearch? search)
        {
            Compute = compute;
            GroupBies = groupBies;
            Index = index;
            Search = search;
        }
    }
}