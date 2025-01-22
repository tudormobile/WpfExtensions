using System.Windows;
using System.Windows.Documents;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class UITests
{
    [TestMethod]
    public void TestAllUIExtensions()
    {
        // not sure if this rest is 'worth the trip'
        Assert.IsInstanceOfType<UIElement>(UI.CenteredText("Hello, World!"));
        Assert.IsInstanceOfType<UIElement>(UI.MainMenu());
        Assert.IsInstanceOfType<UIElement>(UI.Entry());
        Assert.IsInstanceOfType<UIElement>(UI.IconHeader("a", "b"));
        Assert.IsInstanceOfType<UIElement>(UI.Entry("prompt"));
    }

    [TestMethod]
    public void EntryWithPromptTest()
    {
        string expected = "prompt";
        var target = UI.Entry(expected);
        var decorator = new AdornerDecorator() { Child = target };
        var w = new Window() { WindowStyle = WindowStyle.None, Content = decorator, Opacity = 0, AllowsTransparency = true };
        w.Show();
        w.Close();
        var layer = AdornerLayer.GetAdornerLayer(target);
        Assert.IsNotNull(layer);
        Assert.IsTrue(layer.GetAdorners(target).Length == 1);
        // Now set some text and make the adorner go away
        target.Text = "this is a test";
        // cannot figure a way to validate

    }
}