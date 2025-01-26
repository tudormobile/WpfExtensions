using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace Tudormobile.WpfExtensions.Documents;

/// <summary>
/// Block extension methods.
/// </summary>
public static class BlockExtensions
{
    /// <summary>
    /// Sets the Padding property of a Block element.
    /// </summary>
    /// <typeparam name="T">Type of Block element.</typeparam>
    /// <param name="block">The Block element to extend.</param>
    /// <param name="padding">Padding value to use.</param>
    /// <returns>The extended Block element.</returns>
    public static T Padding<T>(this T block, Thickness padding) where T : Block { block.Padding = padding; return block; }

    /// <summary>
    /// Sets the Padding property of a Block element.
    /// </summary>
    /// <typeparam name="T">Type of Block element.</typeparam>
    /// <param name="block">The Block element to extend.</param>
    /// <param name="uniformPadding">Uniform padding for all sides.</param>
    /// <returns>The extended Block element.</returns>
    public static T Padding<T>(this T block, double uniformPadding) where T : Block => block.Padding(new Thickness(uniformPadding));

    /// <summary>
    /// Sets the Padding property of a Block element.
    /// </summary>
    /// <typeparam name="T">Type of Block element.</typeparam>
    /// <param name="block">The Block element to extend.</param>
    /// <param name="horizontalPadding">Padding value to use for Left/Right sides.</param>
    /// <param name="veritcalPadding">Padding value to use for Top/Bottom sides.</param>
    /// <returns>The extended Block element.</returns>
    public static T Padding<T>(this T block, double? horizontalPadding = null, double? veritcalPadding = null) where T : Block
    {
        var padding = block.Padding;
        if (horizontalPadding != null)
        {
            padding.Left = (double)horizontalPadding;
            padding.Right = (double)horizontalPadding;
        }
        if (veritcalPadding != null)
        {
            padding.Top = (double)veritcalPadding;
            padding.Bottom = (double)veritcalPadding;
        }
        return block.Padding(padding);
    }

    /// <summary>
    /// Sets the Padding property of a Block element with individual values for each side.
    /// </summary>
    /// <typeparam name="T">Type of Block element.</typeparam>
    /// <param name="block">The Block element to extend.</param>
    /// <param name="left">Padding value to use for the left side.</param>
    /// <param name="top">Padding value to use for the top side.</param>
    /// <param name="right">Padding value to use for the right side.</param>
    /// <param name="bottom">Padding value to use for the bottom side.</param>
    /// <returns>The extended Block element.</returns>
    public static T Padding<T>(this T block, double? left = null, double? top = null, double? right = null, double? bottom = null) where T : Block
    {
        var t = block.Padding;
        t.Left = left == null ? t.Left : (double)left;
        t.Top = top == null ? t.Top : (double)top;
        t.Right = right == null ? t.Right : (double)right;
        t.Bottom = bottom == null ? t.Bottom : (double)bottom;
        return block.Padding(t);
    }

    /// <summary>
    /// Sets the Margin property of a Block element.
    /// </summary>
    /// <typeparam name="T">Type of Block element.</typeparam>
    /// <param name="block">The Block element to extend.</param>
    /// <param name="margin">Margin value to use.</param>
    /// <returns>The extended Block element.</returns>
    public static T Margin<T>(this T block, Thickness margin) where T : Block { block.Margin = margin; return block; }

    /// <summary>
    /// Sets the Margin property of a Block element with a uniform margin for all sides.
    /// </summary>
    /// <typeparam name="T">Type of Block element.</typeparam>
    /// <param name="block">The Block element to extend.</param>
    /// <param name="uniformMargin">Uniform margin for all sides.</param>
    /// <returns>The extended Block element.</returns>
    public static T Margin<T>(this T block, double uniformMargin) where T : Block => block.Margin(new Thickness(uniformMargin));

    /// <summary>
    /// Sets the Margin property of a Block element with optional horizontal and vertical margins.
    /// </summary>
    /// <typeparam name="T">Type of Block element.</typeparam>
    /// <param name="block">The Block element to extend.</param>
    /// <param name="horizontalMargin">Optional margin value to use for Left/Right sides.</param>
    /// <param name="veritcalMargin">Optional margin value to use for Top/Bottom sides.</param>
    /// <returns>The extended Block element.</returns>
    public static T Margin<T>(this T block, double? horizontalMargin = null, double? veritcalMargin = null) where T : Block
    {
        var padding = block.Margin;
        if (horizontalMargin != null)
        {
            padding.Left = (double)horizontalMargin;
            padding.Right = (double)horizontalMargin;
        }
        if (veritcalMargin != null)
        {
            padding.Top = (double)veritcalMargin;
            padding.Bottom = (double)veritcalMargin;
        }
        return block.Margin(padding);
    }

    /// <summary>
    /// Sets the Margin property of a Block element with individual values for each side.
    /// </summary>
    /// <typeparam name="T">Type of Block element.</typeparam>
    /// <param name="block">The Block element to extend.</param>
    /// <param name="left">Optional margin value to use for the left side.</param>
    /// <param name="top">Margin value to use for the top side.</param>
    /// <param name="right">Margin value to use for the right side.</param>
    /// <param name="bottom">Margin value to use for the bottom side.</param>
    /// <returns>The extended Block element.</returns>
    public static T Margin<T>(this T block, double? left = null, double? top = null, double? right = null, double? bottom = null) where T : Block
    {
        var t = block.Margin;
        t.Left = left == null ? t.Left : (double)left;
        t.Top = top == null ? t.Top : (double)top;
        t.Right = right == null ? t.Right : (double)right;
        t.Bottom = bottom == null ? t.Bottom : (double)bottom;
        return block.Margin(t);
    }

    /// <summary>
    /// Sets the BorderBrush and BorderThickness properties of a Block element.
    /// </summary>
    /// <typeparam name="T">Type of Block element.</typeparam>
    /// <param name="block">The Block element to extend.</param>
    /// <param name="brush">Brush to use for the border.</param>
    /// <param name="thickness">Thickness of the border.</param>
    /// <returns>The extended Block element.</returns>
    public static T Border<T>(this T block, Brush brush, double thickness = 0.5) where T : Block
    {
        block.BorderBrush = brush;
        block.BorderThickness = new Thickness(thickness);
        return block;
    }

    /// <summary>
    /// Sets the TextAlignment property of a Block element to Left.
    /// </summary>
    /// <typeparam name="T">Type of Block element.</typeparam>
    /// <param name="block">The Block element to extend.</param>
    /// <returns>The extended Block element.</returns>
    public static T Left<T>(this T block) where T : Block { block.TextAlignment = TextAlignment.Left; return block; }

    /// <summary>
    /// Sets the TextAlignment property of a Block element to Right.
    /// </summary>
    /// <typeparam name="T">Type of Block element.</typeparam>
    /// <param name="block">The Block element to extend.</param>
    /// <returns>The extended Block element.</returns>
    public static T Right<T>(this T block) where T : Block { block.TextAlignment = TextAlignment.Right; return block; }

    /// <summary>
    /// Sets the TextAlignment property of a Block element to Center.
    /// </summary>
    /// <typeparam name="T">Type of Block element.</typeparam>
    /// <param name="block">The Block element to extend.</param>
    /// <returns>The extended Block element.</returns>
    public static T Center<T>(this T block) where T : Block { block.TextAlignment = TextAlignment.Center; return block; }

    /// <summary>
    /// Sets the TextAlignment property of a Block element to Justify.
    /// </summary>
    /// <typeparam name="T">Type of Block element.</typeparam>
    /// <param name="block">The Block element to extend.</param>
    /// <returns>The extended Block element.</returns>
    public static T Justify<T>(this T block) where T : Block { block.TextAlignment = TextAlignment.Justify; return block; }

    /// <summary>
    /// Sets the BreakPageBefore property of a Block element to true.
    /// </summary>
    /// <typeparam name="T">Type of Block element.</typeparam>
    /// <param name="block">The Block element to extend.</param>
    /// <returns>The extended Block element.</returns>
    public static T PageBreak<T>(this T block) where T : Block { block.BreakPageBefore = true; return block; }

    /// <summary>
    /// Sets the BreakColumnBefore property of a Block element to true.
    /// </summary>
    /// <typeparam name="T">Type of Block element.</typeparam>
    /// <param name="block">The Block element to extend.</param>
    /// <returns>The extended Block element.</returns>
    public static T ColumnBreak<T>(this T block) where T : Block { block.BreakColumnBefore = true; return block; }

}
