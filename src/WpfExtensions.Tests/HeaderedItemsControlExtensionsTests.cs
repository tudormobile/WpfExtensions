using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class HeaderedItemsControlExtensionsTests
{
    [TestMethod]
    public void HeaderTest()
    {
        var expected = "This is a test";
        var target = new MenuItem();
        Assert.AreEqual(target, target.Header(expected));
        var actual = target.Header;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void HeaderTest1()
    {
        var expected = DateTime.Now;
        var format = "D";
        var target = new MenuItem();
        Assert.AreSame(target, target.Header(expected, format));
        var actual = target.Header;
        Assert.AreEqual(expected, actual);
        Assert.AreEqual(format, target.HeaderStringFormat);
    }

}