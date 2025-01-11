using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests
{
    [STATestClass]
    public class TextBoxBaseExtensionsTests
    {
        [TestMethod]
        public void AcceptsReturnTest()
        {
            var target = new TextBox();
            Assert.AreSame(target, target.AcceptsReturn());
            Assert.IsTrue(target.AcceptsReturn);
        }

        [TestMethod]
        public void AcceptsTabTest()
        {
            // Arrange
            var target = new TextBox().AcceptsTab();
            Assert.AreSame(target, target.AcceptsTab());
            Assert.IsTrue(target.AcceptsTab);
        }
    }
}