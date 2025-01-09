using System.Windows;
using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class CanvasExtensionsTests
{
    [TestMethod]
    public void BottomTest()
    {
        var bottom = 5;
        var target = new UIElement();
        Assert.AreSame(target, target.Bottom(bottom));
        Assert.AreEqual(bottom, Canvas.GetBottom(target));
    }

    [TestMethod]
    public void LeftTest()
    {
        var left = 5;
        var target = new UIElement();
        Assert.AreSame(target, target.Left(left));
        Assert.AreEqual(left, Canvas.GetLeft(target));
    }

    [TestMethod]
    public void RightTest()
    {
        var right = 5;
        var target = new UIElement();
        Assert.AreSame(target, target.Right(right));
        Assert.AreEqual(right, Canvas.GetRight(target));
    }

    [TestMethod]
    public void TopTest()
    {
        var top = 5;
        var target = new UIElement();
        Assert.AreSame(target, target.Top(top));
        Assert.AreEqual(top, Canvas.GetTop(target));
    }

    [TestMethod]
    public void ZIndexTest()
    {
        var zIndex = 5;
        var target = new UIElement();
        Assert.AreSame(target, target.ZIndex(zIndex));
        Assert.AreEqual(zIndex, Canvas.GetZIndex(target));
    }

    [TestMethod]
    public void LocationTest1()
    {
        // set everything possible
        var left = 1.23;
        var top = 2.34;
        var right = 3.45;
        var bottom = 4.56;
        var zIndex = 5;
        var target = new UIElement();
        Assert.AreSame(target, target.Location(left, top, right, bottom, zIndex));
        Assert.AreEqual(left, Canvas.GetLeft(target));
        Assert.AreEqual(top, Canvas.GetTop(target));
        Assert.AreEqual(right, Canvas.GetRight(target));
        Assert.AreEqual(bottom, Canvas.GetBottom(target));
        Assert.AreEqual(zIndex, Canvas.GetZIndex(target));
    }

    [TestMethod]
    public void LocationTest2()
    {
        // only set zIndex
        var zIndex = 5;
        var target = new UIElement();
        Assert.AreSame(target, target.Location(zIndex: zIndex));
        Assert.AreEqual(double.NaN, Canvas.GetLeft(target));
        Assert.AreEqual(double.NaN, Canvas.GetTop(target));
        Assert.AreEqual(double.NaN, Canvas.GetRight(target));
        Assert.AreEqual(double.NaN, Canvas.GetBottom(target));
        Assert.AreEqual(zIndex, Canvas.GetZIndex(target));
    }

    [TestMethod]
    public void LocationTest3()
    {
        // set nothing
        var expected = 0;
        var target = new UIElement();
        Assert.AreSame(target, target.Location());
        Assert.AreEqual(double.NaN, Canvas.GetLeft(target));
        Assert.AreEqual(double.NaN, Canvas.GetTop(target));
        Assert.AreEqual(double.NaN, Canvas.GetRight(target));
        Assert.AreEqual(double.NaN, Canvas.GetBottom(target));
        Assert.AreEqual(expected, Canvas.GetZIndex(target));
    }

}