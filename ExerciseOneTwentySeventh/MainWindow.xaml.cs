using ExerciseOneTwentySeventh.Models;
using System.Windows;

namespace ExerciseOneTwentySeventh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = Product.GetProducts();
        }
    }
}
