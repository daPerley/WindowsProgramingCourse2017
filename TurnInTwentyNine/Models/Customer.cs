namespace TurnInTwentyNine.Models
{
    public class Customer : BindableBase
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                NotifyPropertyChanged("Id");
            }
        }

        private bool _isCompany;
        public bool IsCompany
        {
            get { return _isCompany; }
            set
            {
                _isCompany = value;
                NotifyPropertyChanged("IsCompany");
            }
        }

        // Only for companies
        private string _company;
        public string Company
        {
            get { return _company; }
            set
            {
                _company = value;
                NotifyPropertyChanged("Company");
            }
        }

        private string _contactPerson;
        public string ContactPerson
        {
            get { return _contactPerson; }
            set
            {
                _contactPerson = value;
                NotifyPropertyChanged("ContactPerson");
            }
        }

        private string _birthday;
        public string Birthday
        {
            get { return _birthday; }
            set
            {
                _birthday = value;
                NotifyPropertyChanged("Birthday");
            }
        }

        private string _street;
        public string Street
        {
            get { return _street; }
            set
            {
                _street = value;
                NotifyPropertyChanged("Street");
            }
        }

        private string _postalCode;
        public string PostalCode
        {
            get { return _postalCode; }
            set
            {
                _postalCode = value;
                NotifyPropertyChanged("PostalCode");
            }
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
                NotifyPropertyChanged("City");
            }
        }

        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                NotifyPropertyChanged("Phone");
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                NotifyPropertyChanged("Email");
            }
        }


        private bool _newsLetter;
        public bool NewsLetter
        {
            get { return _newsLetter; }
            set
            {
                _newsLetter = value;
                NotifyPropertyChanged("NewsLetter");
            }
        }

        private string _notes;
        public string Notes
        {
            get { return _notes; }
            set
            {
                _notes = value;
                NotifyPropertyChanged("Notes");
            }
        }
    }
}
