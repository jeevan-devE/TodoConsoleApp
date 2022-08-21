using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoConsoleApp.Models
{
    public class Address
    {
        public int EmployeeId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLive2 { get; set; }
        public string City { get; set; }

        //property navigation one employee has one address
        public virtual Employee Employee { get; set; }
    }
}
