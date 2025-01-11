using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Content Control Extension Methods.
/// </summary>
public static class ContentControlExtensions
{
    /// <summary>
    /// Set the content property.
    /// </summary>
    /// <typeparam name="T">Type of content control.</typeparam>
    /// <param name="contentControl">Content control to extend.</param>
    /// <param name="content">Content to set.</param>
    /// <returns>The extended element.</returns>
    public static T Content<T>(this T contentControl, object content) where T : ContentControl { contentControl.Content = content; return contentControl; }

}
