using System.Windows.Documents;

namespace Tudormobile.WpfExtensions.Documents;

/// <summary>
/// Provides extension methods for the <see cref="TableRow"/> class.
/// </summary>
public static class TableRowExtensions
{
    /// <summary>
    /// Adds a collection of <see cref="TableCell"/> objects to the specified <see cref="TableRow"/>.
    /// </summary>
    /// <param name="row">The <see cref="TableRow"/> to add cells to.</param>
    /// <param name="cells">The collection of <see cref="TableCell"/> objects to add.</param>
    /// <returns>The <see cref="TableRow"/> with the added cells.</returns>
    public static TableRow AddCells(this TableRow row, IEnumerable<TableCell> cells)
    {
        foreach (var cell in cells)
        {
            row.Cells.Add(cell);
        }
        return row;
    }

    /// <summary>
    /// Adds a collection of <see cref="Block"/> objects as <see cref="TableCell"/> objects to the specified <see cref="TableRow"/>.
    /// </summary>
    /// <param name="row">The <see cref="TableRow"/> to add cells to.</param>
    /// <param name="blocks">The collection of <see cref="Block"/> objects to add.</param>
    /// <returns>The <see cref="TableRow"/> with the added cells.</returns>
    public static TableRow AddCells(this TableRow row, IEnumerable<Block> blocks)
        => row.AddCells(blocks.Select(x => new TableCell(x)));

    /// <summary>
    /// Adds a collection of <see cref="Inline"/> objects as <see cref="Paragraph"/> objects to the specified <see cref="TableRow"/>.
    /// </summary>
    /// <param name="row">The <see cref="TableRow"/> to add cells to.</param>
    /// <param name="inlines">The collection of <see cref="Inline"/> objects to add.</param>
    /// <returns>The <see cref="TableRow"/> with the added cells.</returns>
    public static TableRow AddCells(this TableRow row, IEnumerable<Inline> inlines)
        => row.AddCells(inlines.Select(x => new Paragraph(x)));

    /// <summary>
    /// Adds a collection of strings as <see cref="Run"/> objects to the specified <see cref="TableRow"/>.
    /// </summary>
    /// <param name="row">The <see cref="TableRow"/> to add cells to.</param>
    /// <param name="stringContent">The collection of strings to add.</param>
    /// <returns>The <see cref="TableRow"/> with the added cells.</returns>
    public static TableRow AddCells(this TableRow row, IEnumerable<string> stringContent)
        => row.AddCells(stringContent.Select(x => new Run(x)));
}
