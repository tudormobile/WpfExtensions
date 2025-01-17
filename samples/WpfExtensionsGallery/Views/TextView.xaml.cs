using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Tudormobile.WpfExtensions;

namespace WpfExtensionsGallery.Views
{
    /// <summary>
    /// Interaction logic for TextView.xaml
    /// </summary>
    public partial class TextView : UserControl
    {
        public TextView()
        {
            InitializeComponent();
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            _ = root.Columns(2).Rows("Auto, Auto, *");
            var sizePanel = new StackPanel()
            {
                Children =
                {
                    new TextBlock().Text("Sample Text Sizes").ExtraSmall().Center(),
                    new TextBlock().Text("Sample Text Sizes").Small().Center(),
                    new Separator().Size(50,0.5).Margin(10,2).Alignment(HorizontalAlignment.Center),
                    new TextBlock().Text("Sample Text Sizes").Center(),
                    new Separator().Size(50,0.50).Margin(10,2).Alignment(HorizontalAlignment.Center),
                    new TextBlock().Text("Sample Text Sizes").Large().Center(),
                    new TextBlock().Text("Sample Text Sizes").ExtraLarge().Center(),
                },
            };

            var fontStylePanel = new StackPanel()
            {
                Children =
                {
                    new TextBlock().Text("Sample Font Styles - Normal").Center(),
                    new TextBlock().Text("Sample Font Styles - Bold").Bold().Center(),
                    new TextBlock().Text("Sample Font Styles - Italic").Italic().Center(),
                    new TextBlock().Text("Sample Text Alignment - Left").TextAlignment(TextAlignment.Left),
                    new TextBlock().Text("Sample Text Alignment - Center").Center(),
                    new TextBlock().Text("Sample Text Alignment - Right").TextAlignment(TextAlignment.Right),
                }
            };

            var wrapTrimPanel = new StackPanel()
            {
                Children =
                {
                    new TextBlock().Text("The quick brown fox jumps over the lazy dog. Do not pass go, and do not collect $200."),
                    new TextBlock().Text("The quick brown fox jumps over the lazy dog. Do not pass go, and do not collect $200.")
                        .TextTrimming(TextTrimming.CharacterEllipsis),
                    new TextBlock().Text("The quick brown fox jumps over the lazy dog. Do not pass go, and do not collect $200.")
                        .TextWrapping(TextWrapping.Wrap),
                }
            };

            var textBoxPanel = new StackPanel()
            {
                Children =
                {
                    new TextBox().Margin(4).Padding(2, 4).Alignment(vertical: VerticalAlignment.Center),
                    UI.Entry("Text box prompt").Margin(4),
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

            root.Children.Add(sizePanel.Row(0).Column(0).Margin(10));
            root.Children.Add(fontStylePanel.Row(0).Column(1).Margin(10));
            root.Children.Add(wrapTrimPanel.Row(1).Column(0).Margin(10));
            root.Children.Add(textBoxPanel.Row(1).Column(1).Margin(10));
            root.Children.Add(codePanel.Row(2).ColumnSpan(2).Margin(10));
        }

        private static readonly string code = @"
// Code ...
    _ = root.Columns(2).Rows(""Auto, Auto, *"");
    var sizePanel = new StackPanel()
    {
        Children =
        {
            new TextBlock().Text(""Sample Text Sizes"").ExtraSmall().Center(),
            new TextBlock().Text(""Sample Text Sizes"").Small().Center(),
            new Separator().Size(50,0.5).Margin(10,2).Alignment(HorizontalAlignment.Center),
            new TextBlock().Text(""Sample Text Sizes"").Center(),
            new Separator().Size(50,0.50).Margin(10,2).Alignment(HorizontalAlignment.Center),
            new TextBlock().Text(""Sample Text Sizes"").Large().Center(),
            new TextBlock().Text(""Sample Text Sizes"").ExtraLarge().Center(),
        },
    };

    var fontStylePanel = new StackPanel()
    {
        Children =
        {
            new TextBlock().Text(""Sample Font Styles - Normal"").Center(),
            new TextBlock().Text(""Sample Font Styles - Bold"").Bold().Center(),
            new TextBlock().Text(""Sample Font Styles - Italic"").Italic().Center(),
            new TextBlock().Text(""Sample Text Alignment - Left"").TextAlignment(TextAlignment.Left),
            new TextBlock().Text(""Sample Text Alignment - Center"").Center(),
            new TextBlock().Text(""Sample Text Alignment - Right"").TextAlignment(TextAlignment.Right),
        }
    };

    var wrapTrimPanel = new StackPanel()
    {
        Children =
        {
            new TextBlock().Text(""The quick brown fox jumps over the lazy dog. Do not pass go, and do not collect $200.""),
            new TextBlock().Text(""The quick brown fox jumps over the lazy dog. Do not pass go, and do not collect $200."")
                .TextTrimming(TextTrimming.CharacterEllipsis),
            new TextBlock().Text(""The quick brown fox jumps over the lazy dog. Do not pass go, and do not collect $200."")
                .TextWrapping(TextWrapping.Wrap),
        }
    };

    var textBoxPanel = new StackPanel()
    {
        Children =
        {
            new TextBox().Margin(4).Padding(2, 4).Alignment(vertical: VerticalAlignment.Center),
            UI.Entry(""Text box prompt"").Margin(4),
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

    root.Children.Add(sizePanel.Row(0).Column(0).Margin(10));
    root.Children.Add(fontStylePanel.Row(0).Column(1).Margin(10));
    root.Children.Add(wrapTrimPanel.Row(1).Column(0).Margin(10));
    root.Children.Add(textBoxPanel.Row(1).Column(1).Margin(10));
    root.Children.Add(codePanel.Row(2).ColumnSpan(2).Margin(10));
";
    }
}
