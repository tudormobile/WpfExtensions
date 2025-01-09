using CommunityToolkit.Mvvm.Input;
using WpfViewsAndModels.Views;

namespace WpfViewsAndModels.Models
{
    public partial class MainModel
    {
        [RelayCommand]
        public void GridPanel() => App.Current.ShowDialog<GridPanelView>();

        [RelayCommand]
        public void DockPanel() => App.Current.ShowDialog<DockPanelView>();

        [RelayCommand]
        public void BorderHeader() => App.Current.ShowDialog<BorderHeaderView>();

        [RelayCommand]
        public void TextBoxBlock() => App.Current.ShowDialog<TextBoxBlockView>();

        [RelayCommand]
        public void Misc() => App.Current.ShowDialog<MiscView>();

    }
}
