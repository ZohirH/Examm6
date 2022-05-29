using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examm.Data.Entities
{
    public class Department
    {
        [Column("Department_Id"), Key]
        public int DepartmentId { get; set; }

        [Required]
        [MaxLength(30)]
        [Column("Department_Name")]
        public string? DepartmentName { get; set; }

        [Column("Location_Id")]
        public int LocationId { get; set; }

        public Location Location { get; set; }

    }
}
