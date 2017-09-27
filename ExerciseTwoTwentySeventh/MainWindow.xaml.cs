using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace ExerciseTwoTwentySeventh
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private TimeSpan increment;

        public MainWindow()
        {
            InitializeComponent();

            TimerLabel.DataContext = "00:00:00";

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 1);
            timer.Tick += Thicker;
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(e.Uri.AbsoluteUri);
        }

        private void Thicker(object sender, EventArgs e)
        {
            increment = increment.Add(timer.Interval);
            TimerLabel.DataContext = increment;
        }

        private void BtnStart_Timer(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void BtnStop_Timer(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void BtnReset_Timer(object sender, RoutedEventArgs e)
        {
            increment = new TimeSpan();
            TimerLabel.DataContext = increment;
        }
    }
}
