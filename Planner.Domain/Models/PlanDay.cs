using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Domain
{
    public class PlanDay : Entity
    {
        public DateTime DatePlanDay { get; set; }
        public string NameDay { get; set; }
        public Shift Change { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public bool Deleted { get; set; }
        public int WardId { get; set; }
    }
}
