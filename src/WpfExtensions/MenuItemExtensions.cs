using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// MenuItem Extension Methods.
/// </summary>
public static class MenuItemExtensions
{
    /// <summary>
    /// Sets the Icon property.
    /// </summary>
    /// <param name="item">MenuItem to extend.</param>
    /// <param name="icon">Value to use for the icon property.</param>
    /// <returns>The extended object.</returns>
    public static MenuItem Icon(this MenuItem item, object icon) { item.Icon = icon; return item; }

    /// <summary>
    /// Sets the InputGestureText
    /// </summary>
    /// <param name="item">MenuItem to extend.</param>
    /// <param name="inputGestureText">The text to use.</param>
    /// <returns>The extended object.</returns>
    public static MenuItem Gesture(this MenuItem item, string inputGestureText) { item.InputGestureText = inputGestureText; return item; }

    /// <summary>
    /// Sets the IsCheckable property to (true).
    /// </summary>
    /// <param name="item">MenuItem to extend.</param>
    /// <returns>The extended object.</returns>
    public static MenuItem Checkable(this MenuItem item) { item.IsCheckable = true; return item; }

    /// <summary>
    /// Sets the IsChecked property to (true).
    /// </summary>
    /// <param name="item">MenuItem to extend.</param>
    /// <returns>The extended object.</returns>
    /// <remarks>
    /// This extensions method will also set the IsCheckable property to true.
    /// </remarks>
    public static MenuItem Check(this MenuItem item) { item.Checkable().IsChecked = true; return item; }

    /// <summary>
    /// Add a click routed event handler.
    /// </summary>
    /// <param name="item">MenuItem to extend.</param>
    /// <param name="handler">Routed even handler to attach to 'Click' event.</param>
    /// <returns>The extended object.</returns>
    public static MenuItem OnClick(this MenuItem item, RoutedEventHandler handler)
    {
        item.Click += handler;
        return item;
    }

    /// <summary>
    /// Add a click routed event handler.
    /// </summary>
    /// <param name="item">MenuItem to extend.</param>
    /// <param name="handler">Routed even handler to attach to 'Click' event.</param>
    /// <returns>The extended object.</returns>
    public static MenuItem OnChecked(this MenuItem item, RoutedEventHandler handler)
    {
        item.Checked += handler;
        return item;
    }

    /// <summary>
    /// Add a click routed event handler.
    /// </summary>
    /// <param name="item">MenuItem to extend.</param>
    /// <param name="handler">Routed even handler to attach to 'Click' event.</param>
    /// <returns>The extended object.</returns>
    public static MenuItem OnUnChecked(this MenuItem item, RoutedEventHandler handler)
    {
        item.Unchecked += handler;
        return item;
    }

    /// <summary>
    /// Set the Command property of a MenuItem.
    /// </summary>
    /// <param name="item">MenuItem to extend.</param>
    /// <param name="command">Command to use.</param>
    /// <returns>The extended object.</returns>
    public static MenuItem Command(this MenuItem item, ICommand command) { item.Command = command; return item; }

    /// <summary>
    /// Set the CommandParameter property of a MenuItem.
    /// </summary>
    /// <param name="item">MenuItem to extend.</param>
    /// <param name="commandParameter">Command parameter to use.</param>
    /// <returns>The extended object.</returns>
    public static MenuItem CommandParameter(this MenuItem item, object commandParameter) { item.CommandParameter = commandParameter; return item; }

    /// <summary>
    /// Binds the Command/CommandParameter property of a MenuItem.
    /// </summary>
    /// <param name="item">MenuItem to extend.</param>
    /// <param name="command">Command to use.</param>
    /// <param name="commandParameter">OPTIONAL; Command parameter to use.</param>
    /// <returns>The extended object.</returns>
    /// <remarks>
    /// If the command parameter is omitted, no binding operation is peformed on the command parameter. Note
    /// that you can bind the command with this extension method, and then directly set the CommandParameter 
    /// with the CommandParameter() extension method, which is a useful scenario when the parameter does not
    /// need to be bound.
    /// </remarks>
    public static MenuItem CommandBinding(this MenuItem item, string command, string? commandParameter = null)
    {
        item.SetBinding(MenuItem.CommandProperty, new Binding(command));
        if (commandParameter != null)
        {
            item.SetBinding(MenuItem.CommandParameterProperty, new Binding(commandParameter));
        }
        return item;
    }
}
