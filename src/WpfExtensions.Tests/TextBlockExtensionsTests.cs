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
}