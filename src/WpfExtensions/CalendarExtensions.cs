using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Extensions for the <see cref="Calendar"/> class.
/// </summary>
public static class CalendarExtensions
{
    /// <summary>
    /// Sets the <see cref="Calendar.DisplayMode"/> to <see cref="CalendarMode.Month"/>.
    /// </summary>
    /// <param name="calendar">Calendar to extend.</param>
    /// <returns>The extended Calendar element.</returns>
    public static Calendar Month(this Calendar calendar) { calendar.DisplayMode = CalendarMode.Month; return calendar; }

    /// <summary>
    /// Sets the <see cref="Calendar.DisplayMode"/> to <see cref="CalendarMode.Year"/>.
    /// </summary>
    /// <param name="calendar">Calendar to extend.</param>
    /// <returns>The extended Calendar element.</returns>
    /// <remarks>
    /// In current versions of WPF (9.0), you can only successfully set the year mode if the calendar is displayed in a window.
    /// This is because the year mode is not supported in the default calendar control template. As a result, a handler is
    /// required to set the Year mode after the Loaded event.
    /// </remarks>
    public static Calendar Year(this Calendar calendar)
    {
        calendar.Loaded += (sender, e) =>
        {
            calendar.DisplayMode = CalendarMode.Year;
        };
        return calendar;
    }

    /// <summary>
    /// Sets the <see cref="Calendar.DisplayMode"/> to <see cref="CalendarMode.Decade"/>.
    /// </summary>
    /// <param name="calendar">Calendar to extend.</param>
    /// <returns>The extended Calendar element.</returns>
    /// <remarks>
    /// In current versions of WPF (9.0), you can only successfully set the year mode if the calendar is displayed in a window.
    /// This is because the year mode is not supported in the default calendar control template. As a result, a handler is
    /// required to set the Year mode after the Loaded event.
    /// </remarks>
    public static Calendar Decade(this Calendar calendar)
    {
        calendar.Loaded += (sender, e) => calendar.DisplayMode = CalendarMode.Decade;
        return calendar;
    }

    /// <summary>
    /// Sets the <see cref="Calendar.DisplayMode"/> to the vale provided.
    /// </summary>
    /// <param name="calendar">Calendar to extend.</param>
    /// <param name="mode">Calendar mode value to use.</param>
    /// <returns>The extended Calendar element.</returns>
    public static Calendar Mode(this Calendar calendar, CalendarMode mode)
        => mode switch
        {
            CalendarMode.Month => calendar.Month(),
            CalendarMode.Year => calendar.Year(),
            CalendarMode.Decade => calendar.Decade(),
            _ => calendar
        };

    /// <summary>
    /// Sets the <see cref="Calendar.DisplayDate"/> to the value provided.
    /// </summary>
    /// <param name="calendar">Calendar to extend.</param>
    /// <param name="date">The date to display.</param>
    /// <returns>The extended Calendar element.</returns>
    public static Calendar DisplayDate(this Calendar calendar, DateTime date) { calendar.DisplayDate = date; return calendar; }
}
