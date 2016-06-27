using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace VirtualDashboard
{
    /// <summary>
    /// Clock Component
    /// </summary>
    public sealed partial class Clock : Page
    {
        public Clock()
        {
            this.InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            timer.Tick += new EventHandler<object>(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, object e)
        {
            clockText.Text = DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}
