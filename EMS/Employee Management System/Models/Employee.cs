using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee_Management_System.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }


        public string Name { get; set; }

        public Employee(){}
    }
}