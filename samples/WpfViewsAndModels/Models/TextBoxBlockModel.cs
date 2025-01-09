using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfViewsAndModels.Models;

public partial class TextBoxBlockModel : ObservableObject
{
    [ObservableProperty]
    public partial string Password { get; set; }

    [ObservableProperty]
    public partial string Username { get; set; }

    public string PasswordPrompt => "Password:";
    public string UsernamePrompt => "Username:";
}
