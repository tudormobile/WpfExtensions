using System.Windows;
using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Button Extension Methods
/// </summary>
public static class ButtonExtensions
{
    /// <summary>
    /// Add a click routed event handler.
    /// </summary>
    /// <param name="button">Button to extend.</param>
    /// <param name="handler">Routed even handler to attach to 'Click' event.</param>
    /// <returns>Fluent-reference to self.</returns>
    public static Button OnClick(this Button button, Action<object, RoutedEventArgs> handler)
    {
        button.Click += (s, e) => handler(button, e);
        return button;
    }
}
