using System.Windows;
using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class CalendarExtensionsTests
{
    [TestMethod]
    public void MonthTest()
    {
        var target = new Calendar() { DisplayMode = CalendarMode.Year };
        Assert.AreSame(target, target.Month());
        forceLoad(target);
        Assert.AreEqual(CalendarMode.Month, target.DisplayMode);
    }

    [TestMethod]
    public void YearTest()
    {
        var target = new Calendar();
        Assert.AreSame(target, target.Year());
        forceLoad(target);
        Assert.AreEqual(CalendarMode.Year, target.DisplayMode);
    }

    [TestMethod]
    public void DecadeTest()
    {
        var target = new Calendar();
        Assert.AreSame(target, target.Decade());
        forceLoad(target);
        Assert.AreEqual(CalendarMode.Decade, target.DisplayMode);
    }

    [TestMethod]
    public void ModeTest1()
    {
        var expected = CalendarMode.Decade;
        var target = new Calendar();
        Assert.AreSame(target, target.Mode(expected));
        forceLoad(target);
        var actual = target.DisplayMode;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ModeTest2()
    {
        var expected = CalendarMode.Year;
        var target = new Calendar();
        Assert.AreSame(target, target.Mode(expected));
        forceLoad(target);
        var actual = target.DisplayMode;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ModeTest3()
    {
        var expected = CalendarMode.Month;
        var target = new Calendar();
        Assert.AreSame(target, target.Mode(expected));
        forceLoad(target);
        var actual = target.DisplayMode;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ModeTestWithInvalidValue()
    {
        var expected = (CalendarMode)10;
        var target = new Calendar();
        Assert.AreSame(target, target.Mode(expected));
        forceLoad(target);
        var actual = target.DisplayMode;
        Assert.AreNotEqual(expected, actual, "Should NOT have set an invalid value.");
    }

    [TestMethod]
    public void DisplayDateTest()
    {
        var expected = new DateTime(1960, 1, 1);
        var target = new Calendar();
        Assert.AreSame(target, target.DisplayDate(expected));
        var actual = target.DisplayDate;
        Assert.AreEqual(expected, actual);
    }

    private void forceLoad(Calendar target)
    {
        var g = new Grid() { Children = { target } };
        g.Measure(new System.Windows.Size(100, 100));
        g.Arrange(new System.Windows.Rect(0, 0, 100, 100));
        target.RaiseEvent(new RoutedEventArgs(FrameworkElement.LoadedEvent));
    }

}