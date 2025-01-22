using System.Windows.Controls;

namespace Tudormobile.WpfExtensions;

/// <summary>
/// Provides extension methods for the RadioButton control.
/// </summary>
public static class RadioButtonExtensions
{
    /// <summary>
    /// Sets the GroupName property of the RadioButton.
    /// </summary>
    /// <param name="radioButton">The RadioButton to set the GroupName for.</param>
    /// <param name="groupName">The name of the group to assign to the RadioButton.</param>
    /// <returns>The RadioButton with the updated GroupName.</returns>
    public static RadioButton GroupName(this RadioButton radioButton, string groupName) { radioButton.GroupName = groupName; return radioButton; }
}
