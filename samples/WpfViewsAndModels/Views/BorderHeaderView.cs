using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Tudormobile.WpfExtensions;
using static Tudormobile.WpfExtensions.UI;

namespace WpfViewsAndModels.Views
{
    internal class BorderHeaderView : ICreateView
    {
        public static UIElement CreateView()
        {
            return new Grid()
            {
                Children =
                {
                    new StackPanel()
                    {
                        Children =
                        {
                            CenteredText("BorderHeaderView").ExtraLarge().Bold().Margin(0,0,0,10),
                            new Border()
                                .Child(new TextBlock().Text("This text is surrounded by a border").Margin(10))
                                .Radius(10)
                                .Brush(Brushes.Red, 2)
                                .Padding(10)
                                .Fill(Brushes.AliceBlue)
                                .Margin(10),
                            new Expander().Header("Click to Expand").Content("I have been revealed!!")
                        }
                    }
                }
            };
        }

    }
}