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
        //private Customer customer;
        private bool isCompany;
        private bool wantNewsletter = false;

        public MainWindow()
        {
            InitializeComponent();

            if (spCompanyOnly != null)
                spCompanyOnly.Visibility = Visibility.Collapsed;

            if (spNotFound != null)
                spNotFound.Visibility = Visibility.Collapsed;

            if (spFound != null)
                spFound.Visibility = Visibility.Collapsed;

            DataContext = new Customer()
            {
                IsCompany = false,
                Birthday = "1995-08-13",
                NewsLetter = false
            };

            DataContext = new Customer();
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

            var save = Customer.AddCustomer(customer);

            if (save)
            {
                txtContactPerson.Text = string.Empty;
                txtStreet.Text = string.Empty;
                txtCompany.Text = string.Empty;
                txtPostalCode.Text = string.Empty;
                txtCity.Text = string.Empty;
                txtPhone.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtNotes.Text = string.Empty;
            }
        }

        public void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (spNotFound != null)
                spNotFound.Visibility = Visibility.Collapsed;

            if (spFound != null)
                spFound.Visibility = Visibility.Collapsed;

            var customer = Customer.FindCustomer(txtSearch.Text);

            if (customer != null)
            {
                tbCustomerName.Text = customer.ContactPerson;
                spFound.Visibility = Visibility.Visible;
            }
            else
            {
                spNotFound.Visibility = Visibility.Visible;
            }
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
