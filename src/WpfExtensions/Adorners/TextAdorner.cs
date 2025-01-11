using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Tudormobile.WpfExtensions.Adorners;

internal class TextAdorner : Adorner
{
    private string _text;
    private FormattedText? _formattedText;
    private Typeface? _typeface;
    public TextAdorner(UIElement adornedElement, string text) : base(adornedElement) { _text = text; }
    public void InvalidateAdorner(object sender, RoutedEventArgs args) => InvalidateVisual();
    protected override void OnRender(DrawingContext drawingContext)
    {
        var adornedElement = AdornedElement as TextBox;
        if (adornedElement != null)
        {
            var hpos = adornedElement.Padding.Left + 4;
            var vpos = adornedElement.Padding.Top;

            var typeface = _typeface ??= new(adornedElement.FontFamily, FontStyles.Italic, adornedElement.FontWeight, adornedElement.FontStretch);
            var formattedText = _formattedText ??= new(
                _text,
                CultureInfo.CurrentCulture,
                adornedElement.FlowDirection,
                typeface,
                adornedElement.FontSize,
                adornedElement.Foreground, null, TextFormattingMode.Display, VisualTreeHelper.GetDpi(adornedElement).PixelsPerDip)
            {
                TextAlignment = TextAlignment.Left
            };

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

