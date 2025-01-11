using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// ProgressBar Extension Methods.
/// </summary>
public static class ProgressBarExtensions
{
    /// <summary>
    /// Sets the Orientation property to 'Vertical'
    /// </summary>
    /// <param name="bar">Element to extend.</param>
    /// <returns>The extended element.</returns>
    public static ProgressBar Vertical(this ProgressBar bar) { bar.Orientation = Orientation.Vertical; return bar; }

    /// <summary>
    /// Sets the IsIndeterminate property to 'True'
    /// </summary>
    /// <param name="bar">Element to extend.</param>
    /// <returns>The extended element.</returns>
    public static ProgressBar Indeterminate(this ProgressBar bar) { bar.IsIndeterminate = true; return bar; }

}
