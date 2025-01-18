using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// HeaderedItemsControl Extension Methods.
/// </summary>
public static class HeaderedItemsControlExtensions
{
    /// <summary>
    /// Sets the Header and HeaderStringFormat properties.
    /// </summary>
    /// <typeparam name="T">Type of header control.</typeparam>
    /// <param name="control">Control to extend.</param>
    /// <param name="header">Header value to use.</param>
    /// <param name="headerStringFormat">OPTIONAL; string format to use.</param>
    /// <returns>The extended control.</returns>
    public static T Header<T>(this T control, object header, string? headerStringFormat = null) where T : HeaderedItemsControl
    {
        control.Header = header;
        if (headerStringFormat != null)
        {
            control.HeaderStringFormat = headerStringFormat;
        }
        return control;
    }

}
