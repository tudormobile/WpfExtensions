using System.Windows;
using System.Windows.Documents;
using Tudormobile.WpfExtensions.Documents;

namespace WpfExtensions.Tests;

[STATestClass]
public class FlowDocumentExtensionsTests
{
    [TestMethod]
    public void PageHeightTest()
    {
        var expected = 1.234;
        var target = new FlowDocument();
        Assert.AreSame(target, target.PageHeight(expected));
        var actual = target.PageHeight;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void PageWidthTest()
    {
        var expected = 23.45;
        var target = new FlowDocument();
        Assert.AreSame(target, target.PageWidth(expected));
        var actual = target.PageWidth;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void PageHeightTest1()
    {
        var expected = 8.5 * 96;
        var target = new FlowDocument();
        Assert.AreSame(target, target.PageHeight("8.5in"));
        var actual = target.PageHeight;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void PageWidthTest1()
    {
        var expected = 8.5 * 96;
        var target = new FlowDocument();
        Assert.AreSame(target, target.PageWidth("8.5in"));
        var actual = target.PageWidth;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void InchesTest()
    {
        var expected = 8.5 * 96;
        var actual = 8.5.Inches();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void PixelsTest()
    {
        var expected = 12345.67;
        var actual = expected.Pixels();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CentimetersTest()
    {
        var expected = 12.0 * 96 / 2.54;
        var actual = 12.0.Centimeters();
        Assert.AreEqual(expected, actual, 0.01);
    }

    [TestMethod]
    public void PointsTest()
    {
        var expected = 896.0 * 96.0 / 72.0;
        var actual = 896.0.Points();
        Assert.AreEqual(expected, actual, 0.01);
    }

    [TestMethod]
    public void InTest()
    {
        var expected = 8.5 * 96;
        var actual = 8.5.In();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void PxTest()
    {
        var expected = 896.0;
        var actual = expected.Px();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CmTest()
    {
        var expected = 12.0 * 96 / 2.54;
        var actual = 12.0.Cm();
        Assert.AreEqual(expected, actual, 0.01);
    }

    [TestMethod]
    public void PtTest()
    {
        var expected = 896.0 * 96.0 / 72.0;
        var actual = 896.0.Pt();
        Assert.AreEqual(expected, actual, 0.01);
    }

    [TestMethod]
    public void LeftTest()
    {
        var expected = TextAlignment.Left;
        var target = new FlowDocument();
        Assert.AreSame(target, target.Left());
        var actual = target.TextAlignment;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RightTest()
    {
        var expected = TextAlignment.Right;
        var target = new FlowDocument();
        Assert.AreSame(target, target.Right());
        var actual = target.TextAlignment;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CenterTest()
    {
        var expected = TextAlignment.Center;
        var target = new FlowDocument();
        Assert.AreSame(target, target.Center());
        var actual = target.TextAlignment;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void JustifyTest()
    {
        var expected = TextAlignment.Justify;
        var target = new FlowDocument();
        Assert.AreSame(target, target.Justify());
        var actual = target.TextAlignment;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ColumnGapTest()
    {
        var expected = 123.45;
        var target = new FlowDocument();
        Assert.AreSame(target, target.ColumnGap(expected));
        var actual = target.ColumnGap;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ColumnWidthTest()
    {
        var expected = 123.45;
        var target = new FlowDocument();
        Assert.AreSame(target, target.ColumnWidth(expected));
        var actual = target.ColumnWidth;
        Assert.AreEqual(expected, actual);
    }
}