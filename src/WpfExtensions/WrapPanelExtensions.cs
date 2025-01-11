using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// WrapPanel Extension Methods.
/// </summary>
public static class WrapPanelExtensions
{
    /// <summary>
    /// Sets the orientation to 'Vertical'.
    /// </summary>
    /// <param name="panel">Panel to extend.</param>
    /// <returns>The extended object.</returns>
    /// <remarks>
    /// There is no corresponding 'Horizontal()' method because horizontal orientation is the default.
    /// </remarks>
    public static WrapPanel Vertical(this WrapPanel panel) { panel.Orientation = Orientation.Vertical; return panel; }

}
