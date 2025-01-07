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
}