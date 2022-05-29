using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examm.Data.Entities
{
    public class Location
    {
        [Column("Location_Id"), Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        [Column("Street_Address")]
        public string? StreetAddress { get; set; }

        [Required]
        [MaxLength(12)]
        [Column("Postal_Code")]
        public string? PostalCode { get; set; }

        [Required]
        [MaxLength(30)]
        public string? City { get; set; }

        [Required]
        [MaxLength(25)]
        [Column("State_Province")]
        public string? StateProvince { get; set; }

        [Required]
        [MaxLength(2)]
        [Column("Country_Id")]
        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}
