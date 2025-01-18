using System.Windows;
using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// FrameworkElement Extension Methods.
/// </summary>
public static class FrameworkElementExtentions
{
    /// <summary>
    /// Set the horizontal alignment property.
    /// </summary>
    /// <typeparam name="T">Type of framework element.</typeparam>
    /// <param name="element">Framework element to extend.</param>
    /// <param name="horizontalAlignment">Horizontal Alignment.</param>
    /// <returns>The extended object.</returns>
    public static T HorizontalAlignment<T>(this T element, HorizontalAlignment horizontalAlignment) where T : FrameworkElement { element.HorizontalAlignment = horizontalAlignment; return element; }

    /// <summary>
    /// Set the vertical alignment property.
    /// </summary>
    /// <typeparam name="T">Type of framework element.</typeparam>
    /// <param name="element">Framework element to extend.</param>
    /// <param name="verticalAlignment">Vertical Alignment.</param>
    /// <returns>The extended object.</returns>
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
    /// <returns>The extended object.</returns>
    public static T Size<T>(this T element, double width, double height) where T : FrameworkElement { element.Width = width; element.Height = height; return element; }

    /// <summary>
    /// Set the size of a framework element.
    /// </summary>
    /// <typeparam name="T">Type of framework element.</typeparam>
    /// <param name="element">Framework element to extend.</param>
    /// <param name="size">Size to use.</param>
    /// <returns>The extended object.</returns>
    public static T Size<T>(this T element, Size size) where T : FrameworkElement { element.Width = size.Width; element.Height = size.Height; return element; }

    /// <summary>
    /// Sets the Margin property of a Framework Element.
    /// </summary>
    /// <typeparam name="T">Type of FrameworkElement.</typeparam>
    /// <param name="element">Framework element to extend.</param>
    /// <param name="margin">Margin value.</param>
    /// <returns>The extended object.</returns>
    public static T Margin<T>(this T element, Thickness margin) where T : FrameworkElement { element.Margin = margin; return element; }

    /// <summary>
    /// Sets the Margin property of a Framework Element.
    /// </summary>
    /// <typeparam name="T">Type of FrameworkElement.</typeparam>
    /// <param name="element">Framework element to extend.</param>
    /// <param name="margin">Margin value for all sides.</param>
    /// <returns>The extended object.</returns>
    public static T Margin<T>(this T element, double margin) where T : FrameworkElement { element.Margin = new Thickness(margin); return element; }

    /// <summary>
    /// Sets the Margin property of a Framework Element.
    /// </summary>
    /// <typeparam name="T">Type of FrameworkElement.</typeparam>
    /// <param name="element">Framework element to extend.</param>
    /// <param name="left">Margin value for left side.</param>
    /// <param name="top">Margin value for left side.</param>
    /// <param name="right">Margin value for left side.</param>
    /// <param name="bottom">Margin value for left side.</param>
    /// <returns>The extended object.</returns>
    public static T Margin<T>(this T element, double left, double top, double right, double bottom) where T : FrameworkElement { element.Margin = new Thickness(left, top, right, bottom); return element; }

    /// <summary>
    /// Sets the Margin property of a Framework Element.
    /// </summary>
    /// <typeparam name="T">Type of FrameworkElement.</typeparam>
    /// <param name="element">Framework element to extend.</param>
    /// <param name="horizontalMargin">Margin value for left and right sides.</param>
    /// <param name="verticalMargin">Margin value for top and bottom sides.</param>
    /// <returns>The extended object.</returns>
    public static T Margin<T>(this T element, double horizontalMargin, double verticalMargin) where T : FrameworkElement { element.Margin = new Thickness(horizontalMargin, verticalMargin, horizontalMargin, verticalMargin); return element; }

    /// <summary>
    /// Sets the DataContext property of a Framework Element.
    /// </summary>
    /// <typeparam name="T">Type of FrameworkElement.</typeparam>
    /// <param name="element">Framework element to extend.</param>
    /// <param name="dataContext">DataContext value.</param>
    /// <returns>The extended object.</returns>
    public static T DataContext<T>(this T element, object dataContext) where T : FrameworkElement { element.DataContext = dataContext; return element; }

    /// <summary>
    /// Sets the Tag property of a Framework Element.
    /// </summary>
    /// <typeparam name="T">Type of FrameworkElement.</typeparam>
    /// <param name="element">Framework element to extend.</param>
    /// <param name="tag">Tag value.</param>
    /// <returns>The extended object.</returns>
    public static T Tag<T>(this T element, object tag) where T : FrameworkElement { element.Tag = tag; return element; }

    /// <summary>
    /// Sets the ToolTip property of a Framework Element.
    /// </summary>
    /// <typeparam name="T">Type of FrameworkElement.</typeparam>
    /// <param name="element">Framework element to extend.</param>
    /// <param name="toolTip">ToolTip value.</param>
    /// <returns>The extended object.</returns>
    public static T ToolTip<T>(this T element, object toolTip) where T : FrameworkElement { element.ToolTip = toolTip; return element; }

    /// <summary>
    /// Sets the ContextMenu property.
    /// </summary>
    /// <typeparam name="T">Type of framework element.</typeparam>
    /// <param name="element">Framework element to extend.</param>
    /// <param name="contextMenu">Context Menu value to use.</param>
    /// <returns>The extended element.</returns>
    public static T ContextMenu<T>(this T element, ContextMenu contextMenu) where T : FrameworkElement
    {
        element.ContextMenu = contextMenu;
        return element;
    }

}
