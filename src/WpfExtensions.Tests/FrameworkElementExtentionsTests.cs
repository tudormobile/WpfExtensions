using System.Windows;
using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[TestClass]
public class FrameworkElementExtentionsTests
{
    [STATestMethod]
    public void HorizontalAlignmentTest()
    {
        var expected = HorizontalAlignment.Right;
        var target = new TextBlock();
        Assert.AreSame(target, target.HorizontalAlignment(expected));
        Assert.AreEqual(expected, target.HorizontalAlignment);
    }

    [STATestMethod]
    public void VerticalAlignmentTest()
    {
        var expected = VerticalAlignment.Bottom;
        var target = new TextBlock();
        Assert.AreSame(target, target.VerticalAlignment(expected));
        Assert.AreEqual(expected, target.VerticalAlignment);
    }

    [STATestMethod]
    public void AlignmentTest1()
    {
        // only set vertical
        var target = new TextBlock();
        Assert.AreSame(target, target.Alignment(vertical: VerticalAlignment.Center));
        Assert.AreEqual(VerticalAlignment.Center, target.VerticalAlignment);
    }

    [STATestMethod]
    public void AlignmentTest2()
    {
        // only set horizontal
        var target = new TextBlock();
        Assert.AreSame(target, target.Alignment(HorizontalAlignment.Center));
        Assert.AreEqual(HorizontalAlignment.Center, target.HorizontalAlignment);
    }

    [STATestMethod]
    public void AlignmentTest3()
    {
        // set both
        var target = new TextBlock();
        Assert.AreSame(target, target.Alignment(HorizontalAlignment.Right, VerticalAlignment.Stretch));
        Assert.AreEqual(HorizontalAlignment.Right, target.HorizontalAlignment);
        Assert.AreEqual(VerticalAlignment.Stretch, target.VerticalAlignment);
    }


    [STATestMethod]
    public void SizeTest1()
    {
        var expectedWidth = 123;
        var expectedHeight = 456;
        var target = new TextBlock();
        Assert.AreSame(target, target.Size(expectedWidth, expectedHeight));

        var actual = new Size(target.Width, target.Height);

        Assert.AreEqual(expectedWidth, actual.Width);
        Assert.AreEqual(expectedHeight, actual.Height);
    }

    [STATestMethod]
    public void SizeTest2()
    {
        var expectedWidth = 123;
        var expectedHeight = 456;
        var size = new System.Windows.Size(expectedWidth, expectedHeight);
        var target = new TextBlock();
        Assert.AreSame(target, target.Size(size));
        Assert.AreEqual(expectedWidth, target.Width);
        Assert.AreEqual(expectedHeight, target.Height);
    }

    [STATestMethod]
    public void ToolTipTest()
    {
        var expected = "this is a tool tip";
        var target = new TextBlock();
        Assert.AreSame(target, target.ToolTip(expected));
        var actual = target.ToolTip;
        Assert.AreEqual(expected, actual);
    }

    [STATestMethod]
    public void TagTest()
    {
        var expected = "this is a tool tip";
        var target = new TextBlock();
        Assert.AreSame(target, target.Tag(expected));
        var actual = target.Tag;
        Assert.AreEqual(expected, actual);
    }

    [STATestMethod]
    public void DataContextTest()
    {
        var expected = "this is some context";
        var target = new TextBlock();
        Assert.AreSame(target, target.DataContext(expected));
        var actual = target.DataContext;
        Assert.AreEqual(expected, actual);
    }

    [STATestMethod]
    public void MarginTest1()
    {
        var expected = new Thickness(1, 2, 3, 4);
        var target = new TextBlock();
        Assert.AreSame(target, target.Margin(expected));
        var actual = target.Margin;
        Assert.AreEqual(expected, actual);
    }

    [STATestMethod]
    public void MarginTest2()
    {
        var expected = 12.34;
        var target = new TextBlock();
        Assert.AreSame(target, target.Margin(expected));
        var actual = target.Margin;
        Assert.AreEqual(expected, actual.Left);
        Assert.AreEqual(expected, actual.Top);
        Assert.AreEqual(expected, actual.Right);
        Assert.AreEqual(expected, actual.Bottom);
    }

    [STATestMethod]
    public void MarginTest3()
    {
        var expectedH = 12.34;
        var expectedV = 56.78;
        var target = new TextBlock();
        Assert.AreSame(target, target.Margin(expectedH, expectedV));
        var actual = target.Margin;
        Assert.AreEqual(expectedH, actual.Left);
        Assert.AreEqual(expectedV, actual.Top);
        Assert.AreEqual(expectedH, actual.Right);
        Assert.AreEqual(expectedV, actual.Bottom);
    }

    [STATestMethod]
    public void MarginTest4()
    {
        var left = 12.34;
        var top = 56.78;
        var right = 11;
        var bottom = 22;
        var target = new TextBlock();
        Assert.AreSame(target, target.Margin(left, top, right, bottom));
        var actual = target.Margin;
        Assert.AreEqual(left, actual.Left);
        Assert.AreEqual(top, actual.Top);
        Assert.AreEqual(right, actual.Right);
        Assert.AreEqual(bottom, actual.Bottom);
    }

}