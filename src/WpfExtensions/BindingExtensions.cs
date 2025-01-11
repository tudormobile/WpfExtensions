using System.Windows;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Binding and Binding Expression Extensions.
/// </summary>
public static class BindingExtensions
{
    /// <summary>
    /// Binds a dependency property to a path.
    /// </summary>
    /// <typeparam name="T">Type of element to extend.</typeparam>
    /// <param name="element">Element to extend.</param>
    /// <param name="dp">Identifies the destination property where the binding should be established.</param>
    /// <param name="path">The source proeprty name or the path to the property used for the binding.</param>
    /// <returns>The extended element.</returns>
    public static T Bind<T>(this T element, DependencyProperty dp, string path) where T : FrameworkElement
    {
        element.SetBinding(dp, path);
        return element;
    }
}
