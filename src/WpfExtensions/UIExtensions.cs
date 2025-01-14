using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using Tudormobile.WpfExtensions.Adorners;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Pre-built UI elements.
/// <para>
/// This static class contains a collection of UI elements with common properties set to default values. For example,
/// a MainMenu containing File (Open|Close|Save|Exit) and Edit (Undo|Cut|Copy|Paste) items, or a text block with appropriate
/// Margin Padding, Alignment, and size.
/// </para>
/// <para>
/// The easiest way to use the UI elements is via static using statement:
/// <code>using static Tudormobile.WpfExtensions.UI;</code>
/// Placing this in your project or source file will allow direct access to the static methods defined below.
/// </para>
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
    /// Creates a simple MainMenu for an application.
    /// </summary>
    /// <returns>A simple MainMenu element.</returns>
    public static Menu MainMenu()
    {
        return new Menu()
        {
            Items =
            {
                new MenuItem()
                {
                    Header = "File",
                    Items =
                    {
                        new Separator(),
                        new MenuItem() {Header = "E_xit"}.Gesture("Alt+F4")
                    }
                },
                new MenuItem()
                {
                    Header = "Edit",
                    Items =
                    {
                        new MenuItem() {Header = "Undo"}.Gesture("Ctrl+Z"),
                        new Separator(),
                        new MenuItem() {Header = "Cut"}.Gesture("Ctrl+X"),
                        new MenuItem() {Header = "Copy"}.Gesture("Ctrl+C"),
                        new MenuItem() {Header = "Paste"}.Gesture("Ctrl+V"),
                        new MenuItem() {Header = "Delete"}.Gesture("Del"),
                    }
                }
            }
        };
    }

    /// <summary>
    /// Creates a TextBox with optional width and height.
    /// </summary>
    /// <param name="height">Height of the TextBox</param>
    /// <param name="width">Width of the TextBox</param>
    /// <returns>TextBox element.</returns>
    public static TextBox Entry(double width = double.NaN, double height = double.NaN)
    => Entry(string.Empty, width, height);

    /// <summary>
    /// Creates a TextBox with a prompt.
    /// </summary>
    /// <param name="width">Width of the TextBox</param>
    /// <param name="height">Height of the TextBox</param>
    /// <param name="prompt">Prompt text</param>
    /// <returns>TextBox element.</returns>
    public static TextBox Entry(string prompt, double width = double.NaN, double height = double.NaN)
    {
        var tb = new TextBox()
            .Padding(2, 4).Size(width, height).Alignment(vertical: VerticalAlignment.Center);

        if (!string.IsNullOrEmpty(prompt))
        {
            tb.SizeChanged += (s, e) =>
            {
                var layer = AdornerLayer.GetAdornerLayer(tb);
                var adorners = layer?.GetAdorners(tb)?.Length;
                if (layer != null && (adorners == null || adorners == 0))
                {
                    var a = new TextAdorner(tb, prompt);
                    a.IsHitTestVisible = false;
                    layer.Add(a);
                    tb.GotKeyboardFocus += a.InvalidateAdorner;
                    tb.LostKeyboardFocus += a.InvalidateAdorner;
                    tb.TextChanged += a.InvalidateAdorner;
                }
            };
        }
        return tb.Margin(4).VerticalAlignment(VerticalAlignment.Center);
    }

    /// <summary>
    /// Suitable 'Header' for a control with Symbol-Icon (Segoe Fluent Icons) and Text.
    /// </summary>
    /// <param name="icon">Symbol-icon code point.</param>
    /// <param name="text">Text to use.</param>
    /// <returns>
    /// A horizontally-aligned StackPanel element with a vertically-centered smbol-icon,
    /// based on the Segoe Fluent Icons font, and a text block.
    /// </returns>
    public static FrameworkElement IconHeader(string icon, string text) => new StackPanel()
    {
        Children =
            {
                new TextBlock().FontFamily("Segoe Fluent Icons").FontSize(16)
                    .Text(icon).Alignment(vertical: VerticalAlignment.Center).Margin(14,0).Padding(4),
                new TextBlock().Text(text).Alignment(vertical: VerticalAlignment.Center).Margin(0,10,22,10)
            }
    }.Horizontal();


}

