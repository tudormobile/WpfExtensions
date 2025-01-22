using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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

    /// <summary>
    /// Sets the ImageSource to a relative URI source (resource or file).
    /// </summary>
    /// <param name="image">Image to extend.</param>
    /// <param name="uriSource">Source value to use.</param>
    /// <returns>The extended element.</returns>
    public static Image Source(this Image image, string uriSource)
    {
        image.Source = new BitmapImage(new Uri(uriSource, UriKind.Relative));
        return image;
    }

    /// <summary>
    /// Sets the Stretch property to 'Uniform' with an optional StretchDirection.
    /// </summary>
    /// <param name="image">Image to extend.</param>
    /// <param name="direction">OPTIONAL; Stretch direction to use (default=Both).</param>
    /// <returns>The extended element.</returns>
    public static Image Uniform(this Image image, StretchDirection direction = StretchDirection.Both) { image.Stretch = Stretch.Uniform; image.StretchDirection = direction; return image; }

    /// <summary>
    /// Sets the Stretch property to 'UniformToFill' with an optional StretchDirection.
    /// </summary>
    /// <param name="image">Image to extend.</param>
    /// <param name="direction">OPTIONAL; Stretch direction to use (default=Both).</param>
    /// <returns>The extended element.</returns>
    public static Image UniformToFill(this Image image, StretchDirection direction = StretchDirection.Both) { image.Stretch = Stretch.UniformToFill; image.StretchDirection = direction; return image; }

    /// <summary>
    /// Sets the Stretch property to 'Fill' with an optional StretchDirection.
    /// </summary>
    /// <param name="image">Image to extend.</param>
    /// <param name="direction">OPTIONAL; Stretch direction to use (default=Both).</param>
    /// <returns>The extended element.</returns>
    public static Image Fill(this Image image, StretchDirection direction = StretchDirection.Both) { image.Stretch = Stretch.Fill; image.StretchDirection = direction; return image; }

    /// <summary>
    /// Sets the Stretch property to 'None'.
    /// </summary>
    /// <param name="image">Image to extend.</param>
    /// <returns>The extended element.</returns>
    public static Image NoStretch(this Image image) { image.Stretch = Stretch.None; return image; }

}
