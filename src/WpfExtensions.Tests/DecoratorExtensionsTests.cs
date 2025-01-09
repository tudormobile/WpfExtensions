using System.Windows.Controls;
using System.Windows.Shapes;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class DecoratorExtensionsTests
{
    [TestMethod]
    public void ChildTest()
    {
        var expected = new Rectangle();
        var target = new Border();
        Assert.AreSame(target, target.Child(expected));
        var actual = target.Child;
        Assert.AreEqual(expected, actual);
    }
}