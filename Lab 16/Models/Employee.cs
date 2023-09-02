using System.ComponentModel.DataAnnotations;

namespace Lab_16.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "ID is mandatory")]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Name is mandatory")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Age is mandatory")]
        public int EmployeeAge { get; set; }
        [Required(ErrorMessage = "Gender is mandatory")]
        public string EmployeeGender { get; set; }
        [Required(ErrorMessage = "Email is mandatory")]
        public string EmployeeEmail { get; set; }
    }
}