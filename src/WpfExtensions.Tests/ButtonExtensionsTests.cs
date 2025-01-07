using System.Windows;
using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[TestClass]
public class ButtonExtensionsTests
{
    [STATestMethod]
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
}