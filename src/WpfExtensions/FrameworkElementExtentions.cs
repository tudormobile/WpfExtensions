using System.Windows;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Framework Element Extensions.
/// </summary>
public static class FrameworkElementExtentions
{
    /// <summary>
    /// Set the horizontal alignment property.
    /// </summary>
    /// <typeparam name="T">Type of framework element.</typeparam>
    /// <param name="element">Framework element to extend.</param>
    /// <param name="horizontalAlignment">Horizontal Alignment.</param>
    /// <returns>Fluent-reference to self.</returns>
    public static T HorizontalAlignment<T>(this T element, HorizontalAlignment horizontalAlignment) where T : FrameworkElement { element.HorizontalAlignment = horizontalAlignment; return element; }

    /// <summary>
    /// Set the vertical alignment property.
    /// </summary>
    /// <typeparam name="T">Type of framework element.</typeparam>
    /// <param name="element">Framework element to extend.</param>
    /// <param name="verticalAlignment">Vertical Alignment.</param>
    /// <returns>Fluent-reference to self.</returns>
    public static T VerticalAlignment<T>(this T element, VerticalAlignment verticalAlignment) where T : FrameworkElement { element.VerticalAlignment = verticalAlignment; return element; }

    /// <summary>
    /// Set the alignment (vertical and/or horizontal)
    /// </summary>
    /// <typeparam name="T">Type of framework element.</typeparam>
    /// <param name="element">Framework element to extend.</param>
    /// <param name="horizontal">OPTONAL; Horizontal alignment to set.</param>
    /// <param name="vertical">OPTIONAL; Verical alignment to set.</param>
    /// <returns></returns>
    public static T Alignment<T>(this T element, HorizontalAlignment? horizontal = null, VerticalAlignment? vertical = null) where T : FrameworkElement
    {
        element.HorizontalAlignment = horizontal ?? element.HorizontalAlignment;
        element.VerticalAlignment = vertical ?? element.VerticalAlignment;
        return element;
    }

    /// <summary>
    /// Set the size of a framework element (width and height).
    /// </summary>
    /// <typeparam name="T">Type of framework element.</typeparam>
    /// <param name="element">Framework element to extend.</param>
    /// <param name="width">Width to use.</param>
    /// <param name="height">Height to use.</param>
    /// <returns>Fluent-reference to self.</returns>
    public static T Size<T>(this T element, double width, double height) where T : FrameworkElement { element.Width = width; element.Height = height; return element; }

    /// <summary>
    /// Set the size of a framework element.
    /// </summary>
    /// <typeparam name="T">Type of framework element.</typeparam>
    /// <param name="element">Framework element to extend.</param>
    /// <param name="size">Size to use.</param>
    /// <returns>Fluent-reference to self.</returns>
    public static T Size<T>(this T element, Size size) where T : FrameworkElement { element.Width = size.Width; element.Height = size.Height; return element; }


}
