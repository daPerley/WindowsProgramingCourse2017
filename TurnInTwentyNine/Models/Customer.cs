using System.Linq;

namespace TurnInTwentyNine.Models
{
    public class Customer
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

        public static Customer FindCustomer(string search)
        {
            Customer customer = null;

            try
            {
                var _context = new ApplicationDbContext();

                customer = _context.Customers.FirstOrDefault(c => c.Phone == search || c.Email == search);
            }
            catch (System.Exception)
            {

                return customer;
            }

            return customer;
        }
    }
}
