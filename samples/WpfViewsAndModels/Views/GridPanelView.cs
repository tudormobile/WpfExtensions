using System.Windows;
using System.Windows.Controls;
using Tudormobile.WpfExtensions;
using static Tudormobile.WpfExtensions.UI;

namespace WpfViewsAndModels.Views
{
    internal class GridPanelView : ICreateView
    {
        public static UIElement CreateView()
        {
            return new Grid()
            {
                ShowGridLines = true,
                Children =
                {
                    CenteredText("GridPanelView").ExtraLarge().Bold().Margin(0,0,0,10).ColumnSpan(4),

                    new TextBlock().Text("(Row 1, Col 0)").Row(1).Column(0).Alignment(HorizontalAlignment.Center, VerticalAlignment.Center),
                    new TextBlock().Text("(Row 1, Col 1)").Row(1).Column(1).Alignment(HorizontalAlignment.Center, VerticalAlignment.Center),
                    new TextBlock().Text("(Row 1, Col 2)").Row(1).Column(2).Alignment(HorizontalAlignment.Center, VerticalAlignment.Center),
                    new TextBlock().Text("(Row 1, Col 3)").Row(1).Column(3).Alignment(HorizontalAlignment.Center, VerticalAlignment.Center),

                    new TextBlock().Text("(Row 2, Col 0)").Row(2).Column(0).Alignment(HorizontalAlignment.Center, VerticalAlignment.Center),
                    new TextBlock().Text("(Row 2, Col 1)").Row(2).Column(1).Alignment(HorizontalAlignment.Center, VerticalAlignment.Center),
                    new TextBlock().Text("(Row 2, Col 2)").Row(2).Column(2).Alignment(HorizontalAlignment.Center, VerticalAlignment.Center),
                    new TextBlock().Text("(Row 2, Col 3)").Row(2).Column(3).Alignment(HorizontalAlignment.Center, VerticalAlignment.Center),

                    new TextBlock().Text("Last Row (3) is 24px high").ColumnSpan(4).Row(3).Center()
                }
            }.Columns(4).Rows("Auto,,,24").Size(600, 500);
        }

    }
}