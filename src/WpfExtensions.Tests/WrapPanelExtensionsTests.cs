using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class WrapPanelExtensionsTests
{
    [TestMethod]
    public void VerticalTest()
    {
        var expected = Orientation.Vertical;
        var target = new WrapPanel();
        Assert.AreSame(target, target.Vertical());
        var actual = target.Orientation;
        Assert.AreEqual(expected, actual);
    }
}