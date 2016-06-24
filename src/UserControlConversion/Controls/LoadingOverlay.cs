using System;
using System.Windows;
using System.Windows.Controls;

namespace UserControlConversion.Controls
{
    /// <summary>
    /// Represents an overlay to be used for loading processes.
    /// </summary>
    public class LoadingOverlay : ContentControl
    {
        /// <summary>
        /// Initializes static members of the <see cref="LoadingOverlay"/> class.
        /// </summary>
        static LoadingOverlay()
        {
            // Retrieve the control template and styling from the resource dictionary.
            Type currentType = typeof(LoadingOverlay);
            FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(
               currentType,
               new FrameworkPropertyMetadata(currentType));
        }
    }
}