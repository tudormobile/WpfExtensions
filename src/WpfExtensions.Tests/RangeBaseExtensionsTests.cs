using System.Windows;
using System.Windows.Controls;
using Tudormobile.WpfExtensions;

namespace WpfExtensions.Tests;

[STATestClass]
public class RangeBaseExtensionsTests
{
    [TestMethod]
    public void RangeTest()
    {
        var min = 123.456;
        var max = 456.789;
        var small = 1.234;
        var large = 2.345;
        var bar = new ProgressBar();
        Assert.AreSame(bar, bar.Range(min, max, small, large));
        Assert.AreEqual(min, bar.Minimum);
        Assert.AreEqual(max, bar.Maximum);
        Assert.AreEqual(small, bar.SmallChange);
        Assert.AreEqual(large, bar.LargeChange);
    }

    [TestMethod]
    public void RangeTest1()
    {
        var min = 1.23456;
        var bar = new ProgressBar();
        Assert.AreSame(bar, bar.Range(minimum: min));
        Assert.AreEqual(min, bar.Minimum);
        Assert.AreEqual(100, bar.Maximum);
        Assert.AreEqual(0.1, bar.SmallChange);
        Assert.AreEqual(1, bar.LargeChange);
    }

    [TestMethod]
    public void RangeTest2()
    {
        var max = 456.789;
        var bar = new ProgressBar();
        Assert.AreSame(bar, bar.Range(maximum: max));
        Assert.AreEqual(0, bar.Minimum);
        Assert.AreEqual(max, bar.Maximum);
        Assert.AreEqual(0.1, bar.SmallChange);
        Assert.AreEqual(1, bar.LargeChange);
    }

    [TestMethod]
    public void RangeTest3()
    {
        var small = 1.234;
        var bar = new ProgressBar();
        Assert.AreSame(bar, bar.Range(smallChange: small));
        Assert.AreEqual(0, bar.Minimum);
        Assert.AreEqual(100, bar.Maximum);
        Assert.AreEqual(small, bar.SmallChange);
        Assert.AreEqual(1, bar.LargeChange);
    }

    [TestMethod]
    public void RangeTest4()
    {
        var large = 2.345;
        var bar = new ProgressBar();
        Assert.AreSame(bar, bar.Range(largeChange: large));
        Assert.AreEqual(0, bar.Minimum);
        Assert.AreEqual(100, bar.Maximum);
        Assert.AreEqual(0.1, bar.SmallChange);
        Assert.AreEqual(large, bar.LargeChange);
    }

    [TestMethod]
    public void OnValueChangedTest()
    {
        var bar = new ProgressBar();
        Assert.AreSame(bar, bar.OnValueChanged(testHandler));
        bar.Value = bar.Value + 1;
        Assert.IsTrue(handlerCalled);
    }
    private static bool handlerCalled = false;
    private void testHandler(object sender, RoutedPropertyChangedEventArgs<double> e) { handlerCalled = true; }

    [TestMethod]
    public void OnValueChangedTest1()
    {
        var handlerCalled = false;
        var bar = new ProgressBar();
        Assert.AreSame(bar, bar.OnValueChanged((sender, args) => { handlerCalled = true; }));
        bar.Value = bar.Value + 1;
        Assert.IsTrue(handlerCalled);
    }

}