using System.Windows.Media;
using System.Windows.Shapes;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Shape Extensions
/// </summary>
public static class ShapeExtensions
{
    /// <summary>
    /// Sets the Stroke and StrokeThickness properties of an element.
    /// </summary>
    /// <typeparam name="T">Type of element.</typeparam>
    /// <param name="shape">Element to extend.</param>
    /// <param name="brush">Value to use for the Stroke property.</param>
    /// <param name="thickness">OPTIONAL; Stroke thickness value.</param>
    /// <returns>Fluent-reference to the extended element.</returns>
    /// <remarks>
    /// A thickness value of 1.0 is used when a value is not provided. This allows for the most common case to be easily invoked.
    /// </remarks>
    public static T Stroke<T>(this T shape, Brush brush, double thickness = 1) where T : Shape
    {
        shape.Stroke = brush;
        shape.StrokeThickness = thickness;
        return shape;
    }

    /// <summary>
    /// Sets the Fill property.
    /// </summary>
    /// <typeparam name="T">Type of element.</typeparam>
    /// <param name="shape">Element to extend.</param>
    /// <param name="brush">Value to use for fill.</param>
    /// <returns>Fluent-reference to the extended element.</returns>
    /// <remarks>
    /// The Fill() extensions method is overloaded. When a Brush argument is provided,
    /// the Fill property is assigned the value. When no arguments are provided the
    /// Stretch property is set to Stretch.Fill.
    /// </remarks>
    public static T Fill<T>(this T shape, Brush brush) where T : Shape { shape.Fill = brush; return shape; }

    /// <summary>
    /// Sets the Stretch property to 'Fill'
    /// </summary>
    /// <typeparam name="T">Type of element.</typeparam>
    /// <param name="shape">Element to extend.</param>
    /// <returns>Fluent-reference to the extended element.</returns>
    /// <remarks>
    /// The Fill() extensions method is overloaded. When a Brush argument is provided,
    /// the Fill property is assigned the value. When no arguments are provided the
    /// Stretch property is set to Stretch.Fill.
    /// </remarks>
    public static T Fill<T>(this T shape) where T : Shape { shape.Stretch = Stretch.Fill; return shape; }

    /// <summary>
    /// Sets the Stretch property to 'Uniform'
    /// </summary>
    /// <typeparam name="T">Type of element.</typeparam>
    /// <param name="shape">Element to extend.</param>
    /// <returns>Fluent-reference to the extended element.</returns>
    public static T Uniform<T>(this T shape) where T : Shape { shape.Stretch = Stretch.Uniform; return shape; }

    /// <summary>
    /// Sets the Stretch property to 'UniformToFill'
    /// </summary>
    /// <typeparam name="T">Type of element.</typeparam>
    /// <param name="shape">Element to extend.</param>
    /// <returns>Fluent-reference to the extended element.</returns>
    public static T UniformToFill<T>(this T shape) where T : Shape { shape.Stretch = Stretch.UniformToFill; return shape; }
}
