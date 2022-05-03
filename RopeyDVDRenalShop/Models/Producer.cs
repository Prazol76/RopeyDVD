using System.ComponentModel.DataAnnotations;

namespace RopeyDVDRenalShop.Models
{
    public class Producer
    {
        [Key]
        public int ProducerNumber { get; set; }
        public string? ProducerName { get; set; }
        public ICollection<DvdTitle>? DVDTitle { get; set; }
    }
}
