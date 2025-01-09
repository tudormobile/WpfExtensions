using System.Windows;
using System.Windows.Controls;
using Tudormobile.WpfExtensions;
using WpfViewsAndModels.Models;
using static Tudormobile.WpfExtensions.UI;

namespace WpfViewsAndModels.Views
{
    class MainView : ICreateWindow
    {
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

        public static Window CreateWindow()
        {
            return new Window()
            {
                Content = CreateView(),
                SizeToContent = SizeToContent.WidthAndHeight,
            };
        }

        public static Button StandardButton(string? text) => new Button() { Content = text }
            .Size(230, 28).Margin(4);

    }
}
