using System.Windows.Controls;
using Tudormobile.WpfExtensions;
namespace WpfExtensions.Tests;

[STATestClass]
public class ListBoxExtensionsTests
{
    [TestMethod]
    public void SelectMultipleTest()
    {
        var target = new ListBox();
        Assert.AreSame(target, target.SelectMultiple());
        Assert.AreEqual(SelectionMode.Multiple, target.SelectionMode);
    }

    [TestMethod]
    public void SelectExtendedTest()
    {
        var target = new ListBox();
        Assert.AreSame(target, target.SelectExtended());
        Assert.AreEqual(SelectionMode.Extended, target.SelectionMode);
    }
}