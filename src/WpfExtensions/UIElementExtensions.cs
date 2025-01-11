using System.Windows;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// UI Element Extension Methods.
/// </summary>
public static class UIElementExtensions
{
    /// <summary>
    /// Sets the Opacity factor.
    /// </summary>
    /// <typeparam name="T">The type of UIElement.</typeparam>
    /// <param name="uiElement">UIElement to extend.</param>
    /// <param name="opacity">Opacity of the element.</param>
    /// <returns>The extended object.</returns>
    public static T Opacity<T>(this T uiElement, double opacity) where T : UIElement { uiElement.Opacity = opacity; return uiElement; }

    /// <summary>
    /// Sets the Visibility.
    /// </summary>
    /// <typeparam name="T">The type of UIElement.</typeparam>
    /// <param name="uiElement">UIElement to extend.</param>
    /// <param name="visibility">Visibility of the element.</param>
    /// <returns>The extended object.</returns>
    public static T Visibility<T>(this T uiElement, Visibility visibility) where T : UIElement { uiElement.Visibility = visibility; return uiElement; }

    /// <summary>
    /// Sets the Visibility to 'Visible'.
    /// </summary>
    /// <typeparam name="T">The type of UIElement.</typeparam>
    /// <param name="uiElement">UIElement to extend.</param>
    /// <returns>The extended object.</returns>
    public static T Visible<T>(this T uiElement) where T : UIElement => uiElement.Visibility(System.Windows.Visibility.Visible);

    /// <summary>
    /// Sets the Visibility to 'Hidden'.
    /// </summary>
    /// <typeparam name="T">The type of UIElement.</typeparam>
    /// <param name="uiElement">UIElement to extend.</param>
    /// <returns>The extended object.</returns>
    public static T Hidden<T>(this T uiElement) where T : UIElement => uiElement.Visibility(System.Windows.Visibility.Hidden);

    /// <summary>
    /// Sets the Visibility to 'Collapsed'.
    /// </summary>
    /// <typeparam name="T">The type of UIElement.</typeparam>
    /// <param name="uiElement">UIElement to extend.</param>
    /// <returns>The extended object.</returns>
    public static T Collapsed<T>(this T uiElement) where T : UIElement => uiElement.Visibility(System.Windows.Visibility.Collapsed);

    /// <summary>
    /// Sets the IsEnabled property to (false).
    /// </summary>
    /// <typeparam name="T">The type of UIElement.</typeparam>
    /// <param name="uiElement">UIElement to extend.</param>
    /// <returns>The extended element.</returns>
    public static T Disable<T>(this T uiElement) where T : UIElement { uiElement.IsEnabled = false; return uiElement; }

}
