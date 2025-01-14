using System.Windows;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Extensions for <see cref="System.Windows.Window"/>.
/// </summary>
public static class WindowExtensions
{
    /// <summary>
    /// Makes the window dragable.
    /// </summary>
    /// <param name="w">Window to extend.</param>
    /// <returns>The extended window.</returns>
    public static Window Dragable(this Window w) { w.MouseLeftButtonDown += ((s, e) => w.DragMove()); return w; }

}
