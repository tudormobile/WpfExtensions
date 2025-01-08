using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Tudormobile.WpfExtensions;
using static Tudormobile.WpfExtensions.UI;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow = new Window()
            {
                Content = new Grid()
                {
                    Children =
                    {
                        new TextBlock().Text("Hello, World!")
                        .Background(Brushes.Yellow)
                        .Size(100, 200)
                        .HorizontalAlignment(HorizontalAlignment.Center)
                        .Bold().Center().Italic()
                    }
                },
                Width = 400,
                Height = 400
            };
            MainWindow.Show();

            var model = new AppModel();
            var loginWindow = new Window()
            {
                Title = "Login",
                SizeToContent = SizeToContent.WidthAndHeight,
                Content = new Grid()
                {
                    Children =
                    {
                        CenteredText("Username:").Row(0).Column(0),
                        CenteredText("Password:").Row(1).Column(0),

                        Entry().Row(0).Column(1).Margin(4).Bind(nameof(AppModel.Username)),
                        Entry().Row(1).Column(1).Margin(4).Bind(nameof(AppModel.Password)),

                        new Button()
                            .Alignment(HorizontalAlignment.Right)
                            .Content("OK").CommandBinding(nameof(AppModel.OKButtonCommand), nameof(AppModel.OKButtonParameter))
                            .Size(120, 24).Margin(4).Row(2).Column(1)
                            .OnClick((sender, args)=>{MessageBox.Show($"Login OK; user/pass={model.Username}/{model.Password}"); Window.GetWindow(sender as DependencyObject).Close(); }),
                    }
                }.Rows(3).Columns("Auto,1*").Margin(10).DataContext(model)
            };
            loginWindow.ShowDialog();
        }




    }



}

