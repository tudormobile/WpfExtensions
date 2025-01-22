using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class SelectorExtensionsTests
{
    [TestMethod]
    public void SelectIndexTest()
    {
        var expected = 0;
        var target = new ListBox();
        target.Items.Add(new ListBoxItem());
        Assert.AreSame(target, target.SelectIndex(expected));
        var actual = target.SelectedIndex;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SelectItemTest()
    {
        var expected = new ListBoxItem();
        var target = new ListBox();
        target.Items.Add(expected);
        Assert.AreSame(target, target.SelectItem(expected));
        var actual = target.SelectedItem;
        Assert.AreEqual(expected, actual);
    }
}