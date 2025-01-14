using System.Windows;
using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Control Extension Methods.
/// </summary>
public static class ControlExtensions
{
    /// <summary>
    /// Set the border thickness property to zero (no border).
    /// </summary>
    /// <typeparam name="T">Type of control to extend.</typeparam>
    /// <param name="control">The control to extend.</param>
    /// <returns>The extended control.</returns>
    public static T NoBorder<T>(this T control) where T : Control { control.BorderThickness = new(0); return control; }

    /// <summary>
    /// Set the minimum width and height properties.
    /// </summary>
    /// <typeparam name="T">Type of control to extend.</typeparam>
    /// <param name="control">The control to extend.</param>
    /// <param name="width">OPTIONAL; minimum width of the control (DEFAULT=0).</param>
    /// <param name="height">OPTIONAL; minimum height of the control (DEFAULT=0).</param>
    /// <returns>The extended control.</returns>
    public static T MinSize<T>(this T control, double width = 0, double height = 0) where T : FrameworkElement { control.MinWidth = width; control.MinHeight = height; return control; }

    /// <summary>
    /// Set the padding property.
    /// </summary>
    /// <typeparam name="T">Type of control to extend.</typeparam>
    /// <param name="control">Element to extend.</param>
    /// <param name="padding">Padding to use.</param>
    /// <returns>The extended object.</returns>
    public static T Padding<T>(this T control, Thickness padding) where T : Control { control.Padding = padding; return control; }

    /// <summary>
    /// Set the padding property.
    /// </summary>
    /// <typeparam name="T">Type of control to extend.</typeparam>
    /// <param name="control">Element to extend.</param>
    /// <param name="padding">Uniform padding to use.</param>
    /// <returns>The extended object.</returns>
    public static T Padding<T>(this T control, double padding) where T : Control { control.Padding = new Thickness(padding); return control; }

    /// <summary>
    /// Set the padding property.
    /// </summary>
    /// <typeparam name="T">Type of control to extend.</typeparam>
    /// <param name="control">Element to extend.</param>
    /// <param name="left">Left padding to use.</param>
    /// <param name="top">Top padding to use.</param>
    /// <param name="right">Right padding to use.</param>
    /// <param name="bottom">Bottom padding to use.</param>
    /// <returns>The extended object.</returns>
    public static T Padding<T>(this T control, double left, double top, double right, double bottom) where T : Control { control.Padding = new Thickness(left, top, right, bottom); return control; }

    /// <summary>
    /// Set the padding property.
    /// </summary>
    /// <typeparam name="T">Type of control to extend.</typeparam>
    /// <param name="control">Element to extend.</param>
    /// <param name="horizontalPadding">Horizontal padding to use.</param>
    /// <param name="verticalPadding">Vertical padding to use.</param>
    /// <returns>The extended object.</returns>
    public static T Padding<T>(this T control, double horizontalPadding, double verticalPadding) where T : Control { control.Padding = new Thickness(horizontalPadding, verticalPadding, horizontalPadding, verticalPadding); return control; }

    /// <summary>
    /// Sets the vertical and/or horizontal content alignment of the control.
    /// </summary>
    /// <typeparam name="T">Type of control to extend.</typeparam>
    /// <param name="control">Element to extend.</param>
    /// <param name="horizontal">Horizontal alignment setting. Default = Left.</param>
    /// <param name="vertical">Vertical alignment setting. Default = Top.</param>
    /// <returns>The extended object.</returns>
    /// <remarks>
    /// The default values for the horizontal and vertical alignment are Left and Top respectively. This matches the default for all Controls.
    /// </remarks>
    public static T ContentAlignment<T>(this T control, HorizontalAlignment horizontal = HorizontalAlignment.Left, VerticalAlignment vertical = VerticalAlignment.Top) where T : Control
    {
        control.HorizontalContentAlignment = horizontal;
        control.VerticalContentAlignment = vertical;
        return control;
    }
}
