using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoConsoleApp.Models
{
    public class Project
    {
        public  int Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectLanguage { get; set; }
        //vavigation property many to many relationship
        //public ICollection<Employee> Employees { get; set; }
    }
}
