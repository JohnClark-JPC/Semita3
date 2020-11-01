using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semita3.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Role { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
