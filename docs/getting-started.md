# Getting Started

### Install the package
```
dotnet add package Tudormobile.WpfExtensions
```
### Prerequisites
**NONE**

### Dependencies
**NONE**

### Using the Library

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
### Key Features
- Fluent-like API for building UI elements in code
- Extension methods for the most common properties
- Complex extension methods for data binding, event handlers, and commanding
- Pre-built UI components with more common defaults (such as Margin and Padding applied), without deriving from styles
- Convienence methods, such as Grid Row/Column definitions and attached properties.