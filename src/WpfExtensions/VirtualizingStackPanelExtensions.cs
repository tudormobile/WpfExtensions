using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Provides extension methods for the VirtualizingStackPanel class.
/// </summary>
public static class VirtualizingStackPanelExtensions
{
    /// <summary>
    /// Sets the orientation to 'Horizontal'.
    /// </summary>
    /// <param name="panel">Stack panel to extend.</param>
    /// <returns>The extended object.</returns>
    /// <remarks>
    /// There is no corresponding 'Vertical()' method because vertical orientation is the default.
    /// </remarks>
    public static VirtualizingStackPanel Horizontal(this VirtualizingStackPanel panel) { panel.Orientation = Orientation.Horizontal; return panel; }

    /// <summary>
    /// Sets the CanVerticallyScroll property to (true).
    /// </summary>
    /// <param name="panel">Stack panel to extend.</param>
    /// <returns>The extended object.</returns>
    public static VirtualizingStackPanel VScroll(this VirtualizingStackPanel panel) { panel.CanVerticallyScroll = true; return panel; }

    /// <summary>
    /// Sets the CanHorizontallyScroll property to (true).
    /// </summary>
    /// <param name="panel">Stack panel to extend.</param>
    /// <returns>The extended object.</returns>
    public static VirtualizingStackPanel HScroll(this VirtualizingStackPanel panel) { panel.CanHorizontallyScroll = true; return panel; }


}
