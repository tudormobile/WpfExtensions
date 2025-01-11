using System.Windows;
using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// DockPanel Extension Methods.
/// </summary>
public static class DockPanelExtensions
{
    /// <summary>
    /// Sets the Dock attached property on the element.
    /// </summary>
    /// <typeparam name="T">Type of element.</typeparam>
    /// <param name="uiElement">Element to extend.</param>
    /// <param name="dock">Dock value to use.</param>
    /// <returns>The extended object.</returns>
    public static T Dock<T>(this T uiElement, Dock dock) where T : UIElement { DockPanel.SetDock(uiElement, dock); return uiElement; }

    /// <summary>
    /// Sets the Dock attached property on the element to 'Left'.
    /// </summary>
    /// <typeparam name="T">Type of element.</typeparam>
    /// <param name="uiElement">Element to extend.</param>
    /// <returns>The extended object.</returns>
    public static T Left<T>(this T uiElement) where T : UIElement { DockPanel.SetDock(uiElement, System.Windows.Controls.Dock.Left); return uiElement; }

    /// <summary>
    /// Sets the Dock attached property on the element to 'Top'.
    /// </summary>
    /// <typeparam name="T">Type of element.</typeparam>
    /// <param name="uiElement">Element to extend.</param>
    /// <returns>The extended object.</returns>
    public static T Top<T>(this T uiElement) where T : UIElement { DockPanel.SetDock(uiElement, System.Windows.Controls.Dock.Top); return uiElement; }

    /// <summary>
    /// Sets the Dock attached property on the element to 'Right'.
    /// </summary>
    /// <typeparam name="T">Type of element.</typeparam>
    /// <param name="uiElement">Element to extend.</param>
    /// <returns>The extended object.</returns>
    public static T Right<T>(this T uiElement) where T : UIElement { DockPanel.SetDock(uiElement, System.Windows.Controls.Dock.Right); return uiElement; }

    /// <summary>
    /// Sets the Dock attached property on the element to 'Bottom'.
    /// </summary>
    /// <typeparam name="T">Type of element.</typeparam>
    /// <param name="uiElement">Element to extend.</param>
    /// <returns>The extended object.</returns>
    public static T Bottom<T>(this T uiElement) where T : UIElement { DockPanel.SetDock(uiElement, System.Windows.Controls.Dock.Bottom); return uiElement; }
}
