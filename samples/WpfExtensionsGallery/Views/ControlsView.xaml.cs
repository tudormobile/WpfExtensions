using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Tudormobile.WpfExtensions;

namespace WpfExtensionsGallery.Views
{
    /// <summary>
    /// Interaction logic for ControlsView.xaml
    /// </summary>
    public partial class ControlsView : UserControl
    {
        public ControlsView()
        {
            InitializeComponent();
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            var grid = new Grid().Columns(2).Rows("Auto, *");

            this.Content = grid;

            var leftPanel = new StackPanel()
            {
                Children =
                {
                    new ProgressBar().Size(double.NaN, 10).Margin(4).Indeterminate(),
                    new ProgressBar() {Value = 175 }.Margin(4).Range(0,200,10,2).Size(10, 100).Vertical(),
                    new Border().Padding(4).Brush(Brushes.DarkRed, 0.5).Child(new TextBlock().Text("Text in a Border")),
                    new Button().Content("Button").Margin(4).Padding(4).Width(100),
                    new CheckBox().Content("CheckBox").Margin(4),
                    new CheckBox().Content("CheckBox 3-state initially 'checked'").Margin(4).IsThreeState().IsChecked(),
                }
            };

            var rightPanel = new StackPanel()
            {
                Children =
                {
                    new TextBlock().Text("Shapes & Images").Margin(4).Center(),
                    new Rectangle().Fill(Brushes.Red).Size(40, 50).Margin(4),
                    new Ellipse().Stroke(Brushes.Red, 2.5).Size(40, 50).Margin(4),
                    new Image().Source("/images/icon64x64.png").Size(64,64).Margin(4),
                }
            };


            var codePanel = new ScrollViewer()
                    .BothScrollBarsVisible()
                    .Content(new TextBlock().Text(code)
                        .FontFamily("Courier New")
                        .Bold()
                        .Background(Brushes.AliceBlue)
                        .Foreground(Brushes.Black)
                        .Margin(4));

            grid.Children.Add(leftPanel.Row(0).Column(0).Margin(4));
            grid.Children.Add(rightPanel.Row(0).Column(1).Margin(4));
            grid.Children.Add(codePanel.Row(2).ColumnSpan(2).Margin(10));

        }

        private static readonly string code = @"
// Code ...
    var grid = new Grid().Columns(2).Rows(""Auto, *"");

    this.Content = grid;

    var leftPanel = new StackPanel()
    {
        Children =
        {
            new ProgressBar().Size(double.NaN, 10).Margin(4).Indeterminate(),
            new ProgressBar() {Value = 175 }.Margin(4).Range(0,200,10,2).Size(10, 100).Vertical(),
            new Border().Padding(4).Brush(Brushes.DarkRed, 0.5).Child(new TextBlock().Text(""Text in a Border"")),
            new Button().Content(""Button"").Margin(4).Padding(4).Width(100),
            new CheckBox().Content(""CheckBox"").Margin(4),
            new CheckBox().Content(""CheckBox 3-state initially 'checked'"").Margin(4).IsThreeState().IsChecked(),
        }
    };

    var rightPanel = new StackPanel()
    {
        Children =
        {
            new TextBlock().Text(""Shapes & Images"").Margin(4).Center(),
            new Rectangle().Fill(Brushes.Red).Size(40, 50).Margin(4),
            new Ellipse().Stroke(Brushes.Red, 2.5).Size(40, 50).Margin(4),
            new Image().Source(""/images/icon64x64.png"").Size(64,64).Margin(4),
        }
    };


    var codePanel = new ScrollViewer()
            .BothScrollBarsVisible()
            .Content(new TextBlock().Text(code)
                .FontFamily(""Courier New"")
                .Bold()
                .Background(Brushes.AliceBlue)
                .Foreground(Brushes.Black)
                .Margin(4));

    grid.Children.Add(leftPanel.Row(0).Column(0).Margin(4));
    grid.Children.Add(rightPanel.Row(0).Column(1).Margin(4));
    grid.Children.Add(codePanel.Row(2).ColumnSpan(2).Margin(10));
";
    }
}
