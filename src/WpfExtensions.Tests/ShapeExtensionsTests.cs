using System.Windows.Media;
using System.Windows.Shapes;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests
{
    [STATestClass]
    public class ShapeExtensionsTests
    {
        [TestMethod]
        public void StrokeTest()
        {
            var expected = Brushes.Red;
            var target = new Rectangle();
            Assert.AreSame(target, target.Stroke(expected));
            Assert.AreEqual(expected, target.Stroke);
            Assert.AreEqual(1.0, target.StrokeThickness, "Must set thickness to 1.0 when it is omitted.");
        }

        [TestMethod]
        public void StrokeTest1()
        {
            var expected = 1.234;
            var target = new Rectangle();
            Assert.AreSame(target, target.Stroke(Brushes.Turquoise, expected));
            var actual = target.StrokeThickness;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void FillTest()
        {
            var expected = Brushes.Red;
            var target = new Rectangle();
            Assert.AreSame(target, target.Fill(expected));
            var actual = target.Fill;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FillTest1()
        {
            var expected = Stretch.Fill;
            var target = new Rectangle();
            Assert.AreSame(target, target.Fill());
            var actual = target.Stretch;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void UniformTest()
        {
            var expected = Stretch.Uniform;
            var target = new Rectangle();
            Assert.AreSame(target, target.Uniform());
            var actual = target.Stretch;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void UniformToFillTest()
        {
            var expected = Stretch.UniformToFill;
            var target = new Rectangle();
            Assert.AreSame(target, target.UniformToFill());
            var actual = target.Stretch;
            Assert.AreEqual(expected, actual);
        }
    }
}