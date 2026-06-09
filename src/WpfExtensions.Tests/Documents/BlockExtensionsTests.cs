using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using Tudormobile.WpfExtensions.Documents;

namespace WpfExtensions.Tests;

[STATestClass]
public class BlockExtensionsTests
{
    [TestMethod]
    public void PaddingTest()
    {
        var target = new Paragraph();
        var expected = 12.34;
        Assert.AreSame(target, target.Padding(expected));
        Assert.AreEqual(expected, target.Padding.Right);
        Assert.AreEqual(expected, target.Padding.Top);
        Assert.AreEqual(expected, target.Padding.Left);
        Assert.AreEqual(expected, target.Padding.Bottom);
    }

    [TestMethod]
    public void PaddingTest1()
    {
        var target = new Paragraph();
        var expectedH = 12.34;
        var expectedV = 34.56;
        Assert.AreSame(target, target.Padding(expectedH, expectedV));
        Assert.AreEqual(expectedH, target.Padding.Right);
        Assert.AreEqual(expectedH, target.Padding.Left);
        Assert.AreEqual(expectedV, target.Padding.Top);
        Assert.AreEqual(expectedV, target.Padding.Bottom);
        target.Padding(right: 22);
        Assert.AreEqual(22, target.Padding.Right);
    }

    [TestMethod]
    public void PaddingTest2()
    {
        var left = 1.2;
        var top = 2.3;
        var bottom = 3.2;
        var right = 4.3;
        var target = new Paragraph();
        Assert.AreSame(target, target.Padding(left, top, right, bottom));
        Assert.AreEqual(left, target.Padding.Left);
        Assert.AreEqual(top, target.Padding.Top);
        Assert.AreEqual(right, target.Padding.Right);
        Assert.AreEqual(bottom, target.Padding.Bottom);
    }

    [TestMethod]
    public void PaddingTest3()
    {
        var expected = new Thickness(1, 2, 3, 4);
        var target = new Paragraph();
        Assert.AreSame(target, target.Padding(expected));
        var actual = target.Padding;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void PaddingTest3a()
    {
        var expected = 1.234;
        var t = new Thickness(1, 2, 3, 4);
        var target = new Paragraph();
        target.Padding = t;
        Assert.AreSame(target, target.Padding(left: expected));
        var actual = target.Padding;
        Assert.AreEqual(expected, actual.Left);
        Assert.AreEqual(t.Top, actual.Top);
        Assert.AreEqual(t.Right, actual.Right);
        Assert.AreEqual(t.Bottom, actual.Bottom);
    }

    [TestMethod]
    public void PaddingTest3b()
    {
        var expected = 1.234;
        var t = new Thickness(1, 2, 3, 4);
        var target = new Paragraph();
        target.Padding = t;
        Assert.AreSame(target, target.Padding(top: expected));
        var actual = target.Padding;
        Assert.AreEqual(expected, actual.Top);
        Assert.AreEqual(t.Left, actual.Left);
        Assert.AreEqual(t.Right, actual.Right);
        Assert.AreEqual(t.Bottom, actual.Bottom);
    }

    [TestMethod]
    public void PaddingTest3c()
    {
        var expected = 1.234;
        var t = new Thickness(1, 2, 3, 4);
        var target = new Paragraph();
        target.Padding = t;
        Assert.AreSame(target, target.Padding(right: expected));
        var actual = target.Padding;
        Assert.AreEqual(expected, actual.Right);
        Assert.AreEqual(t.Left, actual.Left);
        Assert.AreEqual(t.Top, actual.Top);
        Assert.AreEqual(t.Bottom, actual.Bottom);
    }

    [TestMethod]
    public void PaddingTest3d()
    {
        var expected = 1.234;
        var t = new Thickness(1, 2, 3, 4);
        var target = new Paragraph();
        target.Padding = t;
        Assert.AreSame(target, target.Padding(bottom: expected));
        var actual = target.Padding;
        Assert.AreEqual(expected, actual.Bottom);
        Assert.AreEqual(t.Left, actual.Left);
        Assert.AreEqual(t.Top, actual.Top);
        Assert.AreEqual(t.Right, actual.Right);
    }

    [TestMethod]
    public void MarginTest()
    {
        var expected = 1.234;
        var target = new Paragraph();
        Assert.AreSame(target, target.Margin(expected));
        var actual = target.Margin;
        Assert.AreEqual(expected, target.Margin.Top);
        Assert.AreEqual(expected, target.Margin.Right);
        Assert.AreEqual(expected, target.Margin.Bottom);
        Assert.AreEqual(expected, target.Margin.Left);
    }

    [TestMethod]
    public void MarginTest1()
    {
        var expectedH = 12.34;
        var expectedV = 34.56;
        var target = new Paragraph();
        Assert.AreSame(target, target.Margin(expectedH, expectedV));
        Assert.AreEqual(expectedH, target.Margin.Left);
        Assert.AreEqual(expectedH, target.Margin.Right);
        Assert.AreEqual(expectedV, target.Margin.Top);
        Assert.AreEqual(expectedV, target.Margin.Bottom);
    }

    [TestMethod]
    public void MarginTest2()
    {
        var expected = new Thickness(1, 2, 3, 4);
        var target = new Paragraph();
        Assert.AreSame(target, target.Margin(expected));
        var actual = target.Margin;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void MarginTest3()
    {
        var left = 1.2;
        var top = 2.3;
        var right = 3.4;
        var bottom = 4.3;
        var target = new Paragraph();
        Assert.AreSame(target, target.Margin(left, top, right, bottom));
        Assert.AreEqual(left, target.Margin.Left);
        Assert.AreEqual(top, target.Margin.Top);
        Assert.AreEqual(right, target.Margin.Right);
        Assert.AreEqual(bottom, target.Margin.Bottom);
    }

    [TestMethod]
    public void MarginTest3a()
    {
        var left = 1.2;
        var target = new Paragraph();
        Assert.AreSame(target, target.Margin(left: left));
        Assert.AreEqual(left, target.Margin.Left);
        Assert.AreEqual(0, target.Margin.Top);
        Assert.AreEqual(0, target.Margin.Right);
        Assert.AreEqual(0, target.Margin.Bottom);
    }

    [TestMethod]
    public void MarginTest3b()
    {
        var top = 1.2;
        var target = new Paragraph();
        target.Margin = new Thickness(5, 5, 5, 5);
        Assert.AreSame(target, target.Margin(top: top));
        Assert.AreEqual(top, target.Margin.Top);
        Assert.AreEqual(5, target.Margin.Left);
        Assert.AreEqual(5, target.Margin.Right);
        Assert.AreEqual(5, target.Margin.Bottom);
    }

    [TestMethod]
    public void MarginTest3c()
    {
        var right = 1.2;
        var target = new Paragraph();
        target.Margin = new Thickness(5, 5, 5, 5);
        Assert.AreSame(target, target.Margin(right: right));
        Assert.AreEqual(right, target.Margin.Right);
        Assert.AreEqual(5, target.Margin.Left);
        Assert.AreEqual(5, target.Margin.Top);
        Assert.AreEqual(5, target.Margin.Bottom);
    }

    [TestMethod]
    public void MarginTest3d()
    {
        var bottom = 1.2;
        var target = new Paragraph();
        target.Margin = new Thickness(5, 5, 5, 5);
        Assert.AreSame(target, target.Margin(bottom: bottom));
        Assert.AreEqual(bottom, target.Margin.Bottom);
        Assert.AreEqual(5, target.Margin.Left);
        Assert.AreEqual(5, target.Margin.Right);
        Assert.AreEqual(5, target.Margin.Top);
    }

    [TestMethod]
    public void BorderTest()
    {
        var expected = Brushes.Red;
        var target = new Paragraph();
        Assert.AreSame(target, target.Border(expected));
        var actual = target.BorderBrush;
        Assert.AreEqual(expected, actual);
        Assert.AreEqual(0.5, target.BorderThickness.Right, "Thickness is required to DEFAULT to 0.5");
        Assert.AreEqual(0.5, target.BorderThickness.Left, "Thickness is required to DEFAULT to 0.5");
        Assert.AreEqual(0.5, target.BorderThickness.Top, "Thickness is required to DEFAULT to 0.5");
        Assert.AreEqual(0.5, target.BorderThickness.Bottom, "Thickness is required to DEFAULT to 0.5");
    }

    [TestMethod]
    public void BorderTest2()
    {
        var expected = Brushes.Red;
        var expectedThickness = 23.45;
        var target = new Paragraph();
        Assert.AreSame(target, target.Border(expected, expectedThickness));
        var actual = target.BorderBrush;
        Assert.AreEqual(expected, actual);
        Assert.AreEqual(expectedThickness, target.BorderThickness.Right);
        Assert.AreEqual(expectedThickness, target.BorderThickness.Left);
        Assert.AreEqual(expectedThickness, target.BorderThickness.Top);
        Assert.AreEqual(expectedThickness, target.BorderThickness.Bottom);
    }

    [TestMethod]
    public void LeftTest()
    {
        var expected = TextAlignment.Left;
        var target = new Paragraph();
        Assert.AreSame(target, target.Left());
        var actual = target.TextAlignment;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RightTest()
    {
        var expected = TextAlignment.Right;
        var target = new Paragraph();
        Assert.AreSame(target, target.Right());
        var actual = target.TextAlignment;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CenterTest()
    {
        var expected = TextAlignment.Center;
        var target = new Paragraph();
        Assert.AreSame(target, target.Center());
        var actual = target.TextAlignment;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void JustifyTest()
    {
        var expected = TextAlignment.Justify;
        var target = new Paragraph();
        Assert.AreSame(target, target.Justify());
        var actual = target.TextAlignment;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void PageBreakTest()
    {
        var target = new Paragraph();
        Assert.AreSame(target, target.PageBreak());
        Assert.IsTrue(target.BreakPageBefore);
    }

    [TestMethod()]
    public void ColumnBreakTest()
    {
        var target = new Paragraph();
        Assert.AreSame(target, target.ColumnBreak());
        Assert.IsTrue(target.BreakColumnBefore);
    }
}