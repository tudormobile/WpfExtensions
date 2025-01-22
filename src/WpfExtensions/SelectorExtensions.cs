using System.Windows.Controls.Primitives;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Extension methods for the Selector element.
/// </summary>
public static class SelectorExtensions
{
    /// <summary>
    /// Sets the selected index of the Selector element.
    /// </summary>
    /// <typeparam name="T">The type of the Selector element.</typeparam>
    /// <param name="element">The Selector element.</param>
    /// <param name="index">The index to select.</param>
    /// <returns>The Selector element with the selected index set.</returns>
    public static T SelectIndex<T>(this T element, int index) where T : Selector
    {
        element.SelectedIndex = index;
        return element;
    }

    /// <summary>
    /// Sets the selected item of the Selector element.
    /// </summary>
    /// <typeparam name="T">The type of the Selector element.</typeparam>
    /// <param name="element">The Selector element.</param>
    /// <param name="item">The item to select.</param>
    /// <returns>The Selector element with the selected item set.</returns>
    public static T SelectItem<T>(this T element, object item) where T : Selector
    {
        element.SelectedItem = item;
        return element;
    }
}
