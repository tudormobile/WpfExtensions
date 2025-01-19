using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using Tudormobile.WpfExtensions;
namespace WpfExtensions.Tests;

[STATestClass]
public class ItemsControlExtensionsTests
{
    [TestMethod]
    public void ItemTemplateTest()
    {
        var expected = new DataTemplate();
        var target = new ListBox();
        Assert.AreSame(target, target.ItemTemplate(expected));
        var actual = target.ItemTemplate;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod, ExcludeFromCodeCoverage]
    public void DataTemplateTest()
    {
        var expected = () => new Grid();
        var target = new ListBox();
        Assert.AreSame(target, target.DataTemplate(expected));
        var actual = target.ItemTemplate.VisualTree;
        Assert.IsInstanceOfType<FrameworkElementFactory>(actual);   // how else can I validate this?
    }

    [TestMethod]
    public void HeightTest()
    {
        var expected = 42.34;
        var target = new ListBox();
        Assert.AreSame(target, target.Height(expected));
        var actual = target.Height;
        Assert.AreEqual(expected, actual);
    }
}