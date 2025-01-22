using System.Windows;
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

    /// <summary>
    /// Set the content template to dynamically generate a template.
    /// </summary>
    /// <typeparam name="T">Type of ContentControl to extend.</typeparam>
    /// <param name="control">Control to extend.</param>
    /// <param name="dataTemplateBuilder">A function to build a template as a UIElement.</param>
    /// <returns>The extended ContentControl.</returns>
    public static T DataTemplate<T>(this T control, Func<UIElement> dataTemplateBuilder) where T : ContentControl
    {
        control.ContentTemplate = Helpers.TemplateGenerator.CreateDataTemplate(dataTemplateBuilder);
        return control;
    }

    /// <summary>
    /// Set the item template property.
    /// </summary>
    /// <typeparam name="T">Type of ItemsControl to extend.</typeparam>
    /// <param name="control">Control to extend.</param>
    /// <param name="template">ItemTemplate to use.</param>
    /// <returns>The extended control.</returns>
    public static T ContentTemplate<T>(this T control, object template) where T : ContentControl { control.ContentTemplate = template as DataTemplate; return control; }

}
