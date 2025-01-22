using System.Windows;
using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class ExpanderExtensionsTests
{
    [TestMethod]
    public void CollapseTest()
    {
        var target = new Expander();
        Assert.AreSame(target, target.Collapse());
        Assert.AreEqual(false, target.IsExpanded);
    }

    [TestMethod]
    public void ExpandTest()
    {
        var target = new Expander();
        Assert.AreSame(target, target.Expand());
        Assert.AreEqual(true, target.IsExpanded);
    }

    [TestMethod]
    public void ExpandTest1()
    {
        var expected = ExpandDirection.Right;
        var target = new Expander();
        Assert.AreSame(target, target.Expand(expected));
        var actual = target.ExpandDirection;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ExpandDownTest()
    {
        var target = new Expander();
        Assert.AreSame(target, target.ExpandDown());
        Assert.AreEqual(ExpandDirection.Down, target.ExpandDirection);
    }

    [TestMethod]
    public void ExpandUpTest()
    {
        var target = new Expander();
        Assert.AreSame(target, target.ExpandUp());
        Assert.AreEqual(ExpandDirection.Up, target.ExpandDirection);
    }

    [TestMethod]
    public void ExpandLeftTest()
    {
        var target = new Expander();
        Assert.AreSame(target, target.ExpandLeft());
        Assert.AreEqual(ExpandDirection.Left, target.ExpandDirection);
    }

    [TestMethod]
    public void ExpandRightTest()
    {
        var target = new Expander();
        Assert.AreSame(target, target.ExpandRight());
        Assert.AreEqual(ExpandDirection.Right, target.ExpandDirection);
    }

    [TestMethod]
    public void OnCollapsedTest()
    {
        var expected = true;
        var actual = false;
        var handler = new RoutedEventHandler((s, e) => { actual = true; });
        var target = new Expander();
        Assert.AreSame(target, target.OnCollapsed(handler));
        target.RaiseEvent(new RoutedEventArgs(Expander.CollapsedEvent));
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void OnExpandedTest()
    {
        var expected = true;
        var actual = false;
        var handler = new RoutedEventHandler((s, e) => { actual = true; });
        var target = new Expander();
        Assert.AreSame(target, target.OnExpanded(handler));
        target.RaiseEvent(new RoutedEventArgs(Expander.ExpandedEvent));
        Assert.AreEqual(expected, actual);
    }
}