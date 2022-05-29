using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examm.Data.Entities
{
    public class Employee
    {
        [Column("Employee_Id"), Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("First_Name")]
        public string? FistName { get; set; }

        [Required]
        [MaxLength(25)]
        [Column("Last_Name")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("Phone_Number")]
        public string PhoneNumber { get; set; }

        [Column("Hire_Date")]
        public DateTime? HireDate { get; set; }

        [Column("Job_Id")]
        public int JobId { get; set; }

        public decimal Salary { get; set; }

        [Column("Department_Id")]
        public int DepartmentId { get; set; }
    }
}
