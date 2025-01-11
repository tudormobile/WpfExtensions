using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// TextBlock Extension Methods.
/// </summary>
public static class TextBlockExtensions
{
    /// <summary>
    /// Sets the Text property.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <param name="text">Text.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock Text(this TextBlock textBlock, string text) { textBlock.Text = text; return textBlock; }

    /// <summary>
    /// Setthe text alignment property.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <param name="textAlignment">Text alignment.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock TextAlignment(this TextBlock textBlock, TextAlignment textAlignment) { textBlock.TextAlignment = textAlignment; return textBlock; }

    /// <summary>
    /// Set the text alignment property to 'Center'.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock Center(this TextBlock textBlock) => textBlock.TextAlignment(System.Windows.TextAlignment.Center);

    /// <summary>
    /// Set the background brush property.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <param name="brush">Background brush.></param>
    /// <returns>The extended object.</returns>
    public static TextBlock Background(this TextBlock textBlock, Brush brush) { textBlock.Background = brush; return textBlock; }

    /// <summary>
    /// Set the foreground brush property.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <param name="brush">Foreground brush.></param>
    /// <returns>The extended object.</returns>
    public static TextBlock Foreground(this TextBlock textBlock, Brush brush) { textBlock.Foreground = brush; return textBlock; }

    /// <summary>
    /// Set the font weight property.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <param name="fontWeight">Font weight.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock FontWeight(this TextBlock textBlock, FontWeight fontWeight) { textBlock.FontWeight = fontWeight; return textBlock; }

    /// <summary>
    /// Set the font weight property to 'Bold'.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock Bold(this TextBlock textBlock) => textBlock.FontWeight(FontWeights.Bold);

    /// <summary>
    /// Set the font weight property to 'Italic'.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock Italic(this TextBlock textBlock) { textBlock.FontStyle = FontStyles.Italic; return textBlock; }

    /// <summary>
    /// Set the font size property.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <param name="fontSize">Font size.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock FontSize(this TextBlock textBlock, double fontSize) { textBlock.FontSize = fontSize; return textBlock; }

    /// <summary>
    /// Set the font size property to 'Large'.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock Large(this TextBlock textBlock) => textBlock.FontSize(SystemFonts.MessageFontSize + 2);

    /// <summary>
    /// Set the font size property to 'ExtraLarge'.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock ExtraLarge(this TextBlock textBlock) => textBlock.FontSize(SystemFonts.MessageFontSize + 4);

    /// <summary>
    /// Set the font size property to 'Small'.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock Small(this TextBlock textBlock) => textBlock.FontSize(SystemFonts.MessageFontSize - 2);

    /// <summary>
    /// Set the font size property to 'ExtraSmall'.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock ExtraSmall(this TextBlock textBlock) => textBlock.FontSize(SystemFonts.MessageFontSize - 4);

    /// <summary>
    /// Set the padding property.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <param name="padding">Padding to use.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock Padding(this TextBlock textBlock, Thickness padding) { textBlock.Padding = padding; return textBlock; }

    /// <summary>
    /// Set the padding property.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <param name="padding">Uniform padding to use.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock Padding(this TextBlock textBlock, double padding) { textBlock.Padding = new Thickness(padding); return textBlock; }

    /// <summary>
    /// Set the padding property.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <param name="left">Left padding to use.</param>
    /// <param name="top">Top padding to use.</param>
    /// <param name="right">Right padding to use.</param>
    /// <param name="bottom">Bottom padding to use.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock Padding(this TextBlock textBlock, double left, double top, double right, double bottom) { textBlock.Padding = new Thickness(left, top, right, bottom); return textBlock; }

    /// <summary>
    /// Set the padding property.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <param name="horizontalPadding">Horizontal padding to use.</param>
    /// <param name="verticalPadding">Vertical padding to use.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock Padding(this TextBlock textBlock, double horizontalPadding, double verticalPadding) { textBlock.Padding = new Thickness(horizontalPadding, verticalPadding, horizontalPadding, verticalPadding); return textBlock; }

    /// <summary>
    /// Set the text trimming property.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <param name="textTrimming">Text trimming to use.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock TextTrimming(this TextBlock textBlock, TextTrimming textTrimming) { textBlock.TextTrimming = textTrimming; return textBlock; }

    /// <summary>
    /// Set the text trimming property to 'CharacterEllipsis'.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock CharacterEllipsis(this TextBlock textBlock) { textBlock.TextTrimming = System.Windows.TextTrimming.CharacterEllipsis; return textBlock; }

    /// <summary>
    /// Set the text trimming property to 'WordEllipsis'.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock WordEllipsis(this TextBlock textBlock) { textBlock.TextTrimming = System.Windows.TextTrimming.WordEllipsis; return textBlock; }

    /// <summary>
    /// Set the text wrapping property.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <param name="textWrapping">Text trimming to use.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock TextWrapping(this TextBlock textBlock, TextWrapping textWrapping) { textBlock.TextWrapping = textWrapping; return textBlock; }

    /// <summary>
    /// Set the text wrapping property to 'Wrap'.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock Wrap(this TextBlock textBlock) { textBlock.TextWrapping = System.Windows.TextWrapping.Wrap; return textBlock; }

    /// <summary>
    /// Set the text wrapping property to 'WrapWithOverflow'.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock WrapWithOverflow(this TextBlock textBlock) { textBlock.TextWrapping = System.Windows.TextWrapping.WrapWithOverflow; return textBlock; }

    /// <summary>
    /// Add one-way binding to the Text property.
    /// </summary>
    /// <param name="textBlock">TextBlock to extend.</param>
    /// <param name="path">Binding path.</param>
    /// <returns>The extended object.</returns>
    public static TextBlock Bind(this TextBlock textBlock, string path)
    {
        textBlock.SetBinding(TextBlock.TextProperty, new Binding(path) { Mode = BindingMode.OneWay });

        return textBlock;
    }

}
