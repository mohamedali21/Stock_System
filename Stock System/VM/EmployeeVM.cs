using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock.VM
{
    class EmployeeVM
    {
        public int Id { get; set; }
        public string N_Id { get; set; }
        public string Name { get; set; }
        public string phone { get; set; }
        public string Address { get; set; }
        public string JobTitle { get; set; }
        public System.DateTime HireDate { get; set; }
        public string Gender { get; set; }
    }
}
