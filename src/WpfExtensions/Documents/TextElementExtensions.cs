using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace Tudormobile.WpfExtensions.Documents;

/// <summary>
/// Provides extension methods for the <see cref="TextElement"/> class to simplify setting common properties.
/// </summary>
public static class TextElementExtensions
{
    /// <summary>
    /// Sets the background brush of the text element.
    /// </summary>
    /// <typeparam name="T">The type of the text element.</typeparam>
    /// <param name="element">The text element.</param>
    /// <param name="brush">The background brush.</param>
    /// <returns>The text element with the background brush set.</returns>
    public static T Background<T>(this T element, Brush brush) where T : TextElement { element.Background = brush; return element; }

    /// <summary>
    /// Sets the foreground brush of the text element.
    /// </summary>
    /// <typeparam name="T">The type of the text element.</typeparam>
    /// <param name="element">The text element.</param>
    /// <param name="brush">The foreground brush.</param>
    /// <returns>The text element with the foreground brush set.</returns>
    public static T Foreground<T>(this T element, Brush brush) where T : TextElement { element.Foreground = brush; return element; }

    /// <summary>
    /// Sets the font style of the text element to italic.
    /// </summary>
    /// <typeparam name="T">The type of the text element.</typeparam>
    /// <param name="element">The text element.</param>
    /// <returns>The text element with the font style set to italic.</returns>
    public static T Italic<T>(this T element) where T : TextElement { element.FontStyle = FontStyles.Italic; return element; }

    /// <summary>
    /// Sets the font weight of the text element to bold.
    /// </summary>
    /// <typeparam name="T">The type of the text element.</typeparam>
    /// <param name="element">The text element.</param>
    /// <returns>The text element with the font weight set to bold.</returns>
    public static T Bold<T>(this T element) where T : TextElement { element.FontWeight = FontWeights.Bold; return element; }

    /// <summary>
    /// Sets the font weight of the text element to light.
    /// </summary>
    /// <typeparam name="T">The type of the text element.</typeparam>
    /// <param name="element">The text element.</param>
    /// <returns>The text element with the font weight set to light.</returns>
    public static T Light<T>(this T element) where T : TextElement { element.FontWeight = FontWeights.Light; return element; }

    /// <summary>
    /// Sets the font size of the text element.
    /// </summary>
    /// <typeparam name="T">The type of the text element.</typeparam>
    /// <param name="element">The text element.</param>
    /// <param name="fontSize">The font size.</param>
    /// <returns>The text element with the font size set.</returns>
    public static T FontSize<T>(this T element, double fontSize) where T : TextElement { element.FontSize = fontSize; return element; }

    /// <summary>
    /// Sets the font size of the text element to a large size.
    /// </summary>
    /// <typeparam name="T">The type of the text element.</typeparam>
    /// <param name="element">The text element.</param>
    /// <returns>The text element with the font size set to large.</returns>
    public static T Large<T>(this T element) where T : TextElement => element.FontSize(SystemFonts.MessageFontSize + 2);

    /// <summary>
    /// Sets the font size of the text element to an extra large size.
    /// </summary>
    /// <typeparam name="T">The type of the text element.</typeparam>
    /// <param name="element">The text element.</param>
    /// <returns>The text element with the font size set to extra large.</returns>
    public static T ExtraLarge<T>(this T element) where T : TextElement => element.FontSize(SystemFonts.MessageFontSize + 4);

    /// <summary>
    /// Sets the font size of the text element to a small size.
    /// </summary>
    /// <typeparam name="T">The type of the text element.</typeparam>
    /// <param name="element">The text element.</param>
    /// <returns>The text element with the font size set to small.</returns>
    public static T Small<T>(this T element) where T : TextElement => element.FontSize(SystemFonts.MessageFontSize - 2);

    /// <summary>
    /// Sets the font size of the text element to an extra small size.
    /// </summary>
    /// <typeparam name="T">The type of the text element.</typeparam>
    /// <param name="element">The text element.</param>
    /// <returns>The text element with the font size set to extra small.</returns>
    public static T ExtraSmall<T>(this T element) where T : TextElement => element.FontSize(SystemFonts.MessageFontSize - 4);
}
