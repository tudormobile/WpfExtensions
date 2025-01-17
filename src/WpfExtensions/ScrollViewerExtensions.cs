using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Extensions for ScrollViewer.
/// </summary>
public static class ScrollViewerExtensions
{
    /// <summary>
    /// Make both scroll bars visible.
    /// </summary>
    /// <param name="scrollViewer">ScrollViewer to extend.</param>
    /// <returns>The extended scroll viewer.</returns>
    public static ScrollViewer BothScrollBarsVisible(this ScrollViewer scrollViewer)
    {
        scrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Visible;
        scrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
        return scrollViewer;
    }

    /// <summary>
    /// Make the horizontal scroll bar visible.
    /// </summary>
    /// <param name="scrollViewer">ScrollViewer to extend.</param>
    /// <returns>The extended scroll viewer.</returns>
    public static ScrollViewer HorizontalScrollBarVisible(this ScrollViewer scrollViewer)
    {
        scrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Visible;
        return scrollViewer;
    }

    /// <summary>
    /// Set the visibility of the scroll bars.
    /// </summary>
    /// <param name="scrollViewer">ScrollViewer to extend.</param>
    /// <param name="horizontalVisibility">Horizontal scrollbar visibility.</param>
    /// <param name="verticalScrollBarVisibility">OPTIONAL; vertical scrollbar visiblity (default = Visible).</param>
    /// <returns>The extended scroll viewer.</returns>
    /// <remarks>
    /// This method can be used to set both the horizontal and vertical scroll bar visibility. If only the horizontal
    /// parameter is provided, the vertical scrollbar is set to Visible.
    /// </remarks>
    public static ScrollViewer ScrollBarsVisibility(this ScrollViewer scrollViewer, ScrollBarVisibility horizontalVisibility, ScrollBarVisibility verticalScrollBarVisibility = ScrollBarVisibility.Visible)
    {
        scrollViewer.HorizontalScrollBarVisibility = horizontalVisibility;
        scrollViewer.VerticalScrollBarVisibility = verticalScrollBarVisibility;
        return scrollViewer;
    }
}
