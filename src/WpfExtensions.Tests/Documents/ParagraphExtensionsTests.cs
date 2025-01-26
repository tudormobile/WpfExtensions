using System.Windows.Documents;
using Tudormobile.WpfExtensions.Documents;

namespace WpfExtensions.Tests
{
    [TestClass]
    public class ParagraphExtensionsTests
    {
        [TestMethod]
        public void AddTest()
        {
            var expected = "this is a test";
            var target = new Paragraph();
            Assert.AreSame(target, target.Add(expected));
            Assert.AreEqual(1, target.Inlines.Count);
        }

        [TestMethod]
        public void AddRangeTest()
        {
            var expected = 2;
            var target = new Paragraph();
            Assert.AreSame(target, target.AddRange(["one", "two"]));
            Assert.AreEqual(expected, target.Inlines.Count());
        }
    }
}