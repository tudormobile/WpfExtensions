using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Tudormobile.WpfExtensions;
using static WpfExtensions.UI;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application, ICommand
    {
        public event EventHandler? CanExecuteChanged;

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

                        Entry().Row(0).Column(1).Margin(4).Bind(nameof(Username)).DataContext(this),
                        Entry().Row(1).Column(1).Margin(4).Bind(nameof(Password)).DataContext(this),

                        new Button()
                            .Alignment(HorizontalAlignment.Right)
                            .Content("OK").CommandBinding(nameof(OKButtonCommand), nameof(OKButtonParameter)).DataContext(this)
                            .Size(120, 24).Margin(4).Row(2).Column(1)
                            .OnClick((sender, args)=>{MessageBox.Show($"Login OK; user/pass={Username}/{Password}"); Window.GetWindow(sender as DependencyObject).Close(); }),
                    }
                }.Rows(3).Columns("Auto,1*").Margin(10)
            };
            loginWindow.ShowDialog();
        }

        public ICommand OKButtonCommand => this;

        public string OKButtonParameter => "This is the OK button parameter";

        public string Username { get; set; } = "Default username";
        public string Password { get; set; } = "Default password";


        public bool CanExecute(object? parameter)
        {
            MessageBox.Show($"CanExecute() was called with parameter = '{parameter?.ToString() ?? String.Empty}'");
            return true;
        }

        public void Execute(object? parameter)
        {
            MessageBox.Show($"Execute() was called with parameter = '{parameter?.ToString() ?? String.Empty}'");
        }
    }



}

namespace WpfExtensions
{
    public static class UI
    {
        public static TextBlock CenteredText(string? text) => new TextBlock() { Text = text }.Alignment(HorizontalAlignment.Center, VerticalAlignment.Center);
        public static TextBox Entry() => new TextBox() { VerticalContentAlignment = VerticalAlignment.Center }.Size(200, 24);

    }
}

