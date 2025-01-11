using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class StackPanelExtensionsTests
{
    [TestMethod]
    public void HorizontalTest()
    {
        var expected = Orientation.Horizontal;
        var target = new StackPanel();
        Assert.AreSame(target, target.Horizontal());
        var actual = target.Orientation;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void VScrollTest()
    {
        var expected = true;
        var target = new StackPanel();
        Assert.AreSame(target, target.VScroll());
        var actual = target.CanVerticallyScroll;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void HScrollTest()
    {
        var expected = true;
        var target = new StackPanel();
        Assert.AreSame(target, target.HScroll());
        var actual = target.CanHorizontallyScroll;
        Assert.AreEqual(expected, actual);
    }
}