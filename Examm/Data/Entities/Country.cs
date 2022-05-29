using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examm.Data.Entities
{
    public class Country
    {
        [Column("Country_Id"),Key]
        public int CountryId { get; set; }

        [Required]
        [MaxLength(40)]
        [Column("Country_Name")]
        public string? CountryName { get; set; }

        [Required]
        [Column("Region_Id")]
        public int RegionId { get; set; }

    }
}
