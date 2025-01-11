using System.Windows;
using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Decorator Extension Methods.
/// </summary>
public static class DecoratorExtensions
{
    /// <summary>
    /// Adds a child to an element.
    /// </summary>
    /// <typeparam name="T">Type of element.</typeparam>
    /// <param name="element">Element to extend.</param>
    /// <param name="child">Child to add.</param>
    /// <returns>The extended element.</returns>
    public static T Child<T>(this T element, UIElement child) where T : Decorator { element.Child = child; return element; }
}
