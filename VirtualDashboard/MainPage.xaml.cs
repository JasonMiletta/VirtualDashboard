using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace VirtualDashboard
{
    /// <summary>
    /// Main Page to host all of the Dashboard Components
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ClockFrame.Navigate(typeof(Clock));
        }
    }
}
