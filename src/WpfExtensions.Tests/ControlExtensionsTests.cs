using System.Windows;
using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests
{
    [STATestClass]
    public class ControlExtensionsTests
    {
        [TestMethod]
        public void PaddingTest()
        {
            var target = new Control();
            var expectedPadding = new Thickness(1, 2, 3, 4);
            Assert.AreSame(target, target.Padding(expectedPadding));
            Assert.AreEqual(expectedPadding, target.Padding);
        }

        [TestMethod]
        public void PaddingTest1()
        {
            var target = new Control();
            var expectedPadding = new Thickness(5, 10, 5, 10);
            Assert.AreSame(target, target.Padding(horizontalPadding: 5, verticalPadding: 10));
            Assert.AreEqual(expectedPadding, target.Padding);
        }

        [TestMethod]
        public void PaddingTest2()
        {
            var target = new Control();
            var expectedPadding = new Thickness(10);
            Assert.AreSame(target, target.Padding(10));
            Assert.AreEqual(expectedPadding, target.Padding);
        }

        [TestMethod]
        public void PaddingTest3()
        {
            var target = new Control();
            var expectedPadding = new Thickness(20, 15, 10, 5);
            Assert.AreSame(target, target.Padding(20, 15, 10, 5));
            Assert.AreEqual(expectedPadding, target.Padding);
        }

        [TestMethod]
        public void ContentAlignmentTest()
        {
            var target = new Control();
            var expectedAlignment = HorizontalAlignment.Center;
            Assert.AreSame(target, target.ContentAlignment(horizontal: expectedAlignment));
            Assert.AreEqual(expectedAlignment, target.HorizontalContentAlignment);
        }

        [TestMethod]
        public void NoBorderTest()
        {
            var expected = 0;
            var target = new Button();
            Assert.AreSame(target, target.NoBorder());
            Assert.AreEqual(expected, target.BorderThickness.Left);
            Assert.AreEqual(expected, target.BorderThickness.Top);
            Assert.AreEqual(expected, target.BorderThickness.Right);
            Assert.AreEqual(expected, target.BorderThickness.Bottom);
        }

        [TestMethod]
        public void MinSizeTest()
        {
            var minH = 123;
            var minV = 456;
            var target = new Button();
            Assert.AreSame(target, target.MinSize(minH, minV));
            Assert.AreEqual(minH, target.MinWidth);
            Assert.AreEqual(minV, target.MinHeight);
            target.MinSize();
            Assert.AreEqual(0, target.MinWidth);
            Assert.AreEqual(0, target.MinHeight);
        }


    }
}