using System.Windows;
using Tudormobile.WpfExtensions;

namespace WpfExtensionsGallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            root.Children.Add(UI.Entry("Enter value in this box"));
        }
    }
}