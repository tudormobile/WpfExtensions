using System.Windows.Controls;
using System.Windows.Media;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Image Extension Methods.
/// </summary>
public static class ImageExtensions
{
    /// <summary>
    /// Sets the Source property.
    /// </summary>
    /// <param name="image">Image to extend.</param>
    /// <param name="source">Source value to use.</param>
    /// <returns>The extended element.</returns>
    public static Image Source(this Image image, ImageSource source) { image.Source = source; return image; }
}
