using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class ScrollViewerExtensionsTests
{
    [TestMethod]
    public void BothScrollBarsVisibleTest()
    {
        var expected = ScrollBarVisibility.Visible;
        var target = new ScrollViewer();
        Assert.AreSame(target, target.BothScrollBarsVisible());
        Assert.AreEqual(expected, target.HorizontalScrollBarVisibility);
        Assert.AreEqual(expected, target.VerticalScrollBarVisibility);
    }

    [TestMethod]
    public void HorizontalScrollBarVisibleTest()
    {
        var expected = ScrollBarVisibility.Visible;
        var target = new ScrollViewer();
        Assert.AreSame(target, target.HorizontalScrollBarVisible());
        Assert.AreEqual(expected, target.HorizontalScrollBarVisibility);
        Assert.AreEqual(expected, target.VerticalScrollBarVisibility);
    }

    [TestMethod]
    public void ScrollBarsVisibilityTest()
    {
        var target = new ScrollViewer();
        Assert.AreSame(target, target.ScrollBarsVisibility(horizontalVisibility: ScrollBarVisibility.Auto));
        Assert.AreEqual(ScrollBarVisibility.Auto, target.HorizontalScrollBarVisibility);
        Assert.AreEqual(ScrollBarVisibility.Visible, target.VerticalScrollBarVisibility);
    }
}