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
        var size = new Size(expectedWidth, expectedHeight);
        var target = new TextBlock();
        Assert.AreSame(target, target.Size(size));
        Assert.AreEqual(expectedWidth, target.Width);
        Assert.AreEqual(expectedHeight, target.Height);
    }
}