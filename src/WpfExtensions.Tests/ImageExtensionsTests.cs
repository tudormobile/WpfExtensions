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
}