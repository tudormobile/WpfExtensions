using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass()]
public class BorderExtensionsTests
{
    [TestMethod]
    public void BrushTest()
    {
        var expected = Brushes.Red;
        var target = new Border();
        Assert.AreSame(target, target.Brush(expected));
        var actual = target.BorderBrush;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void BrushTest1()
    {
        var thick = 4;
        var expected = Brushes.Red;
        var target = new Border();
        Assert.AreSame(target, target.Brush(expected, thick));
        var actual = target.BorderBrush;
        Assert.AreEqual(expected, actual);
        Assert.AreEqual(new Thickness(thick), target.BorderThickness);
    }



    [TestMethod]
    public void FillTest()
    {
        var expected = Brushes.Red;
        var target = new Border();
        Assert.AreSame(target, target.Fill(expected));
        var actual = target.Background;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ThicknessTest()
    {
        var expected = new Thickness(1, 2, 3, 4);
        var target = new Border();
        Assert.AreSame(target, target.Thickness(expected));
        var actual = target.BorderThickness;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ThicknessTest1()
    {
        var expected = new Thickness(1234);
        var target = new Border();
        Assert.AreSame(target, target.Thickness(1234));
        var actual = target.BorderThickness;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ThicknessTest2()
    {
        var expectedH = 12.34;
        var expectedV = 34.56;
        var target = new Border();
        Assert.AreSame(target, target.Thickness(expectedH, expectedV));
        var actual = target.BorderThickness;
        Assert.AreEqual(expectedH, actual.Left);
        Assert.AreEqual(expectedH, actual.Right);
        Assert.AreEqual(expectedV, actual.Top);
        Assert.AreEqual(expectedV, actual.Bottom);
    }

    [TestMethod]
    public void ThicknessTest3()
    {
        var left = 12.34;
        var top = 34.56;
        var right = 45.67;
        var bottom = 56.78;
        var target = new Border();
        Assert.AreSame(target, target.Thickness(left, top, right, bottom));
        var actual = target.BorderThickness;
        Assert.AreEqual(left, actual.Left);
        Assert.AreEqual(right, actual.Right);
        Assert.AreEqual(top, actual.Top);
        Assert.AreEqual(bottom, actual.Bottom);
    }

    [TestMethod]
    public void RadiusTest()
    {
        var expected = new CornerRadius(1, 2, 3, 4);
        var target = new Border();
        Assert.AreSame(target, target.Radius(expected));
        var actual = target.CornerRadius;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RadiusTest1()
    {
        var expected = new CornerRadius(12.34);
        var target = new Border();
        Assert.AreSame(target, target.Radius(12.34));
        var actual = target.CornerRadius;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RadiusTest2()
    {
        var topLeft = 12.34;
        var topRight = 34.56;
        var bottomLeft = 45.67;
        var bottomRight = 56.78;
        var target = new Border();
        Assert.AreSame(target, target.Radius(topLeft, topRight, bottomRight, bottomLeft));
        var actual = target.CornerRadius;
        Assert.AreEqual(topLeft, actual.TopLeft);
        Assert.AreEqual(topRight, actual.TopRight);
        Assert.AreEqual(bottomRight, actual.BottomRight);
        Assert.AreEqual(bottomLeft, actual.BottomLeft);
    }

    [TestMethod]
    public void PaddingTest()
    {
        var expected = new Thickness(1, 2, 3, 4);
        var target = new Border();
        Assert.AreSame(target, target.Padding(expected));
        var actual = target.Padding;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void PaddingTest1()
    {
        var expected = new Thickness(1234);
        var target = new Border();
        Assert.AreSame(target, target.Padding(1234));
        var actual = target.Padding;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void PaddingTest2()
    {
        var expectedH = 12.34;
        var expectedV = 34.56;
        var target = new Border();
        Assert.AreSame(target, target.Padding(expectedH, expectedV));
        var actual = target.Padding;
        Assert.AreEqual(expectedH, actual.Left);
        Assert.AreEqual(expectedH, actual.Right);
        Assert.AreEqual(expectedV, actual.Top);
        Assert.AreEqual(expectedV, actual.Bottom);
    }

    [TestMethod]
    public void PaddingTest3()
    {
        var left = 12.34;
        var top = 34.56;
        var right = 45.67;
        var bottom = 56.78;
        var target = new Border();
        Assert.AreSame(target, target.Padding(left, top, right, bottom));
        var actual = target.Padding;
        Assert.AreEqual(left, actual.Left);
        Assert.AreEqual(right, actual.Right);
        Assert.AreEqual(top, actual.Top);
        Assert.AreEqual(bottom, actual.Bottom);
    }
}