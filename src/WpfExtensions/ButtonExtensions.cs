﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Button Extension Methods.
/// </summary>
public static class ButtonExtensions
{
    /// <summary>
    /// Add a click routed event handler.
    /// </summary>
    /// <param name="button">Button to extend.</param>
    /// <param name="handler">Routed even handler to attach to 'Click' event.</param>
    /// <returns>The extended object.</returns>
    public static Button OnClick(this Button button, Action<object, RoutedEventArgs> handler)
    {
        button.Click += (s, e) => handler(button, e);
        return button;
    }

    /// <summary>
    /// Set the IsDefault property to 'true'
    /// </summary>
    /// <param name="button">Button to extend.</param>
    /// <returns>The extended object.</returns>
    public static Button Default(this Button button) { button.IsDefault = true; return button; }

    /// <summary>
    /// Set the IsCancel property to 'true'
    /// </summary>
    /// <param name="button">Button to extend.</param>
    /// <returns>The extended object.</returns>
    public static Button Cancel(this Button button) { button.IsCancel = true; return button; }

    /// <summary>
    /// Set the ClickMode property of a button.
    /// </summary>
    /// <typeparam name="T">Type of button</typeparam>
    /// <param name="button">Button to extend.</param>
    /// <param name="clickMode">Click mode to use.</param>
    /// <returns>The extended object.</returns>
    public static T ClickMode<T>(this T button, ClickMode clickMode) where T : ButtonBase { button.ClickMode = clickMode; return button; }

    /// <summary>
    /// Set the ClickMode property of a button to 'Pressed'.
    /// </summary>
    /// <typeparam name="T">Type of button</typeparam>
    /// <param name="button">Button to extend.</param>
    /// <returns>The extended object.</returns>
    public static T ModePress<T>(this T button) where T : ButtonBase => button.ClickMode(System.Windows.Controls.ClickMode.Press);

    /// <summary>
    /// Set the ClickMode property of a button to 'Hover'.
    /// </summary>
    /// <param name="button">Button to extend.</param>
    /// <returns>The extended object.</returns>
    public static T ModeHover<T>(this T button) where T : ButtonBase => button.ClickMode(System.Windows.Controls.ClickMode.Hover);

    /// <summary>
    /// Set the Command property of a button.
    /// </summary>
    /// <typeparam name="T">Type of button</typeparam>
    /// <param name="button">Button to extend.</param>
    /// <param name="command">Command to use.</param>
    /// <returns>The extended object.</returns>
    public static T Command<T>(this T button, ICommand command) where T : ButtonBase { button.Command = command; return button; }

    /// <summary>
    /// Set the CommandParameter property of a button.
    /// </summary>
    /// <typeparam name="T">Type of button</typeparam>
    /// <param name="button">Button to extend.</param>
    /// <param name="commandParameter">Command parameter to use.</param>
    /// <returns>The extended object.</returns>
    public static T CommandParameter<T>(this T button, object commandParameter) where T : ButtonBase { button.CommandParameter = commandParameter; return button; }

    /// <summary>
    /// Binds the Command/CommandParameter property of a button.
    /// </summary>
    /// <typeparam name="T">Type of button</typeparam>
    /// <param name="button">Button to extend.</param>
    /// <param name="command">Command to use.</param>
    /// <param name="commandParameter">OPTIONAL; Command parameter to use.</param>
    /// <returns>The extended object.</returns>
    /// <remarks>
    /// If the command parameter is omitted, no binding operation is peformed on the command parameter. Note
    /// that you can bind the command with this extension method, and then directly set the CommandParameter 
    /// with the CommandParameter() extension method, which is a useful scenario when the parameter does not
    /// need to be bound.
    /// </remarks>
    public static T CommandBinding<T>(this T button, string command, string? commandParameter = null) where T : ButtonBase
    {
        button.SetBinding(Button.CommandProperty, new Binding(command));
        if (commandParameter != null)
        {
            button.SetBinding(Button.CommandParameterProperty, new Binding(commandParameter));
        }
        return button;
    }

    /// <summary>
    /// Sets the IsChecked property of a ToggleButton to true.
    /// </summary>
    /// <typeparam name="T">Type of toggle button to extend.</typeparam>
    /// <param name="element">Element to extend.</param>
    /// <returns>The extended element.</returns>
    public static T IsChecked<T>(this T element) where T : ToggleButton
    {
        element.IsChecked = true;
        return element;
    }

    /// <summary>
    /// Sets the IsThreeState property of a ToggleButton to true.
    /// </summary>
    /// <typeparam name="T">Type of toggle button to extend.</typeparam>
    /// <param name="element">Element to extend.</param>
    /// <returns>The extended element.</returns>
    public static T IsThreeState<T>(this T element) where T : ToggleButton
    {
        element.IsThreeState = true;
        return element;
    }

    /// <summary>
    /// Adds a handler to the Indeterminate event of a ToggleButton.
    /// </summary>
    /// <typeparam name="T">Type of toggle button to extend.</typeparam>
    /// <param name="element">Element to extend.</param>
    /// <param name="handler">Handler to add.</param>
    /// <returns>The extended element.</returns>
    public static T OnIndeterminate<T>(this T element, RoutedEventHandler handler) where T : ToggleButton
    {
        element.Indeterminate += handler;
        return element;
    }

    /// <summary>
    /// Adds a handler to the Checked event of a ToggleButton.
    /// </summary>
    /// <typeparam name="T">Type of toggle button to extend.</typeparam>
    /// <param name="element">Element to extend.</param>
    /// <param name="handler">Handler to add.</param>
    /// <returns>The extended element.</returns>
    public static T OnChecked<T>(this T element, RoutedEventHandler handler) where T : ToggleButton
    {
        element.Checked += handler;
        return element;
    }

    /// <summary>
    /// Adds a handler to the Unchecked event of a ToggleButton.
    /// </summary>
    /// <typeparam name="T">Type of toggle button to extend.</typeparam>
    /// <param name="element">Element to extend.</param>
    /// <param name="handler">Handler to add.</param>
    /// <returns>The extended element.</returns>
    public static T OnUnchecked<T>(this T element, RoutedEventHandler handler) where T : ToggleButton
    {
        element.Unchecked += handler;
        return element;
    }

    /// <summary>
    /// Sets the Width property of a ButtonBase element.
    /// </summary>
    /// <typeparam name="T">Type of element to extend.</typeparam>
    /// <param name="element">Element to extend.</param>
    /// <param name="width">The value to use for Width.</param>
    /// <returns>The extended element.</returns>
    public static T Width<T>(this T element, double width) where T : ButtonBase
    {
        element.Width = width;
        return element;
    }

}
