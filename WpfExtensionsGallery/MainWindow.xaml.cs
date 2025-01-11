using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using Tudormobile.WpfExtensions;

namespace WpfExtensionsGallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            root.Children.Add(Entry("Enter value in this box"));
        }


        public static TextBox Entry(double width = double.NaN, double height = double.NaN)
            => Entry(string.Empty, width, height);

        public static TextBox Entry(string prompt, double width = double.NaN, double height = double.NaN)
        {
            var tb = new TextBox()
            {
                Padding = new Thickness(2, 4, 2, 4),
                VerticalContentAlignment = VerticalAlignment.Center,
                Width = width,
                Height = height
            };

            if (!string.IsNullOrEmpty(prompt))
            {
                tb.SizeChanged += (s, e) =>
                {
                    var layer = AdornerLayer.GetAdornerLayer(tb);
                    var adorners = layer?.GetAdorners(tb)?.Length;
                    if (layer != null && (adorners == null || adorners == 0))
                    {
                        var a = new TextAdorner(tb, prompt);
                        a.IsHitTestVisible = false;
                        layer.Add(a);
                        tb.GotKeyboardFocus += a.GotFocus;
                        tb.LostKeyboardFocus += a.LostFocus;
                        tb.TextChanged += (s, e) => a.InvalidateVisual();
                    }
                };

            }

            return tb.Margin(4).VerticalAlignment(VerticalAlignment.Center);
        }

    }

    public class TextAdorner : Adorner
    {
        private string _text;
        private UIElement _adornedElement;
        public TextAdorner(UIElement adornedElement, string text) : base(adornedElement)
        {
            _adornedElement = adornedElement;
            _text = text;
        }
        public void GotFocus(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Got focus");
            this.InvalidateVisual();

        }
        public void LostFocus(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Got focus");
            this.InvalidateVisual();
        }
        protected override void OnRender(DrawingContext drawingContext)
        {

            var adornedElement = AdornedElement as TextBox;
            Typeface typeface = new Typeface(adornedElement.FontFamily, FontStyles.Italic, adornedElement.FontWeight, adornedElement.FontStretch);

            var hpos = adornedElement.Padding.Left + 4;
            var vpos = adornedElement.Padding.Top;

            FormattedText formattedText = new FormattedText(

                _text,

                CultureInfo.CurrentCulture,

                adornedElement.FlowDirection,

                typeface,

                adornedElement.FontSize,

                adornedElement.Foreground);

            formattedText.TextAlignment = TextAlignment.Left;

            if (!adornedElement.IsKeyboardFocused || adornedElement.Text.Length == 0)
            {
                var o = adornedElement.IsKeyboardFocused ? 0.3 : 0.5;
                drawingContext.PushOpacity(o);
                drawingContext.DrawText(formattedText, new Point(hpos, vpos));
                drawingContext.Pop();
            }
        }
    }
}