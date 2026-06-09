using System.Windows.Documents;

namespace Tudormobile.WpfExtensions.Documents;

/// <summary>
/// Provides extension methods for the <see cref="Table"/> class to add text content.
/// </summary>
public static class TableExtensions
{

    /// <summary>
    /// Adds a column to the table.
    /// </summary>
    /// <param name="table">The table to add the column to.</param>
    /// <param name="column">The column to add.</param>
    /// <returns>The table with the added column.</returns>
    public static Table AddColumn(this Table table, TableColumn column)
    {
        table.Columns.Add(column);
        return table;
    }

    /// <summary>
    /// Adds multiple columns to the table.
    /// </summary>
    /// <param name="table">The table to add the columns to.</param>
    /// <param name="columns">The columns to add.</param>
    /// <returns>The table with the added columns.</returns>
    public static Table AddColumns(this Table table, IEnumerable<TableColumn> columns)
    {
        foreach (var c in columns)
        {
            table.Columns.Add(c);
        }
        return table;
    }

    /// <summary>
    /// Adds a specified number of columns to the table.
    /// </summary>
    /// <param name="table">The table to add the columns to.</param>
    /// <param name="columnCount">The number of columns to add.</param>
    /// <returns>The table with the added columns.</returns>
    public static Table AddColumns(this Table table, int columnCount)
        => table.AddColumns(Enumerable.Range(0, columnCount).Select(x => new TableColumn()));

    /// <summary>
    /// Adds multiple rows to the table.
    /// </summary>
    /// <param name="table">The table to add the rows to.</param>
    /// <param name="rows">The rows to add.</param>
    /// <returns>The table with the added rows.</returns>
    public static Table AddRows(this Table table, IEnumerable<TableRow> rows)
    {
        if (table.RowGroups.Count == 0)
        {
            table.RowGroups.Add(new TableRowGroup());
        }
        var rowGroup = table.RowGroups.First();
        foreach (var row in rows)
        {
            rowGroup.Rows.Add(row);
        }
        return table;
    }

    /// <summary>
    /// Adds a single row to the table.
    /// </summary>
    /// <param name="table">The table to add the row to.</param>
    /// <param name="row">The row to add.</param>
    /// <returns>The table with the added row.</returns>
    public static Table AddRow(this Table table, TableRow row) => table.AddRows(new[] { row });
}