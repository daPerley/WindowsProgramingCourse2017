using System;

namespace TurnInTwentyNine.Models
{
    class Customer
    {
        public int Id { get; set; }
        public string CustomerType { get; set; }
        // Only for companies
        public string Contact { get; set; }
        public DateTime Birthday { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool NewsLetter { get; set; }
        public string Notes { get; set; }
    }
}
