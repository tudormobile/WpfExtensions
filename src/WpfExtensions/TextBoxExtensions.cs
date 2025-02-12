﻿using System.Windows.Controls;
using System.Windows.Data;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// TextBox Extension Methods.
/// </summary>
public static class TextBoxExtensions
{
    /// <summary>
    /// Add two-way binding to the Text property.
    /// </summary>
    /// <param name="textBox">TextBox to extend.</param>
    /// <param name="path">Binding path.</param>
    /// <returns>The extended object.</returns>
    public static TextBox Bind(this TextBox textBox, string path)
    {
        textBox.SetBinding(TextBox.TextProperty, new Binding(path) { Mode = BindingMode.TwoWay, UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged });

        return textBox;
    }
}
