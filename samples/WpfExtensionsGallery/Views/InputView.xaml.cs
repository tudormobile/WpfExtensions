using System.Windows.Controls;
using System.Windows.Media;
using Tudormobile.WpfExtensions;

namespace WpfExtensionsGallery.Views
{
    /// <summary>
    /// Interaction logic for InputView.xaml
    /// </summary>
    public partial class InputView : UserControl
    {
        public InputView()
        {
            InitializeComponent();
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            _ = root.Columns(2).Rows("Auto, *");
            var tb = new TextBlock().Margin(4).Text("Un-checked").Italic().Small();
            var checkBoxPanel = new StackPanel()
            {
                Children =
                {
                    new CheckBox().Content("CheckBox").Margin(4),
                    new CheckBox().Content("CheckBox Initially Checked").Margin(4).IsChecked(),
                    new CheckBox().Content("CheckBox With Three States").Margin(4).IsThreeState()
                        .OnUnchecked((sender, e) => tb.Text = "Un-checked")
                        .OnChecked((sender,e)=>tb.Text = "Checked")
                        .OnIndeterminate((sender,e)=>tb.Text = "Indeterminate"),
                    tb,
               },
            };

            var tbInfo = new TextBlock().Margin(4).Italic().Small().Center();
            var buttonPanel = new StackPanel()
            {
                Children =
                {
                    new Button().Content("Basic Button").Width(180).Padding(11).Margin(4),
                    new Button().Content(UI.IconHeader("\xE70F", "Button With Symbol")).Width(180).Margin(4),
                    new Button().Content("ClickMode Press-Me").Width(180).ModePress().Padding(11).Margin(4)
                        .OnClick((s,e)=> tbInfo.Text = $"Pressed at {DateTime.Now.ToLongTimeString()}"),
                    tbInfo,
               },
            };

            var codePanel = new ScrollViewer()
                                .BothScrollBarsVisible()
                                .Content(new TextBlock().Text(code)
                                    .FontFamily("Courier New")
                                    .Bold()
                                    .Background(Brushes.AliceBlue)
                                    .Foreground(Brushes.Black)
                                    .Margin(4));

            root.Children.Add(checkBoxPanel.Row(0).Column(0).Margin(10));
            root.Children.Add(buttonPanel.Row(0).Column(1).Margin(10));
            root.Children.Add(codePanel.Row(2).ColumnSpan(2).Margin(10));

        }

        private static readonly string code = @"
// Code ...
    _ = root.Columns(2).Rows(""Auto, *"");
    var tb = new TextBlock().Margin(4).Text(""Un-checked"").Italic().Small();
    var checkBoxPanel = new StackPanel()
    {
        Children =
        {
            new CheckBox().Content(""CheckBox"").Margin(4),
            new CheckBox().Content(""CheckBox Initially Checked"").Margin(4).IsChecked(),
            new CheckBox().Content(""CheckBox With Three States"").Margin(4).IsThreeState()
                .OnUnchecked((sender, e) => tb.Text = ""Un-checked"")
                .OnChecked((sender,e)=>tb.Text = ""Checked"")
                .OnIndeterminate((sender,e)=>tb.Text = ""Indeterminate""),
            tb,
        },
    };

    var tbInfo = new TextBlock().Margin(4).Italic().Small().Center();
    var buttonPanel = new StackPanel()
    {
        Children =
        {
            new Button().Content(""Basic Button"").Width(180).Padding(11).Margin(4),
            new Button().Content(UI.IconHeader(""\xE70F"", ""Button With Symbol"")).Width(180).Margin(4),
            new Button().Content(""ClickMode Press-Me"").Width(180).ModePress().Padding(11).Margin(4)
                .OnClick((s,e)=> tbInfo.Text = $""Pressed at {DateTime.Now.ToLongTimeString()}""),
            tbInfo,
        },
    };

    var codePanel = new ScrollViewer()
                        .BothScrollBarsVisible()
                        .Content(new TextBlock().Text(code)
                            .FontFamily(""Courier New"")
                            .Bold()
                            .Background(Brushes.AliceBlue)
                            .Foreground(Brushes.Black)
                            .Margin(4));

    root.Children.Add(checkBoxPanel.Row(0).Column(0).Margin(10));
    root.Children.Add(buttonPanel.Row(0).Column(1).Margin(10));
    root.Children.Add(codePanel.Row(2).ColumnSpan(2).Margin(10));
";
    }
}
