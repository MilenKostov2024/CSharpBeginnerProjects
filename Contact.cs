using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    class Contact
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact()
        {
            Firstname = "";
            LastName = "";
            PhoneNumber = "";
            Email = "";
        }

        public Contact (string firstname, string lastName, string phoneNumber, string email)
        {
            Firstname = firstname;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public override string ToString()
        {
            return $"Name {Firstname}{LastName}, Phone: {PhoneNumber}, Email: {Email}";
        }
    }
}
