using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class VirtualizingStackPanelExtensionsTests
{
    [TestMethod]
    public void HorizontalTest()
    {
        var target = new VirtualizingStackPanel();
        Assert.AreSame(target, target.Horizontal());
        Assert.AreEqual(Orientation.Horizontal, target.Orientation);
    }

    [TestMethod]
    public void VScrollTest()
    {
        var target = new VirtualizingStackPanel();
        Assert.AreSame(target, target.VScroll());
        Assert.AreEqual(true, target.CanVerticallyScroll);
    }

    [TestMethod]
    public void HScrollTest()
    {
        var target = new VirtualizingStackPanel();
        Assert.AreSame(target, target.HScroll());
        Assert.AreEqual(true, target.CanHorizontallyScroll);
    }
}