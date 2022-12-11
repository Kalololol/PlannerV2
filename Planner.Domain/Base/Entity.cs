using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Domain
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string UserCreated { get; set; }
        public DateTime ModifyDate { get; set; }
        public string UserModifiet { get; set; }

    }
}
