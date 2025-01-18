using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Tudormobile.WpfExtensions;

namespace WpfExtensionsGallery.Views
{
    /// <summary>
    /// Interaction logic for MenuView.xaml
    /// </summary>
    public partial class MenuView : UserControl
    {
        public MenuView()
        {
            InitializeComponent();
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            _ = root.Columns(2).Rows("Auto, *");

            var mainMenu = UI.MainMenu().Padding(4);

            var menuPanel = new StackPanel()
            {
                Children =
                {
                    mainMenu,
                    new Menu()
                    {

                        Width = 64,
                        Items =
                        {
                            new MenuItem()
                            {
                                Items =
                                {
                                    new MenuItem().Header("Option One").Checkable(),
                                    new MenuItem().Header("Option Two").Check(),
                                    new MenuItem().Header("Option Three").Check(),
                                    new MenuItem().Header("Option Four").Checkable(),
                                }
                            }.Header(UI.IconHeader("\xE762",""))
                        },
                    }.Margin(0,10).Alignment(HorizontalAlignment.Left),
               },
            };

            var contextMenuPanel = new StackPanel()
            {
                Children =
                {
                    new TextBlock().Text("Right-click on rectangle to show context menu").Margin(4),
                    new Rectangle().Size(200,100).Stroke(Brushes.DarkBlue, 0.5).Fill(Brushes.LightBlue).ContextMenu(new ContextMenu()
                    {
                        Items =
                        {
                            new MenuItem().Header("Option One").Checkable(),
                            new MenuItem().Header("Option Two").Check(),
                            new MenuItem().Header("Option Three").Checkable(),
                            new MenuItem().Header("Option Four").Checkable(),
                        }
                    }),
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

            root.Children.Add(menuPanel.Row(0).Column(0).Margin(4));
            root.Children.Add(contextMenuPanel.Row(0).Column(1).Margin(10));
            root.Children.Add(codePanel.Row(2).ColumnSpan(2).Margin(10));

        }

        private static readonly string code = @"
// Code ...";
    }

}
