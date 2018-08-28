using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_auto_tests.Models
{
    class Customer
    {
        const string CUSTOMER_ID = "94792";
        const string CUSTOMER_NAME = "AlexTest";
        const string GENDER = "male";
        const string BIRTHDATE = "2000-08-16";
        const string ADDRESS = "Earth";
        const string CITY = "NY";
        const string STATE = "NY";
        const string PIN = "410000";
        const string EMAIL = "test@valid.com";


        public string Customer_Id { get; set; }
        public string Customer_name { get; set; }
        public string Gender { get; set; }
        public string Birthdate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pin { get; set; }
        public string Email { get; set; }

        public Customer getDefaultCustomer()
        {
            Customer customer = new Customer();
            customer.Customer_Id = CUSTOMER_ID;
            customer.Customer_name = CUSTOMER_NAME;
            customer.Gender = GENDER;
            customer.Birthdate = BIRTHDATE;
            customer.Address = ADDRESS;
            customer.City = CITY;
            customer.State = STATE;
            customer.Pin = PIN;
            customer.Email = EMAIL;
            return customer;
        }
    }
}
