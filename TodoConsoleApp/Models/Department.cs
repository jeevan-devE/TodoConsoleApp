using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoConsoleApp.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        //navigation properties one dept has many employee
       // public virtual ICollection<Employee> Employees { get; set; }
    }
}
