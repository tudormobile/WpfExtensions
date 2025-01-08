using System.Windows;
using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Grid Extensions.
/// </summary>
public static class GridExtensions
{
    private static GridLengthConverter _converter = new GridLengthConverter();

    /// <summary>
    /// Add Row definitions.
    /// </summary>
    /// <param name="grid">Grid to extend.</param>
    /// <param name="rows">Number of rows to add.</param>
    /// <returns>Fluent reference to self.</returns>
    /// <remarks>
    /// The indicated number of rows are added, each with the default height (1*).
    /// </remarks>
    public static Grid Rows(this Grid grid, int rows)
    {
        while (rows-- > 0)
        {
            grid.RowDefinitions.Add(new RowDefinition());
        }
        return grid;
    }

    /// <summary>
    /// Add Row definitions.
    /// </summary>
    /// <param name="grid">Grid to extend.</param>
    /// <param name="rows">Row definition specification.</param>
    /// <returns>Fluent reference to self.</returns>
    /// <remarks>
    /// Rows are added to match a comma-separated speficiation just as "10, 20*, Auto".
    /// </remarks>
    public static Grid Rows(this Grid grid, string rows) // .Rows("10,20*,Auto")
    {
        foreach (var height in stringToGridLengths(rows))
        {
            grid.RowDefinitions.Add(new RowDefinition() { Height = height });
        }
        return grid;
    }

    /// <summary>
    /// Add Column definitions.
    /// </summary>
    /// <param name="grid">Grid to extend.</param>
    /// <param name="columns">Number of columns to add.</param>
    /// <returns>Fluent reference to self.</returns>
    /// <remarks>
    /// The indicated number of columns are added, each with the default width (1*).
    /// </remarks>
    public static Grid Columns(this Grid grid, int columns)
    {
        while (columns-- > 0)
        {
            grid.ColumnDefinitions.Add(new ColumnDefinition());
        }
        return grid;
    }

    /// <summary>
    /// Add column definitions.
    /// </summary>
    /// <param name="grid">Grid to extend.</param>
    /// <param name="columns">Column definition specification.</param>
    /// <returns>Fluent reference to self.</returns>
    /// <remarks>
    /// Columns are added to match a comma-separated speficiation just as "10, 20*, Auto".
    /// </remarks>
    public static Grid Columns(this Grid grid, string columns) // .Columns("10,20*,Auto")
    {
        foreach (var width in stringToGridLengths(columns))
        {
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = width });
        }
        return grid;
    }

    /// <summary>
    /// Add Grid.Row attached property to an element.
    /// </summary>
    /// <typeparam name="T">Type of UIElement to extend.</typeparam>
    /// <param name="element">Element to extend.</param>
    /// <param name="row">Row index to set.</param>
    /// <returns>Fluent-reference to self.</returns>
    public static T Row<T>(this T element, int row) where T : UIElement { Grid.SetRow(element, row); return element; }

    /// <summary>
    /// Add Grid.Column attached property to an element.
    /// </summary>
    /// <typeparam name="T">Type of UIElement to extend.</typeparam>
    /// <param name="element">Element to extend.</param>
    /// <param name="column">Column index to set.</param>
    /// <returns>Fluent-reference to self.</returns>
    public static T Column<T>(this T element, int column) where T : UIElement { Grid.SetColumn(element, column); return element; }

    /// <summary>
    /// Add Grid.ColumnSpan attached property to an element.
    /// </summary>
    /// <typeparam name="T">Type of UIElement to extend.</typeparam>
    /// <param name="element">Element to extend.</param>
    /// <param name="columnSpan">ColumnSpan to set.</param>
    /// <returns>Fluent-reference to self.</returns>
    public static T ColumnSpan<T>(this T element, int columnSpan) where T : UIElement { Grid.SetColumnSpan(element, columnSpan); return element; }

    /// <summary>
    /// Add Grid.RowSpan attached property to an element.
    /// </summary>
    /// <typeparam name="T">Type of UIElement to extend.</typeparam>
    /// <param name="element">Element to extend.</param>
    /// <param name="rowSpan">RowSpan to set.</param>
    /// <returns>Fluent-reference to self.</returns>
    public static T RowSpan<T>(this T element, int rowSpan) where T : UIElement { Grid.SetRowSpan(element, rowSpan); return element; }

    private static IEnumerable<GridLength> stringToGridLengths(string specification)
        => specification.Split(',').Select(x => _converter.ConvertFromString(string.IsNullOrWhiteSpace(x) ? "1*" : x)).Cast<GridLength>();
}
