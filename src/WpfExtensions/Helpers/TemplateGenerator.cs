using System.Windows;
using System.Windows.Controls;

namespace Tudormobile.WpfExtensions.Helpers;

internal class TemplateGenerator
{
    internal static DataTemplate CreateDataTemplate(Func<object> builder)
        => new DataTemplate(typeof(DependencyObject)).VisualTree(builder);

    internal static ControlTemplate CreateControlTemplate(Type controlType, Func<object> builder)
        => new ControlTemplate(controlType).VisualTree(builder);
}
