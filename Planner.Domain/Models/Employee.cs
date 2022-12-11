using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Domain
{
    public class Employee : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AddressEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string LicenseNumber { get; set; }
        public string Password { get; set; }
        public bool Deleted { get; set; }
        public int ContractId { get; set; }
    }
}
