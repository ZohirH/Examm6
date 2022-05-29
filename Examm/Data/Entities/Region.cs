using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examm.Data.Entities
{
    public class Region
    {
        [Column("Region_Id"), Key]
        public int RegionId { get; set; }

        [Required]
        [MaxLength(25)]
        [Column("Region_Name")]
        public string? RegionName { get; set; }
    }
}
