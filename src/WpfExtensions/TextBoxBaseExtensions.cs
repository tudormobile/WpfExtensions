using System.Windows.Controls.Primitives;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// TextBoxBase Extension Methods.
/// </summary>
public static class TextBoxBaseExtensions
{
    /// <summary>
    /// Set the AcceptsReturn property to (True).
    /// </summary>
    /// <typeparam name="T">Type of element to extend.</typeparam>
    /// <param name="textBox">Element to extend.</param>
    /// <returns>The extended object.</returns>
    public static T AcceptsReturn<T>(this T textBox) where T : TextBoxBase { textBox.AcceptsReturn = true; return textBox; }

    /// <summary>
    /// Set the AcceptsTab property to (True).
    /// </summary>
    /// <typeparam name="T">Type of element to extend.</typeparam>
    /// <param name="textBox">Element to extend.</param>
    /// <returns>The extended object.</returns>
    public static T AcceptsTab<T>(this T textBox) where T : TextBoxBase { textBox.AcceptsTab = true; return textBox; }
}
