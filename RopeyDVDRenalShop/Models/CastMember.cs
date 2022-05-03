using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RopeyDVDRenalShop.Models

{
    public class CastMember
    {
        [Key]
        public int CastMemberNumber { get; set; }
        public int DvdNumber { get; set; }
        [ForeignKey("DvdNumber")]
        public DvdTitle? DVDTitle { get; set; }
        public int ActorNumber { get; set; }
        [ForeignKey("ActorNumber")]
        public Actor? Actor { get; set; }
    }
}
