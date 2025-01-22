using System.Windows.Controls;
using System.Windows.Media;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Extension Methods for the ViewBox control.
/// </summary>
public static class ViewboxExtensions
{
    /// <summary>
    /// Sets the Stretch property to 'Uniform'.
    /// </summary>
    /// <param name="viewBox">Viewbox element to extend.</param>
    /// <param name="direction">OPTIONAL; stretch direction to use (default=Both).</param>
    /// <returns>The extended element.</returns>
    public static Viewbox Uniform(this Viewbox viewBox, StretchDirection direction = StretchDirection.Both) { viewBox.Stretch = Stretch.Uniform; viewBox.StretchDirection = direction; return viewBox; }

    /// <summary>
    /// Sets the Stretch property to 'UniformToFill'.
    /// </summary>
    /// <param name="viewBox">Viewbox element to extend.</param>
    /// <param name="direction">OPTIONAL; stretch direction to use (default=Both).</param>
    /// <returns>The extended element.</returns>
    public static Viewbox UniformToFill(this Viewbox viewBox, StretchDirection direction = StretchDirection.Both) { viewBox.Stretch = Stretch.UniformToFill; viewBox.StretchDirection = direction; return viewBox; }

    /// <summary>
    /// Sets the Stretch property to Fill.
    /// </summary>
    /// <param name="viewBox">Viewbox element to extend.</param>
    /// <param name="direction">OPTIONAL; stretch direction to use (default=Both).</param>
    /// <returns>The extended element.</returns>
    public static Viewbox Fill(this Viewbox viewBox, StretchDirection direction = StretchDirection.Both) { viewBox.Stretch = Stretch.Fill; viewBox.StretchDirection = direction; return viewBox; }


    /// <summary>
    /// Sets the Stretch property to None.
    /// </summary>
    /// <param name="viewBox">Viewbox element to extend.</param>
    /// <returns>The extended element.</returns>
    public static Viewbox NoStretch(this Viewbox viewBox) { viewBox.Stretch = Stretch.None; return viewBox; }

}
