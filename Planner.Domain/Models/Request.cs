using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Domain
{
    public class Request : Entity
    {
        public DateTime DayIndisposition { get; set; }
        public Shift Change { get; set; }
        public TypeRequest TypeRequest { get; set; }
        public int EmployeeId { get; set; }
        public bool Deleted { get; set; }
    }
}
