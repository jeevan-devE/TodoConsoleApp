using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoConsoleApp.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
        public string Phone { get; set; }

        // navigation property one employee one department 
        //public virtual Department Department { get; set; }
        public virtual Address Address { get; set; }
        //public virtual Team Team { get; set; } //one employee can occupies single team
        //public ICollection<Project> Projects { get; set; } //many to many relationship
    }
}
