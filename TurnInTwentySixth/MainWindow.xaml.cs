using Microsoft.Win32;
using System;
using System.Windows;

namespace TurnInTwentySixth
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

        public void Load_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Media files (*.mp4;)|*.mp4;";

            if (openFileDialog.ShowDialog() == true)
                video.Source = new Uri(openFileDialog.FileName);
        }

        public void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            if (video.Source != null)
                video.Play();
        }

        public void BtnPause_Click(object sender, RoutedEventArgs e)
        {
            if (video.Source != null)
                video.Pause();
        }

        public void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            if (video.Source != null)
                video.Stop();
        }
    }
}
