using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using Tudormobile.WpfExtensions.Documents;

namespace WpfExtensions.Tests;

[STATestClass]
public class TextElementExtensionsTests
{
    [TestMethod]
    public void BackgroundTest()
    {
        var expected = Brushes.Red;
        var target = new Paragraph();
        Assert.AreSame(target, target.Background(expected));
        var actual = target.Background;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ForegroundTest()
    {
        var expected = Brushes.Red;
        var target = new Paragraph();
        Assert.AreSame(target, target.Foreground(expected));
        var actual = target.Foreground;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ItalicTest()
    {
        var expected = FontStyles.Italic;
        var target = new Paragraph();
        Assert.AreSame(target, target.Italic());
        var actual = target.FontStyle;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void BoldTest()
    {
        var expected = FontWeights.Bold;
        var target = new Paragraph();
        Assert.AreSame(target, target.Bold());
        var actual = target.FontWeight;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LightTest()
    {
        var expected = FontWeights.Light;
        var target = new Paragraph();
        Assert.AreSame(target, target.Light());
        var actual = target.FontWeight;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FontSizeTest()
    {
        var expected = 24.0;
        var target = new Paragraph();
        Assert.AreSame(target, target.FontSize(expected));
        var actual = target.FontSize;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LargeTest()
    {
        var expected = SystemFonts.MessageFontSize + 2;
        var target = new Paragraph();
        Assert.AreSame(target, target.Large());
        var actual = target.FontSize;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ExtraLargeTest()
    {
        var expected = SystemFonts.MessageFontSize + 4;
        var target = new Paragraph();
        Assert.AreSame(target, target.ExtraLarge());
        var actual = target.FontSize;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SmallTest()
    {
        var expected = SystemFonts.MessageFontSize - 2;
        var target = new Paragraph();
        Assert.AreSame(target, target.Small());
        var actual = target.FontSize;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ExtraSmallTest()
    {
        var expected = SystemFonts.MessageFontSize - 4;
        var target = new Paragraph();
        Assert.AreSame(target, target.ExtraSmall());
        var actual = target.FontSize;
        Assert.AreEqual(expected, actual);
    }
}