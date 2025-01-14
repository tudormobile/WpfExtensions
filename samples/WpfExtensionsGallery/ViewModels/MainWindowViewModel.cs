using System.ComponentModel;

namespace WpfExtensionsGallery.ViewModels;

public class MainWindowViewModel : INotifyPropertyChanged
{
    private NavigationItemViewModel? _selectedNavigationItem;
    public NavigationItemViewModel? SelectedNavigationItem
    {
        get
        {
            return _selectedNavigationItem;
        }
        set
        {
            if (value != _selectedNavigationItem)
            {
                _selectedNavigationItem = value;
                OnPropertyChanged(nameof(SelectedNavigationItem));
            }
        }
    }
    public IEnumerable<NavigationItemViewModel>? NavigationItems { get; set; }
    public IEnumerable<NavigationItemViewModel>? NavigationItemsSkipOne => NavigationItems?.Skip(1);

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
