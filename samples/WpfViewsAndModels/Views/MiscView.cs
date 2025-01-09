using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Tudormobile.WpfExtensions;

namespace WpfViewsAndModels.Views
{
    internal class MiscView : ICreateView
    {
        public static UIElement CreateView()
        {
            return new ScrollViewer().Content(createCanvas());
        }

        private static Canvas createCanvas()
        {
            return new Canvas()
            {
                Background = Brushes.Beige,
                Children =
                {
                    new TextBlock().Text("Text on canvas at x=10, y = 25").Left(10).Top(25),
                    new Rectangle() {Fill = Brushes.Blue, Width = 100, Height = 24}.Left(300).Top(100).ToolTip("Blue rectangle at (300,100)."),
                    createGroupBox()
                }
            }.Size(1000, 800);
        }

        private static GroupBox createGroupBox()
        {
            return new GroupBox()
            {
                Content = new TextBlock().Text("(this is text inside the group box)").Margin(10)
            }.Header(new TextBlock().Text("GroupBox at 100, 300").ExtraLarge().Bold()).Left(100).Top(300);
        }
    }
}