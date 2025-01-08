using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[TestClass]
public class TextBlockExtensionsTests
{
    [STATestMethod]
    public void TextTest()
    {
        var expected = "this is a test";
        var target = new TextBlock();
        Assert.AreSame(target, target.Text(expected));
        Assert.AreEqual(expected, target.Text);
    }

    [STATestMethod]
    public void TextAlignmentTest()
    {
        var expected = TextAlignment.Justify;
        var target = new TextBlock();
        Assert.AreSame(target, target.TextAlignment(expected));
        Assert.AreEqual(expected, target.TextAlignment);
    }

    [STATestMethod]
    public void BackgroundTest()
    {
        var expected = Brushes.Red;
        var target = new TextBlock();
        Assert.AreSame(target, target.Background(expected));
        Assert.AreEqual(expected, target.Background);
    }

    [STATestMethod]
    public void FontWeightTest()
    {
        var expected = FontWeights.SemiBold;
        var target = new TextBlock();
        Assert.AreSame(target, target.FontWeight(expected));
        Assert.AreEqual(expected, target.FontWeight);
    }

    [STATestMethod]
    public void CenterTest()
    {
        var target = new TextBlock();
        Assert.AreSame(target, target.Center());
        Assert.AreEqual(TextAlignment.Center, target.TextAlignment);
    }

    [STATestMethod]
    public void WrapTest()
    {
        var target = new TextBlock();
        Assert.AreSame(target, target.Wrap());
        Assert.AreEqual(TextWrapping.Wrap, target.TextWrapping);
    }

    [STATestMethod]
    public void WrapWithOverflowTest()
    {
        var target = new TextBlock();
        Assert.AreSame(target, target.WrapWithOverflow());
        Assert.AreEqual(TextWrapping.WrapWithOverflow, target.TextWrapping);
    }

    [STATestMethod]
    public void ForegroundTest()
    {
        var expected = Brushes.Red;
        var target = new TextBlock();
        Assert.AreSame(target, target.Foreground(expected));
        Assert.AreEqual(expected, target.Foreground);
    }

    [STATestMethod]
    public void BoldTest()
    {
        var expected = FontWeights.Bold;
        var target = new TextBlock();
        Assert.AreSame(target, target.Bold());
        var actual = target.FontWeight;
        Assert.AreEqual(expected, actual);
    }

    [STATestMethod]
    public void ItalicTest()
    {
        var expected = FontStyles.Italic;
        var target = new TextBlock();
        Assert.AreSame(target, target.Italic());
        var actual = target.FontStyle;
        Assert.AreEqual(expected, actual);
    }

    [STATestMethod]
    public void FontSizeTest()
    {
        var expected = 23.45;
        var target = new TextBlock();
        Assert.AreSame(target, target.FontSize(expected));
        var actual = target.FontSize;
        Assert.AreEqual(expected, actual);
    }

    [STATestMethod]
    public void LargeTest()
    {
        var expected = new TextBlock().FontSize;
        var target = new TextBlock();
        Assert.AreSame(target, target.Large());
        var actual = target.FontSize;
        Assert.IsTrue(actual > expected);
    }

    [STATestMethod]
    public void ExtraLargeTest()
    {
        var expected = new TextBlock().Large().FontSize;
        var target = new TextBlock();
        Assert.AreSame(target, target.ExtraLarge());
        var actual = target.FontSize;
        Assert.IsTrue(actual > expected);
    }

    [STATestMethod]
    public void SmallTest()
    {
        var expected = new TextBlock().FontSize;
        var target = new TextBlock();
        Assert.AreSame(target, target.Small());
        var actual = target.FontSize;
        Assert.IsTrue(actual < expected);
    }

    [STATestMethod]
    public void ExtraSmallTest()
    {
        var expected = new TextBlock().Small().FontSize;
        var target = new TextBlock();
        Assert.AreSame(target, target.ExtraSmall());
        var actual = target.FontSize;
        Assert.IsTrue(actual < expected);
    }

    [STATestMethod]
    public void PaddingTest1()
    {
        var expected = new Thickness(1, 2, 3, 4);
        var target = new TextBlock();
        Assert.AreSame(target, target.Padding(expected));
        var actual = target.Padding;
        Assert.AreEqual(expected, actual);
    }

    [STATestMethod]
    public void PaddingTest2()
    {
        var expected = 12.34;
        var target = new TextBlock();
        Assert.AreSame(target, target.Padding(expected));
        var actual = target.Padding;
        Assert.AreEqual(expected, actual.Left);
        Assert.AreEqual(expected, actual.Top);
        Assert.AreEqual(expected, actual.Right);
        Assert.AreEqual(expected, actual.Bottom);
    }

    [STATestMethod]
    public void PaddingTest3()
    {
        var expectedH = 12.34;
        var expectedV = 56.78;
        var target = new TextBlock();
        Assert.AreSame(target, target.Padding(expectedH, expectedV));
        var actual = target.Padding;
        Assert.AreEqual(expectedH, actual.Left);
        Assert.AreEqual(expectedV, actual.Top);
        Assert.AreEqual(expectedH, actual.Right);
        Assert.AreEqual(expectedV, actual.Bottom);
    }

    [STATestMethod]
    public void PaddingTest4()
    {
        var left = 12.34;
        var top = 56.78;
        var right = 11;
        var bottom = 22;
        var target = new TextBlock();
        Assert.AreSame(target, target.Padding(left, top, right, bottom));
        var actual = target.Padding;
        Assert.AreEqual(left, actual.Left);
        Assert.AreEqual(top, actual.Top);
        Assert.AreEqual(right, actual.Right);
        Assert.AreEqual(bottom, actual.Bottom);
    }

    [STATestMethod]
    public void TextTrimmingTest()
    {
        var expected = TextTrimming.CharacterEllipsis;
        var target = new TextBlock();
        Assert.AreSame(target, target.TextTrimming(expected));
        var actual = target.TextTrimming;
        Assert.AreEqual(expected, actual);
    }

    [STATestMethod]
    public void CharacterEllipsisTest()
    {
        var expected = TextTrimming.CharacterEllipsis;
        var target = new TextBlock();
        Assert.AreSame(target, target.CharacterEllipsis());
        var actual = target.TextTrimming;
        Assert.AreEqual(expected, actual);
    }

    [STATestMethod]
    public void WordEllipsisTest()
    {
        var expected = TextTrimming.WordEllipsis;
        var target = new TextBlock();
        Assert.AreSame(target, target.WordEllipsis());
        var actual = target.TextTrimming;
        Assert.AreEqual(expected, actual);
    }

    [STATestMethod]
    public void TextWrappingTest()
    {
        var expected = TextWrapping.WrapWithOverflow;
        var target = new TextBlock();
        Assert.AreSame(target, target.TextWrapping(expected));
        var actual = target.TextWrapping;
        Assert.AreEqual(expected, actual);
    }

}