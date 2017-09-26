using ExerciseOneTwentySix.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace ExerciseOneTwentySix
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> persons;

        public MainWindow()
        {
            InitializeComponent();
            persons = new ObservableCollection<Person>()
            {
                new Person() { Name = "Gert", Email="gert@gert.com" }
            };
            DataContext = persons;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            persons.Add(new Person() { Name = txtName.Text, Email = txtEmail.Text });
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            var selectedPerson = lstPersons.SelectedItem as Person;

            var person = persons.FirstOrDefault(p => p.Name == selectedPerson.Name);

            persons.Remove(person);
        }
    }
}
