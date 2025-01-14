using System.Windows.Controls;
using System.Windows.Media;
using Tudormobile.WpfExtensions;

namespace WpfExtensionsGallery.views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            var panel = Content as Panel;
            if (panel == null) return;
            panel.Children.Add(new Border().Fill(GetBrush()).Radius(10, 0, 0, 0).ZIndex(0));
        }

        public static Brush GetBrush()
        {
            var b = new LinearGradientBrush()
            {
                StartPoint = new System.Windows.Point(0, 0),
                EndPoint = new System.Windows.Point(1, 1),
                GradientStops = new GradientStopCollection()
                {
                    new GradientStop(Color.FromArgb(255, 0x51, 0x2b, 0xd5), 0),
                    new GradientStop(Color.FromArgb(255, 0xae, 0x96, 0xff), 0.25),
                    new GradientStop(Color.FromArgb(0x00, 0xae, 0x96, 0xff), .80),
                }
            };
            return b;
        }

    }
}
