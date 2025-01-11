using System.Windows;
using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Canvas Extension Methods.
/// </summary>
public static class CanvasExtensions
{
    /// <summary>
    /// Sets the Canvas.Bottom attached property on an element.
    /// </summary>
    /// <typeparam name="T">Type of element to extend.</typeparam>
    /// <param name="element">Element to extend.</param>
    /// <param name="bottom">Value to use.</param>
    /// <returns>The extended object.</returns>
    public static T Bottom<T>(this T element, double bottom) where T : UIElement { Canvas.SetBottom(element, bottom); return element; }

    /// <summary>
    /// Sets the Canvas.Bottom attached property on an element.
    /// </summary>
    /// <typeparam name="T">Type of element to extend.</typeparam>
    /// <param name="element">Element to extend.</param>
    /// <param name="left">The left value to use.</param>
    /// <returns>The extended object.</returns>
    public static T Left<T>(this T element, double left) where T : UIElement { Canvas.SetLeft(element, left); return element; }

    /// <summary>
    /// Sets the Canvas.Bottom attached property on an element.
    /// </summary>
    /// <typeparam name="T">Type of element to extend.</typeparam>
    /// <param name="element">Element to extend.</param>
    /// <param name="right">The right value to use.</param>
    /// <returns>The extended object.</returns>
    public static T Right<T>(this T element, double right) where T : UIElement { Canvas.SetRight(element, right); return element; }

    /// <summary>
    /// Sets the Canvas.Bottom attached property on an element.
    /// </summary>
    /// <typeparam name="T">Type of element to extend.</typeparam>
    /// <param name="element">Element to extend.</param>
    /// <param name="top">The top value to use.</param>
    /// <returns>The extended object.</returns>
    public static T Top<T>(this T element, double top) where T : UIElement { Canvas.SetTop(element, top); return element; }

    /// <summary>
    /// Sets the Canvas.Bottom attached property on an element.
    /// </summary>
    /// <typeparam name="T">Type of element to extend.</typeparam>
    /// <param name="element">Element to extend.</param>
    /// <param name="zIndex">The z-index value to use.</param>
    /// <returns>The extended object.</returns>
    public static T ZIndex<T>(this T element, int zIndex) where T : UIElement { Panel.SetZIndex(element, zIndex); return element; }

    /// <summary>
    /// Sets Canvas location attached properties.
    /// </summary>
    /// <typeparam name="T">Type of element to extend.</typeparam>
    /// <param name="element">Element to extend.</param>
    /// <param name="left">The left value to use.</param>
    /// <param name="top">The top value to use.</param>
    /// <param name="right">The right value to use.</param>
    /// <param name="bottom">The bottom value to use.</param>
    /// <param name="zIndex">The z-index value to use.</param>
    /// <returns>The extended object.</returns>
    public static T Location<T>(this T element, double? left = null, double? top = null, double? right = null, double? bottom = null, int? zIndex = null) where T : UIElement
    {
        if (left != null) Canvas.SetLeft(element, left.Value);
        if (top != null) Canvas.SetTop(element, top.Value);
        if (right != null) Canvas.SetRight(element, right.Value);
        if (bottom != null) Canvas.SetBottom(element, bottom.Value);
        if (zIndex != null) Panel.SetZIndex(element, zIndex.Value);
        return element;
    }

}
