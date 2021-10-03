using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorEmpwage.Data
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }

        public string ProfileImage { get; set; }
        //[Required(ErrorMessage=""]
        // public string City { get; set; }
        [Required(ErrorMessage = "Gender is missing")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "*Department")]
        public string Department { get; set; }
        public int Salary { get; set; }

        public DateTime StartDate { get; set; }

        public string Notes { get; set; }
    }
}
