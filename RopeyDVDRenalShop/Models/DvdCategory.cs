using System.ComponentModel.DataAnnotations;

namespace RopeyDVDRenalShop.Models
{
    public class DvdCategory
    {
        [Key]
        public int CategoryNumber { get; set; }
        public string? CategoryDescription { get; set; }
        public Boolean AgeRestricted { get; set; }
        public ICollection<DvdTitle>? DVDTitle { get; set; }
    }
}
