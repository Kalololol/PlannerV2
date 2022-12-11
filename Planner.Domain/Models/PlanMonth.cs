using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Domain
{
    public class PlanMonth : Entity
    {
        public DateTime DateMonth { get; set; }
        public string NameMonth { get; set; }
        public ICollection<PlanDay> PlanDays { get; set; }
        public bool Deleted { get; set; }
        public int WardId { get; set; }
    }
}
