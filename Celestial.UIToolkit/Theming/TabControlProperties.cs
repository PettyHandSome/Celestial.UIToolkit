﻿using System.Windows;
using System.Windows.Controls;

namespace Celestial.UIToolkit.Theming
{

    /// <summary>
    /// Provides attached dependency properties which are unique to the <see cref="TabControl"/>
    /// and <see cref="TabItem"/> classes.
    /// </summary>
    public static class TabControlProperties
    {
        
        /// <summary>
        /// Identifies the SelectedMarkHeight attached dependency property.
        /// </summary>
        public static readonly DependencyProperty SelectedMarkHeightProperty = DependencyProperty.RegisterAttached(
            "SelectedMarkHeight", typeof(double), typeof(TabControlProperties), new PropertyMetadata(1d));

        /// <summary>
        /// Gets the value of the <see cref="SelectedMarkHeightProperty"/> attached dependency property
        /// for a given <see cref="DependencyObject"/>.
        /// </summary>
        /// <param name="obj">
        /// The <see cref="DependencyObject"/> for which the local value of the
        /// <see cref="SelectedMarkHeightProperty"/> attached dependency property
        /// should be retrieved.
        /// </param>
        /// <returns>
        /// The local value of the <see cref="SelectedMarkHeightProperty"/> attached dependency property,
        /// which is of type <see cref="double"/>.
        /// </returns>
        public static double GetSelectedMarkHeight(DependencyObject obj)
        {
            return (double)obj.GetValue(SelectedMarkHeightProperty);
        }

        /// <summary>
        /// Sets the value of the <see cref="SelectedMarkHeightProperty"/> attached dependency property
        /// for a given <see cref="DependencyObject"/>.
        /// </summary>
        /// <param name="obj">
        /// The <see cref="DependencyObject"/> for which the local value of the
        /// <see cref="SelectedMarkHeightProperty"/> attached dependency property
        /// should be set.
        /// </param>
        /// <param name="value">
        /// The new value for the dependency property.
        /// </param>
        public static void SetSelectedMarkHeight(DependencyObject obj, double value)
        {
            obj.SetValue(SelectedMarkHeightProperty, value);
        }
        
    }

}