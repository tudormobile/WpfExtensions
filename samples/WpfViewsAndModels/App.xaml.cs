using System.Windows;
using WpfViewsAndModels.Views;

namespace WpfViewsAndModels
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow = MainView.CreateWindow();
            MainWindow.Show();
        }
    }

    public static class NewExtensions
    {
        public static void ShowDialog<T>(this Application app) //where T : ICreateWindow
        {
            var t = typeof(T);
            var m = t.GetMethods();
            var mi = t.GetMethod("CreateWindow");
            if (mi != null)
            {
                var d = mi?.Invoke(null, null);
                _ = ((d as Window)?.ShowDialog());
            }
            else
            {
                mi = t.GetMethod("CreateView", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
                var d = mi?.Invoke(null, null);
                var v = d as UIElement;
                if (v != null)
                {
                    var w = new Window()
                    {
                        Content = v,
                        SizeToContent = SizeToContent.WidthAndHeight,
                    };
                    _ = w.ShowDialog();
                }
            }
        }
    }

    public interface ICreateWindow : ICreateView
    {
        static abstract Window CreateWindow();
    }

    public interface ICreateView
    {
        static abstract UIElement CreateView();
    }
}
