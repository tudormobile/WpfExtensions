using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class ComboBoxExtensionsTests
{
    [TestMethod]
    public void EditableTest()
    {
        var target = new ComboBox();
        Assert.AreSame(target, target.Editable());
        Assert.AreEqual(true, target.IsEditable);
    }

    [TestMethod]
    public void ReadOnlyTest()
    {
        var target = new ComboBox();
        Assert.AreSame(target, target.ReadOnly());
        Assert.AreEqual(true, target.IsReadOnly);
    }

    [TestMethod]
    public void ReadOnlyTest1()
    {
        var target = new ComboBox();
        Assert.AreSame(target, target.ReadOnly(["one", "two"]));
        Assert.AreEqual(true, target.IsReadOnly);
        Assert.AreEqual(2, target.Items.Count);
    }

    [TestMethod]
    public void ReadOnlyTest2()
    {
        var target = new ComboBox();
        Assert.AreSame(target, target.ReadOnly<DayOfWeek>());
        Assert.AreEqual(true, target.IsReadOnly);
        Assert.AreEqual(7, target.Items.Count);
    }

    [TestMethod]
    public void TextTest()
    {
        var expected = "Hello";
        var target = new ComboBox();
        Assert.AreSame(target, target.Text(expected));
        var actual = target.Text;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SelectTest()
    {
        var expected = 1;
        var target = new ComboBox();
        Assert.AreSame(target, target.ReadOnly(["one", "two"]).Select(expected));
        var actual = target.SelectedIndex;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SelectTest1()
    {
        var expected = DayOfWeek.Wednesday;
        var target = new ComboBox();
        Assert.AreSame(target, target.ReadOnly<DayOfWeek>().Select(expected));
        var actual = target.SelectedIndex;
        Assert.AreEqual((int)expected, actual);
    }
}