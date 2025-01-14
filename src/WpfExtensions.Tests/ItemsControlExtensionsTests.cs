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
}