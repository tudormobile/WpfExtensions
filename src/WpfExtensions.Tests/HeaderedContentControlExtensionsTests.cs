using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class HeaderedContentControlExtensionsTests
{
    [TestMethod]
    public void HeaderTest()
    {
        var expected = "this is a test";
        var target = new GroupBox();
        Assert.AreSame(target, target.Header(expected));
        var actual = target.Header;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void HeaderTest1()
    {
        var expected = DateTime.Now;
        var format = "D";
        var target = new GroupBox();
        Assert.AreSame(target, target.Header(expected, format));
        var actual = target.Header;
        Assert.AreEqual(expected, actual);
        Assert.AreEqual(format, target.HeaderStringFormat);
    }

}