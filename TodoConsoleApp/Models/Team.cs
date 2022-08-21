using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoConsoleApp.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int TeamSize { get; set; }
        //navigation property one team may have many teams
        //public ICollection<Employee> Employees { get; set; }
    }
}
