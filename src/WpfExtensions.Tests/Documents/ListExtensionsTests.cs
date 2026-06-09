using System.Windows;
using System.Windows.Documents;
using Tudormobile.WpfExtensions.Documents;

namespace WpfExtensions.Tests;

[STATestClass]
public class ListExtensionsTests
{
    [TestMethod]
    public void MarkerOffsetTest()
    {
        var expected = 12.34;
        var target = new List();
        Assert.AreSame(target, target.MarkerOffset(expected));
        var actual = target.MarkerOffset;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void MarkerStyleTest()
    {
        var expected = TextMarkerStyle.LowerRoman;
        var target = new List();
        Assert.AreSame(target, target.MarkerStyle(expected));
        var actual = target.MarkerStyle;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DiscMarkerTest()
    {
        var expected = TextMarkerStyle.Disc;
        var target = new List();
        Assert.AreSame(target, target.DiscMarker());
        var actual = target.MarkerStyle;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CircleMarkerTest()
    {
        var expected = TextMarkerStyle.Circle;
        var target = new List();
        Assert.AreSame(target, target.CircleMarker());
        var actual = target.MarkerStyle;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void BoxMarkerTest()
    {
        var expected = TextMarkerStyle.Box;
        var target = new List();
        Assert.AreSame(target, target.BoxMarker());
        var actual = target.MarkerStyle;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SquareMarkerTest()
    {
        var expected = TextMarkerStyle.Square;
        var target = new List();
        Assert.AreSame(target, target.SquareMarker());
        var actual = target.MarkerStyle;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalMarkerTest()
    {
        var expected = TextMarkerStyle.Decimal;
        var target = new List();
        Assert.AreSame(target, target.DecimalMarker());
        var actual = target.MarkerStyle;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LowerLatinMarkerTest()
    {
        var expected = TextMarkerStyle.LowerLatin;
        var target = new List();
        Assert.AreSame(target, target.LowerLatinMarker());
        var actual = target.MarkerStyle;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LowerRomanMarkerTest()
    {
        var expected = TextMarkerStyle.LowerRoman;
        var target = new List();
        Assert.AreSame(target, target.LowerRomanMarker());
        var actual = target.MarkerStyle;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void UpperLatinMarkerTest()
    {
        var expected = TextMarkerStyle.UpperLatin;
        var target = new List();
        Assert.AreSame(target, target.UpperLatinMarker());
        var actual = target.MarkerStyle;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void UpperRomanMarkerTest()
    {
        var expected = TextMarkerStyle.UpperRoman;
        var target = new List();
        Assert.AreSame(target, target.UpperRomanMarker());
        var actual = target.MarkerStyle;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void StartIndexTest()
    {
        var expected = 2;
        var target = new List();
        Assert.AreSame(target, target.StartIndex(expected));
        var actual = target.StartIndex;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ItemsTest()
    {
        var target = new List();
        Assert.AreSame(target, target.Items(["one", "two", "three"]));
        Assert.AreEqual(3, target.ListItems.Count);
    }

    [TestMethod]
    public void ItemsTest1()
    {
        var target = new List();
        Assert.AreSame(target, target.Items([new Paragraph()]));
        Assert.AreEqual(1, target.ListItems.Count);
    }
}