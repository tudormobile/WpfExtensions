using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class ProgressBarExtensionsTests
{
    [TestMethod]
    public void VerticalTest()
    {
        var target = new ProgressBar();
        Assert.AreSame(target, target.Vertical());
        Assert.AreEqual(Orientation.Vertical, target.Orientation);
    }

    [TestMethod]
    public void IndeterminateTest()
    {
        var target = new ProgressBar();
        Assert.AreSame(target, target.Indeterminate());
        Assert.IsTrue(target.IsIndeterminate);
    }
}