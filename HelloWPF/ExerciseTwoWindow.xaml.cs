using System.Windows;

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for ExerciseTwoWindow.xaml
    /// </summary>
    public partial class ExerciseTwoWindow : Window
    {
        public ExerciseTwoWindow()
        {
            InitializeComponent();
        }

        private void Get_Area(object sender, RoutedEventArgs e)
        {
            var calculation = 13.4 * (40 / 2) * (80 / 2);
            MessageBox.Show("The area of the ellipse is: {0}", calculation.ToString());
        }
    }
}
