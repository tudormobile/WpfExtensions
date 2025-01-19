using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests
{
    [STATestClass]
    public class FrameworkTemplateExtensionsTests
    {
        [TestMethod, ExcludeFromCodeCoverage]
        public void VisualTreeTest()
        {
            var expected = () => new Button();
            var target = new ControlTemplate(typeof(Button));
            Assert.AreSame(target, target.VisualTree(expected));
            Assert.IsInstanceOfType<FrameworkElementFactory>(target.VisualTree); // How else to verify?
        }
    }
}