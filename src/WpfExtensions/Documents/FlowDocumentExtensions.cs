using System.Windows;
using System.Windows.Documents;

namespace Tudormobile.WpfExtensions.Documents;

/// <summary>
/// Provides extension methods for the FlowDocument class to set page dimensions, text alignment, and unit conversions.
/// </summary>
public static class FlowDocumentExtensions
{
    private static LengthConverter _converter = new LengthConverter();

    /// <summary>
    /// Sets the PageHeight property of a FlowDocument element.
    /// </summary>
    /// <param name="document">The FlowDocument element to extend.</param>
    /// <param name="pageHeight">The height of the page in device-independent units (1/96th inch per unit).</param>
    /// <returns>The extended FlowDocument element.</returns>
    public static FlowDocument PageHeight(this FlowDocument document, double pageHeight) { document.PageHeight = pageHeight; return document; }

    /// <summary>
    /// Sets the PageWidth property of a FlowDocument element.
    /// </summary>
    /// <param name="document">The FlowDocument element to extend.</param>
    /// <param name="pageWidth">The width of the page in device-independent units (1/96th inch per unit).</param>
    /// <returns>The extended FlowDocument element.</returns>
    public static FlowDocument PageWidth(this FlowDocument document, double pageWidth) { document.PageWidth = pageWidth; return document; }

    /// <summary>
    /// Sets the PageHeight property of a FlowDocument element using a string representation of the height.
    /// </summary>
    /// <param name="document">The FlowDocument element to extend.</param>
    /// <param name="pageHeight">The height of the page as a string.</param>
    /// <returns>The extended FlowDocument element.</returns>
    public static FlowDocument PageHeight(this FlowDocument document, string pageHeight) { document.PageHeight = toDouble(pageHeight); return document; }

    /// <summary>
    /// Sets the PageWidth property of a FlowDocument element using a string representation of the width.
    /// </summary>
    /// <param name="document">The FlowDocument element to extend.</param>
    /// <param name="pageWidth">The width of the page as a string.</param>
    /// <returns>The extended FlowDocument element.</returns>
    public static FlowDocument PageWidth(this FlowDocument document, string pageWidth) { document.PageWidth = toDouble(pageWidth); return document; }

    /// <summary>
    /// Converts a value in inches to device-independent units (1/96th inch per unit).
    /// </summary>
    /// <param name="x">The value in inches.</param>
    /// <returns>The value in device-independent units.</returns>
    public static double Inches(this double x) => x * 96.0;

    /// <summary>
    /// Returns the value in pixels (device-independent units).
    /// </summary>
    /// <param name="x">The value in pixels.</param>
    /// <returns>The value in device-independent units.</returns>
    public static double Pixels(this double x) => x;

    /// <summary>
    /// Converts a value in centimeters to device-independent units (1/96th inch per unit).
    /// </summary>
    /// <param name="x">The value in centimeters.</param>
    /// <returns>The value in device-independent units.</returns>
    public static double Centimeters(this double x) => x * (96.0 / 2.54);

    /// <summary>
    /// Converts a value in points to device-independent units (1/96th inch per unit).
    /// </summary>
    /// <param name="x">The value in points.</param>
    /// <returns>The value in device-independent units.</returns>
    public static double Points(this double x) => x * (96.0 / 72.0);

    /// <summary>
    /// Converts a value in inches to device-independent units (1/96th inch per unit).
    /// </summary>
    /// <param name="x">The value in inches.</param>
    /// <returns>The value in device-independent units.</returns>
    public static double In(this double x) => x * 96.0;

    /// <summary>
    /// Returns the value in pixels (device-independent units).
    /// </summary>
    /// <param name="x">The value in pixels.</param>
    /// <returns>The value in device-independent units.</returns>
    public static double Px(this double x) => x;

    /// <summary>
    /// Converts a value in centimeters to device-independent units (1/96th inch per unit).
    /// </summary>
    /// <param name="x">The value in centimeters.</param>
    /// <returns>The value in device-independent units.</returns>
    public static double Cm(this double x) => x * (96.0 / 2.54);

    /// <summary>
    /// Converts a value in points to device-independent units (1/96th inch per unit).
    /// </summary>
    /// <param name="x">The value in points.</param>
    /// <returns>The value in device-independent units.</returns>
    public static double Pt(this double x) => x * (96.0 / 72.0);

    /// <summary>
    /// Sets the TextAlignment property to Left.
    /// </summary>
    /// <param name="document">The FlowDocument element to extend.</param>
    /// <returns>The extended FlowDocument element.</returns>
    public static FlowDocument Left(this FlowDocument document) { document.TextAlignment = TextAlignment.Left; return document; }

    /// <summary>
    /// Sets the TextAlignment property of a FlowDocument element to Right.
    /// </summary>
    /// <param name="document">The FlowDocument element to extend.</param>
    /// <returns>The extended FlowDocument element.</returns>
    public static FlowDocument Right(this FlowDocument document) { document.TextAlignment = TextAlignment.Right; return document; }

    /// <summary>
    /// Sets the TextAlignment property of a FlowDocument element to Center.
    /// </summary>
    /// <param name="document">The FlowDocument element to extend.</param>
    /// <returns>The extended FlowDocument element.</returns>
    public static FlowDocument Center(this FlowDocument document) { document.TextAlignment = TextAlignment.Center; return document; }

    /// <summary>
    /// Sets the TextAlignment property of a FlowDocument element to Justify.
    /// </summary>
    /// <param name="document">The FlowDocument element to extend.</param>
    /// <returns>The extended FlowDocument element.</returns>
    public static FlowDocument Justify(this FlowDocument document) { document.TextAlignment = TextAlignment.Justify; return document; }

    /// <summary>
    /// Sets the ColumnGap property of a FlowDocument element.
    /// </summary>
    /// <param name="document">The FlowDocument to extend.</param>
    /// <param name="columnGap">Column gap column to use.</param>
    /// <returns>The extended FlowDocument element.</returns>
    public static FlowDocument ColumnGap(this FlowDocument document, double columnGap) { document.ColumnGap = columnGap; return document; }

    /// <summary>
    /// Sets the ColumnWidth property of a FlowDocument element.
    /// </summary>
    /// <param name="document">The FlowDocument element to extend.</param>
    /// <param name="columnWidth">The width of the column in device-independent units (1/96th inch per unit).</param>
    /// <returns>The extended FlowDocument element.</returns>
    public static FlowDocument ColumnWidth(this FlowDocument document, double columnWidth) { document.ColumnWidth = columnWidth; return document; }

    private static Double toDouble(string qualifiedDouble)
        => (double)_converter.ConvertFrom(qualifiedDouble)!;

}
