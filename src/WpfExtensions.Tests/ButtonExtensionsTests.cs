using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class ButtonExtensionsTests
{
    [TestMethod]
    public void OnClickTest()
    {
        var target = new Button();
        RoutedEventArgs? actual = null;
        RoutedEventArgs expected = new RoutedEventArgs(Button.ClickEvent) { Source = target };
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
    public void DefaultTest()
    {
        var target = new Button();
        Assert.AreSame(target, target.Default());
        Assert.IsTrue(target.IsDefault);
    }

    [TestMethod]
    public void CancelTest()
    {
        var target = new Button();
        Assert.AreSame(target, target.Cancel());
        Assert.IsTrue(target.IsCancel);
    }

    [TestMethod]
    public void ClickModeTest()
    {
        var expected = ClickMode.Hover;
        var target = new Button();
        Assert.AreSame(target, target.ClickMode(expected));
        var actual = target.ClickMode;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CommandBindingTest()
    {
        var expected = "commandPath";
        var target = new Button();
        target.CommandBinding(expected);
        var actual = target.GetBindingExpression(Button.CommandProperty).ParentBinding.Path.Path;
        Assert.AreEqual(expected, actual);
        Assert.IsNull(target.GetBindingExpression(Button.CommandParameterProperty), "Should not have modified the command parameter.");
    }

    [TestMethod]
    public void CommandBindingWithParameterTest()
    {
        var expected1 = "commandPath";
        var expected2 = "commandParameterPath";
        var target = new Button();
        target.CommandBinding(expected1, expected2);
        var actual1 = target.GetBindingExpression(Button.CommandProperty).ParentBinding.Path.Path;
        Assert.AreEqual(expected1, actual1);
        var actual2 = target.GetBindingExpression(Button.CommandParameterProperty).ParentBinding.Path.Path;
        Assert.AreEqual(expected2, actual2);
    }

    [TestMethod]
    public void CommandTest()
    {
        var expected = new TestCommand();
        var target = new Button();
        Assert.AreSame(target, target.Command(expected));
        Assert.AreEqual(expected, target.Command);
    }

    [TestMethod]
    public void CommandParameterTest()
    {
        var expected = "some parameter";
        var target = new Button();
        Assert.AreSame(target, target.CommandParameter(expected));
        var actual = target.CommandParameter;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ModePressTest()
    {
        var expected = ClickMode.Press;
        var target = new Button();
        Assert.AreSame(target, target.ModePress());
        var actual = target.ClickMode;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ModeHoverTest()
    {
        var expected = ClickMode.Hover;
        var target = new Button();
        Assert.AreSame(target, target.ModeHover());
        var actual = target.ClickMode;
        Assert.AreEqual(expected, actual);
    }

    [ExcludeFromCodeCoverage]
    internal class TestCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        public bool CanExecute(object? parameter) => true;
        public void Execute(object? parameter) => throw new NotImplementedException();
        protected virtual void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}