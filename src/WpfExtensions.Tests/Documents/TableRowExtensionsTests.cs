using System.Windows.Documents;
using Tudormobile.WpfExtensions.Documents;

namespace WpfExtensions.Tests
{
    [STATestClass]
    public class TableRowExtensionsTests
    {
        [TestMethod]
        public void AddCellsTest()
        {
            var expected = "string content";
            var target = new TableRow();
            Assert.AreSame(target, target.AddCells([expected]));
            var actual = ((target.Cells.First().Blocks.FirstBlock as Paragraph).Inlines.FirstInline as Run).Text;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddCellsTest1()
        {
            var p = new Paragraph();
            var l = new List();
            var target = new TableRow();
            Assert.AreSame(target, target.AddCells([p, l]));
            Assert.AreEqual<Block>(p, target.Cells[0].Blocks.FirstBlock);
            Assert.AreEqual<Block>(l, target.Cells[1].Blocks.FirstBlock);
        }

        [TestMethod]
        public void AddCellsTest2()
        {
            var expected = new TableCell();
            var target = new TableRow();
            Assert.AreSame(target, target.AddCells([expected]));
            var actual = target.Cells[0];
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddCellsTest3()
        {
            var expected = new Run();
            var target = new TableRow();
            Assert.AreSame(target, target.AddCells([expected]));
            var actual = target.Cells.Count;
            Assert.AreEqual(1, actual);
        }
    }
}