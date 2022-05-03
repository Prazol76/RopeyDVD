using System.ComponentModel.DataAnnotations;

namespace RopeyDVDRenalShop.Models
{
    public class Studio
    {
        [Key]
        public int StudioNumber { get; set; }
        public string? StudioName { get; set; }
        public ICollection<DvdTitle>? DVDTitle { get; set; }
    }
}
