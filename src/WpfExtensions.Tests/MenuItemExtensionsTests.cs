using System.Windows;
using System.Windows.Controls;
using Tudormobile.WpfExtensions;
using static WpfExtensions.Tests.ButtonExtensionsTests;

namespace WpfExtensions.Tests;

[STATestClass()]
public class MenuItemExtensionsTests
{
    [TestMethod]
    public void IconTest()
    {
        var expected = new Image();
        var target = new MenuItem();
        Assert.AreSame(target, target.Icon(expected));
        var actual = target.Icon;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GestureTest()
    {
        var expected = "ALT+F4";
        var target = new MenuItem();
        Assert.AreSame(target, target.Gesture(expected));
        var actual = target.InputGestureText;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CheckableTest()
    {
        var target = new MenuItem();
        Assert.AreSame(target, target.Checkable());
        Assert.IsTrue(target.IsCheckable);
    }

    [TestMethod]
    public void CheckedTest()
    {
        var target = new MenuItem();
        Assert.AreSame(target, target.Check());
        Assert.IsTrue(target.IsCheckable);
        Assert.IsTrue(target.IsChecked);
    }

    [TestMethod]
    public void OnClickTest()
    {
        var target = new MenuItem();
        RoutedEventArgs? actual = null;
        RoutedEventArgs expected = new RoutedEventArgs(MenuItem.ClickEvent) { Source = target };
        Assert.AreSame(target, target.OnClick((sender, e) =>
        {
            Assert.AreSame(target, sender);
            actual = e;
            e.Handled = true;
        }));
        target.RaiseEvent(expected);
        Assert.IsNotNull(actual);
        Assert.IsTrue(actual.Handled);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void OnCheckedTest()
    {
        var target = new MenuItem();
        RoutedEventArgs? actual = null;
        RoutedEventArgs expected = new RoutedEventArgs(MenuItem.CheckedEvent) { Source = target };
        Assert.AreSame(target, target.OnChecked((sender, e) =>
        {
            Assert.AreSame(target, sender);
            actual = e;
            e.Handled = true;
        }));
        target.RaiseEvent(expected);
        Assert.IsNotNull(actual);
        Assert.IsTrue(actual.Handled);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void OnUnCheckedTest()
    {
        var target = new MenuItem();
        RoutedEventArgs? actual = null;
        RoutedEventArgs expected = new RoutedEventArgs(MenuItem.UncheckedEvent) { Source = target };
        Assert.AreSame(target, target.OnUnChecked((sender, e) =>
        {
            Assert.AreSame(target, sender);
            actual = e;
            e.Handled = true;
        }));
        target.RaiseEvent(expected);
        Assert.IsNotNull(actual);
        Assert.IsTrue(actual.Handled);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CommandTest()
    {
        var expected = new TestCommand();
        var target = new MenuItem();
        Assert.AreSame(target, target.Command(expected));
        Assert.AreEqual(expected, target.Command);
    }

    [TestMethod]
    public void CommandParameterTest()
    {
        var expected = "some parameter";
        var target = new MenuItem();
        Assert.AreSame(target, target.CommandParameter(expected));
        var actual = target.CommandParameter;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CommandBindingTest()
    {
        var expected = "commandPath";
        var target = new MenuItem();
        target.CommandBinding(expected);
        var actual = target.GetBindingExpression(MenuItem.CommandProperty).ParentBinding.Path.Path;
        Assert.AreEqual(expected, actual);
        Assert.IsNull(target.GetBindingExpression(MenuItem.CommandParameterProperty), "Should not have modified the command parameter.");
    }

    [TestMethod]
    public void CommandBindingWithParameterTest()
    {
        var expected1 = "commandPath";
        var expected2 = "commandParameterPath";
        var target = new MenuItem();
        target.CommandBinding(expected1, expected2);
        var actual1 = target.GetBindingExpression(MenuItem.CommandProperty).ParentBinding.Path.Path;
        Assert.AreEqual(expected1, actual1);
        var actual2 = target.GetBindingExpression(MenuItem.CommandParameterProperty).ParentBinding.Path.Path;
        Assert.AreEqual(expected2, actual2);
    }

}