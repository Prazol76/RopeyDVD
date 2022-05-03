using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RopeyDVDRenalShop.Models
{
    public class DvdTitle
    {

        [Key]
        public int DvdNumber { get; set; }
        public string? DvdTitles { get; set; }
        public DateTime DateReleased { get; set; }
        public float StandardCharge { get; set; }
        public float PenaltyCharge { get; set; }
        public int CategoryNumber { get; set; }
        [ForeignKey("CategoryNumber")]
        public DvdCategory? DVDCategory { get; set; }
        public int StudioNumber { get; set; }
        [ForeignKey("StudioNumber")]
        public Studio? Studio { get; set; }
        public int ProducerNumber { get; set; }
        [ForeignKey("ProducerNumber")]
        public Producer? Producer { get; set; }
        public ICollection<DvdCopy>? DVDCopy { get; set; }
        public ICollection<CastMember>? CastMember { get; set; }

    }
}
