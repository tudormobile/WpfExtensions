using System.Windows;
using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class UIElementExtensionsTests
{
    [TestMethod]
    public void CollapsedTest()
    {
        var target = new TextBox();
        Assert.AreSame(target, target.Collapsed());
        Assert.AreEqual(Visibility.Collapsed, target.Visibility);
    }

    [TestMethod]
    public void HiddenTest()
    {
        var target = new TextBox();
        Assert.AreSame(target, target.Hidden());
        Assert.AreEqual(Visibility.Hidden, target.Visibility);
    }

    [TestMethod]
    public void VisibleTest()
    {
        var target = new TextBox();
        Assert.AreSame(target, target.Visible());
        Assert.AreEqual(Visibility.Visible, target.Visibility);
    }


    [STATestMethod]
    public void OpacityTest()
    {
        var expected = 0.123;
        var target = new TextBlock();
        Assert.AreSame(target, target.Opacity(expected));
        var actual = target.Opacity;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DisableTest()
    {
        var expected = false;
        var target = new TextBlock();
        Assert.AreSame(target, target.Disable());
        var actual = target.IsEnabled;
        Assert.AreEqual(expected, actual);
    }
}