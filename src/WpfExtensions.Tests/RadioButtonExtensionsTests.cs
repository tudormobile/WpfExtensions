using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class RadioButtonExtensionsTests
{
    [TestMethod]
    public void GroupNameTest()
    {
        var expected = "Some name";
        var target = new RadioButton();
        Assert.AreSame(target, target.GroupName(expected));
        var actual = target.GroupName;
        Assert.AreEqual(expected, actual);
    }
}