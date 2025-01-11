using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// StackPanel Extension Methods.
/// </summary>
public static class StackPanelExtensions
{
    /// <summary>
    /// Sets the orientation to 'Horizontal'.
    /// </summary>
    /// <param name="panel">Stack panel to extend.</param>
    /// <returns>The extended object.</returns>
    /// <remarks>
    /// There is no corresponding 'Vertical()' method because vertical orientation is the default.
    /// </remarks>
    public static StackPanel Horizontal(this StackPanel panel) { panel.Orientation = Orientation.Horizontal; return panel; }

    /// <summary>
    /// Sets the CanVerticallyScroll property to (true).
    /// </summary>
    /// <param name="panel">Stack panel to extend.</param>
    /// <returns>The extended object.</returns>
    public static StackPanel VScroll(this StackPanel panel) { panel.CanVerticallyScroll = true; return panel; }

    /// <summary>
    /// Sets the CanHorizontallyScroll property to (true).
    /// </summary>
    /// <param name="panel">Stack panel to extend.</param>
    /// <returns>The extended object.</returns>
    public static StackPanel HScroll(this StackPanel panel) { panel.CanHorizontallyScroll = true; return panel; }

}
