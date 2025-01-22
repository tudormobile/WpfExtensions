using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Extension methods for the ListBox class.
/// </summary>
public static class ListBoxExtensions
{
    /// <summary>
    /// Sets the SelectionMode to 'Multiple'.
    /// </summary>
    /// <param name="listBox">The list box element to extend.</param>
    /// <returns>The extended element.</returns>
    public static ListBox SelectMultiple(this ListBox listBox) { listBox.SelectionMode = SelectionMode.Multiple; return listBox; }

    /// <summary>
    /// Sets the SelectionMode to 'Extended'.
    /// </summary>
    /// <param name="listBox">The list box element to extend.</param>
    /// <returns>The extended element.</returns>
    public static ListBox SelectExtended(this ListBox listBox) { listBox.SelectionMode = SelectionMode.Extended; return listBox; }
}
