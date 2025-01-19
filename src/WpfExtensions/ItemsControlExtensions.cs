using System.Windows;
using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Extensions for ItemsControls such as ListBox, ListView, TreeView, etc.
/// </summary>
public static class ItemsControlExtensions
{
    /// <summary>
    /// Set the item template property.
    /// </summary>
    /// <typeparam name="T">Type of ItemsControl to extend.</typeparam>
    /// <param name="control">Control to extend.</param>
    /// <param name="template">ItemTemplate to use.</param>
    /// <returns>The extended control.</returns>
    public static T ItemTemplate<T>(this T control, object template) where T : ItemsControl { control.ItemTemplate = template as DataTemplate; return control; }

    /// <summary>
    /// Set the item template to dynamically generate a data template.
    /// </summary>
    /// <typeparam name="T">Type of ItemsControl to extend.</typeparam>
    /// <param name="control">Control to extend.</param>
    /// <param name="dataTemplateBuilder">A function to build a data template as a UIElement.</param>
    /// <returns>The extended ItemsControl.</returns>
    public static T DataTemplate<T>(this T control, Func<UIElement> dataTemplateBuilder) where T : ItemsControl
    {
        control.ItemTemplate = Helpers.TemplateGenerator.CreateDataTemplate(dataTemplateBuilder);
        return control;
    }

    /// <summary>
    /// Set the Height of an items control element.
    /// </summary>
    /// <typeparam name="T">Type of items control element.</typeparam>
    /// <param name="element">ItemsControl element to extend.</param>
    /// <param name="height">Height to use.</param>
    /// <returns>The extended object.</returns>
    public static T Height<T>(this T element, double height) where T : ItemsControl { element.Height = height; return element; }

}
