using System;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Markup;

namespace ReflectionIT.WindowsMarkupExtensions {

    /// <summary>
    /// MarkupExtension used for DeviceFamily specific property values
    /// <code>
    ///     <TextBlock Text="{helpers:OnDevice Desktop=Hello, Mobile=World}" />
    /// </code>
    /// </summary>
    public class OnDeviceExtension : MarkupExtension {

        public OnDeviceExtension() {
        }

        public object Desktop { get; set; }
        public object Mobile { get; set; }
        public object Xbox { get; set; }
        public object IoT { get; set; }
        public object Team { get; set; }
        public object Holographic { get; set; }
        public object Default { get; set; }

        protected override object ProvideValue() {

            if (DesignMode.DesignMode2Enabled) {
                // TODO: detect DeviceFamily in designer
            }

            switch (Windows.System.Profile.AnalyticsInfo.VersionInfo.DeviceFamily) {
                case "Windows.Desktop":
                    return this.Desktop ?? this.Default;
                case "Windows.Mobile":
                    return this.Mobile ?? this.Default;
                case "Windows.Xbox":
                    return this.Xbox ?? this.Default;
                case "Windows.Team":
                    return this.Team ?? this.Default;
                case "Windows.Holographic":
                    return this.Holographic ?? this.Default;
                default:
                    return this.Default;
            }
        }
    }
}
