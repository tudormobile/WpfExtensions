# WpfExtensions
WPF Extension Methods  

Copyright&copy;Tudormobile LLC  
[Source Code](https://github.com/tudormobile/WpfExtensions) | [Documentation](https://tudormobile.github.io/WpfExtensions/) | [API documentation](https://tudormobile.github.io/WpfExtensions/api/Tudormobile.html)
## Getting Started
### Install the package
```
dotnet add Tudormobile.WpfExtensions
```
### Prerequisites
***None.***
### Dependencies
***None.*** Compatible with Tudormobile.WfApp and Communnity Toolkits such as MVVM.
### Using the library

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

### API Documentation
The API documentation can be found on *github pages* here - [API Documentation](https://tudormobile.github.io/WpfExtensions/).
### Sample Code
Code samples are located in the *samples* folder of the github repository.
### Feedback
**Tudormobile.WpfExtensions** is released as open source under the MIT license. Bug reports and contributions are welcome at the [the github repository](https://github.com/tudormobile/WpfExtensions).