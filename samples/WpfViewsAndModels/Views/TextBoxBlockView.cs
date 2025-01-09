using System.Windows;
using System.Windows.Controls;
using Tudormobile.WpfExtensions;
using WpfViewsAndModels.Models;
using static Tudormobile.WpfExtensions.UI;

namespace WpfViewsAndModels.Views
{
    internal class TextBoxBlockView : ICreateView
    {
        public static UIElement CreateView()
        {
            return new Grid()
            {
                Children =
                {
                    CenteredText("TextBoxBlockView").ExtraLarge().Bold().Margin(0,0,0,10),
                    textViews().Row(1)
                }
            }.Rows("Auto,*").DataContext(new TextBoxBlockModel());
        }

        private static Grid textViews()
        {
            return new Grid()
            {
                Children =
                {
                    new TextBlock().Bind("UsernamePrompt").Row(0).Column(0).Margin(4).Padding(0,1,0,0),
                    new TextBlock().Bind("PasswordPrompt").Row(1).Column(0).Margin(4).Padding(0,1,0,0),
                    new TextBox().Bind("Username").Row(0).Column(1).Margin(4).Size(100,24),
                    new TextBox().Bind("Password").Row(1).Column(1).Margin(4).Size(100,24),
                    new StackPanel()
                    {
                        Orientation = Orientation.Horizontal,
                        Children =
                        {
                            new TextBlock().Bind("Username").Margin(4),
                            new TextBlock().Text("/").Margin(0,4),
                            new TextBlock().Bind("Password").Margin(4),
                        }
                    }.Row(2).ColumnSpan(2)
                }
            }.Rows(3).Columns(2).Margin(40);
        }
    }
}