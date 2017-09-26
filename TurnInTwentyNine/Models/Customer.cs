namespace TurnInTwentyNine.Models
{
    public class Customer : BindableBase
    {
        public int Id { get; set; }
        public bool IsCompany { get; set; }
        public string Company { get; set; }
        public string ContactPerson { get; set; }
        public string Birthday { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool NewsLetter { get; set; }
        public string Notes { get; set; }

        public static bool AddCustomer(Customer customer)
        {
            try
            {
                var _context = new ApplicationDbContext();

                _context.Customers.Add(customer);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }

            return true;
        }
    }
}
