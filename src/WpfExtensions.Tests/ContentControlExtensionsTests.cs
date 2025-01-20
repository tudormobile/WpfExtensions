using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class ContentControlExtensionsTests
{
    [TestMethod]
    public void ContentTest()
    {
        var target = new ContentControl();
        var expected = "this is a test";

        Assert.AreSame(target, target.Content(expected));
        Assert.AreEqual(expected, target.Content);
    }

    [TestMethod]
    public void ContentTemplateTest()
    {
        var expected = new DataTemplate();
        var target = new ContentControl();
        Assert.AreSame(target, target.ContentTemplate(expected));
        var actual = target.ContentTemplate;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod, ExcludeFromCodeCoverage]
    public void DataTemplateTest()
    {
        var expected = () => new Grid();
        var target = new ContentControl();
        Assert.AreSame(target, target.DataTemplate(expected));
        var actual = target.ContentTemplate.VisualTree;
        Assert.IsInstanceOfType<FrameworkElementFactory>(actual);   // how else can I validate this?

        // Let's try to generate the content
        var g = new Grid() { Children = { target } };

        // I believe this will force the content to be generated
        g.Measure(new Size(100, 100));
        g.Arrange(new Rect(0, 0, 100, 100));

        // How to validate now?
        // This validation requires 'inside knowledge' of the implementation where the 
        // content that is generated is wrapped inside a ContentControl that hosts the UI.
        Assert.IsTrue(target.ContentTemplate.VisualTree.Type.IsAssignableTo(typeof(ContentControl)));
    }

    [TestMethod]
    public void DataTemplateTestWithNullFunction()
    {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        Func<UIElement> expected = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        var target = new ContentControl();
#pragma warning disable CS8604 // Possible null reference argument.
        Assert.AreSame(target, target.DataTemplate(expected));
#pragma warning restore CS8604 // Possible null reference argument.
        var actual = target.ContentTemplate.VisualTree;
        Assert.IsInstanceOfType<FrameworkElementFactory>(actual);   // how else can I validate this?

        // Let's try to generate the content
        var g = new Grid() { Children = { target } };

        // I believe this will force the content to be generated
        g.Measure(new Size(100, 100));
        g.Arrange(new Rect(0, 0, 100, 100));

        // How to validate now?
        // This validation requires 'inside knowledge' of the implementation where the 
        // content that is generated is wrapped inside a ContentControl that hosts the UI.
        Assert.IsTrue(target.ContentTemplate.VisualTree.Type.IsAssignableTo(typeof(ContentControl)));
    }

}