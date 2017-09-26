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
        private bool wantNewsletter;
        private ApplicationDbContext _context;

        public MainWindow()
        {
            _context = new ApplicationDbContext();

            InitializeComponent();

            if (spCompanyOnly != null)
                spCompanyOnly.Visibility = Visibility.Collapsed;
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

            _context.Customers.Add(customer);
            _context.SaveChanges();

            txtContactPerson.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtPostalCode.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNotes.Text = string.Empty;
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
