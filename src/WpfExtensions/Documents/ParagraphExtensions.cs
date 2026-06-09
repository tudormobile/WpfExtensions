using System.Windows.Documents;

namespace Tudormobile.WpfExtensions.Documents;

/// <summary>
/// Provides extension methods for the <see cref="Paragraph"/> class to add text content.
/// </summary>
public static class ParagraphExtensions
{
    /// <summary>
    /// Adds a single string of text to the paragraph.
    /// </summary>
    /// <param name="paragraph">The paragraph to add text to.</param>
    /// <param name="text">The text to add.</param>
    /// <returns>The updated paragraph.</returns>
    public static Paragraph Add(this Paragraph paragraph, string text)
    {
        paragraph.Inlines.Add(new Run(text));
        return paragraph;
    }

    /// <summary>
    /// Adds a range of strings to the paragraph.
    /// </summary>
    /// <param name="paragraph">The paragraph to add text to.</param>
    /// <param name="text">The collection of strings to add.</param>
    /// <returns>The updated paragraph.</returns>
    public static Paragraph AddRange(this Paragraph paragraph, IEnumerable<string> text)
    {
        paragraph.Inlines.AddRange(text.Select(x => new Run(x)));
        return paragraph;
    }
}
