using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace VirtualDashboard.Dashboard_Components
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Date : Page
    {
        public Date()
        {
            this.InitializeComponent();
            setupDateDispatcherTime();
        }

        private void setupDateDispatcherTime()
        {
            dayText.Text = DateTime.Now.Date.ToString("dddd");
            dateText.Text = DateTime.Now.Date.ToString("MM/dd/yy");

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 1, 0);
            timer.Tick += new EventHandler<object>(date_Tick);
            timer.Start();
        }

        private void date_Tick(object sender, object e)
        {
            dayText.Text = DateTime.Now.Date.ToString("dddd");
            dateText.Text = DateTime.Now.Date.ToString("MM/dd/yy");
        }
    }
}
