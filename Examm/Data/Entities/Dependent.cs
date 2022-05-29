using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examm.Data.Entities
{
    public class Dependent
    {
        [Column("Dependent_Id"), Key]
        public int DependentId { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("First_Name")]
        public string? FistName { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("Last_Name")]
        public string? LastName { get; set; }

        [Required]
        [MaxLength(25)]
        public string? Realtionship { get; set; }

        [Column("Eployee_Id")]
        public int EmployeeId { get; set; }
    }
}
