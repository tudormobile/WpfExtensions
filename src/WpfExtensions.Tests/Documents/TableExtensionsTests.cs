using System.Windows.Documents;
using Tudormobile.WpfExtensions.Documents;

namespace WpfExtensions.Tests;

[STATestClass]
public class TableExtensionsTests
{
    [TestMethod]
    public void AddColumnTest()
    {
        var expected = new TableColumn();
        var target = new Table();
        Assert.AreSame(target, target.AddColumn(expected));
        var actual = target.Columns.First();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void AddColumnsTest()
    {
        var target = new Table();
        Assert.AreSame(target, target.AddColumns([new TableColumn(), new TableColumn()]));
        Assert.AreEqual(2, target.Columns.Count);
    }

    [TestMethod]
    public void AddColumnsTest1()
    {
        var expected = 5;
        var target = new Table();
        Assert.AreSame(target, target.AddColumns(expected));
        var actual = target.Columns.Count;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void AddRowsTest()
    {
        var target = new Table();
        Assert.AreSame(target, target.AddRows([new TableRow(), new TableRow()]));
        Assert.AreEqual(2, target.RowGroups.First().Rows.Count);
        Assert.AreEqual(1, target.RowGroups.Count);
    }

    [TestMethod]
    public void AddRowTest()
    {
        var target = new Table();
        target.RowGroups.Add(new TableRowGroup());
        Assert.AreSame(target, target.AddRow(new TableRow()));
        Assert.AreEqual(1, target.RowGroups.First().Rows.Count);
        Assert.AreEqual(1, target.RowGroups.Count);
    }
}