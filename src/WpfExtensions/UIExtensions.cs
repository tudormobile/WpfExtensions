using System.Windows;
using System.Windows.Controls;

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
    /// Creates a TextBox
    /// </summary>
    /// <returns>TextBox element.</returns>
    public static TextBox Entry(int width = 200, int height = 24) => new TextBox() { VerticalContentAlignment = VerticalAlignment.Center }.Size(width, height);

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
}
