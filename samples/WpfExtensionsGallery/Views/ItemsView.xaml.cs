using System.Windows.Controls;
using System.Windows.Media;
using Tudormobile.WpfExtensions;

namespace WpfExtensionsGallery.Views
{
    /// <summary>
    /// Interaction logic for ItemsView.xaml
    /// </summary>
    public partial class ItemsView : UserControl
    {
        public ItemsView()
        {
            InitializeComponent();
        }
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            _ = root.Columns(2).Rows("Auto, *");

            var listPanel1 = new StackPanel()
            {
                Children =
                {
                    new TextBlock().Text("ListBox with ItemTemplate resource").Center(),
                    new ListBox()
                        .Height(200)
                        .ItemTemplate(root.Resources["itemTemplate"])
                        .Bind(ItemsControl.ItemsSourceProperty, "NavigationItems"),
               },
            };

            var grid = () => new Grid()
            {
                Children =
                    {
                        new TextBlock().Bind("Symbol").Margin(4).FontFamily("Segoe Fluent Icons").FontSize(16),
                        new TextBlock().Bind("Title").Column(1).Margin(4).Bold(),
                        new TextBlock().Bind("Description").Row(1).ColumnSpan(2).Margin(4,0).ExtraSmall().Italic(),
                    },
            }.Columns("Auto, *").Rows("Auto, Auto");

            var listPanel2 = new StackPanel()
            {
                Children =
                {
                    new TextBlock().Text("ListBox with ItemTemplate in Code").Center(),
                    new ListBox()
                        .Height(200)
                        .DataTemplate(grid)
                        .Bind(ItemsControl.ItemsSourceProperty, "NavigationItems"),
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

            root.Children.Add(listPanel1.Row(0).Column(0).Margin(4));
            root.Children.Add(listPanel2.Row(0).Column(1).Margin(4));
            root.Children.Add(codePanel.Row(2).ColumnSpan(2).Margin(10));

        }

        private static readonly string code = @"
// Code ...

    _ = root.Columns(2).Rows(""Auto, *"");

    var listPanel1 = new StackPanel()
    {
        Children =
        {
            new TextBlock().Text(""ListBox with ItemTemplate resource"").Center(),
            new ListBox()
                .Height(200)
                .ItemTemplate(root.Resources[""itemTemplate""])
                .Bind(ItemsControl.ItemsSourceProperty, ""NavigationItems""),
        },
    };

    var grid = () => new Grid()
    {
        Children =
            {
                new TextBlock().Bind(""Symbol"").Margin(4).FontFamily(""Segoe Fluent Icons"").FontSize(16),
                new TextBlock().Bind(""Title"").Column(1).Margin(4).Bold(),
                new TextBlock().Bind(""Description"").Row(1).ColumnSpan(2).Margin(4,0).ExtraSmall().Italic(),
            },
    }.Columns(""Auto, *"").Rows(""Auto, Auto"");

    var listPanel2 = new StackPanel()
    {
        Children =
        {
            new TextBlock().Text(""ListBox with ItemTemplate in Code"").Center(),
            new ListBox()
                .Height(200)
                .DataTemplate(grid)
                .Bind(ItemsControl.ItemsSourceProperty, ""NavigationItems""),
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

    root.Children.Add(listPanel1.Row(0).Column(0).Margin(4));
    root.Children.Add(listPanel2.Row(0).Column(1).Margin(4));
    root.Children.Add(codePanel.Row(2).ColumnSpan(2).Margin(10));
";


    }
}
