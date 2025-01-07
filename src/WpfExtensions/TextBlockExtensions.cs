using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// TextBlock Extension Methods.
/// </summary>
public static class TextBlockExtensions
{
    /// <summary>
    /// Sets the Text property.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <param name="text">Text.</param>
    /// <returns>Fluent reference to self.</returns>
    public static TextBlock Text(this TextBlock textBlock, string text) { textBlock.Text = text; return textBlock; }

    /// <summary>
    /// Setthe text alignment property.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <param name="textAlignment">Text alignment.</param>
    /// <returns>Fluent reference to self.</returns>
    public static TextBlock TextAlignment(this TextBlock textBlock, TextAlignment textAlignment) { textBlock.TextAlignment = textAlignment; return textBlock; }

    /// <summary>
    /// Set the background bruch property.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <param name="brush">Background brush.></param>
    /// <returns>Fluent reference to self.</returns>
    public static TextBlock Background(this TextBlock textBlock, Brush brush) { textBlock.Background = brush; return textBlock; }

    /// <summary>
    /// Set the font weight property.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <param name="fontWeight">Font weight.</param>
    /// <returns>Fluent reference to self.</returns>
    public static TextBlock FontWeight(this TextBlock textBlock, FontWeight fontWeight) { textBlock.FontWeight = fontWeight; return textBlock; }
}
