// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog.Inputs
{

    public sealed class DashboardWidgetScatterplotDefinitionRequestGetArgs : Pulumi.ResourceArgs
    {
        [Input("xes")]
        private InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestXGetArgs>? _xes;
        public InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestXGetArgs> Xes
        {
            get => _xes ?? (_xes = new InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestXGetArgs>());
            set => _xes = value;
        }

        [Input("ys")]
        private InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestYGetArgs>? _ys;
        public InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestYGetArgs> Ys
        {
            get => _ys ?? (_ys = new InputList<Inputs.DashboardWidgetScatterplotDefinitionRequestYGetArgs>());
            set => _ys = value;
        }

        public DashboardWidgetScatterplotDefinitionRequestGetArgs()
        {
        }
    }
}
