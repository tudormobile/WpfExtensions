using System.Windows;
using System.Windows.Controls.Primitives;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Range element extensions.
/// </summary>
public static class RangeBaseExtensions
{
    /// <summary>
    /// Sets the parameters of a Range element.
    /// </summary>
    /// <typeparam name="T">Type of range element to extend.</typeparam>
    /// <param name="rangeBase">Element to extend.</param>
    /// <param name="minimum">OPTIONAL; Minimum, if provided.</param>
    /// <param name="maximum">OPTIONAL; Maximum, if provided.</param>
    /// <param name="smallChange">OPTIONAL; Small change, if provided.</param>
    /// <param name="largeChange">OPTIONAL; Large change, if provided.</param>
    /// <returns>Fluent-reference to the extended element.</returns>
    public static T Range<T>(this T rangeBase, double? minimum = null, double? maximum = null, double? smallChange = null, double? largeChange = null) where T : RangeBase
    {
        rangeBase.Minimum = minimum ?? rangeBase.Minimum;
        rangeBase.Maximum = maximum ?? rangeBase.Maximum;
        rangeBase.SmallChange = smallChange ?? rangeBase.SmallChange;
        rangeBase.LargeChange = largeChange ?? rangeBase.LargeChange;
        return rangeBase;
    }

    /// <summary>
    /// Adds an event handler to the ValueChanged event.
    /// </summary>
    /// <typeparam name="T">Type of range element to extend.</typeparam>
    /// <param name="element">Element to extend.</param>
    /// <param name="handler">Event handler to add.</param>
    /// <returns>Fluent-reference to the extended element.</returns>
    public static T OnValueChanged<T>(this T element, RoutedPropertyChangedEventHandler<double> handler) where T : RangeBase
    {
        element.ValueChanged += handler;
        return element;
    }
}
