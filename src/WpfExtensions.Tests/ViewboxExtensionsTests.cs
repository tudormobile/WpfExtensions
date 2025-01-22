using System.Windows.Controls;
using System.Windows.Media;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests
{
    [STATestClass]
    public class ViewboxExtensionsTests
    {
        [TestMethod]
        public void UniformTest()
        {
            var expected = Stretch.Uniform;
            var direction = StretchDirection.UpOnly;
            var target = new Viewbox();
            Assert.AreSame(target, target.Uniform(direction));
            var actual = target.Stretch;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(direction, target.StretchDirection);
        }

        [TestMethod]
        public void UniformToFillTest()
        {
            var expected = Stretch.UniformToFill;
            var direction = StretchDirection.UpOnly;
            var target = new Viewbox();
            Assert.AreSame(target, target.UniformToFill(direction));
            var actual = target.Stretch;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(direction, target.StretchDirection);
        }

        [TestMethod]
        public void FillTest()
        {
            var expected = Stretch.Fill;
            var direction = StretchDirection.UpOnly;
            var target = new Viewbox();
            Assert.AreSame(target, target.Fill(direction));
            var actual = target.Stretch;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(direction, target.StretchDirection);
        }

        [TestMethod]
        public void NoStretchTest()
        {
            var expected = Stretch.None;
            var target = new Viewbox();
            Assert.AreSame(target, target.NoStretch());
            var actual = target.Stretch;
            Assert.AreEqual(expected, actual);
        }
    }
}