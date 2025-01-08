using System.Windows;
using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Pre-built UI elements.
/// </summary>
public static partial class UI
{
    /// <summary>
    /// Creates a center-justified text block
    /// </summary>
    /// <param name="text">Text</param>
    /// <returns>TextBlock element.</returns>
    public static TextBlock CenteredText(string? text) => new TextBlock() { Text = text }.Alignment(HorizontalAlignment.Center, VerticalAlignment.Center);

    /// <summary>
    /// Creates a TextBox
    /// </summary>
    /// <returns>TextBox element.</returns>
    public static TextBox Entry(int width = 200, int height = 24) => new TextBox() { VerticalContentAlignment = VerticalAlignment.Center }.Size(width, height);

}
