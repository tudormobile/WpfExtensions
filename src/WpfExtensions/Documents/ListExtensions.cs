using System.Windows;
using System.Windows.Documents;

namespace Tudormobile.WpfExtensions.Documents;

/// <summary>
/// Provides extension methods for the <see cref="List"/> class.
/// </summary>
public static class ListExtensions
{
    /// <summary>
    /// Sets the marker offset for the list.
    /// </summary>
    /// <param name="list">The list to set the marker offset for.</param>
    /// <param name="markerOffset">The marker offset value.</param>
    /// <returns>The modified list.</returns>
    public static List MarkerOffset(this List list, double markerOffset)
    {
        list.MarkerOffset = markerOffset;
        return list;
    }

    /// <summary>
    /// Sets the marker style for the list.
    /// </summary>
    /// <param name="list">The list to set the marker style for.</param>
    /// <param name="markerStyle">The marker style value.</param>
    /// <returns>The modified list.</returns>
    public static List MarkerStyle(this List list, TextMarkerStyle markerStyle)
    {
        list.MarkerStyle = markerStyle;
        return list;
    }

    /// <summary>
    /// Sets the marker style to Disc.
    /// </summary>
    /// <param name="list">The list to set the marker style for.</param>
    /// <returns>The modified list.</returns>
    public static List DiscMarker(this List list) => list.MarkerStyle(TextMarkerStyle.Disc);

    /// <summary>
    /// Sets the marker style to Circle.
    /// </summary>
    /// <param name="list">The list to set the marker style for.</param>
    /// <returns>The modified list.</returns>
    public static List CircleMarker(this List list) => list.MarkerStyle(TextMarkerStyle.Circle);

    /// <summary>
    /// Sets the marker style to Box.
    /// </summary>
    /// <param name="list">The list to set the marker style for.</param>
    /// <returns>The modified list.</returns>
    public static List BoxMarker(this List list) => list.MarkerStyle(TextMarkerStyle.Box);

    /// <summary>
    /// Sets the marker style to Square.
    /// </summary>
    /// <param name="list">The list to set the marker style for.</param>
    /// <returns>The modified list.</returns>
    public static List SquareMarker(this List list) => list.MarkerStyle(TextMarkerStyle.Square);

    /// <summary>
    /// Sets the marker style to Decimal.
    /// </summary>
    /// <param name="list">The list to set the marker style for.</param>
    /// <returns>The modified list.</returns>
    public static List DecimalMarker(this List list) => list.MarkerStyle(TextMarkerStyle.Decimal);

    /// <summary>
    /// Sets the marker style to LowerLatin.
    /// </summary>
    /// <param name="list">The list to set the marker style for.</param>
    /// <returns>The modified list.</returns>
    public static List LowerLatinMarker(this List list) => list.MarkerStyle(TextMarkerStyle.LowerLatin);

    /// <summary>
    /// Sets the marker style to LowerRoman.
    /// </summary>
    /// <param name="list">The list to set the marker style for.</param>
    /// <returns>The modified list.</returns>
    public static List LowerRomanMarker(this List list) => list.MarkerStyle(TextMarkerStyle.LowerRoman);

    /// <summary>
    /// Sets the marker style to UpperLatin.
    /// </summary>
    /// <param name="list">The list to set the marker style for.</param>
    /// <returns>The modified list.</returns>
    public static List UpperLatinMarker(this List list) => list.MarkerStyle(TextMarkerStyle.UpperLatin);

    /// <summary>
    /// Sets the marker style to UpperRoman.
    /// </summary>
    /// <param name="list">The list to set the marker style for.</param>
    /// <returns>The modified list.</returns>
    public static List UpperRomanMarker(this List list) => list.MarkerStyle(TextMarkerStyle.UpperRoman);

    /// <summary>
    /// Sets the start index for the list.
    /// </summary>
    /// <param name="list">The list to set the start index for.</param>
    /// <param name="startIndex">The start index value.</param>
    /// <returns>The modified list.</returns>
    public static List StartIndex(this List list, int startIndex)
    {
        list.StartIndex = startIndex;
        return list;
    }

    /// <summary>
    /// Adds a collection of paragraphs to the list.
    /// </summary>
    /// <param name="list">The list to add the paragraphs to.</param>
    /// <param name="paragraphs">The collection of paragraphs.</param>
    /// <returns>The modified list.</returns>
    public static List Items(this List list, IEnumerable<Paragraph> paragraphs)
    {
        list.ListItems.AddRange(paragraphs.Select(x => new ListItem(x)));
        return list;
    }

    /// <summary>
    /// Adds a collection of strings to the list as paragraphs.
    /// </summary>
    /// <param name="list">The list to add the strings to.</param>
    /// <param name="items">The collection of strings.</param>
    /// <returns>The modified list.</returns>
    public static List Items(this List list, IEnumerable<string> items)
    {
        list.Items(items.Select(x => new Paragraph(new Run(x))));
        return list;
    }
}
