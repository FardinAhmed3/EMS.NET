using System;
using System.ComponentModel.DataAnnotations;

namespace EMS.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string Position { get; set; }

        [Required]
        public Department Department { get; set; }

        [StringLength(100)]
        public string City { get; set; }
    }

    public enum Department
    {
        Technology,
        Finance,
        Operations
    }
}
