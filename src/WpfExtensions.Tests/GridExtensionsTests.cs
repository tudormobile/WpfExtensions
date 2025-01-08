using System.Windows;
using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class GridExtensionsTests
{
    [TestMethod]
    public void ColumnsTest()
    {
        var expected = 5;
        var target = new Grid();
        Assert.AreSame(target, target.Columns(expected));
        Assert.AreEqual(expected, target.ColumnDefinitions.Count);
    }

    [TestMethod]
    public void RowsTest()
    {
        var expected = 15;
        var target = new Grid();
        Assert.AreSame(target, target.Rows(expected));
        Assert.AreEqual(expected, target.RowDefinitions.Count);
    }

    [TestMethod]
    public void ColumnsWithStringSpecificationTest()
    {
        var spec = "*,2*,,Auto,34";
        var target = new Grid();
        Assert.AreSame(target, target.Columns(spec));

        // Validate all column definitions
        Assert.AreEqual(5, target.ColumnDefinitions.Count, "Should have defined 5 columns.");
        Assert.IsTrue(target.ColumnDefinitions[0].Width.IsStar);
        Assert.IsTrue(target.ColumnDefinitions[1].Width.IsStar);
        Assert.AreEqual(2, target.ColumnDefinitions[1].Width.Value);
        Assert.IsTrue(target.ColumnDefinitions[2].Width.IsStar);

        Assert.IsTrue(target.ColumnDefinitions[3].Width.IsAuto);
        Assert.IsTrue(target.ColumnDefinitions[4].Width.IsAbsolute);
        Assert.AreEqual(34, target.ColumnDefinitions[4].Width.Value);
    }

    [TestMethod]
    public void RowsWithStringSpecificationTest()
    {
        var spec = "*,2*,,Auto,34";
        var target = new Grid();
        Assert.AreSame(target, target.Rows(spec));

        // Validate all column definitions
        Assert.AreEqual(5, target.RowDefinitions.Count, "Should have defined 5 columns.");
        Assert.IsTrue(target.RowDefinitions[0].Height.IsStar);
        Assert.IsTrue(target.RowDefinitions[1].Height.IsStar);
        Assert.AreEqual(2, target.RowDefinitions[1].Height.Value);
        Assert.IsTrue(target.RowDefinitions[2].Height.IsStar);

        Assert.IsTrue(target.RowDefinitions[3].Height.IsAuto);
        Assert.IsTrue(target.RowDefinitions[4].Height.IsAbsolute);
        Assert.AreEqual(34, target.RowDefinitions[4].Height.Value);
    }

    [TestMethod]
    public void RowsWhitespaceTest()
    {
        // whitespace produces single 1* definition
        var spec = "\t\r\n  ";
        var target = new Grid();
        Assert.AreSame(target, target.Rows(spec));
        Assert.AreEqual(1, target.RowDefinitions.Count);
    }

    [TestMethod]
    public void RowTest()
    {
        var expected = 123;
        var target = new UIElement();
        Assert.AreSame(target, target.Row(expected));
        var actual = Grid.GetRow(target);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ColumnTest()
    {
        var expected = 123;
        var target = new UIElement();
        Assert.AreSame(target, target.Column(expected));
        var actual = Grid.GetColumn(target);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ColumnSpanTest()
    {
        var expected = 2;
        var target = new UIElement();
        Assert.AreSame(target, target.ColumnSpan(expected));
        var actual = Grid.GetColumnSpan(target);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RowSpanTest()
    {
        var expected = 5;
        var target = new UIElement();
        Assert.AreSame(target, target.RowSpan(expected));
        var actual = Grid.GetRowSpan(target);
        Assert.AreEqual(expected, actual);
    }
}