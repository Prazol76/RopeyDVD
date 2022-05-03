using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RopeyDVDRenalShop.Models
{
    public class DvdCopy
    {
        [Key]
        public int CopyNumber { get; set; }
        public DateTime DatePurchased { get; set; }
        public int DvdNumber { get; set; }
        [ForeignKey("DvdNumber")]
        public DvdTitle? DvdTitle { get; set; }
        public ICollection<Loan>? Loan { get; set; }
    }
}
    