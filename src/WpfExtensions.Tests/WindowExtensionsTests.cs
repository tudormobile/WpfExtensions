using System.Windows;
using Tudormobile.WpfExtensions;
namespace WpfExtensions.Tests;

[STATestClass]
public class WindowExtensionsTests
{
    [STATestMethod]
    public void DragableTest()
    {
        var w = new Window();
        Assert.AreSame(w, w.Dragable());

        // How to validate that a handler was added to the MouseDown event?
    }
}