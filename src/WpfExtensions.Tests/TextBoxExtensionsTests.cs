using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class TextBoxExtensionsTests
{
    [TestMethod]
    public void BindTest()
    {
        var expected = "bindingPath";
        var target = new TextBox();
        Assert.AreSame(target, target.Bind(expected));
        var actual = target.GetBindingExpression(TextBox.TextProperty).ParentBinding.Path.Path;
        Assert.AreEqual(expected, actual);
    }
}