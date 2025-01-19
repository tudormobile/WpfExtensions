using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Tudormobile.WpfExtensions;

namespace WpfExtensionsGallery.Views
{
    /// <summary>
    /// Interaction logic for PanelView.xaml
    /// </summary>
    public partial class PanelView : UserControl
    {
        public PanelView()
        {
            InitializeComponent();
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            _ = root.Columns(2).Rows("Auto, *");

            var dockPanel = new DockPanel()
            {
                Children =
                {
                    new TextBlock().Text("DockPanel - docked at the top").Center().Top(),
                    new TextBlock().Text("DockPanel - docked at the Bottom").Center().Bottom(),
                    new Rectangle().Size(10,100).Fill(Brushes.Blue).Left(),
                    new Rectangle().Size(10,100).Fill(Brushes.Blue).Right(),
                    new TextBlock().Text("(( Blue bars docked Left & Right ))")
                        .Alignment(HorizontalAlignment.Center, VerticalAlignment.Center)// Last item is filled in the remaining space
               },
            };

            var gridPanel = new Grid()
            {
                ShowGridLines = true,
                Children =
                        {
                            new TextBlock().Text("GridPanel - 4x3").Center().Row(0).Column(0).ColumnSpan(4),
                            new TextBlock().Text("Row 1, Col 1").Center().Row(1).Column(0),
                            new TextBlock().Text("Row 1, Col 2").Center().Row(1).Column(1),
                            new TextBlock().Text("Row 1, Col 3").Center().Row(1).Column(2),
                            new TextBlock().Text("Row 1, Col 4").Center().Row(1).Column(3),
                            new TextBlock().Text("(2, 1)").Center().Row(2).Column(0),
                            new TextBlock().Text("(2, 2)").Center().Row(2).Column(1),
                            new TextBlock().Text("(2, 3)").Center().Row(2).Column(2),
                            new TextBlock().Text("(2, 4)").Center().Row(2).Column(3),
                        }
            }.Columns(4).Rows(3).Margin(4);

            var codePanel = new ScrollViewer()
                                .BothScrollBarsVisible()
                                .Content(new TextBlock().Text(code)
                                    .FontFamily("Courier New")
                                    .Bold()
                                    .Background(Brushes.AliceBlue)
                                    .Foreground(Brushes.Black)
                                    .Margin(4));

            root.Children.Add(new Border().Brush(Brushes.Blue, 0.5).Row(0).Column(0).Margin(4).Child(dockPanel));
            root.Children.Add(gridPanel.Row(0).Column(1).Margin(10));
            root.Children.Add(codePanel.Row(2).ColumnSpan(2).Margin(10));

        }

        private static readonly string code = @"
// Code ...
    _ = root.Columns(2).Rows(""Auto, *"");

    var dockPanel = new DockPanel()
    {
        Children =
        {
            new TextBlock().Text(""DockPanel - docked at the top"").Center().Top(),
            new TextBlock().Text(""DockPanel - docked at the Bottom"").Center().Bottom(),
            new Rectangle().Size(10,100).Fill(Brushes.Blue).Left(),
            new Rectangle().Size(10,100).Fill(Brushes.Blue).Right(),
            new TextBlock().Text(""(( Blue bars docked Left & Right ))"")
                .Alignment(HorizontalAlignment.Center, VerticalAlignment.Center)// Last item is filled in the remaining space
        },
    };

    var gridPanel = new Grid()
    {
        ShowGridLines = true,
        Children =
                {
                    new TextBlock().Text(""GridPanel - 4x3"").Center().Row(0).Column(0).ColumnSpan(4),
                    new TextBlock().Text(""Row 1, Col 1"").Center().Row(1).Column(0),
                    new TextBlock().Text(""Row 1, Col 2"").Center().Row(1).Column(1),
                    new TextBlock().Text(""Row 1, Col 3"").Center().Row(1).Column(2),
                    new TextBlock().Text(""Row 1, Col 4"").Center().Row(1).Column(3),
                    new TextBlock().Text(""(2, 1)"").Center().Row(2).Column(0),
                    new TextBlock().Text(""(2, 2)"").Center().Row(2).Column(1),
                    new TextBlock().Text(""(2, 3)"").Center().Row(2).Column(2),
                    new TextBlock().Text(""(2, 4)"").Center().Row(2).Column(3),
                }
    }.Columns(4).Rows(3).Margin(4);

    var codePanel = new ScrollViewer()
                        .BothScrollBarsVisible()
                        .Content(new TextBlock().Text(code)
                            .FontFamily(""Courier New"")
                            .Bold()
                            .Background(Brushes.AliceBlue)
                            .Foreground(Brushes.Black)
                            .Margin(4));

    root.Children.Add(new Border().Brush(Brushes.Blue, 0.5).Row(0).Column(0).Margin(4).Child(dockPanel));
    root.Children.Add(gridPanel.Row(0).Column(1).Margin(10));
    root.Children.Add(codePanel.Row(2).ColumnSpan(2).Margin(10));
";
    }
}
