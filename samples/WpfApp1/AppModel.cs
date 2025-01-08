using System.Windows;
using System.Windows.Input;

namespace WpfApp1
{
    public class AppModel : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public string Password { get; set; } = "Default password";
        public string Username { get; set; } = "Default username";
        public ICommand OKButtonCommand => this;
        public string OKButtonParameter => "This is the OK button parameter";

        public bool CanExecute(object? parameter)
        {
            MessageBox.Show($"CanExecute() was called with parameter = '{parameter?.ToString() ?? String.Empty}'");
            return true;
        }

        public void Execute(object? parameter)
            => MessageBox.Show($"Execute() was called with parameter = '{parameter?.ToString() ?? String.Empty}'");

        public void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
