using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using TurnInTwentyNine.Models;

namespace TurnInTwentyNine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Customer> customers;
        private bool isCompany;
        private bool wantNewsletter;

        public MainWindow()
        {
            InitializeComponent();

            if (spCompanyOnly != null)
                spCompanyOnly.Visibility = Visibility.Collapsed;

            //DataContext = customers;
        }

        public void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            var customer = new Customer()
            {
                IsCompany = isCompany,
                ContactPerson = txtContactPerson.Text,
                Birthday = cBirthday.SelectedDate.Value.ToString("dd/MM/yyyy"),
                Street = txtStreet.Text,
                PostalCode = txtPostalCode.Text,
                City = txtCity.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                NewsLetter = wantNewsletter,
                Notes = txtNotes.Text
            };

            if (isCompany)
                customer.Company = txtCompany.Text;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = sender as RadioButton;

            isCompany = radioButton.Content.ToString() != "Privat" ? true : false;

            if (!isCompany && spCompanyOnly != null)
                spCompanyOnly.Visibility = Visibility.Collapsed;

            if (isCompany && spCompanyOnly != null)
                spCompanyOnly.Visibility = Visibility.Visible;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            wantNewsletter = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            wantNewsletter = false;
        }
    }
}
