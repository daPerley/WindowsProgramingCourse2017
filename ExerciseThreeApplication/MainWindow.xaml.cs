using System.Windows;

namespace ExerciseThreeApplication
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

        private void Spela1_Click(object sender, RoutedEventArgs e)
        {
            musik1.Play();
        }

        private void Spela2_Click(object sender, RoutedEventArgs e)
        {
            musik2.Play();
        }

        private void Spela3_Click(object sender, RoutedEventArgs e)
        {
            musik3.Play();
        }

        private void Spela4_Click(object sender, RoutedEventArgs e)
        {
            musik4.Play();
        }

        private void Spela5_Click(object sender, RoutedEventArgs e)
        {
            musik5.Play();
        }
    }
}
