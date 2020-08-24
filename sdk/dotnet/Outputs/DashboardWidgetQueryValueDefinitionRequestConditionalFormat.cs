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
    public sealed class DashboardWidgetQueryValueDefinitionRequestConditionalFormat
    {
        /// <summary>
        /// Comparator to apply from: One of `&gt;`, `&gt;=`, `&lt;`, or `&lt;=`.
        /// </summary>
        public readonly string Comparator;
        /// <summary>
        /// Color palette to apply to the background, same values available as palette.
        /// </summary>
        public readonly string? CustomBgColor;
        /// <summary>
        /// Color palette to apply to the foreground, same values available as palette.
        /// </summary>
        public readonly string? CustomFgColor;
        public readonly bool? HideValue;
        /// <summary>
        /// Displays an image as the background.
        /// .
        /// </summary>
        public readonly string? ImageUrl;
        /// <summary>
        /// Color palette to apply; One of `blue`, `custom_bg`, `custom_image`, `custom_text`, `gray_on_white`, `green`, `green_on_white`, `grey`, `orange`, `red`, `red_on_white`, `white_on_gray`, `white_on_green`, `white_on_red`, `white_on_yellow`, or `yellow_on_white`.
        /// </summary>
        public readonly string Palette;
        public readonly string? Timeframe;
        /// <summary>
        /// Value for the comparator.
        /// </summary>
        public readonly double Value;

        [OutputConstructor]
        private DashboardWidgetQueryValueDefinitionRequestConditionalFormat(
            string comparator,

            string? customBgColor,

            string? customFgColor,

            bool? hideValue,

            string? imageUrl,

            string palette,

            string? timeframe,

            double value)
        {
            Comparator = comparator;
            CustomBgColor = customBgColor;
            CustomFgColor = customFgColor;
            HideValue = hideValue;
            ImageUrl = imageUrl;
            Palette = palette;
            Timeframe = timeframe;
            Value = value;
        }
    }
}
