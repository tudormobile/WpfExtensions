using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Tudormobile.WpfExtensions;
using static Tudormobile.WpfExtensions.UI;

namespace WpfViewsAndModels.Views
{
    internal class DockPanelView : ICreateView
    {
        public static UIElement CreateView()
        {
            return new DockPanel()
            {
                Children =
                {
                    new TextBlock().Text("This text is docked at the bottom").Background(Brushes.AliceBlue).Padding(10).Center().Bottom(),
                    new TextBlock().Text("This text is docked at the TOP").Background(Brushes.AliceBlue).Padding(10).Center().Top(),
                    new ProgressBar() {Width = 10 }.Indeterminate().Vertical().Right(),
                    new Rectangle() {VerticalAlignment = VerticalAlignment.Stretch, Width=10, Fill = Brushes.Red},
                    CenteredText("Filled Content in dock panel").ExtraLarge().Bold().Margin(0,0,0,10),
                },
                MinHeight = 400,
                MinWidth = 400
            };
        }

    }
}