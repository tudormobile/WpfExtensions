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
This library provides extension methods enabling a fluent-like api for building complex UIs in code without the use of xaml markup.

[Documentation](docs/introduction.md) | [Source Code README](src.README.md) | [API Documentation](https://tudormobile.github.io/WpfExtensions/)

