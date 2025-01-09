using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Border Extensions.
/// </summary>
public static class BorderExtensions
{
    /// <summary>
    /// Sets the Border Brush and Thickness.
    /// </summary>
    /// <param name="border">Element to extend.</param>
    /// <param name="brush">Border brush to use.</param>
    /// <param name="thickness">OPTIONAL; sets the border thickness to this uniform value if provided.</param>
    /// <returns>Fluent reference to extended object.</returns>
    public static Border Brush(this Border border, Brush brush, double? thickness = null)
    {
        border.BorderBrush = brush;
        if (thickness != null)
        {
            border.BorderThickness = new Thickness(thickness.Value);
        }
        return border;
    }

    /// <summary>
    /// Sets the Background property.
    /// </summary>
    /// <param name="border">Element to extend.</param>
    /// <param name="fill">Brush value to use.</param>
    /// <returns>Fluent reference to extended object.</returns>
    public static Border Fill(this Border border, Brush fill) { border.Background = fill; return border; }

    /// <summary>
    /// Sets the BorderThickness property.
    /// </summary>
    /// <param name="border">Element to extend.</param>
    /// <param name="borderThickness">Value to use.</param>
    /// <returns>Fluent reference to extended object.</returns>
    public static Border Thickness(this Border border, Thickness borderThickness) { border.BorderThickness = borderThickness; return border; }

    /// <summary>
    /// Sets the BorderThickness property.
    /// </summary>
    /// <param name="border">Element to extend.</param>
    /// <param name="thickness">Uniform padding to use.</param>
    /// <returns>Fluent reference to extended object.</returns>
    public static Border Thickness(this Border border, double thickness) { border.BorderThickness = new Thickness(thickness); return border; }

    /// <summary>
    /// Sets the BorderThickness property.
    /// </summary>
    /// <param name="border">Element to extend.</param>
    /// <param name="left">Left value to use.</param>
    /// <param name="top">Top value to use.</param>
    /// <param name="right">Right value to use.</param>
    /// <param name="bottom">Bottom value to use.</param>
    /// <returns>Fluent reference to extended object.</returns>
    public static Border Thickness(this Border border, double left, double top, double right, double bottom) { border.BorderThickness = new Thickness(left, top, right, bottom); return border; }

    /// <summary>
    /// Sets the BorderThickness property.
    /// </summary>
    /// <param name="border">Element to extend.</param>
    /// <param name="horizontalValue">Horizontal value to use.</param>
    /// <param name="verticalValue">Vertical value to use.</param>
    /// <returns>Fluent reference to extended object.</returns>
    public static Border Thickness(this Border border, double horizontalValue, double verticalValue) { border.BorderThickness = new Thickness(horizontalValue, verticalValue, horizontalValue, verticalValue); return border; }

    /// <summary>
    /// Set the Corner Radius property.
    /// </summary>
    /// <param name="border">Element to extend.</param>
    /// <param name="cornerRadius">Value to use.</param>
    /// <returns>Fluent reference to extended object.</returns>
    public static Border Radius(this Border border, CornerRadius cornerRadius) { border.CornerRadius = cornerRadius; return border; }

    /// <summary>
    /// Set the Corner Radius property.
    /// </summary>
    /// <param name="border">Element to extend.</param>
    /// <param name="uniformRadius">Uniform value to use.</param>
    /// <returns>Fluent reference to extended object.</returns>
    public static Border Radius(this Border border, double uniformRadius) { border.CornerRadius = new CornerRadius(uniformRadius); return border; }

    /// <summary>
    /// Set the Corner Radius property.
    /// </summary>
    /// <param name="border">Element to extend.</param>
    /// <param name="left">Left value to use.</param>
    /// <param name="top">Top value to use.</param>
    /// <param name="right">Right value to use.</param>
    /// <param name="bottom">Bottom value to use.</param>
    /// <returns>Fluent reference to extended object.</returns>
    public static Border Radius(this Border border, double left, double top, double right, double bottom) { border.CornerRadius = new CornerRadius(left, top, right, bottom); return border; }


    /// <summary>
    /// Set the padding property.
    /// </summary>
    /// <param name="border">Element to extend.</param>
    /// <param name="padding">Padding to use.</param>
    /// <returns>Fluent reference to extended object.</returns>
    public static Border Padding(this Border border, Thickness padding) { border.Padding = padding; return border; }

    /// <summary>
    /// Set the padding property.
    /// </summary>
    /// <param name="border">Element to extend.</param>
    /// <param name="padding">Uniform padding to use.</param>
    /// <returns>Fluent reference to extended object.</returns>
    public static Border Padding(this Border border, double padding) { border.Padding = new Thickness(padding); return border; }

    /// <summary>
    /// Set the padding property.
    /// </summary>
    /// <param name="border">Element to extend.</param>
    /// <param name="left">Left padding to use.</param>
    /// <param name="top">Top padding to use.</param>
    /// <param name="right">Right padding to use.</param>
    /// <param name="bottom">Bottom padding to use.</param>
    /// <returns>Fluent reference to extended object.</returns>
    public static Border Padding(this Border border, double left, double top, double right, double bottom) { border.Padding = new Thickness(left, top, right, bottom); return border; }

    /// <summary>
    /// Set the padding property.
    /// </summary>
    /// <param name="border">Element to extend.</param>
    /// <param name="horizontalPadding">Horizontal padding to use.</param>
    /// <param name="verticalPadding">Vertical padding to use.</param>
    /// <returns>Fluent reference to extended object.</returns>
    public static Border Padding(this Border border, double horizontalPadding, double verticalPadding) { border.Padding = new Thickness(horizontalPadding, verticalPadding, horizontalPadding, verticalPadding); return border; }

}
