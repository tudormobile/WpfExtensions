using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class ImageExtensionsTests
{
    [TestMethod]
    public void SourceTest()
    {
        var expected = BitmapSource.Create(1, 1, 96, 96, PixelFormats.Bgr32, null, new byte[32], 8);
        var target = new Image();
        Assert.AreEqual(target, target.Source(expected));
        var actual = target.Source;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SourceTest1()
    {
        var expected = "/images/icon64x64.png";
        var target = new Image();
        Assert.AreEqual(target, target.Source(expected));
        var actual = target.Source;
        Assert.IsInstanceOfType<BitmapImage>(actual);
    }

    [TestMethod]
    public void UniformTest()
    {
        var expected = Stretch.Uniform;
        var direction = StretchDirection.UpOnly;
        var target = new Image();
        Assert.AreSame(target, target.Uniform(direction));
        var actual = target.Stretch;
        Assert.AreEqual(expected, actual);
        Assert.AreEqual(direction, target.StretchDirection);
    }

    [TestMethod]
    public void UniformToFillTest()
    {
        var expected = Stretch.UniformToFill;
        var direction = StretchDirection.UpOnly;
        var target = new Image();
        Assert.AreSame(target, target.UniformToFill(direction));
        var actual = target.Stretch;
        Assert.AreEqual(expected, actual);
        Assert.AreEqual(direction, target.StretchDirection);
    }

    [TestMethod]
    public void FillTest()
    {
        var expected = Stretch.Fill;
        var direction = StretchDirection.UpOnly;
        var target = new Image();
        Assert.AreSame(target, target.Fill(direction));
        var actual = target.Stretch;
        Assert.AreEqual(expected, actual);
        Assert.AreEqual(direction, target.StretchDirection);
    }

    [TestMethod]
    public void NoStretchTest()
    {
        var expected = Stretch.None;
        var target = new Image();
        Assert.AreSame(target, target.NoStretch());
        var actual = target.Stretch;
        Assert.AreEqual(expected, actual);
    }
}