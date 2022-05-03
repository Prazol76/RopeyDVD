using System.ComponentModel.DataAnnotations;

namespace RopeyDVDRenalShop.Models
{
    public class MembershipCategory
    {
        [Key]
        public int MembershipCategoryNumber { get; set; }
        public string? MembershipCategoryDescription { get; set; }
        public int MembershipCategoryTotalLoans { get; set; }
        public ICollection<Member>? Member { get; set; }

    }


}

