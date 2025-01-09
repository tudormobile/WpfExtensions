using System.Windows;
using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass()]
public class DockPanelExtensionsTests
{
    [TestMethod]
    public void DockTest()
    {
        var expected = Dock.Right;
        var target = new UIElement();
        Assert.AreSame(target, target.Dock(expected));
        var actual = DockPanel.GetDock(target);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LeftTest()
    {
        var expected = Dock.Left;
        var target = new UIElement();
        Assert.AreSame(target, target.Left());
        var actual = DockPanel.GetDock(target);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TopTest()
    {
        var expected = Dock.Top;
        var target = new UIElement();
        Assert.AreSame(target, target.Top());
        var actual = DockPanel.GetDock(target);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RightTest()
    {
        var expected = Dock.Right;
        var target = new UIElement();
        Assert.AreSame(target, target.Right());
        var actual = DockPanel.GetDock(target);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void BottomTest()
    {
        var expected = Dock.Bottom;
        var target = new UIElement();
        Assert.AreSame(target, target.Bottom());
        var actual = DockPanel.GetDock(target);
        Assert.AreEqual(expected, actual);
    }
}