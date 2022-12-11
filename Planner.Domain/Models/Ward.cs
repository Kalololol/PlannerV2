using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Domain
{
    public class Ward : Entity
    {
        public string WardName { get; set; }
        public bool Deleted { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
