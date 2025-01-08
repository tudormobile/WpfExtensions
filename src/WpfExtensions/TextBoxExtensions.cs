using System.Windows.Controls;
using System.Windows.Data;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// TextBox Extensions.
/// </summary>
public static class TextBoxExtensions
{
    /// <summary>
    /// Add two-way binding to the Text property.
    /// </summary>
    /// <param name="textBox">TextBox to extend.</param>
    /// <param name="path">Binding path.</param>
    /// <returns>Fluent-reference to the extended object.</returns>
    public static TextBox Bind(this TextBox textBox, string path)
    {
        textBox.SetBinding(TextBox.TextProperty, new Binding(path) { Mode = BindingMode.TwoWay });

        return textBox;
    }
}
