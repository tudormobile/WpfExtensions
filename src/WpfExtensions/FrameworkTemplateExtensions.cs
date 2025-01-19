using System.Windows;
using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Extensions for templates such as ControlTemplates and DataTemplates.
/// </summary>
public static class FrameworkTemplateExtensions
{
    private class _contentControl : ContentControl
    {
        internal static readonly DependencyProperty FactoryProperty
            = DependencyProperty.Register("Factory", typeof(Func<object>), typeof(_contentControl), new PropertyMetadata(null, (s, e) =>
            {
                var control = s as _contentControl;
                var factory = e.NewValue as Func<object>;
                if (control != null && factory != null)
                {
                    control.Content = factory();
                }
            }));
    }

    /// <summary>
    /// Set the visual tree of a template to a dynamically generated UIElement.
    /// </summary>
    /// <typeparam name="T">Type of template to extend.</typeparam>
    /// <param name="template">Template to extend.</param>
    /// <param name="builder">Function to create a visual tree.</param>
    /// <returns>The extended template.</returns>
    public static T VisualTree<T>(this T template, Func<object> builder) where T : FrameworkTemplate
    {
        var factory = new FrameworkElementFactory(typeof(_contentControl));
        factory.SetValue(_contentControl.FactoryProperty, builder);
        template.VisualTree = factory;
        return template;
    }
}
