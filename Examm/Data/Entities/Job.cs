using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examm.Data.Entities
{
    public class Job
    {
        [Column("Job_Id"), Key]
        public int JobId { get; set; }

        [Required]
        [MaxLength(35)]
        [Column("Job_Title")]
        public string? JobTitle { get; set; }

        [Column("Max_Salary")]
        public decimal MinSalary { get; set; }

        [Column("Min_Salary")]
        public decimal MaxSalary { get; set; }
    }
}
