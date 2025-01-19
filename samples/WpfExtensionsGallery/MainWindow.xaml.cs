using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using Tudormobile.WpfExtensions;
using WpfExtensionsGallery.ViewModels;

namespace WpfExtensionsGallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Border? _contentBorder;
        public MainWindow()
        {
            InitializeComponent();
            //"pack://application:,,,/WPFExtensionsGallery;component/data/navigation_items.js", UriKind.RelativeOrAbsolute)
            using var json = Application.GetResourceStream(new Uri("/data/navigation_items.js", UriKind.Relative)).Stream;
            var items = JsonSerializer.Deserialize<IEnumerable<NavigationItemViewModel>>(json, JsonSerializerOptions.Web);
            DataContext = new MainWindowViewModel()
            {
                NavigationItems = items,
                SelectedNavigationItem = items?.FirstOrDefault(),
            };
            this.Dragable();
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            setGridContent();
        }
        private void setGridContent()
        {
            root.Columns("Auto, *");

            var listBox = new ListView()
                .ItemTemplate(this.Resources["NavigationItemTemplate"])
                .NoBorder()
                .MinSize(width: 100)
                .Margin(4, 10, 4, 0)
                .Bind(Selector.SelectedItemProperty, "SelectedNavigationItem")
                .Bind(ItemsControl.ItemsSourceProperty, "NavigationItems");

            listBox.SelectionChanged += (s, e) =>
            {
                var box = (ListBox)s;
                var index = box.SelectedIndex;
                if (index >= 0 && index < UIEx.Views.Length && _contentBorder != null)
                {
                    _contentBorder.Child = UIEx.Views[box.SelectedIndex]();
                }
            };
            root.Children.Add(listBox);
            _contentBorder = new Border()
                .Brush(new SolidColorBrush(Color.FromArgb(0x80, 0x00, 0x00, 0x00)))
                .Thickness(0.5, 0.5, 0, 0)
                .Padding(1)
                .Margin(10, 10, 0, 0)
                .Radius(10, 0, 0, 0)
                .Column(1);
            root.Children.Add(_contentBorder);

            // Theme mode buttons
            var buttonPanel = new StackPanel().Horizontal().Alignment(HorizontalAlignment.Right, VerticalAlignment.Bottom).Margin(2);
#pragma warning disable WPF0001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
            buttonPanel.Children.Add(new Button().Content("Light").OnClick((s, e) => swapThemes(ThemeMode.Light)).Margin(4).Padding(4, 2));
            buttonPanel.Children.Add(new Button().Content("Dark").OnClick((s, e) => swapThemes(ThemeMode.Dark)).Margin(4).Padding(4, 2));
            buttonPanel.Children.Add(new Button().Content("Aero").OnClick((s, e) => swapThemes(ThemeMode.None)).Margin(4).Padding(4, 2));

            root.Children.Add(buttonPanel);
        }

        private void swapThemes(ThemeMode themeMode)
        {
            if (_contentBorder != null)
            {
                _contentBorder.Child = null;
                root.Children.Clear();
                root.ColumnDefinitions.Clear();
                root.RowDefinitions.Clear();
                _contentBorder = null;
            }
            Application.Current.ThemeMode = themeMode;

            setGridContent();

        }
#pragma warning restore WPF0001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
    }
    public static partial class UIEx
    {

        public static Func<FrameworkElement>[] Views =
        [
            (() => new Views.HomeView()),
            (() => new Views.MenuView()),
            (() => new Views.PanelView()),
            (() => new Views.ItemsView()),
            (() => new Views.InputView()),
            (() => new Views.TextView()),
            (() => new Views.ControlsView()),
        ];
    }
}

