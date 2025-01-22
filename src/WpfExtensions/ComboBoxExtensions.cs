using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Extension methods for <see cref="ComboBox"/>.
/// </summary>
public static class ComboBoxExtensions
{
    /// <summary>
    /// Makes the <see cref="ComboBox"/> editable.
    /// </summary>
    /// <param name="comboBox">ComboBox element to extend.</param>
    /// <returns>The extended element.</returns>
    public static ComboBox Editable(this ComboBox comboBox) { comboBox.IsEditable = true; return comboBox; }

    /// <summary>
    /// Makes the <see cref="ComboBox"/> read-only and (optionally) add items to the ComboBox.
    /// </summary>
    /// <param name="comboBox">ComboBox element to extend.</param>
    /// <param name="items">[OPTIONAL]; Items to add.</param>
    /// <returns>The extended element.</returns>
    /// <remarks>
    /// This extenstion method allows you to easily create a read-only combo box with a list of items to select.
    /// <para>
    /// This method is also overloaded to accept an <see cref="Enum"/> type and select a default value, allowing
    /// a simplified way to choose an enumeration value from a list of possible values.
    /// </para>
    /// </remarks>
    public static ComboBox ReadOnly(this ComboBox comboBox, IEnumerable<object>? items = null)
    {
        comboBox.IsReadOnly = true;
        if (items != null)
        {
            foreach (var item in items)
            {
                comboBox.Items.Add(item);
            }
        }
        return comboBox;
    }

    /// <summary>
    /// Makes the <see cref="ComboBox"/> read-only and (optionally) add an Enum to the ComboBox.
    /// </summary>
    /// <typeparam name="T">Type of Enum to add.</typeparam>
    /// <param name="comboBox">ComboBox element to extend.</param>
    /// <param name="selectedEnum">[OPTIONAL]; The initially selected Enum value.</param>
    /// <returns>The extended element.</returns>
    /// <remarks>
    /// This method allows a simplified way to create a read-only combo box with a list of Enum values to select.
    /// </remarks>
#pragma warning disable CS8601 // Possible null reference assignment.
    public static ComboBox ReadOnly<T>(this ComboBox comboBox, T selectedEnum = default) where T : Enum
#pragma warning restore CS8601 // Possible null reference assignment.
    {
        comboBox.IsReadOnly = true;
        if (selectedEnum != null)
        {
            foreach (var item in Enum.GetValues(selectedEnum.GetType()))
            {
                comboBox.Items.Add(item);
                if (item.Equals(selectedEnum))
                {
                    comboBox.SelectedItem = item;
                }
            }
        }
        return comboBox;
    }

    /// <summary>
    /// Sets the text of the <see cref="ComboBox"/>.
    /// </summary>
    /// <param name="comboBox">ComboBox element to extend.</param>
    /// <param name="text">The Text value to use.</param>
    /// <returns>The extended element.</returns>
    public static ComboBox Text(this ComboBox comboBox, string text) { comboBox.Text = text; return comboBox; }

    /// <summary>
    /// Selects an item in the <see cref="ComboBox"/> by index.
    /// </summary>
    /// <param name="comboBox">ComboBox element to extend.</param>
    /// <param name="index">The zero-based index of the item to select.</param>
    /// <returns>The extended element.</returns>
    public static ComboBox Select(this ComboBox comboBox, int index) { comboBox.SelectedIndex = index; return comboBox; }

    /// <summary>
    /// Selects an item in the <see cref="ComboBox"/> by item.
    /// </summary>
    /// <param name="comboBox">ComboBox element to extend.</param>
    /// <param name="item">The item to select.</param>
    /// <returns>The extended element.</returns>
    public static ComboBox Select(this ComboBox comboBox, object item) { comboBox.SelectedItem = item; return comboBox; }
}
