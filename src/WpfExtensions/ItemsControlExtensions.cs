using System.Windows;
using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// 
/// </summary>
public static class ItemsControlExtensions
{
    /// <summary>
    /// Set the item template property.
    /// </summary>
    /// <typeparam name="T">Type of ItemsControl to extend.</typeparam>
    /// <param name="control">Control to extend.</param>
    /// <param name="template">ItemTemplate to use.</param>
    /// <returns>THe extended control.</returns>
    public static T ItemTemplate<T>(this T control, object template) where T : ItemsControl { control.ItemTemplate = template as DataTemplate; return control; }

}
