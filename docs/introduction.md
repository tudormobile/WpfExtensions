# Introduction
**Tudormobile.WpfExtensions** provides extension methods for WPF UI and Framework elements.

## Overview
The WpfExtension library contains a series of extension methods for common WPF UIElements and FrameworkElements that allow for setting common properties using a fluent-like API in code.

- Extension methods are provided to allow for a fluent-like coding style to set common properties on elements, such as *Text* in a TextBlock control.
- Additional extension methods, such as *Bold()* and *Italic()*, are also included.
- Extension methods for common attached properties (*Row()*, *ColumnSpan()*) and some command events (*OnClick()*, *OnTextChanged()*) are present.
- More complex extensions, such as *Command()* and *Bind()* are also provided.
- Finally, the library also contains higher level extensions methods for common groupings of UI elements, as well as user-defined overrides and additions to these groupings. These allow for quickly building complex UIs all in code with no xaml markup.

### Framework Element and UIElement Extensions
The FrameworkElement and UIElement classes provide base level implementtions of several properties and events for WPF elements. Extension properties are provided for the most common of these, including the following:
- Alignment (Horizontal, Vertical)
- Size (Width, Height)
- Margin and Padding
- Tag, DataContext, ToolTip
- Visibility and Opacity
- more...

### Grid and other Panel extensions
The *Grid* (and other panel elements) contain extensions for many of the commonly used attached properties. Extension methods are provided to allow these to be fluently-attached to framework and UI elements in code. Additionally, the Grid extensions include methods to allow columns and rows to be more easily defined:

```
// Creates a grid with 4 columns and 4 rows.
var grid = new Grid().Columns("45, , Auto, 5*").Rows("1*, 2*, 2*, Auto");

var child = new Button().Row(2);    // a button for row 2, col 0
```
Similarly, the *DockPanel* and *Canvas()* extensions include ***Left()***, ***Right()***, ***Top()***, and ***Bottom()*** extensions to set attached properties on their respective children.

### Content, HeaderedContent, and Border Control Extensions
Extensions method are provided to set the Header, Border size and brush, child element, and corner radius as applicable.

### Range Control Extensions
Range controls, such as *ProgressBar*, include extensions for setting range values (minimum, maximum, etc.) and event handlers for **ValueChanged**.

### Button Extensions
In addition to the basic properties discussed above, the Button elements (ButtonBase, PushButton, Button, etc.) include extension methods for setting handlers for the *Click* event, Command and CommandParameter properties, as well as binding Commands (and CommandParameters) to data models.

### TextBlock, TextBox, Label Extensions
The Text-based elements contain extensions for text, font style, font weight, font size, as well as more complex extensions, such as *Large()* and *ExtraLarge()* to control the text rendering. Binding extensions are allow provided for the most commonly-bound property, such as the *Text* of a TextBox control.

### Other Extensions
In addition to framework element extensions, a static class that provides composites of pre-built UI elements with the most commonly used properties is also available.
```

// Example: Using the UI element.

using static Tudormobile.WpfExtensions.UI;

public static UIElement CreateView()
{
    return new StackPanel()
    {
        Children =
        {
            CenteredText("Choose a Demo to run...").ExtraLarge().Bold().Margin(0,0,0,10),
            StandardButton("Grid Panel Extensions").CommandBinding("GridPanelCommand"),
            StandardButton("Dock Panel Extensions").CommandBinding("DockPanelCommand"),
            StandardButton("Border and Header Extensions").CommandBinding("BorderHeaderCommand"),
            StandardButton("TextBlock and TextBox Extensions").CommandBinding("TextBoxBlockCommand"),
            StandardButton("Misc Extensions").CommandBinding("MiscCommand"),
        }
    }.DataContext(new MainModel()).Margin(20, 30);
}

```
Many other extension methods are defined for a variety of framework elements. See the API documentation for additional information.

[&#8962; Home](https://tudormobile.github.io/WpfExtensions/) | [&#128640; Getting Started](https://tudormobile.github.io/WpfExtensions/getting-started.html) | [&#128462; API Documentation](https://tudormobile.github.io/WpfExtensions/api/Tudormobile.html)

