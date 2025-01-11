using System.Windows;
using Tudormobile.WpfExtensions;
namespace WpfExtensions.Tests;

[STATestClass]
public class BindingExtensionsTests
{
    [TestMethod]
    public void BindTest()
    {
        var expected = "test";
        var target = new FrameworkElement();
        Assert.AreSame(target, target.Bind(FrameworkElement.IsEnabledProperty, expected));
        var actual = target.GetBindingExpression(FrameworkElement.IsEnabledProperty).ParentBinding.Path.Path;
        Assert.AreEqual(expected, actual);
    }
}