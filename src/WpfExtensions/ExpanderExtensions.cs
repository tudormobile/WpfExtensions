using System.Windows;
using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Extensions for the <see cref="Expander"/> class.
/// </summary>
public static class ExpanderExtensions
{
    /// <summary>
    /// Collapses the <see cref="Expander"/>.
    /// </summary>
    /// <param name="expander">The expander element to extend.</param>
    /// <returns>The extended expander.</returns>
    public static Expander Collapse(this Expander expander) { expander.IsExpanded = false; return expander; }

    /// <summary>
    /// Expands the <see cref="Expander"/>.
    /// </summary>
    /// <param name="expander">The expander element to extend.</param>
    /// <returns>The extended expander.</returns>
    public static Expander Expand(this Expander expander) { expander.IsExpanded = true; return expander; }

    /// <summary>
    /// Sets the <see cref="Expander.ExpandDirection"/> to the value provided.
    /// </summary>
    /// <param name="expander"></param>
    /// <param name="direction">The expander direction value to use.</param>
    /// <returns></returns>
    public static Expander Expand(this Expander expander, ExpandDirection direction) { expander.ExpandDirection = direction; return expander; }

    /// <summary>
    /// Sets the <see cref="Expander"/> to expand in the down direction.
    /// </summary>
    /// <param name="expander">The expander element to extend.</param>
    /// <returns>The extended expander.</returns>
    public static Expander ExpandDown(this Expander expander) => expander.Expand(ExpandDirection.Down);

    /// <summary>
    /// Sets the expander to expand in the up direction.
    /// </summary>
    /// <param name="expander">The expander element to extend.</param>
    /// <returns>The extended expander.</returns>
    public static Expander ExpandUp(this Expander expander) => expander.Expand(ExpandDirection.Up);

    /// <summary>
    /// Sets the expander to expand in the left direction.
    /// </summary>
    /// <param name="expander">The expander element to extend.</param>
    /// <returns>The extended expander.</returns>
    public static Expander ExpandLeft(this Expander expander) => expander.Expand(ExpandDirection.Left);

    /// <summary>
    /// Sets the expander to expand in the right direction.
    /// </summary>
    /// <param name="expander">The expander element to extend.</param>
    /// <returns>The extended expander.</returns>
    public static Expander ExpandRight(this Expander expander) => expander.Expand(ExpandDirection.Right);

    /// <summary>
    /// Attached an event handler to the Collapsed event.
    /// </summary>
    /// <param name="expander">The expander element to extend.</param>
    /// <param name="handler"></param>
    /// <returns>The extended expander.</returns>
    public static Expander OnCollapsed(this Expander expander, RoutedEventHandler handler) { expander.Collapsed += handler; return expander; }

    /// <summary>
    /// Attached an event handler to the Expanded event.
    /// </summary>
    /// <param name="expander">The expander element to extend.</param>
    /// <param name="handler"></param>
    /// <returns>The extended expander.</returns>
    public static Expander OnExpanded(this Expander expander, RoutedEventHandler handler) { expander.Expanded += handler; return expander; }

}
