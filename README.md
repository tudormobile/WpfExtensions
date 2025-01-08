# WpfExtensions
WPF Extension Methods

[![Build and Deploy](https://github.com/tudormobile/WpfExtensions/actions/workflows/dotnet.yml/badge.svg)](https://github.com/tudormobile/WpfExtensions/actions/workflows/dotnet.yml)  [![Publish Docs](https://github.com/tudormobile/WpfExtensions/actions/workflows/docs.yml/badge.svg)](https://github.com/tudormobile/WpfExtensions/actions/workflows/docs.yml)  [![Create Package Release](https://github.com/tudormobile/WpfExtensions/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tudormobile/WpfExtensions/actions/workflows/dotnet.yml)

Copyright&copy;Tudormobile LLC
### Quick Start

```
using Tudormobile.WpfExtensions;

MainWindow = new Window()
{
    Content = new Grid()
    {
        Children =
        {
            new TextBlock().Text("Hello").Row(0)
                .Bold().Center().Italic(),

            new TextBlock().Text("World!").Row(1)
                .Margin(10).Padding(4,0).ExtraLarge()
        }
    }.Rows(2)
};

MainWindow.Show();
```
The library provides extension methods provide a fluent-like api for building complex UIs in code without the use of xaml markup.

[NuGET Package README](src/README.md) | [API Documentation](https://tudormobile.github.io/WpfApp/)

## Overview
The WpfExtension library contains a series of extension methods for most WPF UIElements and FrameworkElements that allow for setting common properties using a fluent-like API in code.

- Extension methods are provided to allow for a fluent-like coding style to set common properties on elements, such as *Text* in a TextBlock control.
- Additional extension methods, such as *Bold()* and *Italic()* are also included.
- Extension methods for common attached properties (*Row()*, *ColumnSpan()*) and some command events (*OnClick()*, *OnTextChanged()*) are present.
- More complex extensions, such as *Command()* and *Bind()* are also provided.
- Finally, higher level extensions methods for common groupings of UI elements, as well as user-defined overrides and additions to these grouping allow for quickly building complex UIs all in code with no xaml markup.add content here

### Framework Element and UIElement Extensions
The FrameworkElement and UIElement classes provide base level implementtions of several properties and events for WPF elements. Extension properties are provided for the most common of these, including the following:
- Alignment (Horizontal, Vertical)
- Size (Width, Height)
- Margin and Padding
- Tag, DataContext, ToolTip
- Visibility and Opacity


### Grid and other Panel extensions
The *Grid* (and other panel elements) contain commonly used attached properties. Extension methods are provided to allow these to be fluently-attached to framework and UI elements in code. Additionally, the Grid extensions include methods to allow columns and rows to be more easily defined:

```
// Creates a grid with 4 columns and 4 rows.
var grid = new Grid().Columns("45, , Auto, 5*").Rows("1*, 2*, 2*, Auto");

var child = new Button().Row(2);    // a button for row 2, col 0
```

### Content Controls
[add content here]
### Items Controls
[add content here]

### Button Extensions
In addition to the basic properties discussed above, the Button elements (ButtonBase, PushButton, Button, etc.) include extension methods for setting handlers for the *Click* event, Command and CommandParameter properties, as well as binding Commands (and CommandParameters) to data models.

### TextBlock, TextBox, Label Extensions
The Text-based elements contain extensions for text, font style, font weight, font size, as well as more complex extensions, such as *Large()* and *ExtraLarge()* to control the text rendering. Binding extensions are allow provided for the most commonly-bound property, such as the *Text* of a TextBox control.



