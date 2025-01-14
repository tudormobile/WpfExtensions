using System.Windows.Input;

namespace WpfExtensionsGallery.ViewModels;

public class NavigationItemViewModel : ICommand
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public string? Symbol { get; set; }

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter) => true;

    public void Execute(object? parameter)
    {
        var model = parameter as MainWindowViewModel;
        if (model != null)
        {
            model.SelectedNavigationItem = this;
        }
    }
    protected virtual void OnCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
}
